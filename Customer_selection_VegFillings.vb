Imports System.Data.SqlClient

Public Class Customer_selection_VegFillings
    Private Sub VegFillingsButton_AaluTikki_Click(sender As Object, e As EventArgs) Handles VegFillingsButton_AaluTikki.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Aalu Tikki'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.FillingsTextBox.Text = "Aalu Tikki"
        We_re_almost_there.FillingsPrice.Text = "20"
        Customer_selection_toppings.Visible = True
        Me.Visible = False
    End Sub

    Private Sub VegFillingsButton_HariyaliPatty_Click(sender As Object, e As EventArgs) Handles VegFillingsButton_HariyaliPatty.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Hariyali Patty'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.FillingsTextBox.Text = "Hariyali Patty"
        We_re_almost_there.FillingsPrice.Text = "20"
        Customer_selection_toppings.Visible = True
        Me.Visible = False
    End Sub

    Private Sub VegFillingsButton_PalakPatty_Click(sender As Object, e As EventArgs) Handles VegFillingsButton_PalakPatty.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Palak Patty'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.FillingsTextBox.Text = "Palak Patty"
        We_re_almost_there.FillingsPrice.Text = "20"
        Customer_selection_toppings.Visible = True
        Me.Visible = False
    End Sub

    Private Sub VegFillingsButton_Paneer_Click(sender As Object, e As EventArgs) Handles VegFillingsButton_Paneer.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Paneer'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.FillingsTextBox.Text = "Paneer"
        We_re_almost_there.FillingsPrice.Text = "20"
        Customer_selection_toppings.Visible = True
        Me.Visible = False
    End Sub

    Private Sub VegFillingsButton_SoyaPatty_Click(sender As Object, e As EventArgs) Handles VegFillingsButton_SoyaPatty.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Soya Patty'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.FillingsTextBox.Text = "Soya Patty"
        We_re_almost_there.FillingsPrice.Text = "20"
        Customer_selection_toppings.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Customer_selection_VegFillings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class