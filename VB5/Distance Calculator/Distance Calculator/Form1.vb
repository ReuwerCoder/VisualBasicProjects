Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strMph As String
        Dim intCount As Integer
        Dim intDistance As Integer
        Dim intHours As Integer
        Dim intSpeed As Integer

        lstDisplay.Items.Clear()

        Try
            intSpeed = CInt(InputBox("Please enter the speed."))

            intHours = CInt(InputBox("Please enter the hours elapsed."))

            With lstDisplay.Items
                .Add("Vehicle Speed: " & intSpeed.ToString & " MPH")
                .Add("Time Travelled: " & intHours.ToString & " Hours")
                .Add("Hours       Distance Travelled")
                .Add("------------------------------")
            End With

            For intCount = 1 To intHours
                intDistance = intSpeed * intCount
                strMph = CStr(intCount) & "              " & CStr(intDistance)
                lstDisplay.Items.Add(strMph)
            Next
        Catch
            MessageBox.Show("Invalid Input", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        lstDisplay.Items.Add("Total Distance: " & intDistance.ToString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
