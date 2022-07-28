Public Class Form17
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SocietyDataSet.sellhouse' table. You can move, or remove it, as needed.
        Me.SellhouseTableAdapter.Fill(Me.SocietyDataSet.sellhouse)

    End Sub
End Class