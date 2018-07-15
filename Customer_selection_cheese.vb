Imports System.Data.SqlClient

Public Class Customer_selection_cheese
    Private Sub CheeseButton_Cheddar_Click(sender As Object, e As EventArgs) Handles CheeseButton_Cheddar.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Cheddar Cheese'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.CheeseTextBoxCheddar.Clear()
        We_re_almost_there.CheeseTextBoxCheddar.Text = "Cheddar Cheese"
        CheesePrice1.Text = "20"
        CheeseSelected_Cheddar.Visible = True
    End Sub

    Private Sub CheeseButton_Cotija_Click(sender As Object, e As EventArgs) Handles CheeseButton_Cotija.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Cotija Cheese'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.CheeseTextBoxCotija.Clear()
        We_re_almost_there.CheeseTextBoxCotija.Text = "Cotija Cheese"
        CheesePrice2.Text = "20"
        CheeseSelected_Cotija.Visible = True
    End Sub

    Private Sub CheeseButton_Gauda_Click(sender As Object, e As EventArgs) Handles CheeseButton_Gauda.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Gauda Cheese'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.CheeseTextBoxGauda.Clear()
        We_re_almost_there.CheeseTextBoxGauda.Text = "Gauda Cheese"
        CheesePrice3.Text = "20"
        CheeseSelected_Gauda.Visible = True
    End Sub

    Private Sub CheeseButton_Mozzarella_Click(sender As Object, e As EventArgs) Handles CheeseButton_Mozzarella.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Mozzarella Cheese'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.CheeseTextBoxMozzarella.Clear()
        We_re_almost_there.CheeseTextBoxMozzarella.Text = "Mozzarella Cheese"
        CheesePrice4.Text = "20"
        CheeseSelected_Mozzarella.Visible = True
    End Sub

    Private Sub CheeseButton_Parmigiano_Click(sender As Object, e As EventArgs) Handles CheeseButton_Parmigiano.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Parmigiano Cheese'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.CheeseTextBoxParmigiano.Clear()
        We_re_almost_there.CheeseTextBoxParmigiano.Text = "Parmigiano Cheese"
        CheesePrice5.Text = "20"
        CheeseSelected_Parmigiano.Visible = True
    End Sub

    Private Sub Customer_selection_cheese_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheeseSelected_Mozzarella.Visible = False
        CheeseSelected_Cheddar.Visible = False
        CheeseSelected_Cotija.Visible = False
        CheeseSelected_Gauda.Visible = False
        CheeseSelected_Parmigiano.Visible = False
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Dim a, b, c, d, f, g As Integer
        If CheesePrice1.Text = "20" Then
            a = CheesePrice1.Text
        End If
        If CheesePrice2.Text = "20" Then
            b = CheesePrice2.Text
        End If
        If CheesePrice3.Text = "20" Then
            c = CheesePrice3.Text
        End If
        If CheesePrice4.Text = "20" Then
            d = CheesePrice4.Text
        End If
        If CheesePrice5.Text = "20" Then
            f = CheesePrice5.Text
        End If
        g = a + b + c + d + f
        We_re_almost_there.CheesePrice.Text = g
        Customer_selection_fillings.Visible = True
        Me.Visible = False
    End Sub
End Class