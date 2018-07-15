<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgBox_SandwichQuantity
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IncreaseButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DecreaseButton = New System.Windows.Forms.Button()
        Me.QuantityText = New System.Windows.Forms.RichTextBox()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 23)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "The Sandwich Wizard"
        '
        'IncreaseButton
        '
        Me.IncreaseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IncreaseButton.FlatAppearance.BorderSize = 0
        Me.IncreaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IncreaseButton.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncreaseButton.ForeColor = System.Drawing.Color.White
        Me.IncreaseButton.Location = New System.Drawing.Point(325, 114)
        Me.IncreaseButton.Name = "IncreaseButton"
        Me.IncreaseButton.Size = New System.Drawing.Size(65, 70)
        Me.IncreaseButton.TabIndex = 53
        Me.IncreaseButton.Text = "+"
        Me.IncreaseButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 22.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(495, 37)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "How many sandwiches would you like?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(513, 33)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "                                                                                 " &
    "  "
        '
        'DecreaseButton
        '
        Me.DecreaseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DecreaseButton.FlatAppearance.BorderSize = 0
        Me.DecreaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DecreaseButton.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecreaseButton.ForeColor = System.Drawing.Color.White
        Me.DecreaseButton.Location = New System.Drawing.Point(111, 114)
        Me.DecreaseButton.Name = "DecreaseButton"
        Me.DecreaseButton.Size = New System.Drawing.Size(65, 70)
        Me.DecreaseButton.TabIndex = 52
        Me.DecreaseButton.Text = "-"
        Me.DecreaseButton.UseVisualStyleBackColor = False
        '
        'QuantityText
        '
        Me.QuantityText.Font = New System.Drawing.Font("Calibri", 40.0!)
        Me.QuantityText.Location = New System.Drawing.Point(217, 114)
        Me.QuantityText.Name = "QuantityText"
        Me.QuantityText.ReadOnly = True
        Me.QuantityText.Size = New System.Drawing.Size(65, 70)
        Me.QuantityText.TabIndex = 56
        Me.QuantityText.Text = ""
        '
        'NextButton
        '
        Me.NextButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NextButton.FlatAppearance.BorderSize = 0
        Me.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NextButton.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.ForeColor = System.Drawing.Color.White
        Me.NextButton.Location = New System.Drawing.Point(197, 206)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(103, 44)
        Me.NextButton.TabIndex = 57
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'MsgBox_SandwichQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(513, 280)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.QuantityText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IncreaseButton)
        Me.Controls.Add(Me.DecreaseButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MsgBox_SandwichQuantity"
        Me.Text = "MsgBox_SandwichQuantity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents IncreaseButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DecreaseButton As Button
    Friend WithEvents QuantityText As RichTextBox
    Friend WithEvents NextButton As Button
End Class
