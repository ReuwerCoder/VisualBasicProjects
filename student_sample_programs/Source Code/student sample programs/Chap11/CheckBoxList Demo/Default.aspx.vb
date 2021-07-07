
Partial Class _Default
    Inherits System.Web.UI.Page

	Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim item As ListItem
        lblResult.Text = "You selected "
        For Each item In chkDrinks.Items
            If item.Selected Then
                lblResult.Text &= item.ToString() + ", "
            End If
        Next
    End Sub
End Class
