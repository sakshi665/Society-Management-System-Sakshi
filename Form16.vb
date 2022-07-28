Public Class Form16
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SocietyDataSet.renthouse' table. You can move, or remove it, as needed.
        Me.RenthouseTableAdapter.Fill(Me.SocietyDataSet.renthouse)

    End Sub
End Class