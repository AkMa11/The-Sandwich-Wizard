Imports System.Data.SqlClient

Public Class Customer_selection_SideOrders

    Private Sub Customer_selection_SideOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quantity_Coke.Text = "1"
        Quantity_Coffee.Text = "1"
        Quantity_Fries.Text = "1"
        Quantity_IceCream.Text = "1"
        Quantity_MousseCake.Text = "1"
        SideOrdersSelected_Coffee.Visible = False
        SideOrdersSelected_Coke.Visible = False
        SideOrdersSelected_Fries.Visible = False
        SideOrdersSelected_IceCream.Visible = False
        SideOrdersSelected_MousseCake.Visible = False
        DecCoffee.Visible = False
        DecCoke.Visible = False
        DecFries.Visible = False
        DecIceCream.Visible = False
        DecMousseCake.Visible = False
        IncCoffee.Visible = False
        IncCoke.Visible = False
        IncFries.Visible = False
        IncIceCream.Visible = False
        IncMousseCake.Visible = False
        Xcoffee.Visible = False
        Xcoke.Visible = False
        xFries.Visible = False
        XiceCream.Visible = False
        XmousseCake.Visible = False
        Quantity_Coffee.Visible = False
        Quantity_Coke.Visible = False
        Quantity_Fries.Visible = False
        Quantity_IceCream.Visible = False
        Quantity_MousseCake.Visible = False
    End Sub

    Private Sub IncCoke_Click(sender As Object, e As EventArgs) Handles IncCoke.Click
        Quantity_Coke.Text = Val(Quantity_Coke.Text) + 1
        If Quantity_Coke.Text = "1" Then
            DecCoke.Enabled = False
        Else
            DecCoke.Enabled = True
        End If
    End Sub

    Private Sub DecCoke_Click(sender As Object, e As EventArgs) Handles DecCoke.Click
        Quantity_Coke.Text = Val(Quantity_Coke.Text) - 1
        If Quantity_Coke.Text = "1" Then
            DecCoke.Enabled = False
        Else
            DecCoke.Enabled = True
        End If
    End Sub

    Private Sub IncCoffee_Click(sender As Object, e As EventArgs) Handles IncCoffee.Click
        Quantity_Coffee.Text = Val(Quantity_Coffee.Text) + 1
        If Quantity_Coffee.Text = "1" Then
            DecCoffee.Enabled = False
        Else
            DecCoffee.Enabled = True
        End If
    End Sub

    Private Sub DecCoffee_Click(sender As Object, e As EventArgs) Handles DecCoffee.Click
        Quantity_Coffee.Text = Val(Quantity_Coffee.Text) - 1
        If Quantity_Coffee.Text = "1" Then
            DecCoffee.Enabled = False
        Else
            DecCoffee.Enabled = True
        End If

    End Sub

    Private Sub IncFries_Click(sender As Object, e As EventArgs) Handles IncFries.Click
        Quantity_Fries.Text = Val(Quantity_Fries.Text) + 1
        If Quantity_Fries.Text = "1" Then
            DecFries.Enabled = False
        Else
            DecFries.Enabled = True
        End If
    End Sub

    Private Sub DecFries_Click(sender As Object, e As EventArgs) Handles DecFries.Click
        Quantity_Fries.Text = Val(Quantity_Fries.Text) - 1
        If Quantity_Fries.Text = "1" Then
            DecFries.Enabled = False
        Else
            DecFries.Enabled = True
        End If
    End Sub

    Private Sub IncIceCream_Click(sender As Object, e As EventArgs) Handles IncIceCream.Click
        Quantity_IceCream.Text = Val(Quantity_IceCream.Text) + 1
        If Quantity_IceCream.Text = "1" Then
            DecIceCream.Enabled = False
        Else
            DecIceCream.Enabled = True
        End If
    End Sub

    Private Sub DecIceCream_Click(sender As Object, e As EventArgs) Handles DecIceCream.Click
        Quantity_IceCream.Text = Val(Quantity_IceCream.Text) - 1
        If Quantity_IceCream.Text = "1" Then
            DecIceCream.Enabled = False
        Else
            DecIceCream.Enabled = True
        End If
    End Sub

    Private Sub IncMousseCake_Click(sender As Object, e As EventArgs) Handles IncMousseCake.Click
        Quantity_MousseCake.Text = Val(Quantity_MousseCake.Text) + 1
        If Quantity_MousseCake.Text = "1" Then
            DecMousseCake.Enabled = False
        Else
            DecMousseCake.Enabled = True
        End If
    End Sub

    Private Sub DecMousseCake_Click(sender As Object, e As EventArgs) Handles DecMousseCake.Click
        Quantity_MousseCake.Text = Val(Quantity_MousseCake.Text) - 1
        If Quantity_MousseCake.Text = "1" Then
            DecMousseCake.Enabled = False
        Else
            DecMousseCake.Enabled = True
        End If
    End Sub

    Private Sub SideOrdersButton_Coffee_Click(sender As Object, e As EventArgs) Handles SideOrdersButton_Coffee.Click
        DecCoffee.Visible = True
        IncCoffee.Visible = True
        Xcoffee.Visible = True
        Quantity_Coffee.Visible = True
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Coffee'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.SideOrdersTextBoxCoffee.Clear()
        SideOrderPrice1.Text = "35"
        SideOrdersSelected_Coffee.Visible = True
    End Sub

    Private Sub SideOrdersButton_Coke_Click(sender As Object, e As EventArgs) Handles SideOrdersButton_Coke.Click
        DecCoke.Visible = True
        IncCoke.Visible = True
        Xcoke.Visible = True
        Quantity_Coke.Visible = True
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Coke'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.SideOrdersTextBoxCoke.Clear()
        SideOrderPrice2.Text = "35"
        SideOrdersSelected_Coke.Visible = True
    End Sub

    Private Sub SideOrdersButton_Fries_Click(sender As Object, e As EventArgs) Handles SideOrdersButton_Fries.Click
        DecFries.Visible = True
        IncFries.Visible = True
        xFries.Visible = True
        Quantity_Fries.Visible = True
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Fries'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.SideOrdersTextBoxFries.Clear()
        SideOrderPrice3.Text = "30"
        SideOrdersSelected_Fries.Visible = True
    End Sub

    Private Sub SideOrdersButton_IceCream_Click(sender As Object, e As EventArgs) Handles SideOrdersButton_IceCream.Click
        DecIceCream.Visible = True
        IncIceCream.Visible = True
        XiceCream.Visible = True
        Quantity_IceCream.Visible = True
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Ice Cream'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.SideOrdersTextBoxIceCream.Clear()
        SideOrderPrice4.Text = "35"
        SideOrdersSelected_IceCream.Visible = True
    End Sub

    Private Sub SideOrdersButton_MousseCake_Click(sender As Object, e As EventArgs) Handles SideOrdersButton_MousseCake.Click
        DecMousseCake.Visible = True
        IncMousseCake.Visible = True
        XmousseCake.Visible = True
        Quantity_MousseCake.Visible = True
        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("update products set quantity = quantity + 1 where name = 'Mousse Cake'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        'sent to server
        We_re_almost_there.SideOrdersTextBoxMousseCake.Clear()
        SideOrderPrice5.Text = "35"
        SideOrdersSelected_MousseCake.Visible = True
    End Sub

    Private Sub DoneButton2_Click(sender As Object, e As EventArgs) Handles DoneButton2.Click

        If Quantity_Coffee.Visible = True Then
            We_re_almost_there.SideOrdersTextBoxCoffee.Text = "Coffee " & Xcoffee.Text & Quantity_Coffee.Text
        Else
            We_re_almost_there.SideOrdersTextBoxCoffee.Text = "Coffee"
        End If
        If Quantity_Coke.Visible = True Then
            We_re_almost_there.SideOrdersTextBoxCoke.Text = "Coke " & Xcoke.Text & Quantity_Coke.Text
        Else
            We_re_almost_there.SideOrdersTextBoxCoke.Text = "Coke"
        End If
        If Quantity_Fries.Visible = True Then
            We_re_almost_there.SideOrdersTextBoxFries.Text = "Fries " & xFries.Text & Quantity_Fries.Text
        Else
            We_re_almost_there.SideOrdersTextBoxFries.Text = "Fries"
        End If
        If Quantity_IceCream.Visible = True Then
            We_re_almost_there.SideOrdersTextBoxIceCream.Text = "Ice Cream " & XiceCream.Text & Quantity_IceCream.Text
        Else
            We_re_almost_there.SideOrdersTextBoxIceCream.Text = "Ice Cream"
        End If
        If Quantity_MousseCake.Visible = True Then
            We_re_almost_there.SideOrdersTextBoxMousseCake.Text = "Mousse Cake " & XmousseCake.Text & Quantity_MousseCake.Text
        Else
            We_re_almost_there.SideOrdersTextBoxMousseCake.Text = "Mousse Cake"
        End If

        Dim a, b, c, d, f, g As Integer
        If SideOrderPrice1.Text = "35" And Quantity_Coffee.Visible = True Then
            a = (SideOrderPrice1.Text) * (Quantity_Coffee.Text)
        ElseIf SideOrderPrice1.Text = "35" Then
            a = SideOrderPrice1.Text
        End If
        If SideOrderPrice2.Text = "35" And Quantity_Coke.Visible = True Then
            b = (SideOrderPrice2.Text) * (Quantity_Coke.Text)
        ElseIf SideOrderPrice2.Text = "35" Then
            b = SideOrderPrice2.Text
        End If
        If SideOrderPrice3.Text = "30" And Quantity_Fries.Visible = True Then
            c = (SideOrderPrice3.Text) * (Quantity_Fries.Text)
        ElseIf SideOrderPrice3.Text = "30" Then
            c = SideOrderPrice3.Text
        End If
        If SideOrderPrice4.Text = "35" And Quantity_IceCream.Visible = True Then
            d = (SideOrderPrice4.Text) * (Quantity_IceCream.Text)
        ElseIf SideOrderPrice4.Text = "35" Then
            d = SideOrderPrice4.Text
        End If
        If SideOrderPrice5.Text = "35" And Quantity_MousseCake.Visible = True Then
            f = (SideOrderPrice5.Text) * (Quantity_MousseCake.Text)
        ElseIf SideOrderPrice5.Text = "35" Then
            f = SideOrderPrice5.Text
        End If
        g = a + b + c + d + f
        We_re_almost_there.SideOrdersPrice.Text = g
        We_re_almost_there.Visible = True
        Me.Visible = False
    End Sub


    Private Sub SideOrdersSelected_Coke_Click(sender As Object, e As EventArgs) Handles SideOrdersSelected_Coke.Click

    End Sub
End Class