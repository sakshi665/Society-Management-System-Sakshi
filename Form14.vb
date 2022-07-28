Public Class Form14
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SocietyDataSet.members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.SocietyDataSet.members)

    End Sub
End Class