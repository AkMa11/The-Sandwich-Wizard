<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Staff_home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BreadGroup = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SauceGroup = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheeseGroup = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FillingsGroup = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ToppingsGroup = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SideOrdersGroup = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RefreshOrdersButton = New System.Windows.Forms.Button()
        Me.OrderTypeGroup = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TotalPrice = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.OrderFulfilmentGroup = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.CancelOrderButton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PlaceholderButton = New System.Windows.Forms.Button()
        Me.OrderCompleteButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.StaffpendingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TSWDataSet = New The_Sandwich_Wizard.TSWDataSet()
        Me.Staff_pendingTableAdapter = New The_Sandwich_Wizard.TSWDataSetTableAdapters.staff_pendingTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.BreadGroup.SuspendLayout()
        Me.SauceGroup.SuspendLayout()
        Me.CheeseGroup.SuspendLayout()
        Me.FillingsGroup.SuspendLayout()
        Me.ToppingsGroup.SuspendLayout()
        Me.SideOrdersGroup.SuspendLayout()
        Me.OrderTypeGroup.SuspendLayout()
        Me.TotalPrice.SuspendLayout()
        Me.OrderFulfilmentGroup.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.StaffpendingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSWDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1424, 861)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox6)
        Me.FlowLayoutPanel1.Controls.Add(Me.BreadGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.SauceGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.CheeseGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.FillingsGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.ToppingsGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.SideOrdersGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.RefreshOrdersButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.OrderTypeGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.TotalPrice)
        Me.FlowLayoutPanel1.Controls.Add(Me.OrderFulfilmentGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelOrderButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button5)
        Me.FlowLayoutPanel1.Controls.Add(Me.PlaceholderButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.OrderCompleteButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 103)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1418, 755)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 155)
        Me.Button1.TabIndex = 16
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox6.Controls.Add(Me.ComboBox1)
        Me.GroupBox6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(47, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(184, 155)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Order Number"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(22, 97)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(143, 31)
        Me.ComboBox1.TabIndex = 0
        '
        'BreadGroup
        '
        Me.BreadGroup.Controls.Add(Me.Label2)
        Me.BreadGroup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreadGroup.ForeColor = System.Drawing.Color.White
        Me.BreadGroup.Location = New System.Drawing.Point(237, 3)
        Me.BreadGroup.Name = "BreadGroup"
        Me.BreadGroup.Size = New System.Drawing.Size(184, 155)
        Me.BreadGroup.TabIndex = 2
        Me.BreadGroup.TabStop = False
        Me.BreadGroup.Text = "Bread"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "-"
        '
        'SauceGroup
        '
        Me.SauceGroup.BackColor = System.Drawing.Color.Transparent
        Me.SauceGroup.Controls.Add(Me.Label7)
        Me.SauceGroup.Controls.Add(Me.Label6)
        Me.SauceGroup.Controls.Add(Me.Label5)
        Me.SauceGroup.Controls.Add(Me.Label4)
        Me.SauceGroup.Controls.Add(Me.Label3)
        Me.SauceGroup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SauceGroup.ForeColor = System.Drawing.Color.White
        Me.SauceGroup.Location = New System.Drawing.Point(427, 3)
        Me.SauceGroup.Name = "SauceGroup"
        Me.SauceGroup.Size = New System.Drawing.Size(184, 155)
        Me.SauceGroup.TabIndex = 3
        Me.SauceGroup.TabStop = False
        Me.SauceGroup.Text = "Sauce"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 23)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "-"
        '
        'CheeseGroup
        '
        Me.CheeseGroup.Controls.Add(Me.Label8)
        Me.CheeseGroup.Controls.Add(Me.Label9)
        Me.CheeseGroup.Controls.Add(Me.Label10)
        Me.CheeseGroup.Controls.Add(Me.Label11)
        Me.CheeseGroup.Controls.Add(Me.Label12)
        Me.CheeseGroup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheeseGroup.ForeColor = System.Drawing.Color.White
        Me.CheeseGroup.Location = New System.Drawing.Point(617, 3)
        Me.CheeseGroup.Name = "CheeseGroup"
        Me.CheeseGroup.Size = New System.Drawing.Size(184, 155)
        Me.CheeseGroup.TabIndex = 4
        Me.CheeseGroup.TabStop = False
        Me.CheeseGroup.Text = "Cheese"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 23)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 23)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(6, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 23)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(6, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 23)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(6, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 23)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "-"
        '
        'FillingsGroup
        '
        Me.FillingsGroup.Controls.Add(Me.Label13)
        Me.FillingsGroup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillingsGroup.ForeColor = System.Drawing.Color.White
        Me.FillingsGroup.Location = New System.Drawing.Point(807, 3)
        Me.FillingsGroup.Name = "FillingsGroup"
        Me.FillingsGroup.Size = New System.Drawing.Size(184, 155)
        Me.FillingsGroup.TabIndex = 5
        Me.FillingsGroup.TabStop = False
        Me.FillingsGroup.Text = "Fillings"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(6, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 23)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "-"
        '
        'ToppingsGroup
        '
        Me.ToppingsGroup.Controls.Add(Me.Label14)
        Me.ToppingsGroup.Controls.Add(Me.Label15)
        Me.ToppingsGroup.Controls.Add(Me.Label16)
        Me.ToppingsGroup.Controls.Add(Me.Label17)
        Me.ToppingsGroup.Controls.Add(Me.Label18)
        Me.ToppingsGroup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToppingsGroup.ForeColor = System.Drawing.Color.White
        Me.ToppingsGroup.Location = New System.Drawing.Point(997, 3)
        Me.ToppingsGroup.Name = "ToppingsGroup"
        Me.ToppingsGroup.Size = New System.Drawing.Size(184, 155)
        Me.ToppingsGroup.TabIndex = 6
        Me.ToppingsGroup.TabStop = False
        Me.ToppingsGroup.Text = "Toppings"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(6, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 23)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "-"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(6, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 23)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "-"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(6, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 23)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "-"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(6, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(16, 23)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "-"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(6, 27)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(16, 23)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "-"
        '
        'SideOrdersGroup
        '
        Me.SideOrdersGroup.Controls.Add(Me.Label19)
        Me.SideOrdersGroup.Controls.Add(Me.Label20)
        Me.SideOrdersGroup.Controls.Add(Me.Label21)
        Me.SideOrdersGroup.Controls.Add(Me.Label22)
        Me.SideOrdersGroup.Controls.Add(Me.Label23)
        Me.SideOrdersGroup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SideOrdersGroup.ForeColor = System.Drawing.Color.White
        Me.SideOrdersGroup.Location = New System.Drawing.Point(1187, 3)
        Me.SideOrdersGroup.Name = "SideOrdersGroup"
        Me.SideOrdersGroup.Size = New System.Drawing.Size(184, 155)
        Me.SideOrdersGroup.TabIndex = 7
        Me.SideOrdersGroup.TabStop = False
        Me.SideOrdersGroup.Text = "SideOrders"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(6, 119)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 23)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "-"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(6, 96)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(16, 23)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "-"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(6, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(16, 23)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "-"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(6, 50)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(16, 23)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "-"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(6, 27)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(16, 23)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "-"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1377, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 155)
        Me.Button2.TabIndex = 17
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(3, 164)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 155)
        Me.Button3.TabIndex = 18
        Me.Button3.UseVisualStyleBackColor = False
        '
        'RefreshOrdersButton
        '
        Me.RefreshOrdersButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RefreshOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RefreshOrdersButton.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshOrdersButton.ForeColor = System.Drawing.Color.White
        Me.RefreshOrdersButton.Location = New System.Drawing.Point(47, 164)
        Me.RefreshOrdersButton.Name = "RefreshOrdersButton"
        Me.RefreshOrdersButton.Size = New System.Drawing.Size(374, 155)
        Me.RefreshOrdersButton.TabIndex = 10
        Me.RefreshOrdersButton.Text = "Refresh Orders"
        Me.RefreshOrdersButton.UseVisualStyleBackColor = False
        '
        'OrderTypeGroup
        '
        Me.OrderTypeGroup.Controls.Add(Me.Label27)
        Me.OrderTypeGroup.Controls.Add(Me.Label25)
        Me.OrderTypeGroup.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.OrderTypeGroup.ForeColor = System.Drawing.Color.White
        Me.OrderTypeGroup.Location = New System.Drawing.Point(427, 164)
        Me.OrderTypeGroup.Name = "OrderTypeGroup"
        Me.OrderTypeGroup.Size = New System.Drawing.Size(184, 155)
        Me.OrderTypeGroup.TabIndex = 12
        Me.OrderTypeGroup.TabStop = False
        Me.OrderTypeGroup.Text = "Order Type and Sandwich Quantity"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(6, 83)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(16, 23)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "-"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(6, 51)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(16, 23)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "-"
        '
        'TotalPrice
        '
        Me.TotalPrice.Controls.Add(Me.Label24)
        Me.TotalPrice.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPrice.ForeColor = System.Drawing.Color.White
        Me.TotalPrice.Location = New System.Drawing.Point(617, 164)
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Size = New System.Drawing.Size(184, 155)
        Me.TotalPrice.TabIndex = 9
        Me.TotalPrice.TabStop = False
        Me.TotalPrice.Text = "Total Price"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(6, 29)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(16, 23)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "-"
        '
        'OrderFulfilmentGroup
        '
        Me.OrderFulfilmentGroup.Controls.Add(Me.Label26)
        Me.OrderFulfilmentGroup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderFulfilmentGroup.ForeColor = System.Drawing.Color.White
        Me.OrderFulfilmentGroup.Location = New System.Drawing.Point(807, 164)
        Me.OrderFulfilmentGroup.Name = "OrderFulfilmentGroup"
        Me.OrderFulfilmentGroup.Size = New System.Drawing.Size(184, 155)
        Me.OrderFulfilmentGroup.TabIndex = 13
        Me.OrderFulfilmentGroup.TabStop = False
        Me.OrderFulfilmentGroup.Text = "Order Fulfilment"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(6, 29)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(16, 23)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "-"
        '
        'CancelOrderButton
        '
        Me.CancelOrderButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CancelOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelOrderButton.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelOrderButton.ForeColor = System.Drawing.Color.White
        Me.CancelOrderButton.Location = New System.Drawing.Point(997, 164)
        Me.CancelOrderButton.Name = "CancelOrderButton"
        Me.CancelOrderButton.Size = New System.Drawing.Size(374, 155)
        Me.CancelOrderButton.TabIndex = 14
        Me.CancelOrderButton.Text = "Cancel Order"
        Me.CancelOrderButton.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1377, 164)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(38, 155)
        Me.Button4.TabIndex = 19
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(3, 325)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(38, 155)
        Me.Button5.TabIndex = 20
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PlaceholderButton
        '
        Me.PlaceholderButton.BackColor = System.Drawing.Color.Transparent
        Me.PlaceholderButton.FlatAppearance.BorderSize = 0
        Me.PlaceholderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.PlaceholderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.PlaceholderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlaceholderButton.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceholderButton.ForeColor = System.Drawing.Color.White
        Me.PlaceholderButton.Location = New System.Drawing.Point(47, 325)
        Me.PlaceholderButton.Name = "PlaceholderButton"
        Me.PlaceholderButton.Size = New System.Drawing.Size(465, 155)
        Me.PlaceholderButton.TabIndex = 15
        Me.PlaceholderButton.UseVisualStyleBackColor = False
        '
        'OrderCompleteButton
        '
        Me.OrderCompleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OrderCompleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OrderCompleteButton.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderCompleteButton.ForeColor = System.Drawing.Color.White
        Me.OrderCompleteButton.Location = New System.Drawing.Point(518, 325)
        Me.OrderCompleteButton.Name = "OrderCompleteButton"
        Me.OrderCompleteButton.Size = New System.Drawing.Size(374, 155)
        Me.OrderCompleteButton.TabIndex = 11
        Me.OrderCompleteButton.Text = "Order Complete"
        Me.OrderCompleteButton.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.27503!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.724965!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button6, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1418, 94)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(1353, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 50)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "X"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'StaffpendingBindingSource
        '
        Me.StaffpendingBindingSource.DataMember = "staff_pending"
        Me.StaffpendingBindingSource.DataSource = Me.TSWDataSet
        '
        'TSWDataSet
        '
        Me.TSWDataSet.DataSetName = "TSWDataSet"
        Me.TSWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Staff_pendingTableAdapter
        '
        Me.Staff_pendingTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.DateTimePicker1.Location = New System.Drawing.Point(22, 37)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(143, 24)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Staff_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.The_Sandwich_Wizard.My.Resources.Resources.staff1
        Me.ClientSize = New System.Drawing.Size(1424, 861)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Staff_home"
        Me.Text = "Staff_home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.BreadGroup.ResumeLayout(False)
        Me.BreadGroup.PerformLayout()
        Me.SauceGroup.ResumeLayout(False)
        Me.SauceGroup.PerformLayout()
        Me.CheeseGroup.ResumeLayout(False)
        Me.CheeseGroup.PerformLayout()
        Me.FillingsGroup.ResumeLayout(False)
        Me.FillingsGroup.PerformLayout()
        Me.ToppingsGroup.ResumeLayout(False)
        Me.ToppingsGroup.PerformLayout()
        Me.SideOrdersGroup.ResumeLayout(False)
        Me.SideOrdersGroup.PerformLayout()
        Me.OrderTypeGroup.ResumeLayout(False)
        Me.OrderTypeGroup.PerformLayout()
        Me.TotalPrice.ResumeLayout(False)
        Me.TotalPrice.PerformLayout()
        Me.OrderFulfilmentGroup.ResumeLayout(False)
        Me.OrderFulfilmentGroup.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.StaffpendingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSWDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TSWDataSet As TSWDataSet
    Friend WithEvents StaffpendingBindingSource As BindingSource
    Friend WithEvents Staff_pendingTableAdapter As TSWDataSetTableAdapters.staff_pendingTableAdapter
    Friend WithEvents BreadGroup As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SauceGroup As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheeseGroup As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents FillingsGroup As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ToppingsGroup As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents SideOrdersGroup As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TotalPrice As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents RefreshOrdersButton As Button
    Friend WithEvents OrderCompleteButton As Button
    Friend WithEvents OrderTypeGroup As GroupBox
    Friend WithEvents Label25 As Label
    Friend WithEvents OrderFulfilmentGroup As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents CancelOrderButton As Button
    Friend WithEvents PlaceholderButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button6 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
