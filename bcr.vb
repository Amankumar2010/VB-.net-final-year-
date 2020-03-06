Public Class bcr
    Private Sub bcr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Autodb2DataSet2.Booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.Autodb2DataSet2.Booking)
        Dim rpt As New CrystalReport4

        rpt.SetDataSource(Autodb2DataSet2.Tables("Booking"))
        CrystalReportViewer1.ReportSource = rpt

    End Sub

End Class