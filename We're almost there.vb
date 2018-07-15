Imports System.Data.SqlClient

Public Class We_re_almost_there

    Private Sub ServeHereButton_Click(sender As Object, e As EventArgs) Handles ServeHereButton.Click
        Dim p, q, r, s, t, u, v, w, x As Integer
        If BreadPrice.Text > "1" Then
            p = BreadPrice.Text
        End If
        If SaucePrice.Text > "1" Then
            q = SaucePrice.Text
        End If
        If CheesePrice.Text > "1" Then
            r = CheesePrice.Text
        End If
        If FillingsPrice.Text > "1" Then
            s = FillingsPrice.Text
        End If
        If ToppingsPrice.Text > "1" Then
            t = ToppingsPrice.Text
        End If
        If SideOrdersPrice.Text > "1" Then
            u = SideOrdersPrice.Text
            CustomerBill.SideOrdersCost.Text = "Rs" & u
        End If
        x = MsgBox_SandwichQuantity.QuantityText.Text
            v = (p + q + r + s + t) * (x)
        CustomerBill.SandwichCost.Text = "Rs" & v
        w = v + u
        CustomerBill.TotalCost.Text = "Rs" & w

        

        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"

        con.Open()
        Dim cmd As New SqlCommand(("INSERT INTO staff_pending VALUES('" &
                                  BreadTextBox.Text & "','" &
                                  SauceTextBoxMayonese.Text & "','" &
                                  SauceTextBoxMustard.Text & "','" &
                                  SauceTextBoxPesto.Text & "','" &
                                  SauceTextBoxSchezwan.Text & "','" &
                                  SauceTextBoxTomato.Text & "','" &
                                  CheeseTextBoxCheddar.Text & "','" &
                                  CheeseTextBoxCotija.Text & "','" &
                                  CheeseTextBoxGauda.Text & "','" &
                                  CheeseTextBoxMozzarella.Text & "','" &
                                  CheeseTextBoxParmigiano.Text & "','" &
                                  FillingsTextBox.Text & "','" &
                                  ToppingsTextBoxCapsicum.Text & "','" &
                                  ToppingsTextBoxJalapeño.Text & "','" &
                                  ToppingsTextBoxOlives.Text & "','" &
                                  ToppingsTextBoxOnion.Text & "','" &
                                  ToppingsTextBoxTomato.Text & "','" &
                                  SideOrdersTextBoxCoffee.Text & "','" &
                                  SideOrdersTextBoxCoke.Text & "','" &
                                  SideOrdersTextBoxFries.Text & "','" &
                                  SideOrdersTextBoxIceCream.Text & "','" &
                                  SideOrdersTextBoxMousseCake.Text & "','" &
                                  CustomerBill.TotalCost.Text & "','" &
                                  DateTimePicker1.Value & "','" &
                                  CustomerBill.SandwichCost.Text & "','" &
                                  CustomerBill.SideOrdersCost.Text & "','" &
                                  ServeHereButton.Text & "','" &
                                  FulfilmentText.Text & "','" &
                                  MsgBox_SandwichQuantity.QuantityText.Text & "')"), con)
        cmd.ExecuteNonQuery()
        con.Close()


        Dim da As New SqlDataAdapter
        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand
        Dim ds As New DataSet
        Dim dv As New DataView
        con2.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"
        Dim r2 As SqlDataReader
        cmd2.CommandText = "select Order_No from staff_pending where Order_DateTime = '" & DateTimePicker1.Value & "'"
        cmd2.Connection = con2
        con2.Open()
        Try
            r2 = cmd2.ExecuteReader
            Do While r2.Read()
                CustomerBill.OrderNumberText.Text = (r2(0))
            Loop
            r2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con2.Close()

        End_Screen.Visible = True
        Me.Visible = False
    End Sub

    Private Sub TakeAwayButton_Click(sender As Object, e As EventArgs) Handles TakeAwayButton.Click
        Dim p, q, r, s, t, u, v, w, x As Integer
        If BreadPrice.Text > "1" Then
            p = BreadPrice.Text
        End If
        If SaucePrice.Text > "1" Then
            q = SaucePrice.Text
        End If
        If CheesePrice.Text > "1" Then
            r = CheesePrice.Text
        End If
        If FillingsPrice.Text > "1" Then
            s = FillingsPrice.Text
        End If
        If ToppingsPrice.Text > "1" Then
            t = ToppingsPrice.Text
        End If
        If SideOrdersPrice.Text > "1" Then
            u = SideOrdersPrice.Text
            CustomerBill.SideOrdersCost.Text = "Rs" & u
        End If
        x = MsgBox_SandwichQuantity.QuantityText.Text
        v = (p + q + r + s + t) * (x)
        CustomerBill.SandwichCost.Text = "Rs" & v
        w = v + u
        CustomerBill.TotalCost.Text = "Rs" & w


        'sending data to the server
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"
        con.Open()
        Dim cmd As New SqlCommand(("INSERT INTO staff_pending VALUES('" &
                                  BreadTextBox.Text & "','" &
                                  SauceTextBoxMayonese.Text & "','" &
                                  SauceTextBoxMustard.Text & "','" &
                                  SauceTextBoxPesto.Text & "','" &
                                  SauceTextBoxSchezwan.Text & "','" &
                                  SauceTextBoxTomato.Text & "','" &
                                  CheeseTextBoxCheddar.Text & "','" &
                                  CheeseTextBoxCotija.Text & "','" &
                                  CheeseTextBoxGauda.Text & "','" &
                                  CheeseTextBoxMozzarella.Text & "','" &
                                  CheeseTextBoxParmigiano.Text & "','" &
                                  FillingsTextBox.Text & "','" &
                                  ToppingsTextBoxCapsicum.Text & "','" &
                                  ToppingsTextBoxJalapeño.Text & "','" &
                                  ToppingsTextBoxOlives.Text & "','" &
                                  ToppingsTextBoxOnion.Text & "','" &
                                  ToppingsTextBoxTomato.Text & "','" &
                                  SideOrdersTextBoxCoffee.Text & "','" &
                                  SideOrdersTextBoxCoke.Text & "','" &
                                  SideOrdersTextBoxFries.Text & "','" &
                                  SideOrdersTextBoxIceCream.Text & "','" &
                                  SideOrdersTextBoxMousseCake.Text & "','" &
                                  CustomerBill.TotalCost.Text & "','" &
                                  DateTimePicker1.Value & "','" &
                                  CustomerBill.SandwichCost.Text & "','" &
                                  CustomerBill.SideOrdersCost.Text & "','" &
                                  TakeAwayButton.Text & "','" &
                                  FulfilmentText.Text & "','" &
                                  MsgBox_SandwichQuantity.QuantityText.Text & "')"), con)
        cmd.ExecuteNonQuery()
        con.Close()

        Dim da As New SqlDataAdapter
        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand
        Dim ds As New DataSet
        Dim dv As New DataView
        con2.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"
        Dim r2 As SqlDataReader
        cmd2.CommandText = "select Order_No from staff_pending where Order_DateTime = '" & DateTimePicker1.Value & "'"
        cmd2.Connection = con2
        con2.Open()
        Try
            r2 = cmd2.ExecuteReader
            Do While r2.Read()
                CustomerBill.OrderNumberText.Text = (r2(0))
            Loop
            r2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con2.Close()

        End_Screen.Visible = True
        Me.Visible = False
    End Sub

    Private Sub StartOverButton_Click(sender As Object, e As EventArgs) Handles StartOverButton.Click
        MsgBox_SandwichQuantity.Enabled = True
        Customer_selection_SideOrders.SideOrdersSelected_Coke.Visible = False
        Customer_selection_SideOrders.SideOrdersSelected_Fries.Visible = False
        Customer_selection_SideOrders.SideOrdersSelected_IceCream.Visible = False
        Customer_selection_SideOrders.SideOrdersSelected_MousseCake.Visible = False
        Customer_selection_SideOrders.DecCoffee.Visible = False
        Customer_selection_SideOrders.DecCoke.Visible = False
        Customer_selection_SideOrders.DecFries.Visible = False
        Customer_selection_SideOrders.DecIceCream.Visible = False
        Customer_selection_SideOrders.DecMousseCake.Visible = False
        Customer_selection_SideOrders.IncCoffee.Visible = False
        Customer_selection_SideOrders.IncCoke.Visible = False
        Customer_selection_SideOrders.IncFries.Visible = False
        Customer_selection_SideOrders.IncIceCream.Visible = False
        Customer_selection_SideOrders.IncMousseCake.Visible = False
        Customer_selection_SideOrders.Xcoffee.Visible = False
        Customer_selection_SideOrders.Xcoke.Visible = False
        Customer_selection_SideOrders.xFries.Visible = False
        Customer_selection_SideOrders.XiceCream.Visible = False
        Customer_selection_SideOrders.XmousseCake.Visible = False
        Customer_selection_SideOrders.Quantity_Coffee.Visible = False
        Customer_selection_SideOrders.Quantity_Coke.Visible = False
        Customer_selection_SideOrders.Quantity_Fries.Visible = False
        Customer_selection_SideOrders.Quantity_IceCream.Visible = False
        Customer_selection_SideOrders.Quantity_MousseCake.Visible = False
        'deselecting sauce
        Customer_selection_sauce.SauceSelected_Mayonese.Visible = False
        Customer_selection_sauce.SauceSelected_Mustard.Visible = False
        Customer_selection_sauce.SauceSelected_Pesto.Visible = False
        Customer_selection_sauce.SauceSelected_Schezwan.Visible = False
        Customer_selection_sauce.SauceSelected_Tomato.Visible = False
        'deselecting cheese
        Customer_selection_cheese.CheeseSelected_Cheddar.Visible = False
        Customer_selection_cheese.CheeseSelected_Cotija.Visible = False
        Customer_selection_cheese.CheeseSelected_Gauda.Visible = False
        Customer_selection_cheese.CheeseSelected_Mozzarella.Visible = False
        Customer_selection_cheese.CheeseSelected_Parmigiano.Visible = False
        'deselecting toppings
        Customer_selection_toppings.ToppingsSelected_Capsicum.Visible = False
        Customer_selection_toppings.ToppingsSelected_Jalapeño.Visible = False
        Customer_selection_toppings.ToppingsSelected_Olives.Visible = False
        Customer_selection_toppings.ToppingsSelected_Onion.Visible = False
        Customer_selection_toppings.ToppingsSelected_Tomato.Visible = False
        'deselecting side orders
        Customer_selection_SideOrders.SideOrdersSelected_Coffee.Visible = False
        Customer_selection_SideOrders.SideOrdersSelected_Coke.Visible = False
        Customer_selection_SideOrders.SideOrdersSelected_Fries.Visible = False
        Customer_selection_SideOrders.SideOrdersSelected_IceCream.Visible = False
        Customer_selection_SideOrders.SideOrdersSelected_MousseCake.Visible = False
        'clearing the list boxes
        Me.BreadTextBox.Clear()
        'sauces:
        Me.SauceTextBoxMayonese.Clear()
        Me.SauceTextBoxMustard.Clear()
        Me.SauceTextBoxPesto.Clear()
        Me.SauceTextBoxSchezwan.Clear()
        Me.SauceTextBoxTomato.Clear()
        'cheese:
        Me.CheeseTextBoxCheddar.Clear()
        Me.CheeseTextBoxCotija.Clear()
        Me.CheeseTextBoxGauda.Clear()
        Me.CheeseTextBoxMozzarella.Clear()
        Me.CheeseTextBoxParmigiano.Clear()
        'Fillings
        Me.FillingsTextBox.Clear()
        'Toppings:
        Me.ToppingsTextBoxCapsicum.Clear()
        Me.ToppingsTextBoxJalapeño.Clear()
        Me.ToppingsTextBoxOlives.Clear()
        Me.ToppingsTextBoxOnion.Clear()
        Me.ToppingsTextBoxTomato.Clear()
        'SideOrders:
        Me.SideOrdersTextBoxCoffee.Clear()
        Me.SideOrdersTextBoxCoke.Clear()
        Me.SideOrdersTextBoxFries.Clear()
        Me.SideOrdersTextBoxIceCream.Clear()
        Me.SideOrdersTextBoxMousseCake.Clear()
        'Prices:
        Me.BreadPrice.Clear()
        Me.SaucePrice.Clear()
        Me.CheesePrice.Clear()
        Me.FillingsPrice.Clear()
        Me.ToppingsPrice.Clear()
        Me.SideOrdersPrice.Clear()

        Customer_selection_bread.Visible = True
        Me.Visible = False
    End Sub

    Private Sub We_re_almost_there_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToppingsPrice_TextChanged(sender As Object, e As EventArgs) Handles ToppingsPrice.TextChanged

    End Sub

    Private Sub SideOrdersPrice_TextChanged(sender As Object, e As EventArgs) Handles SideOrdersPrice.TextChanged

    End Sub
End Class