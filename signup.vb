Imports System.Data.OleDb

Public Class signup

    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\aman\Documents\Autodb2.mdb")
    Dim cmd As New OleDbCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mainmenu.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        cmd = New OleDbCommand("insert into login values('" & TextBox2.Text & "', " & TextBox3.Text & " )", con)
        cmd.ExecuteNonQuery()

        MsgBox("Record inserted sucessfully:")
        con.Close()


    End Sub
End Class