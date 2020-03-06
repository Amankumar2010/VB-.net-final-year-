Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class InquiryForm_3_
    Dim ocon As OleDbConnection
    Dim ocmd As OleDbCommand
    Dim query As String
    Dim adpt As OleDbDataAdapter
    Dim ds As New DataSet



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub InquiryForm_3__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\aman\Documents\Autodb2.mdb")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mainmenu.Show()
        Hide()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles Text2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If (Text1.Text = "" And Text2.Text = "" And Text3.Text = "" And Text4.Text = "" And ComboBox1.Text = "" And Text6.Text = "" And ComboBox2.Text = "" And Text8.Text = "" And Text9.Text = "" And Text10.Text = "" And Text11.Text = "") Then
            MsgBox("Insert details")
        End If

        If (Text11.TextLength < 6) Then
            MsgBox("check pincode")
        End If

        If (Text9.TextLength < 10) Then
            MsgBox("check PH NO")
        End If


        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
            Dim isValid As Boolean = regex.IsMatch(Text8.Text.Trim)
        If Not isValid Then

            MessageBox.Show("Invalid Email.")

        Else

            ocon.Open()

            ocmd = New OleDbCommand("insert into Inquiry values(" & Text1.Text & ",' " & Text2.Text & " ',' " & Text3.Text & " ',' " & Text4.Text & " ',' " & ComboBox1.Text & " ',' " & Text6.Text & " ',' " & ComboBox2.Text & " ',' " & Text8.Text & " '," & Text9.Text & "," & Text10.Text & " ," & Text11.Text & ")", ocon)
            ocmd.ExecuteNonQuery()
            ocon.Close()
            MsgBox("Record inserted sucessfully:")

        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        ocon.Open()

        adpt = New OleDbDataAdapter("select * from Inquiry where ino =" & Text1.Text & " ", ocon)

        adpt.Fill(ds, "inq")
        Text1.DataBindings.Add("text", ds, "inq.ino")
        Text2.DataBindings.Add("text", ds, "inq.iname")
        Text3.DataBindings.Add("text", ds, "inq.dob")
        Text4.DataBindings.Add("text", ds, "inq.address")
        ComboBox1.DataBindings.Add("text", ds, "inq.state")
        Text6.DataBindings.Add("text", ds, "inq.city")
        ComboBox2.DataBindings.Add("text", ds, "inq.crname")
        Text8.DataBindings.Add("text", ds, "inq.email")
        Text9.DataBindings.Add("text", ds, "inq.phono")
        Text10.DataBindings.Add("text", ds, "inq.age")
        Text11.DataBindings.Add("text", ds, "inq.pincode")

        ocon.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Text1.Text = ""
        Text2.Text = ""
        Text3.Text = ""
        Text4.Text = ""
        ComboBox1.Text = ""
        Text6.Text = ""
        ComboBox2.Text = ""
        Text8.Text = ""
        Text9.Text = ""
        Text10.Text = ""
        Text11.Text = ""
    End Sub

    Private Sub Text1_TextChanged(sender As Object, e As EventArgs) Handles Text1.TextChanged

    End Sub

    Private Sub Text1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text1.KeyPress
        Call val_number(e)
    End Sub



    Private Sub Text9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text9.KeyPress
        Call val_number(e)
    End Sub

    Private Sub Text10_TextChanged(sender As Object, e As EventArgs) Handles Text10.TextChanged

    End Sub

    Private Sub Text10_KeyDown(sender As Object, e As KeyEventArgs) Handles Text10.KeyDown

    End Sub

    Private Sub Text10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text10.KeyPress
        Call val_number(e)
    End Sub


End Class