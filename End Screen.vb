Public Class End_Screen
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) 
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
        We_re_almost_there.BreadTextBox.Clear()
        'sauces:
        We_re_almost_there.SauceTextBoxMayonese.Clear()
        We_re_almost_there.SauceTextBoxMustard.Clear()
        We_re_almost_there.SauceTextBoxPesto.Clear()
        We_re_almost_there.SauceTextBoxSchezwan.Clear()
        We_re_almost_there.SauceTextBoxTomato.Clear()
        'cheese:
        We_re_almost_there.CheeseTextBoxCheddar.Clear()
        We_re_almost_there.CheeseTextBoxCotija.Clear()
        We_re_almost_there.CheeseTextBoxGauda.Clear()
        We_re_almost_there.CheeseTextBoxMozzarella.Clear()
        We_re_almost_there.CheeseTextBoxParmigiano.Clear()
        'Fillings
        We_re_almost_there.FillingsTextBox.Clear()
        'Toppings:
        We_re_almost_there.ToppingsTextBoxCapsicum.Clear()
        We_re_almost_there.ToppingsTextBoxJalapeño.Clear()
        We_re_almost_there.ToppingsTextBoxOlives.Clear()
        We_re_almost_there.ToppingsTextBoxOnion.Clear()
        We_re_almost_there.ToppingsTextBoxTomato.Clear()
        'SideOrders:
        We_re_almost_there.SideOrdersTextBoxCoffee.Clear()
        We_re_almost_there.SideOrdersTextBoxCoke.Clear()
        We_re_almost_there.SideOrdersTextBoxFries.Clear()
        We_re_almost_there.SideOrdersTextBoxIceCream.Clear()
        We_re_almost_there.SideOrdersTextBoxMousseCake.Clear()
        'Prices:
        We_re_almost_there.BreadPrice.Clear()
        We_re_almost_there.SaucePrice.Clear()
        We_re_almost_there.CheesePrice.Clear()
        We_re_almost_there.FillingsPrice.Clear()
        We_re_almost_there.ToppingsPrice.Clear()
        We_re_almost_there.SideOrdersPrice.Clear()
        Welcome_Screen.Visible = True
        Me.Visible = False
    End Sub

    Private Sub ViewBill_Click(sender As Object, e As EventArgs) Handles ViewBill.Click
        CustomerBill.Visible = True
        Me.Visible = False
    End Sub
End Class