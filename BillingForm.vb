Imports System.Data.OleDb


Public Class BillingForm_4_
        Dim ocon As OleDbConnection
        Dim ocmd As OleDbCommand
        Dim query As String
        Dim adpt As OleDbDataAdapter
        Dim ds As New DataSet



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        MsgBox("Connection establish")
            ocon.Open()
        ocmd = New OleDbCommand("insert into Billing values(" & Text1.Text & ",' " & Text2.Text & " ',' " & Text3.Text & " ',' " & ComboBox1.Text & " ',' " & Text4.Text & " ',' " & Text5.Text & " ',' " & Text6.Text & " ','" & Text7.Text & "'," & Text8.Text & ",' " & Text9.Text & " '," & Text10.Text & "," & Text11.Text & ")", ocon)
        ocmd.ExecuteNonQuery()
            ocon.Close()
            MsgBox("Record inserted sucessfully:")

            Text1.Text = ""
            Text2.Text = ""
            Text3.Text = ""
            ComboBox1.Text = ""
            Text4.Text = ""
            Text5.Text = ""
            Text6.Text = ""
            Text7.Text = ""
            Text8.Text = ""
            Text9.Text = ""
            Text10.Text = ""
            Text11.Text = ""



        End Sub

    Private Sub BillingForm_4__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\aman\Documents\Autodb2.mdb")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ocon.Open()

        adpt = New OleDbDataAdapter("select * from Billing where cno=" & Text1.Text & " ", ocon)

        adpt.Fill(ds, "bill")
        Text1.DataBindings.Add("text", ds, "bill.cno")
        Text2.DataBindings.Add("text", ds, "bill.cname")
        Text3.DataBindings.Add("text", ds, "bill.address")
        ComboBox1.DataBindings.Add("text", ds, "bill.model")
        Text4.DataBindings.Add("text", ds, "bill.datbill")
        Text5.DataBindings.Add("text", ds, "bill.datdil")
        Text6.DataBindings.Add("text", ds, "bill.dname")
        Text7.DataBindings.Add("text", ds, "bill.pid")
        Text8.DataBindings.Add("text", ds, "bill.picod")
        Text9.DataBindings.Add("text", ds, "bill.color")
        Text10.DataBindings.Add("text", ds, "bill.amt")
        Text11.DataBindings.Add("text", ds, "bill.gamt")

        ocon.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Text1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text1.KeyPress
        val_number(e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Hide()
        mainmenu.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class