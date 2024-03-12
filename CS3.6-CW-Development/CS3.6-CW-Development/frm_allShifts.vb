Public Class frm_allShifts
    'Evaulation - Very confusing screen
    Private Sub frm_allShifts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Formatting Buttons
        ' Loop through all buttons on the form and set the colour and round the edges.
        For Each btn As Button In Me.Controls.OfType(Of Button)
            standardProcedures.RoundButton(btn)
        Next
    End Sub

    Private Sub frm_allShifts_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible() Then
            ' Clear the list boxes
            lst_allShifts.Items.Clear()
            'Set Check Box to unchecked - to ensure checkbox matches the list
            chkbox_filterTaken.Checked = False



            ' Update the list box - with all the shifts
            Dim currentNode As ShiftNode = DataStructures.ShiftLL._root

            While currentNode IsNot Nothing
                ' Add Shift to mulitcolumned ListBox adding the shiftID, Start Time and End Time in columns
                Dim tmpshiftItem As ListViewItem = New ListViewItem(currentNode.shiftData.shiftID)
                tmpshiftItem.SubItems.Add(currentNode.shiftData.endTime.DayOfWeek.ToString.Substring(0, 3) & " " & currentNode.shiftData.startTime)
                tmpshiftItem.SubItems.Add(currentNode.shiftData.endTime.DayOfWeek.ToString.Substring(0, 3) & " " & currentNode.shiftData.endTime)
                ' Add the isTaken to the list however make the language more userfriendly. By using yes or no.
                ' So if the shift is taken add yes, if it isn't then no.
                If currentNode.shiftData.isTaken Then
                    tmpshiftItem.SubItems.Add("Yes")
                    ' If the shift is taken then add the staff username to the list
                    ' As desault for not taken is the first user ie "HarrisonGreen0" but do not want to show anything if the shift ahs not been taken.
                    tmpshiftItem.SubItems.Add(currentNode.shiftData.staffUserName)
                Else
                    tmpshiftItem.SubItems.Add("No")
                End If
                lst_allShifts.Items.Add(tmpshiftItem)
                ' Move to the next node
                currentNode = currentNode.nextShift
            End While
        End If
    End Sub

    Private Sub chkbox_filterTaken_CheckedChanged(sender As Object, e As EventArgs) Handles chkbox_filterTaken.CheckedChanged
        If chkbox_filterTaken.Checked Then
            ' Clear the list box
            lst_allShifts.Items.Clear()

            ' Find all the available shifts
            Dim availableShifts As List(Of Integer) = DataStructures.ShiftLL.availableShifts()

            ' Add each shift in available shifts to the list box.
            For i = 0 To availableShifts.Count - 1
                Dim tmpShift As Shift = DataStructures.ShiftLL.find(availableShifts(i))
                ' Add Shift to mulitcolumned ListBox adding the shiftID, Start Time and End Time in columns
                Dim tmpShiftItem As ListViewItem = New ListViewItem(tmpShift.shiftID)
                tmpShiftItem.SubItems.Add(tmpShift.startTime)
                tmpShiftItem.SubItems.Add(tmpShift.endTime)
                tmpShiftItem.SubItems.Add("No")
                lst_allShifts.Items.Add(tmpShiftItem)
            Next
        Else
            frm_allShifts_VisibleChanged(sender, e)
        End If
    End Sub

    Private Sub lst_allShifts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_allShifts.SelectedIndexChanged
        ' Ensure only one shift is selected
        If lst_allShifts.SelectedItems.Count > 1 Then lst_allShifts.SelectedItems(0).Selected = False

        ' If a shift is deselected, clear the labels
        If lst_allShifts.SelectedItems.Count = 0 Then
            'Reset the labels
            lbl_shiftID_dynamic.Text = "<ShiftID>"
            lbl_startDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
            lbl_endDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
            lbl_isTaken_dynamic.Text = "<Yes/No>"
            lbl_takenBy_dynamic.Text = "<StaffUserName>"
            Exit Sub
        End If

        ' Get the selected shift
        Dim tmpShift As Shift = DataStructures.ShiftLL.find(Integer.Parse(lst_allShifts.SelectedItems(0).Text))
        ' Check the shift exists
        If tmpShift.staffUserName IsNot Nothing Then
            ' Update Labels
            lbl_shiftID_dynamic.Text = tmpShift.shiftID
            lbl_startDateTime_dynamic.Text = tmpShift.startTime
            lbl_endDateTime_dynamic.Text = tmpShift.endTime
            ' Check if the shift is taken
            If tmpShift.isTaken Then
                lbl_isTaken_dynamic.Text = "Yes"
                lbl_takenBy_dynamic.Text = tmpShift.staffUserName
            Else
                lbl_isTaken_dynamic.Text = "No"
                lbl_takenBy_dynamic.Text = "N/A"
            End If
        End If
    End Sub

    Private Sub btn_addShift_process_Click(sender As Object, e As EventArgs) Handles btn_addShift_process.Click
        ' Ensure no shift is selected
        If lst_allShifts.SelectedItems.Count > 0 Then MsgBox("Please deselect shift before adding a new shift.") : Exit Sub

        ' Check data has been ionputted into the text boxes and datetime picker
        If Not Validation.PresenceValidation(txt_startTime_inp.Text) Then MsgBox("Please enter a start time.") : Exit Sub
        If Not Validation.PresenceValidation(txt_endTime_inp.Text) Then MsgBox("Please enter an end time.") : Exit Sub
        If dtePicker_date.Value < Date.Now Then MsgBox("Please enter a date in the future.") : Exit Sub

        ' Validate time inputs
        If Not Validation.correctTimeFormat(txt_startTime_inp.Text) Then MsgBox("Please enter a valid start time.") : Exit Sub
        If Not Validation.correctTimeFormat(txt_endTime_inp.Text) Then MsgBox("Please enter a valid end time.") : Exit Sub

        ' Check the start time is before the end time
        Dim tmpTime As DateTime = txt_startTime_inp.Text
        Dim tmpTime2 As DateTime = txt_endTime_inp.Text
        If tmpTime > tmpTime2 Then MsgBox("Start time must be before end time.") : Exit Sub


        ' Take the filled in details and create a new shift
        Dim newShift As Shift
        newShift.shiftID = DataStructures.ShiftLL.nextAvailableID()
        ' Set start time to include the date from the date picker and the time from the text box.
        newShift.startTime = dtePicker_date.Value.ToShortDateString & " " & txt_startTime_inp.Text
        newShift.endTime = dtePicker_date.Value.ToShortDateString & " " & txt_endTime_inp.Text
        newShift.isTaken = False
        newShift.staffUserName = "HarrisonGreen0"
        ' Add the shift to the linked list
        DataStructures.ShiftLL.add(newShift)

        MsgBox("Shift added succesfully.") ' Inform the user the shift has been added successfully

        ' Clears the text boxes and resets date picker
        txt_startTime_inp.Text = "HH:mm"
        txt_endTime_inp.Text = "HH:mm"
        dtePicker_date.Value = Date.Now

        ' Update the list box
        frm_allShifts_VisibleChanged(sender, e)
    End Sub

    Private Sub btn_removeShift_process_Click(sender As Object, e As EventArgs) Handles btn_removeShift_process.Click
        ' Ensure a shift is selected
        If lbl_shiftID_dynamic.Text = "<ShiftID>" Then MsgBox("Please select a shift to remove.") : Exit Sub

        ' Remove the shift from the linked list
        DataStructures.ShiftLL.remove(Integer.Parse(lbl_shiftID_dynamic.Text))
        MsgBox("Shift removed succesfully.") ' Inform the user the shift has been removed successfully

        'Reset the labels
        lbl_shiftID_dynamic.Text = "<ShiftID>"
        lbl_startDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
        lbl_endDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
        lbl_isTaken_dynamic.Text = "<Yes/No>"
        lbl_takenBy_dynamic.Text = "<StaffUserName>"


        ' Update the list box
        frm_allShifts_VisibleChanged(sender, e)
    End Sub

    Private Sub btn_back_redir_Click(sender As Object, e As EventArgs) Handles btn_back_redir.Click
        ' Redirect to relevent menu for user type
        Dim tmpStaff As StaffMember = DataStructures.StaffHashTable.findStaffMember(activeUser, True) ' Get the active user details.
        ' Check if the user is a manager or not
        If tmpStaff.isManager Then
            ' Show the manager menu is user is a manager
            frm_managerMenu.Show()
        Else
            ' Show the staff menu if the user is not a manager
            frm_staffMenu.Show()
        End If
        Me.Hide()   ' Hide the current form
    End Sub

    Private Sub btn_assignShift_redir_Click(sender As Object, e As EventArgs) Handles btn_assignShift_redir.Click
        ' Redirect to the assign shift form
        ' Ensure a shift is selected to redirect with the shiftID
        If lbl_shiftID_dynamic.Text = "<ShiftID>" Then MsgBox("Please select a shift to assign.") : Exit Sub
        ' Show the assign shifts form
        frm_assignShifts.Show()
        Me.Hide()
    End Sub

    Private Sub btn_editShift_process_Click(sender As Object, e As EventArgs) Handles btn_editShift_process.Click
        ' User will not need to change the date if they are editing a shift so process should ignore the date time picker. Notify user of this - and ignore date picker in process.
        ' Ensure a shift is selected
        If lbl_shiftID_dynamic.Text = "<ShiftID>" Then MsgBox("Please select a shift to edit.") : Exit Sub

        ' Check data has been inputted into the text boxes but ignoring date picker.
        If Not Validation.PresenceValidation(txt_startTime_inp.Text) Then MsgBox("Please enter a start time.") : Exit Sub
        If Not Validation.PresenceValidation(txt_endTime_inp.Text) Then MsgBox("Please enter an end time.") : Exit Sub

        ' Validate time inputs
        If Not Validation.correctTimeFormat(txt_startTime_inp.Text) Then MsgBox("Please enter a valid start time.") : Exit Sub
        If Not Validation.correctTimeFormat(txt_endTime_inp.Text) Then MsgBox("Please enter a valid end time.") : Exit Sub

        ' Check the start time is before the end time
        Dim tmpTime As DateTime = txt_startTime_inp.Text
        Dim tmpTime2 As DateTime = txt_endTime_inp.Text
        If tmpTime > tmpTime2 Then MsgBox("Start time must be before end time.") : Exit Sub

        ' Take the filled in details and create a new shift
        Dim newShift As Shift   ' New shift based on old shift details to be used to update the shift.
        Dim oldShift As Shift   ' Old shift to be used to find the shift to update and used in update function.
        oldShift = DataStructures.ShiftLL.find(Integer.Parse(lbl_shiftID_dynamic.Text)) ' Find the shift to update
        ' Check the shift exists
        If oldShift.staffUserName Is Nothing Then MsgBox("Shift does not exist.") : Exit Sub
        newShift = oldShift ' Set the new shift to the old shift details
        ' Update the new shift time keeping the date the same as it is.
        newShift.startTime = newShift.startTime.ToString.Substring(0, 10) & " " & txt_startTime_inp.Text
        newShift.endTime = newShift.endTime.ToString.Substring(0, 10) & " " & txt_endTime_inp.Text

        ' Add the shift to the linked list
        DataStructures.ShiftLL.updateShiftData(oldShift, newShift)

        MsgBox("Shift edited succesfully.") ' Inform the user the shift has been edited successfully

        ' Clears the text boxes and resets date picker
        txt_startTime_inp.Text = "HH:mm"
        txt_endTime_inp.Text = "HH:mm"
        dtePicker_date.Value = Date.Now

        ' Update the list box
        frm_allShifts_VisibleChanged(sender, e)

        'Reset the labels
        lbl_shiftID_dynamic.Text = "<ShiftID>"
        lbl_startDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
        lbl_endDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
        lbl_isTaken_dynamic.Text = "<Yes/No>"
        lbl_takenBy_dynamic.Text = "<StaffUserName>"

    End Sub
End Class