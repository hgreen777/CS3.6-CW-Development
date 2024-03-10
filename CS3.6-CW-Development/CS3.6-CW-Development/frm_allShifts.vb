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
                lst_allShifts.Items.Add(currentNode.shiftData.shiftID)  ' Add the shiftID to the list
                lst_allShifts.Items(lst_allShifts.Items.Count - 1).SubItems.Add(currentNode.shiftData.startTime)    ' Add the start time to the list
                lst_allShifts.Items(lst_allShifts.Items.Count - 1).SubItems.Add(currentNode.shiftData.endTime)      ' Add the end time to the list
                ' Add the isTaken to the list however make the language more userfriendly. By using yes or no.
                ' So if the shift is taken add yes, if it isn't then no.
                If currentNode.shiftData.isTaken Then
                    lst_allShifts.Items(lst_allShifts.Items.Count - 1).SubItems.Add("Yes")
                    ' If the shift is taken then add the staff username to the list
                    ' As desault for not taken is the first user ie "HarrisonGreen0" but do not want to show anything if the shift ahs not been taken.
                    lst_allShifts.Items(lst_allShifts.Items.Count - 1).SubItems.Add(currentNode.shiftData.staffUserName)
                Else
                    lst_allShifts.Items(lst_allShifts.Items.Count - 1).SubItems.Add("No")
                End If

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
                lst_allShifts.Items.Add(tmpShift.shiftID)
                lst_allShifts.Items(i).SubItems.Add(tmpShift.startTime)
                lst_allShifts.Items(i).SubItems.Add(tmpShift.endTime)
                lst_allShifts.Items(i).SubItems.Add("No")
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


        ' Take the filled in details and create a new shift
        Dim newShift As Shift
        newShift.shiftID = DataStructures.ShiftLL.nextAvailableID()
        MsgBox(newShift.shiftID)
        ' Set start time to include the date from the date picker and the time from the text box.
        newShift.startTime = dtePicker_date.Value.ToShortDateString & " " & txt_startTime_inp.Text
        newShift.endTime = dtePicker_date.Value.ToShortDateString & " " & txt_startTime_inp.Text
        newShift.isTaken = False
        newShift.staffUserName = Nothing
        ' Add the shift to the linked list
        DataStructures.ShiftLL.add(newShift)

        ' Update the list box
        frm_allShifts_VisibleChanged(sender, e)

    End Sub
End Class