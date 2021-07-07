Public Class Form1
    'Declares a variable to hold the wholesale value
    Function wholesaleIsValid() As Boolean

        Dim dblTempValue As Double

        If Not Double.TryParse(txtwholesalecost.text, dblTempValue) Then
            MessageBox.Show("Please enter a numeric value for the Wholesale Cost of Item", "Error")
            Return False
        End If
        'Check if the value entered for wholesale value is negative
        If dblTempValue < 0 Then
            MessageBox.Show("Please enter a positive value for the Wholesale Cost of Item", "Error")
            Return False
        End If
        Return True
    End Function
    'Declares function MarkupisValid
    Function MarkupisValid() As Boolean
        'Declares variable to hold the markup value and checks for nonnumeric data
        Dim dblTempValue As Double
        If Not Double.TryParse(txtmarkup.Text, dblTempValue) Then
            MessageBox.Show("Please enter a numeric value for the Markup %", "Error")
            Return False
        End If
        Return True
    End Function
    Function CalculateRetail(ByVal dblwholesale As Double, ByVal dblmarkupPct As Double) As Double
        'Declare variables dblmarkupamount and dblretail
        Dim dblmarkupamount As Double
        Dim dblretail As Double

        'Calculate the dollar amount of markup
        dblmarkupamount = dblwholesale * (dblmarkupPct * 0.01)

        'Calculate Retail Price
        dblretail = dblwholesale + dblmarkupamount

        'Return Retail Price
        Return dblretail

    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Closes the application and displays a message box asking user whether or not they would like to quit
        Dim Button2 As DialogResult
        Button2 = MessageBox.Show("Are you sure you want to quit?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Button2 = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetRetail.Click
        ' Declare variables dblewholesale, dblemarkupPct, dblretail
        Dim dblWholesale As Double
        Dim dblmarkupPct As Double
        Dim dblRetail As Double

        If wholesaleIsValid() And MarkupisValid() Then
            'Retrieve Wholesale Cost
            Double.TryParse(txtwholesalecost.Text, dblWholesale)

            'Retrieve Markup Percentage
            Double.TryParse(txtmarkup.Text, dblmarkupPct)


            'Retrieve the retail price
            dblRetail = CalculateRetail(dblWholesale, dblmarkupPct)

            'Display the Retail Price
            lblRetailprice.text = dblRetail.ToString("C")

        End If
    End Sub
End Class

