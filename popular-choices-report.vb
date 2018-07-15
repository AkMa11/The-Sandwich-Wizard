Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class popular_choices_report
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub popular_choices_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cr As New ReportDocument()
        cr.Load("E:\The Sandwich Wizard\The Sandwich Wizard\PopularChoices.rpt")
        CrystalReportViewer1.ReportSource = cr
        CrystalReportViewer1.Refresh()
    End Sub
End Class