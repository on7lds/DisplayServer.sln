Imports System.Net

Public Class Settings
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As Integer = 0

        Dim a As IPAddress = Nothing

        If Not a.TryParse(TextBox1.Text, a) Then
            MessageBox.Show("IP address not valid", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If (IsNumeric(TextBox2.Text)) Then p = Convert.ToDecimal(TextBox2.Text)
        If p > 0 And p < 65536 Then
            MainForm.IPadres = TextBox1.Text
            MainForm.IPpoort = p
            MsgBox("Restart program to apply settings")
            MainForm.WriteSettings()
            Me.Close()
        Else
            MessageBox.Show("Port not valid", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = MainForm.IPadres
        TextBox2.Text = MainForm.IPpoort
    End Sub
End Class