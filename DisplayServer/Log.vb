Public Class Log

    Public Delegate Sub AppendTextBoxDelegate(ByVal TB As TextBox, ByVal txt As String)

    Public Sub AppendTextBox(ByVal TB As TextBox, ByVal txt As String)
        If TB.InvokeRequired Then
            TB.Invoke(New AppendTextBoxDelegate(AddressOf AppendTextBox), New Object() {TB, txt})
        Else
            TB.AppendText(Format(Now, "[HH:mm:ss] ") & txt & vbCrLf)
        End If

        If TextBox1.TextLength > (TextBox1.MaxLength - 50) Then
            MainForm.MaxLogLines = TextBox1.Lines.Count
        End If

        If (TextBox1.Lines.Count > MainForm.MaxLogLines) Then
            Dim lines = TextBox1.Lines
            Dim newLines = lines.Skip(TextBox1.Lines.Count - MainForm.MaxLogLines - 1)

            TextBox1.Lines = newLines.ToArray()
            Label1.Text = "Max of " & (TextBox1.Lines.Count - 1) & " lines reached"
        Else
            Label1.Text = (TextBox1.Lines.Count - 1) & " lines"
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        Label1.Text = ""
    End Sub

    Private Sub Log_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then

            e.Cancel = True
            MainForm.VerbergLog()

        End If
    End Sub
End Class