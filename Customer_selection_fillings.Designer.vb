<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_selection_fillings
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
        Me.VegFillingsButton = New System.Windows.Forms.Button()
        Me.NonVegFillingsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'VegFillingsButton
        '
        Me.VegFillingsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VegFillingsButton.FlatAppearance.BorderSize = 0
        Me.VegFillingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.VegFillingsButton.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VegFillingsButton.ForeColor = System.Drawing.Color.White
        Me.VegFillingsButton.Location = New System.Drawing.Point(326, 358)
        Me.VegFillingsButton.Name = "VegFillingsButton"
        Me.VegFillingsButton.Size = New System.Drawing.Size(300, 300)
        Me.VegFillingsButton.TabIndex = 27
        Me.VegFillingsButton.Text = "Veg Fillings"
        Me.VegFillingsButton.UseVisualStyleBackColor = False
        '
        'NonVegFillingsButton
        '
        Me.NonVegFillingsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NonVegFillingsButton.FlatAppearance.BorderSize = 0
        Me.NonVegFillingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NonVegFillingsButton.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NonVegFillingsButton.ForeColor = System.Drawing.Color.White
        Me.NonVegFillingsButton.Location = New System.Drawing.Point(810, 358)
        Me.NonVegFillingsButton.Name = "NonVegFillingsButton"
        Me.NonVegFillingsButton.Size = New System.Drawing.Size(300, 300)
        Me.NonVegFillingsButton.TabIndex = 28
        Me.NonVegFillingsButton.Text = "Non-Veg Fillings"
        Me.NonVegFillingsButton.UseVisualStyleBackColor = False
        '
        'Customer_selection_fillings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.The_Sandwich_Wizard.My.Resources.Resources.fillings
        Me.ClientSize = New System.Drawing.Size(1440, 900)
        Me.Controls.Add(Me.NonVegFillingsButton)
        Me.Controls.Add(Me.VegFillingsButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Customer_selection_fillings"
        Me.Text = "Customer_selection_fillings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VegFillingsButton As Button
    Friend WithEvents NonVegFillingsButton As Button
End Class
