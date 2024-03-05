Imports System.Text.RegularExpressions

Public Class frm_accountManager
    Dim oldUsername As String

    Private Sub frm_accountManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Formatting Buttons
        ' Loop through all buttons on the form and set the colour and round the edges.
        For Each btn As Button In Me.Controls.OfType(Of Button)
            standardProcedures.RoundButton(btn)
        Next
    End Sub

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

        ' Update User Details
        Dim tmpStaff As StaffMember ' Store the user's details in a temporary staff member to overwrite the old data.
        tmpStaff.firstName = txt_firstName_inp.Text
        tmpStaff.lastName = txt_surname_inp.Text
        tmpStaff.password = txt_password_inp.Text
        tmpStaff.userName = lbl_username_dynamic.Text
        tmpStaff.isManager = chBox_isManager.Checked
        If chBox_isfullTimeStaff.Checked = True Then
            ' change to be dynamic for allocation
            tmpStaff.fullTimeNO = 1
        Else
            tmpStaff.fullTimeNO = 0
        End If

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
End Class