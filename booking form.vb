Imports System.Data.OleDb
Public Class Form1
    Dim ocon As OleDbConnection
    Dim ocmd As OleDbCommand
    Dim query As String
    Dim adpt As OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles Text11.TextChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles Text8.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Connection establish")
        ocon.Open()
        ocmd = New OleDbCommand("insert into Booking values(" & Text1.Text & ",' " & Text2.Text & " ',' " & ComboBox3.Text & " ',' " & Text4.Text & " ',' " & Text5.Text & " ',' " & Text6.Text & " '," & Text7.Text & "," & Text8.Text & "," & Text9.Text & " ," & Text10.Text & ",' " & Text11.Text & " '," & Text12.Text & "," & Text13.Text & "," & Text14.Text & " )", ocon)
        ocmd.ExecuteNonQuery()
        ocon.Close()
        MsgBox("Record inserted sucessfully:")

        Text1.Text = ""
        Text2.Text = ""
        ComboBox3.Text = ""
        Text4.Text = ""
        Text5.Text = ""
        Text6.Text = ""
        Text7.Text = ""
        Text8.Text = ""
        Text9.Text = ""
        Text10.Text = ""
        Text11.Text = ""
        Text12.Text = ""
        Text13.Text = ""
        Text14.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\aman\Documents\Autodb2.mdb")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Hide()
        mainmenu.Show()
    End Sub
End Class