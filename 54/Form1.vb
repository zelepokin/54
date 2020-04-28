Public Class Form1


    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Dim i, n As Integer
        n = InputBox("N =")
        T1.Text = Nothing
        T2.Text = Nothing
        For i = 1 To n
            T1.Text = T1.Text + CStr(i) + vbNewLine
        Next
        For i = n To 1 Step -1
            T2.Text = T2.Text + CStr(i) + vbNewLine
        Next
    End Sub
End Class
