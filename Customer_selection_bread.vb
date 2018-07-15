Imports System.Data.SqlClient

Public Class Customer_selection_bread
    Private Sub BreadButton_white_Click(sender As Object, e As EventArgs) Handles BreadButton_white.Click

        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'White Bread'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server

        We_re_almost_there.BreadTextBox.Text = "White Bread"
        We_re_almost_there.BreadPrice.Text = "5"
        Customer_selection_sauce.Visible = True
        Me.Visible = False
    End Sub

    Private Sub BreadButton_Brown_Click(sender As Object, e As EventArgs) Handles BreadButton_Brown.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Brown Bread'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.BreadTextBox.Text = "Brown Bread"
        We_re_almost_there.BreadPrice.Text = "10"
        Customer_selection_sauce.Visible = True
        Me.Visible = False
    End Sub

    Private Sub BreadButton_Multigrain_Click(sender As Object, e As EventArgs) Handles BreadButton_Multigrain.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Multigrain Bread'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.BreadTextBox.Text = "Multigrain Bread"
        We_re_almost_there.BreadPrice.Text = "15"
        Customer_selection_sauce.Visible = True
        Me.Visible = False
    End Sub

    Private Sub BreadButton_Ragi_Click(sender As Object, e As EventArgs) Handles BreadButton_Ragi.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'ragi Bread'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.BreadTextBox.Text = "Ragi Bread"
        We_re_almost_there.BreadPrice.Text = "15"
        Customer_selection_sauce.Visible = True
        Me.Visible = False
    End Sub

    Private Sub BreadButton_Italian_Click(sender As Object, e As EventArgs) Handles BreadButton_Italian.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Italian Bread'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.BreadTextBox.Text = "Italian Bread"
        We_re_almost_there.BreadPrice.Text = "20"
        Customer_selection_sauce.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Customer_selection_bread_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class