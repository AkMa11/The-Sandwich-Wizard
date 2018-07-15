Public Class MessageBox


    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Customer_selection_SideOrders.Visible = True
        Customer_selection_toppings.Visible = False
        Me.Visible = False
        MsgBox_SandwichQuantity.Visible = False
        Customer_selection_toppings.Enabled = True
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        We_re_almost_there.Visible = True
        Customer_selection_toppings.Visible = False
        Me.Visible = False
        MsgBox_SandwichQuantity.Visible = False
        Customer_selection_toppings.Enabled = True
    End Sub

    Private Sub MessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class