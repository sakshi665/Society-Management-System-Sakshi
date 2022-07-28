Public Class Form11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sql = "insert into ComplainBox  (complain) values('" & TextBox1.Text & "');"
        connect()

        If dr.Read Then
            MsgBox("Complain already exists")
        Else
            MsgBox("Complain Added Successfully")
        End If
        conn.Close()
        MessageBox.Show("Complain Added Successfully")
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost ; user id = root ; port=3306 ; password = root ; database = society"
    End Sub
End Class