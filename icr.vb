Public Class icr
    Private Sub icr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Autodb2DataSet.Inquiry' table. You can move, or remove it, as needed.
        Me.InquiryTableAdapter.Fill(Me.Autodb2DataSet.Inquiry)

        Dim rpt As New CrystalReport2

        rpt.SetDataSource(Autodb2DataSet.Tables("Inquiry"))
        CrystalReportViewer1.ReportSource = rpt

    End Sub


End Class