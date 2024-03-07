Public Class frm_managerMenu
    Private Sub frm_managerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Formatting Buttons
        ' Loop through all buttons on the form and set the colour and round the edges.
        For Each btn As Button In Me.Controls.OfType(Of Button)
            standardProcedures.RoundButton(btn)
        Next

    End Sub

    Private Sub btn_profile_redir_Click(sender As Object, e As EventArgs) Handles btn_profile_redir.Click
        frm_accountEditor.Show()
        Me.Hide()
    End Sub

    Private Sub btn_editAcc_redir_Click(sender As Object, e As EventArgs) Handles btn_editAcc_redir.Click
        frm_accountManager.Show()
        Me.Hide()
    End Sub

    Private Sub btn_myShifts_redir_Click(sender As Object, e As EventArgs) Handles btn_myShifts_redir.Click
        frm_myShifts.Show()
        Me.Hide()
    End Sub

    Private Sub btn_allShifts_redir_Click(sender As Object, e As EventArgs) Handles btn_allShifts_redir.Click
        frm_allShifts.Show()
        Me.Hide()
    End Sub

    Private Sub btn_takeShifts_redir_Click(sender As Object, e As EventArgs) Handles btn_takeShifts_redir.Click
        frm_takeShifts.Show()
        Me.Hide()
    End Sub
End Class