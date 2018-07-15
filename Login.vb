Public Class Login
    Public Class DoubleBufferedTableLayoutPanel
        Inherits TableLayoutPanel
        Public Sub New()
            Me.DoubleBuffered = True
        End Sub
    End Class
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Select Case SelectUserComboBox.Text
            Case "Customer"
                Welcome_Screen.Visible = True
                'Staff_home.Visible = True
                'Customer_Bill_Report.Visible = True
                Me.Visible = False
            Case "Staff"
                Staff_home.Visible = True
                Me.Visible = False
        End Select
    End Sub
End Class
