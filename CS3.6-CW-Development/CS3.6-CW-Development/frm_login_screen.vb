Imports System.Data.Common

Public Class frm_login_screen
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
        ' Read all staff members from the staff file and store in the staff hash table. Exit system if error occurs.
        If FileHandler.staffRead() = False Then MsgBox("Fatal Error Reading Staff Data: Exiting System.") : End
        ' Read all shift data from the shift file and store in the shift linked list. Exit system if error occurs.
        If FileHandler.shiftRead() = False Then MsgBox("Fatal Error Reading Shift Data: Exiting System.") : End
        ' Read all notification data from the notification file and store in the notification binary tree. Exit system if error occurs.
        'If FileHandler.notificationRead() = False Then MsgBox("Fatal Error Reading Notification Data: Exiting System.") : End
        ' Read all the notification instance data from the notification file and store in the notification linked list. Exit system is error occurs.
        'If FileHandler.notificationInstanceRead() = False Then MsgBox("Fatal Error Reading Notification Instance Data: Exiting System.") : End

    End Sub
End Class