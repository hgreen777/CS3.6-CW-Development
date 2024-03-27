Imports System.Data.Common

Public Class frm_login_screen
    '
    ' Form Open & Close Events
    '
    Private Sub frm_login_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Formatting Buttons
        ' Loop through all buttons on the form and set the colour and round the edges.
        For Each btn As Button In Me.Controls.OfType(Of Button)
            standardProcedures.RoundButton(btn)
        Next
        '
        ' Read all data from persistent data files and store in data sxtructures (memory)
        '
        If FileHandler.readAllData() = False Then MsgBox("Fatal Error Reading Data: Exiting System.") : End
    End Sub
    ' Make sure textboxes are cleared on show to prevent an old user's details being shown when a new user goes to log in.
    Private Sub frm_login_screen_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            ' Clear all text boxes
            txt_username_inp.Text = ""
            txt_password_inp.Text = ""
            'Set focus to the username input box
            txt_username_inp.Focus()
        End If
    End Sub
    '
    ' Redirect/Process Code
    '
    ' Login Button
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login_redir.Click
        ' Validate input is present
        If Validation.PresenceValidation(txt_username_inp.Text) = False Then MsgBox("Please enter a username") : Exit Sub
        If Validation.PresenceValidation(txt_password_inp.Text) = False Then MsgBox("Please enter a password") : Exit Sub
        ' Validate username is in the correct format.
        If Validation.isUsernameFormat(txt_username_inp.Text) = False Then MsgBox("Username must be in the format FirstLastID") : Exit Sub

        ' Check if the staff member exists
        Dim tmpStaff As StaffMember = DataStructures.StaffHashTable.findStaffMember(txt_username_inp.Text, True)
        ' Check if the staff member function returns a node 
        If tmpStaff.userName = Nothing Then Exit Sub ' Function includes error message

        ' Check if the password is correct then open the correct menu.
        If tmpStaff.password = txt_password_inp.Text Then
            ' Set the active user to the staff member.
            activeUser = tmpStaff.userName
            ' Check user account type.
            If tmpStaff.isManager Then
                ' Open the manager menu.
                frm_managerMenu.Show()
            Else
                ' Open the staff menu.
                frm_staffMenu.Show()
            End If
            Me.Hide()
        Else
            ' Error message for incorrect password.
            MsgBox("Incorrect Password")
        End If
    End Sub
End Class