﻿Imports System.Text.RegularExpressions
Public Class frm_accountEditor
    '
    ' Form Open & close Events
    '
    Private Sub frm_acountEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Formatting Buttons
        ' Loop through all buttons on the form and set the colour and round the edges.
        For Each btn As Button In Me.Controls.OfType(Of Button)
            standardProcedures.RoundButton(btn)
        Next
    End Sub
    Private Sub frm_accountEditor_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            ' Set the form title to include the user's first name 
            lbl_accountEditor_TITLE.Text = DataStructures.StaffHashTable.firstFromUserName(activeUser) & "'s Account Editor"

            ' Set the username label to be the current user's username.
            lbl_username_dynamic.Text = activeUser

            ' Getting user details
            Dim tmpStaff As StaffMember = DataStructures.StaffHashTable.findStaffMember(activeUser, True)

            ' Set the textboxes to the current user's data
            txt_firstName_inp.Text = tmpStaff.firstName
            txt_surname_inp.Text = tmpStaff.lastName
            txt_password_inp.Text = tmpStaff.password
        End If
    End Sub
    '
    ' Redirect Code
    '
    Private Sub btn_back_redir_Click(sender As Object, e As EventArgs) Handles btn_back_redir.Click
        ' Check if the user is a manager, if they are then return to manager menu, else return to staff menu
        If DataStructures.StaffHashTable.findStaffMember(activeUser, True).isManager Then
            frm_managerMenu.Show()
        Else
            frm_staffMenu.Show()
        End If
        Me.Hide()
    End Sub
    '
    ' Processes code ie buttons for processing data
    '
    Private Sub txt_firstName_inp_TextChanged(sender As Object, e As EventArgs) Handles txt_firstName_inp.TextChanged
        'Change the username label to change for the new updates. 
        ' Find the numbers in the username ie the staffId and then change the string before that
        Dim currentUserName As String = lbl_username_dynamic.Text                               ' Get the current username
        Dim staffID As String = Regex.Match(currentUserName, "\d+").Value                       ' Find the staffID in the username
        lbl_username_dynamic.Text = txt_firstName_inp.Text & txt_surname_inp.Text & staffID     ' Set the new username
    End Sub

    Private Sub txt_surname_inp_TextChanged(sender As Object, e As EventArgs) Handles txt_surname_inp.TextChanged
        'Change the username label to change for the new updates. 
        ' Find the numbers in the username ie the staffId and then change the string before that
        Dim currentUserName As String = lbl_username_dynamic.Text                               ' Get the current username
        Dim staffID As String = Regex.Match(currentUserName, "\d+").Value                       ' Find the staffID in the username
        lbl_username_dynamic.Text = txt_firstName_inp.Text & txt_surname_inp.Text & staffID     ' Set the new username
    End Sub

    Private Sub chkBox_showPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox_showPassword.CheckedChanged
        ' If the checkbox is checked then show the password
        If chkBox_showPassword.Checked = True Then
            txt_password_inp.PasswordChar = ""      ' Set the password character to nothing (so password is shown truly)
        Else
            txt_password_inp.PasswordChar = "*"     ' Set the password character to * (so password is hidden)
        End If
    End Sub

    'Error 2 saying not writing properly b ut then it seems to be writing properly
    Private Sub btn_saveDetails_process_Click(sender As Object, e As EventArgs) Handles btn_saveDetails_process.Click
        ' Check if the first name is valid
        If Validation.PresenceValidation(txt_firstName_inp.Text) = False Then MsgBox("First Name is empty, please enter a valid first name.") : Return
        ' Check if the last name is valid
        If Validation.PresenceValidation(txt_surname_inp.Text) = False Then MsgBox("Surname is empty, please enter a valid surname.") : Return
        ' Check if the password is valid
        If Validation.PresenceValidation(txt_password_inp.Text) = False Then MsgBox("Password is empty, please enter a valid password.") : Return

        ' Update User Details
        Dim tmpStaff As StaffMember = DataStructures.StaffHashTable.findStaffMember(activeUser, True) ' Get the current user's details
        tmpStaff.firstName = txt_firstName_inp.Text
        tmpStaff.lastName = txt_surname_inp.Text
        tmpStaff.password = txt_password_inp.Text
        tmpStaff.userName = lbl_username_dynamic.Text


        ' Update the user's details in the hash table
        If DataStructures.StaffHashTable.updateStaffMember(activeUser, tmpStaff) Then
            MsgBox("User details updated successfully.")
            activeUser = tmpStaff.userName
        End If

        ' Data is written back to file in ^^ Function

    End Sub
End Class