Imports System.Data.OleDb

Public Class login
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\aman\Documents\Autodb2.mdb")
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adminpass As String


    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Incorrect Username or Password", vbCritical, "Invalid")
            TextBox1.Focus()
        Else
            con.Open()
            cmd = New OleDbCommand("select Password from Login where Ename='" & TextBox1.Text & "'", con)


            dr = cmd.ExecuteReader()

            If dr.Read Then
                adminpass = dr("Password")
            End If



            If TextBox2.Text = adminpass Then
                MsgBox("Login Success", vbOKOnly, "Success")
                splash.Show()
                Me.Hide()


            Else
                MsgBox("Incorrect Username or Password", vbCritical, "Invalid")
            End If

            con.Close()
        End If

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

