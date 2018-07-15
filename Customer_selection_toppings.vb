Imports System.Data.SqlClient

Public Class Customer_selection_toppings
    Private Sub Customer_selection_toppings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToppingsSelected_Capsicum.Visible = False
        ToppingsSelected_Jalapeño.Visible = False
        ToppingsSelected_Olives.Visible = False
        ToppingsSelected_Onion.Visible = False
        ToppingsSelected_Tomato.Visible = False
    End Sub

    Private Sub ToppingsButton_Capsicum_Click(sender As Object, e As EventArgs) Handles ToppingsButton_Capsicum.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Capsicum Topping'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.ToppingsTextBoxCapsicum.Clear()
        We_re_almost_there.ToppingsTextBoxCapsicum.Text = "Capsicum"
        ToppingsPrice1.Text = "5"
        ToppingsSelected_Capsicum.Visible = True
    End Sub

    Private Sub ToppingsButton_Jalapeño_Click(sender As Object, e As EventArgs) Handles ToppingsButton_Jalapeño.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Jalapeno Topping'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.ToppingsTextBoxJalapeño.Clear()
        We_re_almost_there.ToppingsTextBoxJalapeño.Text = "Jalapeño"
        ToppingsPrice2.Text = "5"
        ToppingsSelected_Jalapeño.Visible = True
    End Sub

    Private Sub ToppingsButton_Olives_Click(sender As Object, e As EventArgs) Handles ToppingsButton_Olives.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Olives Topping'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.ToppingsTextBoxOlives.Clear()
        We_re_almost_there.ToppingsTextBoxOlives.Text = "Olives"
        ToppingsPRice3.Text = "5"
        ToppingsSelected_Olives.Visible = True
    End Sub

    Private Sub ToppingsButton_Onion_Click(sender As Object, e As EventArgs) Handles ToppingsButton_Onion.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Onion Topping'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.ToppingsTextBoxOnion.Clear()
        We_re_almost_there.ToppingsTextBoxOnion.Text = "Onion"
        ToppingsPrice4.Text = "10"
        ToppingsSelected_Onion.Visible = True
    End Sub

    Private Sub ToppingsButton_Tomato_Click(sender As Object, e As EventArgs) Handles ToppingsButton_Tomato.Click
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Tomato Topping'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.ToppingsTextBoxTomato.Clear()
        We_re_almost_there.ToppingsTextBoxTomato.Text = "Tomato"
        ToppingsPrice5.Text = "10"
        ToppingsSelected_Tomato.Visible = True
    End Sub

    Private Sub DoneButton_Click(sender As Object, e As EventArgs) Handles DoneButton.Click
        Dim a, b, c, d, f, g As Integer
        If ToppingsPrice1.Text = "5" Then
            a = ToppingsPrice1.Text
        End If
        If ToppingsPrice2.Text = "5" Then
            b = ToppingsPrice2.Text
        End If
        If ToppingsPRice3.Text = "5" Then
            c = ToppingsPRice3.Text
        End If
        If ToppingsPrice4.Text = "10" Then
            d = ToppingsPrice4.Text
        End If
        If ToppingsPrice5.Text = "10" Then
            f = ToppingsPrice5.Text
        End If
        g = a + b + c + d + f
        We_re_almost_there.ToppingsPrice.Text = g
        MsgBox_SandwichQuantity.Visible = True
        Me.Enabled = False
    End Sub
End Class