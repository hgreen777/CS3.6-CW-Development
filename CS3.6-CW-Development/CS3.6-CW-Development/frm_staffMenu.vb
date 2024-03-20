Public Class frm_staffMenu
    '
    ' Form Open and close events
    '
    Private Sub frm_staffMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Formatting Buttons
        ' Loop through all buttons on the form and set the colour and round the edges.
        For Each btn As Button In Me.Controls.OfType(Of Button)
            standardProcedures.RoundButton(btn)
        Next

    End Sub
    ' Set the title to be the staff member's first name. 
    Private Sub frm_staffMenu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            ' Edit title to show user's first name.
            lbl_menu_TITLE.Text = DataStructures.StaffHashTable.firstFromUserName(activeUser) & "'s Menu (Manager)"
        End If
    End Sub
    '
    ' Redirect Code
    '
    ' Logout Button
    Private Sub btn_logout_redir_Click(sender As Object, e As EventArgs) Handles btn_logout_redir.Click
        ' Logout of account ie set active user to nothing
        activeUser = Nothing
        ' Show login form and hide current form
        frm_login_screen.Show()
        Me.Hide()
    End Sub

    ' Profile Button
    Private Sub btn_profile_redir_Click(sender As Object, e As EventArgs) Handles btn_profile_redir.Click
        'Show profile form and hide current form
        frm_accountEditor.Show()
        Me.Hide()
    End Sub
    ' Notifications Button
    Private Sub btn_notifications_redir_Click(sender As Object, e As EventArgs) Handles btn_notifications_redir.Click
        ' Show notifications form and hide current form
        frm_notifications.Show()
        Me.Hide()
    End Sub
    ' Take Shifts Button
    Private Sub btn_takeShifts_redir_Click(sender As Object, e As EventArgs) Handles btn_takeShifts_redir.Click
        ' Show take shifts form and hide current form
        frm_takeShifts.Show()
        Me.Hide()
    End Sub
    ' My Shifts Button
    Private Sub btn_myShifts_redir_Click(sender As Object, e As EventArgs) Handles btn_myShifts_redir.Click
        ' Show my shifts form and hide current form
        frm_myShifts.Show()
        Me.Hide()
    End Sub
End Class