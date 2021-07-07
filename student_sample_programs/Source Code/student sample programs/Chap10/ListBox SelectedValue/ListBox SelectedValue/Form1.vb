Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MembersDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.MembersDataSet.Members)

    End Sub

    Private Sub lstMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMembers.SelectedIndexChanged

        If lstMembers.SelectedValue Is Nothing Then Exit Sub

        MessageBox.Show("The member's ID is " &
                        lstMembers.SelectedValue.ToString())
    End Sub
End Class
