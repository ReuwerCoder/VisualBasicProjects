Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtOriginalPrice.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decOriginalPrice As Decimal = 0 'Original Price
        Dim decDiscountPercentage As Decimal = 0 ' Discount percentage
        Dim decDiscountAmount As Decimal = 0 'Amouint of Discount
        Dim decSalePrice As Decimal = 0 ' SAle Price

        'Get the items original price.
        decOriginalPrice = CDec(txtOriginalPrice.Text)

        'Get the discount percentage.
        decDiscountPercentage = CDec(txtDiscountPercentage.Text)

        'Move the percntages deciaml point left two spaces.
        decDiscountPercentage = decDiscountPercentage / 100

        'Calculate the amount of the discount.
        decDiscountAmount = decOriginalPrice * decDiscountPercentage

        'Calculate teh sale price.
        decSalePrice = decOriginalPrice - decDiscountAmount

        'Display the sale price.
        lblSalePrice.Text = decSalePrice.ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class
