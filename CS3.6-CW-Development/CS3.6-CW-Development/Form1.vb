Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim testSet As String() = {"00:00", "99:99", "19:00", "23:59", "12", "12:3123123", "James", "Ja:Me"}
        For Each strs In testSet
            MsgBox(strs & validation.CorrectTimeFormat(strs))
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_login_screen.Show()
        Me.Hide()
    End Sub
End Class
