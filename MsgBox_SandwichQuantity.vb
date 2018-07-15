Public Class MsgBox_SandwichQuantity
    Private Sub IncreaseButton_Click(sender As Object, e As EventArgs) Handles IncreaseButton.Click
        QuantityText.Text = Val(QuantityText.Text) + 1
        If QuantityText.Text = "1" Then
            DecreaseButton.Enabled = False
        Else
            DecreaseButton.Enabled = True
        End If
    End Sub

    Private Sub DecreaseButton_Click(sender As Object, e As EventArgs) Handles DecreaseButton.Click
        QuantityText.Text = Val(QuantityText.Text) - 1
        If QuantityText.Text = "1" Then
            DecreaseButton.Enabled = False
        Else
            DecreaseButton.Enabled = True
        End If
    End Sub

    Private Sub MsgBox_SandwichQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QuantityText.Text = "1"
        DecreaseButton.Enabled = False

    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Me.Enabled = False
        MessageBox.Visible = True
    End Sub

    Private Sub QuantityText_TextChanged(sender As Object, e As EventArgs) Handles QuantityText.TextChanged

    End Sub
End Class