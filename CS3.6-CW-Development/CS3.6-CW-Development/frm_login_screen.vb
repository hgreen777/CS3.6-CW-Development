Public Class frm_login_screen
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login_redir.Click
        'TODO: ACC Implement
        frm_staffMenu.Show()
        Me.Hide()
    End Sub

    Private Sub frm_login_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Formatting Buttons
        ' Loop through all buttons on the form and set the colour and round the edges.
        For Each btn As Button In Me.Controls.OfType(Of Button)
            standardProcedures.RoundButton(btn)
        Next
    End Sub
End Class