Imports System.Net.Sockets
Imports System.Text
Imports System.IO
Imports System.Net
Imports System.Threading


Public Class MainForm
    Dim ListenThread As Thread

    Public IPadres As String = "224.1.2.3"
    Public IPpoort As Integer = 62001
    Public MaxLogLines = 1000
    Dim KleurActief, KleurStop, KleurFout As Color

    Dim Slot1_dst, Slot2_dst As String
    Dim Slot1_src, Slot2_src As String
    Dim Slot1_type, Slot2_type As String
    Dim Slot1_TA, Slot2_TA As String
    Dim wisVelden As Boolean = False
    Dim tekst As String = ""

    Dim nu As String = ""

    Shared GroupIP As IPAddress
    Shared GroupEP As IPEndPoint
    Shared ListenUdp As UdpClient


    Private Function LeesConfig(welke As String)
        Dim readValue As String

        My.Computer.Registry.CurrentUser.CreateSubKey(My.Resources.REGISTRY_PROG_KEY & My.Resources.ProgName)
        readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\" & My.Resources.REGISTRY_PROG_KEY & My.Resources.ProgName, welke, "")
        Return readValue
    End Function


    Private Sub SchrijfConfig(welke As String, wat As String)

        My.Computer.Registry.CurrentUser.CreateSubKey(My.Resources.REGISTRY_PROG_KEY & My.Resources.ProgName)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\" & My.Resources.REGISTRY_PROG_KEY & My.Resources.ProgName, welke, wat)

    End Sub

    Private Sub ReadSettings()
        Dim s As String
        Dim i As Integer
        s = LeesConfig("IPaddress")
        If s.Length > 0 Then IPadres = s Else SchrijfConfig("IPaddress", IPadres)

        i = IPpoort
        s = LeesConfig("IPport")
        If s.Length > 0 Then i = Convert.ToInt32(s)
        If (i < 1) Or (i > 65534) Then i = 62001
        IPpoort = i
        SchrijfConfig("IPport", IPpoort)

        i = MaxLogLines
        s = LeesConfig("MaxLogLines")
        If s.Length > 0 Then i = Convert.ToInt32(s)
        If (i < 10) Or (i > 100000) Then i = 10
        MaxLogLines = i
        SchrijfConfig("MaxLogLines", MaxLogLines)

        KleurActief = Color.LightGreen
        s = LeesConfig("ColorActive")
        If s.Length > 0 Then KleurActief = Color.FromArgb(Convert.ToInt32(s, 16))
        SchrijfConfig("ColorActive", Hex(KleurActief.ToArgb))

        KleurStop = Color.IndianRed
        s = LeesConfig("ColorStop")
        If s.Length > 0 Then KleurStop = Color.FromArgb(Convert.ToInt32(s, 16))
        SchrijfConfig("ColorStop", Hex(KleurStop.ToArgb))

        KleurFout = Color.IndianRed
        s = LeesConfig("ColorError")
        If s.Length > 0 Then KleurFout = Color.FromArgb(Convert.ToInt32(s, 16))
        SchrijfConfig("ColorError", Hex(KleurFout.ToArgb))
    End Sub


    Public Sub WriteSettings()
        SchrijfConfig("IPaddress", IPadres)
        SchrijfConfig("IPport", IPpoort)
        SchrijfConfig("MaxLogLines", MaxLogLines)
        SchrijfConfig("ColorActive", Hex(KleurActief.ToArgb))
        SchrijfConfig("ColorStop", Hex(KleurStop.ToArgb))
        SchrijfConfig("ColorError", Hex(KleurFout.ToArgb))
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadSettings()

        Me.TopMost = True
        wisVelden = True
        Label4.Text = ""
        Main()
        Timer1.Enabled = True

        nu = Format(Now, "********** dd/MM/yyyy **********")
        Log.AppendTextBox(Log.TextBox1, nu)
    End Sub


    Private Delegate Sub ZetTextDelegate(ByVal L As Object, ByVal txt As String)

    Private Sub ZetText(ByVal L As Object, ByVal txt As String)
        Try
            If L.InvokeRequired Then
                L.Invoke(New ZetTextDelegate(AddressOf ZetText), New Object() {L, txt})
            Else
                L.Text = txt
            End If
        Catch
        End Try
    End Sub

    Private Sub Main()
        ListenThread = New Thread(AddressOf BeginListen)
        ListenThread.Start()
    End Sub

    Private Sub WisAlleVelden()
        Slot1_dst = ""
        Slot2_dst = ""
        Slot1_src = ""
        Slot2_src = ""
        Slot1_type = ""
        Slot2_type = ""
        Slot1_TA = ""
        Slot2_TA = ""

        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label5.Text = ""

        GroupBox1.BackColor = SystemColors.Control
    End Sub

    Private Sub BeginListen()
        Dim bteReceiveData() As Byte
        Dim TA, TA2, F As String
        Dim c, type As Byte
        Dim id, slot As Integer
        Dim ok As Boolean

        ok = True
        F = ""

        GroupIP = IPAddress.Parse(IPadres)

        GroupEP = New IPEndPoint(GroupIP, IPpoort)
        Try
            ListenUdp = New UdpClient(IPpoort)
            ListenUdp.JoinMulticastGroup(GroupIP)
        Catch ex As Exception
            F = "ERROR : " & ex.Message
            Threading.Thread.Sleep(100)
            Application.DoEvents()
            ok = False
        End Try

        If ok = True Then
            ToolStripStatusLabel1.Text = "Listening on " & IPadres & ":" & IPpoort

        End If

        TA = ""
        TA2 = ""

        Do
            If (ok) Then
                bteReceiveData = ListenUdp.Receive(GroupEP)
                type = bteReceiveData(0)

            Else
                bteReceiveData = {0}
                type = 0
                Threading.Thread.Sleep(1000)
            End If

            TA = ""

            tekst = Format(Now, "********** dd/MM/yyyy **********")
            If Not (nu = tekst) Then
                Log.AppendTextBox(Log.TextBox1, tekst & vbCrLf)
                nu = tekst
                tekst = tekst & vbCrLf & Format(Now, "[HH:mm:ss] ")
            Else
                tekst = ""
            End If
            Try
                ToolStripStatusLabel2.Text = Format(Now, "[HH:mm:ss]")
            Catch
            End Try
            If (bteReceiveData.Length > 1) Then slot = bteReceiveData(1) Else slot = 0
            Select Case type
                Case 0
                    ZetText(Label4, F)
                    Label4.ForeColor = KleurFout
                    Slot2_src = "ERROR: Socket in use"
                    GroupBox1.BackColor = KleurFout
                Case 1
                    wisVelden = True
                    Threading.Thread.Sleep(100)
                    tekst = tekst & "Idle"
                    Slot2_src = "Idle"
                Case 2
                    wisVelden = True
                    Threading.Thread.Sleep(100)
                    tekst = tekst & "ERROR "
                    For i = 1 To bteReceiveData(1)
                        c = bteReceiveData(i + 1)
                        If (c > 31) Then tekst = tekst & Chr(c) Else tekst = tekst & "[" & c & "]"
                    Next
                    GroupBox1.BackColor = KleurFout
                Case 3
                    wisVelden = True
                    Threading.Thread.Sleep(100)
                    tekst = tekst & "Quit "
                Case 4 'write DMR
                    id = bteReceiveData(2) * 256 * 256 * 256 + bteReceiveData(3) * 256 * 256 + bteReceiveData(4) * 256 + bteReceiveData(5)
                    If slot = 1 Then Slot1_src = id Else Slot2_src = id
                    tekst = tekst & "DMR " & id & " --> "

                    id = bteReceiveData(7) * 256 * 256 * 256 + bteReceiveData(8) * 256 * 256 + bteReceiveData(9) * 256 + bteReceiveData(10)
                    If slot = 1 Then Slot1_dst = id Else Slot2_dst = id
                    tekst = tekst & id

                    If bteReceiveData(6) > 0 Then tekst = tekst & " " & Chr(bteReceiveData(11)) & " Group Call "
                    If bteReceiveData(6) > 0 Then
                        If slot = 1 Then Slot1_type = "Group Call" Else Slot2_type = "Group Call"
                    Else
                        If slot = 1 Then Slot1_type = "Private Call" Else Slot2_type = "Private Call"
                    End If
                    Slot1_type = ">>> " & Slot1_type & " >>>"
                    Slot2_type = ">>> " & Slot2_type & " >>>"

                    If Slot2_TA.Length > 0 Then TA2 = " (" & Slot2_TA & ") " Else TA2 = ""

                    GroupBox1.BackColor = KleurActief

                Case 5 'DMR RSSI
                    tekst = tekst & "Slot " & bteReceiveData(1) & " RSSI " & bteReceiveData(2)
                Case 6 'DMR TA
                    If bteReceiveData(3) = 0 Then
                        tekst = tekst & "Clear DMR TA on slot " & bteReceiveData(1)
                    Else
                        tekst = tekst & bteReceiveData(1) & " " & Chr(bteReceiveData(2)) & " "
                        TA = ""
                        For i = 1 To bteReceiveData(3)
                            c = bteReceiveData(3 + i)
                            If (c > 31) Then TA = TA & Chr(c) Else TA = TA & "[" & c & "]"
                        Next
                        tekst = tekst & TA

                    End If
                    If slot = 1 Then Slot1_TA = TA Else Slot2_TA = TA
                    If slot = 2 Then
                        If Slot2_TA.Length > 0 Then
                            If Slot2_TA.Length > 0 Then TA2 = " (" & Slot2_TA & ") " Else TA2 = ""
                        Else
                            ZetText(Label4, Slot2_src & TA2 & " > " & Slot2_dst)
                            ZetText(GroupBox2, "Last " & Format(Now, " (HH:mm:ss)"))
                        End If
                    End If
                Case 7 'DMR BER
                    tekst = tekst & "Slot " & bteReceiveData(1) & " BER "
                    For i = 1 To bteReceiveData(2)
                        c = bteReceiveData(2 + i)
                        If (c > 31) Then tekst = tekst & Chr(c) Else tekst = tekst & "[" & c & "]"
                    Next
                Case 8 'Clear DMR
                    tekst = tekst & "Clear DMR slot " & bteReceiveData(1)
                    If bteReceiveData(1) = 1 Then Slot1_TA = "" Else Slot2_TA = ""
                    ZetText(Label4, Slot2_src & TA2 & " > " & Slot2_dst)
                    ZetText(GroupBox2, "Last " & Format(Now, " (HH:mm:ss)"))
                    GroupBox1.BackColor = SystemColors.Control
                Case 9
                    id = bteReceiveData(1) * 256 * 256 * 256 + bteReceiveData(2) * 256 * 256 + bteReceiveData(3) * 256 + bteReceiveData(4)
                    tekst = tekst & "POCSAG RIC " & id & "Msg : "
                    For i = 1 To bteReceiveData(5)
                        c = bteReceiveData(5 + i)
                        If (c > 31) Then tekst = tekst & Chr(c) Else tekst = tekst & "[" & c & "]"
                    Next
                Case 10
                    tekst = tekst & "ClearPOCSAG"
                Case 11
                    tekst = tekst & "CW start"
                    TA = "CW"
                Case 12
                    tekst = tekst & "CW end"
                    TA = ""
                Case 13
                    tekst = tekst & "Close Display"
                    Slot2_src = "Display closed"
                    GroupBox1.BackColor = KleurStop
                Case Else
                    tekst = tekst & "Unknow type " & type

            End Select

            Try
                ToolStripStatusLabel2.Text = tekst
            Catch ex As Exception
            End Try

            ZetText(Label1, Slot2_src)
            ZetText(Label2, Slot2_type)
            ZetText(Label3, Slot2_dst)
            ZetText(Label5, TA)

            Application.DoEvents()
        Loop

    End Sub


    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Sub VerbergLog()
        LogToolStripMenuItem.Checked = False
        Log.Hide()
    End Sub

    Private Sub IpAddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IpAddressToolStripMenuItem.Click
        Settings.ShowDialog()
    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click, LogToolStripMenuItem.Click
        If LogToolStripMenuItem.Checked Then
            Log.Show()
            Log.TopMost = True
            Log.TopMost = False
        Else
            Log.Hide()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
        AboutBox.TopMost = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If wisVelden Then
            WisAlleVelden()
            wisVelden = False
        End If
        If tekst.Length > 0 Then
            Log.AppendTextBox(Log.TextBox1, tekst)
            tekst = ""
        End If
    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SchrijfConfig("MaxLogLines", MaxLogLines)
        Try
            ListenUdp.DropMulticastGroup(GroupIP)
            ListenUdp.Close()
        Catch

        End Try
        ListenThread.Abort()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        If (Me.WindowState = FormWindowState.Minimized) Then
            Log.WindowState = FormWindowState.Minimized
        ElseIf (Me.WindowState = FormWindowState.Normal) Then
            Log.WindowState = FormWindowState.Normal

        Else

            'Dim fontName As FontFamily = Label2.Font.FontFamily
            'Dim h As Integer
            'h = Me.Size.Height - 120
            'If h < 8 Then h = 8
            'Label2.Font = New Font(fontName, h)

            Dim w As Integer
            w = ToolStripStatusLabel2.Width
            ToolStripStatusLabel2.Width = Me.Size.Width - 250
        End If

    End Sub


    Private Sub AlwaysInForntToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysInForntToolStripMenuItem.Click
        AlwaysInForntToolStripMenuItem.Checked = Not AlwaysInForntToolStripMenuItem.Checked
        Me.TopMost = AlwaysInForntToolStripMenuItem.Checked
    End Sub
End Class


