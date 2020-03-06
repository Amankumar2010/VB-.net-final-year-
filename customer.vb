Imports System.Data.OleDb
Public Class customer
    Dim ocon As OleDbConnection
    Dim ocmd As OleDbCommand
    Dim query As String
    Dim adpt As OleDbDataAdapter
    Dim ds As New DataSet
    Dim g, yn, n As String
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\aman\Documents\Autodb2.mdb")
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mainmenu.Show()
        Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton1.Checked = True) Then
            g = RadioButton1.Text
        Else
            If (RadioButton2.Checked = True) Then
                g = RadioButton2.Text
            End If
        End If

        If (RadioButton5.Checked = True) Then
            n = RadioButton5.Text
        Else
            If (RadioButton6.Checked = True) Then
                n = RadioButton6.Text
            Else
                If (RadioButton7.Checked = True) Then
                    n = RadioButton7.Text
                End If
            End If
        End If

        MsgBox("Connection establish")
        ocon.Open()
        ocmd = New OleDbCommand("insert into Customer values(" & TextBox1.Text & ",' " & TextBox2.Text & " ', " & TextBox3.Text & ", " & TextBox4.Text & " ,' " & TextBox5.Text & " ',' " & TextBox6.Text & " ',' " & TextBox7.Text & " ',' " & ComboBox3.Text & " ', " & TextBox9.Text & " ,' " & g & " ' ,' " & TextBox10.Text & " ' ,' " & ComboBox1.Text & " ',' " & TextBox11.Text & " ', ' " & n & " ' ,' " & ComboBox2.Text & " ')", ocon)
        ocmd.ExecuteNonQuery()
        ocon.Close()
        MsgBox("Record inserted sucessfully:")

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        ComboBox3.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        ComboBox1.Text = ""
        TextBox11.Text = ""
        ComboBox2.Text = ""


    End Sub



End Class
