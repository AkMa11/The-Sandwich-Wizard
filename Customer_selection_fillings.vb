Public Class Customer_selection_fillings
    Private Sub VegFillingsButton_Click(sender As Object, e As EventArgs) Handles VegFillingsButton.Click
        Customer_selection_VegFillings.Visible = True
        Me.Visible = False
    End Sub

    Private Sub NonVegFillingsButton_Click(sender As Object, e As EventArgs) Handles NonVegFillingsButton.Click
        Customer_selection_NonVegFillings.Visible = True
        Me.Visible = False
    End Sub
End Class