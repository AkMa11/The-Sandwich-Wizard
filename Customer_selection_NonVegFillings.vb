Imports System.Data.SqlClient

Public Class Customer_selection_NonVegFillings
    Private Sub NonVegFillingsButton_BBQChicken_Click(sender As Object, e As EventArgs) Handles NonVegFillingsButton_BBQChicken.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'BBQ Chicken'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.FillingsTextBox.Text = "BBQChicken"
        We_re_almost_there.FillingsPrice.Text = "35"
        Customer_selection_toppings.Visible = True
        Me.Visible = False
    End Sub

    Private Sub NonVegFillingsButton_ChickenPatty_Click(sender As Object, e As EventArgs) Handles NonVegFillingsButton_ChickenPatty.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Chicken Patty'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.FillingsTextBox.Text = "Chicken Patty"
        We_re_almost_there.FillingsPrice.Text = "30"
        Customer_selection_toppings.Visible = True
        Me.Visible = False
    End Sub

    Private Sub NonVegFillingsButton_EggPatty_Click(sender As Object, e As EventArgs) Handles NonVegFillingsButton_EggPatty.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Egg Patty'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.FillingsTextBox.Text = "Egg Patty"
        We_re_almost_there.FillingsPrice.Text = "30"
        Customer_selection_toppings.Visible = True
        Me.Visible = False
    End Sub

    Private Sub NonVegFillingsButton_GrilledChicken_Click(sender As Object, e As EventArgs) Handles NonVegFillingsButton_GrilledChicken.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Grilled Chicken'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.FillingsTextBox.Text = "Grilled Chicken"
        We_re_almost_there.FillingsPrice.Text = "35"
        Customer_selection_toppings.Visible = True
        Me.Visible = False
    End Sub

    Private Sub NonVegFillingsButton_SmokedChicken_Click(sender As Object, e As EventArgs) Handles NonVegFillingsButton_SmokedChicken.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Smoked Chicken'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.FillingsTextBox.Text = "Smoked Chicken"
        We_re_almost_there.FillingsPrice.Text = "30"
        Customer_selection_toppings.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Customer_selection_NonVegFillings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class