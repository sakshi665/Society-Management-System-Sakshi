Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SocietyDataSet.complainbox' table. You can move, or remove it, as needed.
        Me.ComplainboxTableAdapter.Fill(Me.SocietyDataSet.complainbox)

    End Sub
End Class