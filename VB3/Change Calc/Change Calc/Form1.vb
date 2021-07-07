Public Class Form1
    'Class-level constants for the coin values
    Dim decFIVE_CENTS_VALUE As Decimal = 0.05D
    Dim decTEN_CENTS_VALUE As Decimal = 0.1D
    Dim decTWENTY_FIVE_CENTS_VALUE As Decimal = 0.25D
    Dim decFIFTY_CENTS_VALUE As Decimal = 0.5D

    'Class-level varaible to hold the total.
    ' initialized with 0
    Dim decTotal As Decimal = 0.0D
    Private Sub picFiveCents_Click(sender As Object, e As EventArgs) Handles picFiveCents.Click
        'Add the value of 5 cents to the total.
        decTotal = decTotal + decFIVE_CENTS_VALUE

        'Display the total, formatted as cuurency.
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub picTenCents_Click(sender As Object, e As EventArgs) Handles picTenCents.Click
        'Add the value of 5 cents to the total.
        decTotal = decTotal + decTEN_CENTS_VALUE

        'Display the total, formatted as cuurency.
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub picTwentyCents_Click(sender As Object, e As EventArgs) Handles picTwentyCents.Click
        'Add the value of 5 cents to the total.
        decTotal = decTotal + decTWENTY_FIVE_CENTS_VALUE

        'Display the total, formatted as cuurency.
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub picFiftyCents_Click(sender As Object, e As EventArgs) Handles picFiftyCents.Click
        'Add the value of 5 cents to the total.
        decTotal = decTotal + decFIFTY_CENTS_VALUE

        'Display the total, formatted as cuurency.
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class
