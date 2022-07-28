Public Class Form2

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sql = "SELECT * from Admin where aUsername = '" & TextBox1.Text & "' AND aPassword = '" & TextBox2.Text & "'"
        connect()
        Dim flag = False
        If dr.Read Then
            MsgBox("Login Successfull")
            flag = True

        Else
            MsgBox("Invalid Credentials")
        End If

        conn.Close()

        If flag = True Then
            Form3.ShowDialog()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost ; user id = root ; port=3306 ; password = root ; database = society"
    End Sub
End Class