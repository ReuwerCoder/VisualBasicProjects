Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBIllAmount.TextChanged

    End Sub

    Private Sub btnFifteen_Click(sender As Object, e As EventArgs) Handles btnFifteen.Click
        ' Vairable Declarations
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        ' Get the amount of the Bill.
        dblBill = CDbl(txtBIllAmount.Text)

        ' Calculate a 15 percent tip.
        dblTip = dblBill * 0.15

        ' Display the tip.
        lblTip.Text = CStr(dblTip)
    End Sub

    Private Sub btnTwenty_Click(sender As Object, e As EventArgs) Handles btnTwenty.Click
        ' Vairable Declarations
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        ' Get the amount of the Bill.
        dblBill = CDbl(txtBIllAmount.Text)

        ' Calculate a 20 percent tip.
        dblTip = dblBill * 0.2

        ' Display the tip.
        lblTip.Text = CStr(dblTip)
    End Sub

    Private Sub btnTwetyFive_Click(sender As Object, e As EventArgs) Handles btnTwetyFive.Click
        ' Vairable Declarations
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        ' Get the amount of the Bill.
        dblBill = CDbl(txtBIllAmount.Text)

        ' Calculate a 25 percent tip.
        dblTip = dblBill * 0.25

        ' Display the tip.
        lblTip.Text = CStr(dblTip)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
