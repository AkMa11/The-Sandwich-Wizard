
Public Class Welcome_Screen
    Private Sub ClickHereToMakeYourSandwichNowButton_Click(sender As Object, e As EventArgs) Handles ClickHereToMakeYourSandwichNowButton.Click
        Customer_selection_bread.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Welcome_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        LogoutBox.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        popular_choices_report.Show()
    End Sub
End Class