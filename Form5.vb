Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sql = "insert into AddHouse  (societyName , blockNo , houseNo , city , houseType) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "');"
        connect()

        If dr.Read Then
            MsgBox("House already exists")
        Else
            MsgBox("House Added Successfully")
        End If
        conn.Close()
        MessageBox.Show("House added Successfully")
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost ; user id = root ; port=3306 ; password = root ; database = society"
    End Sub
End Class