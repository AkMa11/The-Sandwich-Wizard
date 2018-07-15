<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome_Screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ClickHereToMakeYourSandwichNowButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ClickHereToMakeYourSandwichNowButton
        '
        Me.ClickHereToMakeYourSandwichNowButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClickHereToMakeYourSandwichNowButton.FlatAppearance.BorderSize = 0
        Me.ClickHereToMakeYourSandwichNowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ClickHereToMakeYourSandwichNowButton.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClickHereToMakeYourSandwichNowButton.ForeColor = System.Drawing.Color.White
        Me.ClickHereToMakeYourSandwichNowButton.Location = New System.Drawing.Point(473, 700)
        Me.ClickHereToMakeYourSandwichNowButton.Name = "ClickHereToMakeYourSandwichNowButton"
        Me.ClickHereToMakeYourSandwichNowButton.Size = New System.Drawing.Size(460, 102)
        Me.ClickHereToMakeYourSandwichNowButton.TabIndex = 2
        Me.ClickHereToMakeYourSandwichNowButton.Text = "Click Here To Make Your Own Sandwich Now!"
        Me.ClickHereToMakeYourSandwichNowButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(515, 878)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "© 2015-16 | Amodh Naik, Manasi Nair | Version Early Beta 1"
        '
        'LogoutButton
        '
        Me.LogoutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogoutButton.FlatAppearance.BorderSize = 0
        Me.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LogoutButton.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.ForeColor = System.Drawing.Color.White
        Me.LogoutButton.Location = New System.Drawing.Point(1328, 12)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(100, 50)
        Me.LogoutButton.TabIndex = 4
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(473, 808)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(460, 60)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "View Popular Choices"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Welcome_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.The_Sandwich_Wizard.My.Resources.Resources.Home2
        Me.ClientSize = New System.Drawing.Size(1440, 900)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ClickHereToMakeYourSandwichNowButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Welcome_Screen"
        Me.Text = "Welcome_Screen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClickHereToMakeYourSandwichNowButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LogoutButton As Button
    Friend WithEvents Button1 As Button
End Class
