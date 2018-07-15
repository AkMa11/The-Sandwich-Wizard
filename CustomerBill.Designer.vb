<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerBill
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
        Me.SandwichCost = New System.Windows.Forms.Label()
        Me.SideOrdersCost = New System.Windows.Forms.Label()
        Me.TotalCost = New System.Windows.Forms.Label()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.OrderNumberText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SandwichCost
        '
        Me.SandwichCost.AutoSize = True
        Me.SandwichCost.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SandwichCost.Location = New System.Drawing.Point(829, 366)
        Me.SandwichCost.Name = "SandwichCost"
        Me.SandwichCost.Size = New System.Drawing.Size(0, 29)
        Me.SandwichCost.TabIndex = 0
        '
        'SideOrdersCost
        '
        Me.SideOrdersCost.AutoSize = True
        Me.SideOrdersCost.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SideOrdersCost.Location = New System.Drawing.Point(829, 439)
        Me.SideOrdersCost.Name = "SideOrdersCost"
        Me.SideOrdersCost.Size = New System.Drawing.Size(0, 29)
        Me.SideOrdersCost.TabIndex = 1
        '
        'TotalCost
        '
        Me.TotalCost.AutoSize = True
        Me.TotalCost.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCost.Location = New System.Drawing.Point(829, 510)
        Me.TotalCost.Name = "TotalCost"
        Me.TotalCost.Size = New System.Drawing.Size(0, 29)
        Me.TotalCost.TabIndex = 2
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HomeButton.FlatAppearance.BorderSize = 0
        Me.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HomeButton.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeButton.ForeColor = System.Drawing.Color.White
        Me.HomeButton.Location = New System.Drawing.Point(609, 774)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(220, 81)
        Me.HomeButton.TabIndex = 33
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'OrderNumberText
        '
        Me.OrderNumberText.AutoSize = True
        Me.OrderNumberText.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.OrderNumberText.Location = New System.Drawing.Point(829, 297)
        Me.OrderNumberText.Name = "OrderNumberText"
        Me.OrderNumberText.Size = New System.Drawing.Size(0, 29)
        Me.OrderNumberText.TabIndex = 34
        '
        'CustomerBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.The_Sandwich_Wizard.My.Resources.Resources.bill1
        Me.ClientSize = New System.Drawing.Size(1440, 900)
        Me.Controls.Add(Me.OrderNumberText)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.TotalCost)
        Me.Controls.Add(Me.SideOrdersCost)
        Me.Controls.Add(Me.SandwichCost)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomerBill"
        Me.Text = "CustomerBill"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SandwichCost As Label
    Friend WithEvents SideOrdersCost As Label
    Friend WithEvents TotalCost As Label
    Friend WithEvents HomeButton As Button
    Friend WithEvents OrderNumberText As Label
End Class
