Public Class billcr


    Private Sub billcr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Autodb2DataSet1.Billing' table. You can move, or remove it, as needed.
        Me.BillingTableAdapter.Fill(Me.Autodb2DataSet1.Billing)

        Dim rpt As New CrystalReport3

        rpt.SetDataSource(Autodb2DataSet1.Tables("Billing"))
        CrystalReportViewer1.ReportSource = rpt

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class