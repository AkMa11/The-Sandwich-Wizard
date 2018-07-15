Imports System.Data.SqlClient
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine

Public Class Staff_home
    Dim da As New SqlDataAdapter
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim ds As New DataSet
    Dim dv As New DataView
    Dim i, sql As Integer
    Dim days As String
    Dim months As String
    Dim years As String
    Private Sub fill()
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"
        Dim r As SqlDataReader
        con.Open()
        cmd = New SqlCommand("select * from staff_pending where Order_No='" & ComboBox1.Text & "'", con)

        Try

            r = cmd.ExecuteReader()
            Do While r.Read()
                Label2.Text = r(1)
                Label3.Text = r(2)
                Label4.Text = r(3)
                Label5.Text = r(4)
                Label6.Text = r(5)
                Label7.Text = r(6)
                Label8.Text = r(7)
                Label9.Text = r(8)
                Label10.Text = r(9)
                Label11.Text = r(10)
                Label12.Text = r(11)
                Label13.Text = r(12)
                Label14.Text = r(13)
                Label15.Text = r(14)
                Label16.Text = r(15)
                Label17.Text = r(16)
                Label18.Text = r(17)
                Label19.Text = r(18)
                Label20.Text = r(19)
                Label21.Text = r(20)
                Label22.Text = r(21)
                Label23.Text = r(22)
                Label24.Text = r(23)
                Label25.Text = r(27)
                Label26.Text = r(28)
                Label27.Text = r(29)
            Loop
            r.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    Private Sub combo()
        days = DateTimePicker1.Value.Day
        months = DateTimePicker1.Value.Month
        years = DateTimePicker1.Value.Year
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"
        Dim r As SqlDataReader
        cmd.CommandText = "select Order_No from staff_pending where DAY(Order_DateTime)='" & days & "' AND MONTH(Order_DateTime)='" & months & "' AND YEAR(Order_DateTime)='"& years &"';"
        cmd.Connection = con
        con.Open()
        Try
            r = cmd.ExecuteReader
            Do While r.Read()
                ComboBox1.Items.Add(r(0))
            Loop
            r.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub Staff_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TSWDataSet.staff_pending' table. You can move, or remove it, as needed.
        Me.Staff_pendingTableAdapter.Fill(Me.TSWDataSet.staff_pending)
        combo()
    End Sub

    Public od As String

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        fill()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RefreshOrdersButton.Click
        ComboBox1.Items.Clear()

        combo()
        fill()
    End Sub

    Private Sub OrderCompleteButton_Click(sender As Object, e As EventArgs) Handles OrderCompleteButton.Click
        Try
            Dim con As New SqlConnection
            con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"
            con.Open()
            Dim cmd As New SqlCommand(("update staff_pending set Order_Fulfilment='Fulfilled' where Order_No ='" &
            ComboBox1.Text & "'"), con)
            cmd.ExecuteNonQuery()

            Dim cmd2 As New SqlCommand
            With cmd2
                .Connection = con
                .CommandText = "select Order_No, Sandwich_Cost, Side_Orders_Cost, Order_DateTime, Total_price from staff_pending where Order_No= '" & ComboBox1.Text & "'"
            End With
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cmd2)
            da.Fill(ds, "staff_pending")
            Dim crs As New ReportDocument
            crs.Load("E:\The Sandwich Wizard\The Sandwich Wizard\customer_Bill_Orderwise.rpt")
            crs.RecordSelectionFormula = "{staff_pending.Order_No} = " & ComboBox1.Text
            crs.SetDataSource(ds.Tables("staff_pending"))
            Customer_Bill_Report.CrystalReportViewer1.ReportSource = crs
            Customer_Bill_Report.CrystalReportViewer1.Refresh()
            Customer_Bill_Report.ShowDialog()
        Catch ex As Exception
            'MsgBox("Error" & ex.Message, "Update Record")
        End Try

        con.Close()
        fill()
    End Sub

    Private Sub CancelOrderButton_Click(sender As Object, e As EventArgs) Handles CancelOrderButton.Click
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-RDBH5MV\SQLEXPRESS;Initial Catalog=TSW;Integrated Security=True"
        con.Open()
        Dim cmd As New SqlCommand(("update staff_pending set Order_Fulfilment='Cancelled' where Order_No ='" &
        ComboBox1.Text & "'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        fill()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Login.Close()
        Customer_Bill_Report.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ComboBox1.Items.Clear()
        combo()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class