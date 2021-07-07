Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblDate.Click
        'Get the current date from the system
        Dim dtmSystemDate = Today

        'Display the date. 
        lblDate.Text = dtmSystemDate.ToString("d")
    End Sub
End Class
