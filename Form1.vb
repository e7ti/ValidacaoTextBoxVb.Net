Public Class Form1
    Private Sub TextBoxValidate1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxValidate1.KeyPress
        If AscW(e.KeyChar) = 13 Then
            TextBoxValidate2.Focus()
        End If
    End Sub

    Private Sub TextBoxValidate2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxValidate2.KeyPress
        If AscW(e.KeyChar) = 13 Then
            TextBoxValidate3.Focus()
        End If

    End Sub

    Private Sub TextBoxValidate3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxValidate3.KeyPress
        If AscW(e.KeyChar) = 13 Then
            TextBoxValidate4.Focus()
        End If

    End Sub
End Class
