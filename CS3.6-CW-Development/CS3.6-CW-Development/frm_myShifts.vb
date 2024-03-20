Public Class frm_myShifts
    Private Sub frm_myShifts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Formatting Buttons
        ' Loop through all buttons on the form and set the colour and round the edges.
        For Each btn As Button In Me.Controls.OfType(Of Button)
            standardProcedures.RoundButton(btn)
        Next
    End Sub

    Private Sub frm_myShifts_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible() Then
            ' Clear the list boxes
            lst_myShifts.Items.Clear()

            ' Update listbox with all shifts
            Dim staffShifts As List(Of Integer) = DataStructures.ShiftLL.findStaffShifts(activeUser)

            ' Force a sort algorithm - Quick Sort - Due to implementation less efficient due to all the linear searching of LL to then sort.
            ' Sort the array
            If cbo_sortStartTime.Checked Then
                ' Move the shifts to an array of Shifts
                Dim staffShiftsArray(staffShifts.Count - 1) As Shift
                For i = 0 To staffShifts.Count - 1
                    ' Find the shift and add it to the array
                    staffShiftsArray(i) = DataStructures.ShiftLL.find(staffShifts(i))
                Next

                staffShiftsArray = DataStructures.quickSortShifts(staffShiftsArray, 0, staffShiftsArray.Length - 1)

                ' Clear the list 
                staffShifts.Clear()
                ' Add the sorted shifts back to the list - adding the shiftID to the list
                For i = 0 To staffShiftsArray.Length - 1
                    staffShifts.Add(staffShiftsArray(i).shiftID)
                Next
            End If



            For i = 0 To staffShifts.Count - 1
                Dim tmpShift As Shift = DataStructures.ShiftLL.find(staffShifts(i))
                ' Add Shift to mulitcolumned ListBox adding the shiftID, Start Time and End Time in columns
                Dim tmpShiftItem As ListViewItem = New ListViewItem(tmpShift.shiftID)
                tmpShiftItem.SubItems.Add(tmpShift.startTime.DayOfWeek.ToString.Substring(0, 3) & " " & tmpShift.startTime)
                tmpShiftItem.SubItems.Add(tmpShift.endTime.DayOfWeek.ToString.Substring(0, 3) & " " & tmpShift.endTime)
                lst_myShifts.Items.Add(tmpShiftItem)
            Next
        End If
    End Sub

    Private Sub btn_removeShift_process_Click(sender As Object, e As EventArgs) Handles btn_removeShift_process.Click
        ' Check that a shift has been selected
        If lbl_shiftID_dynamic.Text = "<ShiftID>" Then MsgBox("Please select a shift to remove.") : Exit Sub

        ' Set shift isTaken to false so it does not show in ListBox
        Dim tmpShift As Shift = DataStructures.ShiftLL.find(Integer.Parse(lbl_shiftID_dynamic.Text))
        tmpShift.isTaken = False
        'Update the node
        DataStructures.ShiftLL.updateShiftData(tmpShift, tmpShift)  ' Works as username is same in both.

        ' Update the listbox
        lst_myShifts.Items.Clear()
        frm_myShifts_VisibleChanged(sender, e)


        'Reset the labels
        lbl_shiftID_dynamic.Text = "<ShiftID>"
        lbl_startDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
        lbl_endDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"

        ' Write to file
        FileHandler.shiftWrite()
    End Sub

    Private Sub lst_myShifts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_myShifts.SelectedIndexChanged
        ' Check that a shift has been selected
        If lst_myShifts.SelectedItems.Count = 0 Then
            'Reset the labels
            lbl_shiftID_dynamic.Text = "<ShiftID>"
            lbl_startDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
            lbl_endDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
            Exit Sub
        End If
        ' Set the labels to the selected shift
        lbl_shiftID_dynamic.Text = lst_myShifts.SelectedItems(0).Text
        lbl_startDateTime_dynamic.Text = lst_myShifts.SelectedItems(0).SubItems(1).Text
        lbl_endDateTime_dynamic.Text = lst_myShifts.SelectedItems(0).SubItems(2).Text
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


End Class