Imports System.Text.RegularExpressions

Public Class frm_accountManager
    Dim oldUsername As String
    '
    ' Form Open & close Events
    '
    Private Sub frm_accountManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Formatting Buttons
        ' Loop through all buttons on the form and set the colour and round the edges.
        For Each btn As Button In Me.Controls.OfType(Of Button)
            standardProcedures.RoundButton(btn)
        Next
    End Sub
    Private Sub frm_accountManager_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            ' Reset all labels and text boxes
            lbl_username_dynamic.Text = "<StaffUserName>"
            txt_firstName_search.Text = ""
            txt_firstName_inp.Text = ""
            txt_surname_inp.Text = ""
            txt_password_inp.Text = ""
            chBox_isManager.Checked = False
            chBox_isfullTimeStaff.Checked = False
        End If
    End Sub
    '
    ' Redirect Code
    '
    Private Sub btn_back_redir_Click(sender As Object, e As EventArgs) Handles btn_back_redir.Click
        frm_managerMenu.Show()
        Me.Hide()
    End Sub
    '
    ' Processes code ie buttons for processing data
    '
    Private Sub chkBox_showPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox_showPassword.CheckedChanged
        ' If the checkbox is checked then show the password
        If chkBox_showPassword.Checked = True Then
            txt_password_inp.PasswordChar = ""      ' Set the password character to nothing (so password is shown truly)
        Else
            txt_password_inp.PasswordChar = "*"     ' Set the password character to * (so password is hidden)
        End If
    End Sub

    Private Sub btn_saveDetails_process_Click(sender As Object, e As EventArgs) Handles btn_saveDetails_process.Click
        ' Make sure the user is editing an account and not trying to make a new one or no user is selected.
        If lbl_username_dynamic.Text = "<StaffUserName>" Or lbl_username_dynamic.Text = "NEW" Then
            MsgBox("Cannot edit a user's details if their account has not been created or searched for. Try create account for a new account or try searching for a user if you wish to edit an account.")
            Exit Sub
        End If

        ' Check if the first name is valid
        If Validation.PresenceValidation(txt_firstName_inp.Text) = False Then MsgBox("First Name is empty, please enter a valid first name.") : Return
        ' Check if the last name is valid
        If Validation.PresenceValidation(txt_surname_inp.Text) = False Then MsgBox("Surname is empty, please enter a valid surname.") : Return
        ' Check if the password is valid
        If Validation.PresenceValidation(txt_password_inp.Text) = False Then MsgBox("Password is empty, please enter a valid password.") : Return

        ' Standardised Results so hash table does not break.
        txt_firstName_inp.Text = Validation.FormatName(txt_firstName_inp.Text)
        txt_surname_inp.Text = Validation.FormatName(txt_surname_inp.Text)

        ' Update User Details
        Dim tmpStaff As StaffMember ' Store the user's details in a temporary staff member to overwrite the old data.
        ' Set the staffID to the current user's staffID
        tmpStaff.staffID = DataStructures.StaffHashTable.findStaffMember(oldUsername, True).staffID
        tmpStaff.firstName = txt_firstName_inp.Text
        tmpStaff.lastName = txt_surname_inp.Text
        tmpStaff.password = txt_password_inp.Text
        tmpStaff.userName = lbl_username_dynamic.Text
        tmpStaff.isManager = chBox_isManager.Checked
        tmpStaff.isFullTime = chBox_isfullTimeStaff.Checked

        'Update the user's details in the hash table
        If DataStructures.StaffHashTable.updateStaffMember(oldUsername, tmpStaff) Then
            MsgBox("User details updated successfully.")
            MsgBox("New Username: " & tmpStaff.userName)

            ' Reset all labels and text boxes
            lbl_username_dynamic.Text = "<StaffUserName>"
            txt_firstName_inp.Text = ""
            txt_surname_inp.Text = ""
            txt_password_inp.Text = ""
            chBox_isManager.Checked = False
            chBox_isfullTimeStaff.Checked = False
        Else
            MsgBox("Error updating user details.")
        End If

    End Sub

    Private Sub txt_firstName_inp_TextChanged(sender As Object, e As EventArgs) Handles txt_firstName_inp.TextChanged
        ' Ensure that the username should be changed or not
        If lbl_username_dynamic.Text = "NEW" Or lbl_username_dynamic.Text = "<StaffUserName>" Then Exit Sub

        'Change the username label to change for the new updates. 
        ' Find the numbers in the username ie the staffId and then change the string before that
        Dim currentUserName As String = lbl_username_dynamic.Text                               ' Get the current username
        Dim staffID As String = Regex.Match(currentUserName, "\d+").Value                       ' Find the staffID in the username
        lbl_username_dynamic.Text = txt_firstName_inp.Text & txt_surname_inp.Text & staffID     ' Set the new username
    End Sub

    Private Sub txt_surname_inp_TextChanged(sender As Object, e As EventArgs) Handles txt_surname_inp.TextChanged
        ' Ensure that the username should be changed or not
        If lbl_username_dynamic.Text = "NEW" Or lbl_username_dynamic.Text = "<StaffUserName>" Then Exit Sub

        'Change the username label to change for the new updates. 
        ' Find the numbers in the username ie the staffId and then change the string before that
        Dim currentUserName As String = lbl_username_dynamic.Text                               ' Get the current username
        Dim staffID As String = Regex.Match(currentUserName, "\d+").Value                       ' Find the staffID in the username
        lbl_username_dynamic.Text = txt_firstName_inp.Text & txt_surname_inp.Text & staffID     ' Set the new username
    End Sub

    Private Sub btn_searchStaff_process_Click(sender As Object, e As EventArgs) Handles btn_searchStaff_process.Click
        ' Validate Input 
        If Validation.PresenceValidation(txt_firstName_search.Text) = False Then MsgBox("Must enter a name to search or NEW") : Exit Sub

        ' If New update displayed data
        If txt_firstName_search.Text = "NEW" Then
            lbl_username_dynamic.Text = "NEW"
            txt_firstName_search.Text = ""
            txt_surname_inp.Text = ""
            txt_password_inp.Text = ""
            chBox_isManager.Checked = False
            chBox_isfullTimeStaff.Checked = False
            Return
        End If

        Dim searchData As String        ' Store the data to search for either a username or firstname
        Dim tmpStaff As StaffMember     ' Store the staff member that is found
        ' Check if the input is a username or a name
        Dim isUserName As Boolean = Validation.isUsernameFormat(txt_firstName_search.Text)

        ' Checks if input is a username or a name
        If isUserName Then
            searchData = txt_firstName_search.Text
        Else
            ' Formatting input if it is not a username and is a name.
            searchData = Validation.FormatName(txt_firstName_search.Text)
        End If

        ' Find User
        tmpStaff = DataStructures.StaffHashTable.findStaffMember(searchData, isUserName)

        'Check if a user has been found before updating info.
        If tmpStaff.userName IsNot Nothing Then
            ' Update Displayed Data
            lbl_username_dynamic.Text = tmpStaff.userName
            txt_firstName_inp.Text = tmpStaff.firstName
            txt_surname_inp.Text = tmpStaff.lastName
            txt_password_inp.Text = tmpStaff.password
            chBox_isManager.Checked = tmpStaff.isManager
            chBox_isfullTimeStaff.Checked = tmpStaff.isFullTime
            oldUsername = tmpStaff.userName

            txt_firstName_search.Text = ""
        Else
            ' Reset all labels and text boxes
            lbl_username_dynamic.Text = "<StaffUserName>"
            txt_firstName_inp.Text = ""
            txt_surname_inp.Text = ""
            txt_password_inp.Text = ""
            chBox_isManager.Checked = False
            chBox_isfullTimeStaff.Checked = False
        End If

    End Sub

    Private Sub btn_createAccount_process_Click(sender As Object, e As EventArgs) Handles btn_createAccount_process.Click
        'Check if the username is set to new
        If lbl_username_dynamic.Text = "NEW" Then
            ' Presence Check all Input
            If Validation.PresenceValidation(txt_firstName_inp.Text) = False Then MsgBox("First Name is empty, please enter a valid first name.") : Return
            If Validation.PresenceValidation(txt_surname_inp.Text) = False Then MsgBox("Surname is empty, please enter a valid surname.") : Return
            If Validation.PresenceValidation(txt_password_inp.Text) = False Then MsgBox("Password is empty, please enter a valid password.") : Return

            ' Standardised Results so hash table does not break.
            txt_firstName_inp.Text = Validation.FormatName(txt_firstName_inp.Text)
            txt_surname_inp.Text = Validation.FormatName(txt_surname_inp.Text)

            ' Create a new staff member to store the data from the file
            Dim tmpStaff As StaffMember
            tmpStaff.staffID = DataStructures.StaffHashTable.findUniqueID()
            tmpStaff.firstName = txt_firstName_inp.Text
            tmpStaff.lastName = txt_surname_inp.Text
            tmpStaff.password = txt_password_inp.Text
            tmpStaff.userName = txt_firstName_inp.Text & txt_surname_inp.Text & tmpStaff.staffID
            tmpStaff.isManager = chBox_isManager.Checked
            tmpStaff.isFullTime = chBox_isfullTimeStaff.Checked

            ' Add the staff member to the hash table
            If DataStructures.StaffHashTable.addStaffMember(tmpStaff, True) Then
                MsgBox("User details updated successfully.")
                MsgBox("New Username: " & tmpStaff.userName)
            Else
                MsgBox("Error updating user details.")
            End If

            ' Reset all labels and text boxes
            lbl_username_dynamic.Text = "<StaffUserName>"
            txt_firstName_inp.Text = ""
            txt_surname_inp.Text = ""
            txt_password_inp.Text = ""
            chBox_isManager.Checked = False
            chBox_isfullTimeStaff.Checked = False

        Else
            ' If the username is not set to new then the user is trying to create a new account with a username that is already set to something else.
            MsgBox("Cannot create a new account if the username is already set to new.")
        End If
    End Sub

    Private Sub btn_deleteAccount_process_Click(sender As Object, e As EventArgs) Handles btn_deleteAccount_process.Click
        ' Check if the user is trying to delete a valid account'
        If lbl_username_dynamic.Text = "<StaffUserName>" Or lbl_username_dynamic.Text = "NEW" Then
            MsgBox("Cannot delete a user's details if their account has not been created or searched for. Try create account for a new account or try searching for a user if you wish to edit an account.")
            Exit Sub
        End If

        ' If the user is trying to delete their own account
        If lbl_username_dynamic.Text = activeUser Then
            MsgBox("Cannot delete your own account.")
            Exit Sub
        End If

        ' Get confirmation the user wants to delte account
        Dim result As Integer = MsgBox("Are you sure you want to delete this account?", MsgBoxStyle.YesNo, "Delete Account")
        If result = DialogResult.No Then Exit Sub

        ' Delete the account
        If DataStructures.StaffHashTable.removeStaffMember(lbl_username_dynamic.Text) Then
            MsgBox("Account Deleted Successfully.")
            ' Reset all labels and text boxes
            lbl_username_dynamic.Text = "<StaffUserName>"
            txt_firstName_inp.Text = ""
            txt_surname_inp.Text = ""
            txt_password_inp.Text = ""
            chBox_isManager.Checked = False
            chBox_isfullTimeStaff.Checked = False
        Else
            MsgBox("Error Deleting Account.")   ' Inform user of error
        End If
    End Sub

    Private Sub btn_resetPassword_process_Click(sender As Object, e As EventArgs) Handles btn_resetPassword_process.Click
        ' Evaluation : Security wise not very secure as user can look at all other passwords or if a user has wrong permissions
        ' However staff should not use the same password for 2 things and no sensitive information should be kept in this system so a breach only leaks names and passwords (which should be only one system).

        ' Check if the user is trying to reset a valid account
        If lbl_username_dynamic.Text = "<StaffUserName>" Or lbl_username_dynamic.Text = "NEW" Then
            MsgBox("Cannot reset a user's password if their account has not been created or searched for. Try create account for a new account or try searching for a user if you wish to edit an account.")
            Exit Sub
        End If

        ' Get confirmation the user wants to reset the password
        Dim result As Integer = MsgBox("Are you sure you want to reset this account's password?", MsgBoxStyle.YesNo, "Reset Password")
        If result = DialogResult.No Then Exit Sub

        ' Update user details with a reset password 
        Dim tmpStaff As StaffMember = DataStructures.StaffHashTable.findStaffMember(lbl_username_dynamic.Text, True)
        tmpStaff.password = "Password123!"
        ' Update the user's details in the hash table
        If DataStructures.StaffHashTable.updateStaffMember(lbl_username_dynamic.Text, tmpStaff) Then MsgBox("Password Has been reset for user: " & tmpStaff.userName & vbNewLine & "New Password: " & tmpStaff.password)

        ' Update Displayed Data
        lbl_username_dynamic.Text = tmpStaff.userName
        txt_firstName_inp.Text = tmpStaff.firstName
        txt_surname_inp.Text = tmpStaff.lastName
        txt_password_inp.Text = tmpStaff.password
        chBox_isManager.Checked = tmpStaff.isManager
        chBox_isfullTimeStaff.Checked = tmpStaff.isFullTime
    End Sub
End Class