<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class End_Screen
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
        Me.ViewBill = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ViewBill
        '
        Me.ViewBill.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ViewBill.FlatAppearance.BorderSize = 0
        Me.ViewBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ViewBill.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewBill.ForeColor = System.Drawing.Color.White
        Me.ViewBill.Location = New System.Drawing.Point(610, 807)
        Me.ViewBill.Name = "ViewBill"
        Me.ViewBill.Size = New System.Drawing.Size(220, 81)
        Me.ViewBill.TabIndex = 33
        Me.ViewBill.Text = "View Bill"
        Me.ViewBill.UseVisualStyleBackColor = False
        '
        'End_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.The_Sandwich_Wizard.My.Resources.Resources.done
        Me.ClientSize = New System.Drawing.Size(1440, 900)
        Me.Controls.Add(Me.ViewBill)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "End_Screen"
        Me.Text = "End_Screen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ViewBill As Button
End Class
