Imports System.Data.SqlClient

Public Class Customer_selection_sauce
    Private Sub Customer_selection_sauce_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SauceSelected_Tomato.Visible = False
        SauceSelected_Pesto.Visible = False
        SauceSelected_Schezwan.Visible = False
        SauceSelected_Mayonese.Visible = False
        SauceSelected_Mustard.Visible = False
    End Sub

    Private Sub SauceButton_Mayonese_Click(sender As Object, e As EventArgs) Handles SauceButton_Mayonese.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Mayonese Sauce'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.SauceTextBoxMayonese.Clear()
        We_re_almost_there.SauceTextBoxMayonese.Text = "Mayonese Sauce"
        SaucePrice1.Text = "10"
        SauceSelected_Mayonese.Visible = True
    End Sub

    Private Sub SauceButton_Mustard_Click(sender As Object, e As EventArgs) Handles SauceButton_Mustard.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Mustard Sauce'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.SauceTextBoxMustard.Clear()
        We_re_almost_there.SauceTextBoxMustard.Text = "Mustard Sauce"
        SaucePrice2.Text = "15"
        SauceSelected_Mustard.Visible = True
    End Sub

    Private Sub SauceButton_Pesto_Click(sender As Object, e As EventArgs) Handles SauceButton_Pesto.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Pesto Sauce'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.SauceTextBoxPesto.Clear()
        We_re_almost_there.SauceTextBoxPesto.Text = "Pesto Sauce"
        SaucePrice3.Text = "15"
        SauceSelected_Pesto.Visible = True
    End Sub

    Private Sub SauceButton_Schezwan_Click(sender As Object, e As EventArgs) Handles SauceButton_Schezwan.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Schezwan Sauce'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.SauceTextBoxSchezwan.Clear()
        We_re_almost_there.SauceTextBoxSchezwan.Text = "Schezwan Sauce"
        SaucePrice4.Text = "15"
        SauceSelected_Schezwan.Visible = True
    End Sub

    Private Sub SauceButton_Tomato_Click(sender As Object, e As EventArgs) Handles SauceButton_Tomato.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Tomato Sauce'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.SauceTextBoxTomato.Clear()
        We_re_almost_there.SauceTextBoxTomato.Text = "Tomato Sauce"
        SaucePrice5.Text = "5"
        SauceSelected_Tomato.Visible = True
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Dim a, b, c, d, f, g As Integer
        If SaucePrice1.Text = "10" Then
            a = SaucePrice1.Text
        End If
        If SaucePrice2.Text = "15" Then
            b = SaucePrice2.Text
        End If
        If SaucePrice3.Text = "15" Then
            c = SaucePrice3.Text
        End If
        If SaucePrice4.Text = "15" Then
            d = SaucePrice4.Text
        End If
        If SaucePrice5.Text = "5" Then
            f = SaucePrice5.Text
        End If
        g = a + b + c + d + f
        We_re_almost_there.SaucePrice.Text = g
        Customer_selection_cheese.Visible = True
        Me.Visible = False
    End Sub

    Private Sub SauceSelected_Tomato_Click(sender As Object, e As EventArgs) Handles SauceSelected_Tomato.Click

    End Sub
End Class