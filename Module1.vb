Module Module1
    Public Sub val_text(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
                MessageBox.Show("you can enter only letter")
            End If
        End If

    End Sub


    Public Sub val_number(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MessageBox.Show("you can enter only number")
            End If
        End If
    End Sub


    Public Sub dont_write(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MessageBox.Show("dont write its view section")
        End If
    End Sub
End Module
