Public Class frm_assignShifts
    Private Sub frm_assignShifts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Formatting Buttons
        ' Loop through all buttons on the form and set the colour and round the edges.
        For Each btn As Button In Me.Controls.OfType(Of Button)
            standardProcedures.RoundButton(btn)
        Next
    End Sub


    Private Sub frm_assignShifts_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible() Then
            lbl_shiftID_dynamic.Text = frm_allShifts.lbl_shiftID_dynamic.Text
            lbl_startDateTime_dynamic.Text = frm_allShifts.lbl_startDateTime_dynamic.Text
            lbl_endDateTime_dynamic.Text = frm_allShifts.lbl_endDateTime_dynamic.Text
        Else
            ' Clear all labels
            lbl_shiftID_dynamic.Text = "<ShiftID>"
            lbl_startDateTime_dynamic.Text = "<StartDateTime>"
            lbl_endDateTime_dynamic.Text = "<EndDateTime>"
            ' Clear text boxes
            txt_firstName_search.Text = ""
            txt_startTime_inp.Text = "HH:mm"
            txt_endTime_inp.Text = "HH:mm"
        End If
    End Sub

    Private Sub btn_searchStaff_process_Click(sender As Object, e As EventArgs) Handles btn_searchStaff_process.Click
        ' Validate Input 
        If Validation.PresenceValidation(txt_firstName_search.Text) = False Then MsgBox("Must enter a name to search or NEW") : Exit Sub

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
            lbl_StaffUserName_dynamic.Text = tmpStaff.userName
            lbl_staffFirstName_dynamic.Text = tmpStaff.firstName

            txt_firstName_search.Text = ""
        Else
            ' Reset all labels and text boxes
            lbl_StaffUserName_dynamic.Text = "<StaffUserName>"
            lbl_staffFirstName_dynamic.Text = "<StaffFirstName>"
        End If

    End Sub

    Private Sub btn_assignShift_redir_Click(sender As Object, e As EventArgs) Handles btn_assignShift_redir.Click
        ' Call the assign shift function 
        If DataStructures.ShiftLL.assignShift(txt_startTime_inp.Text, txt_endTime_inp.Text, lbl_shiftID_dynamic.Text, lbl_StaffUserName_dynamic.Text) Then
            ' Shift assignment was successful so return to calling form
            frm_allShifts.Show()
            Me.Hide()

        Else
            ' Shift assignment was unsuccessful so display an error message.
            MsgBox("Shift assignment was unsuccessful")
        End If
    End Sub

    Private Sub btn_back_redir_Click(sender As Object, e As EventArgs) Handles btn_back_redir.Click
        ' Redirect to the calling form.
        frm_allShifts.Show()
        Me.Hide()
    End Sub
End Class