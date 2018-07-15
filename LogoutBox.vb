Imports System.Data.SqlClient

Public Class LogoutBox
    Private Sub LogoutBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Dim con As New SqlConnection
        Dim rd As SqlDataReader
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"
        con.Open()
        Dim cmd As New SqlCommand(("select username, password from users where username ='" &
        UsernameText.Text & "' and password= '" & PasswordText.Text & "'"), con)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Me.Close()
            Welcome_Screen.Close()
            Login.Close()
        Else
            MsgBox("Invalid Username or Password.")
        End If
        con.Close()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub UsernameText_TextChanged(sender As Object, e As EventArgs) Handles UsernameText.TextChanged

    End Sub
End Class