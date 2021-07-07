Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim Result As Double 'Declare "Result" as Decimal

        If Convert.ToDouble(txtboxInput.Text) <= 10.0 Then
            lblWeightResult.Text = "Object is too Light"
        ElseIf Convert.ToDouble(txtboxInput.Text) >= 1000.0 Then
            lblWeightResult.Text = "Object is too Heavy"
        Else
            Result = Convert.ToDouble(txtboxInput.Text) * 9.8

            lblWeightResult.Text = Result.ToString
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
