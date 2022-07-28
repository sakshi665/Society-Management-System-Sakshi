Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost ; user id = root ; port=3306 ; password = root ; database = society"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MessageBox.Show("Thank You for visiting.")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim flag = False
        sql = "SELECT * from Members where mUsername = '" & TextBox1.Text & "' AND mPassword = '" & TextBox2.Text & "'"
        connect()
        If dr.Read Then
            MsgBox("Login Successfull")
            flag = True
        Else
            MsgBox("Invalid Credentials")
        End If

        conn.Close()
        If flag = True Then
            Form9.ShowDialog()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form15.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form16.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form17.ShowDialog()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        sql = "insert into Members (mUsername , mPassword) values('" & TextBox1.Text & "','" & TextBox2.Text & "');"
        connect()

        If dr.Read Then
            MsgBox("Username already exists")
        Else
            MsgBox("Registered Successfully")
        End If
        conn.Close()
    End Sub


End Class
