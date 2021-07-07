Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnItalian_Click(sender As Object, e As EventArgs) Handles btnItalian.Click
        lblTranslation.Text = "Buongiorno"
    End Sub

    Private Sub btnSpanish_Click(sender As Object, e As EventArgs) Handles btnSpanish.Click
        lblTranslation.Text = "Buenos Dias"
    End Sub

    Private Sub btnGerman_Click(sender As Object, e As EventArgs) Handles btnGerman.Click
        lblTranslation.Text = "Guten Morgen"
    End Sub
End Class
