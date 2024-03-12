Public Class frm_takeShifts
    Private Sub frm_takeShifts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Formatting Buttons
        ' Loop through all buttons on the form and set the colour and round the edges.
        For Each btn As Button In Me.Controls.OfType(Of Button)
            standardProcedures.RoundButton(btn)
        Next

    End Sub

    Private Sub frm_takeShifts_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible() Then
            ' Clear the list boxes
            lst_suggestedShifts.Items.Clear()
            lst_availableShifts.Items.Clear()
            ' Update the suggested shifts list box
            Dim suggestedShifts As List(Of Integer) = DataStructures.ShiftLL.usersSuggestedShifts()
            For i = 0 To suggestedShifts.Count - 1
                Dim tmpShift As Shift = DataStructures.ShiftLL.find(suggestedShifts(i))
                ' Add Shift to mulitcolumned ListBox adding the shiftID, Start Time and End Time in columns
                Dim lsvItem As ListViewItem = New ListViewItem(tmpShift.shiftID)
                lsvItem.SubItems.Add(tmpShift.startTime.DayOfWeek.ToString.Substring(0, 3) & " " & tmpShift.startTime.ToString)
                lsvItem.SubItems.Add(tmpShift.endTime.DayOfWeek.ToString.Substring(0, 3) & " " & tmpShift.endTime)
                lst_suggestedShifts.Items.Add(lsvItem)

            Next

            'Update the all availabler shifts list box
            Dim allShifts As List(Of Integer) = DataStructures.ShiftLL.availableShifts()
            For i = 0 To allShifts.Count - 1
                Dim tmpShift As Shift = DataStructures.ShiftLL.find(allShifts(i))
                ' Add Shift to mulitcolumned ListBox adding the shiftID, Start Time and End Time in columns
                Dim lsvItem As ListViewItem = New ListViewItem(tmpShift.shiftID)
                lsvItem.SubItems.Add(tmpShift.startTime)
                lsvItem.SubItems.Add(tmpShift.endTime)
                lst_availableShifts.Items.Add(lsvItem)

            Next
        End If
    End Sub

    Private Sub lst_suggestedShifts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_suggestedShifts.SelectedIndexChanged
        ' Check if a shift has been selected in availableShifts (if it has deselect it)
        If lst_availableShifts.SelectedItems.Count > 0 Then lst_availableShifts.SelectedItems(0).Selected = False
        ' If a shift has already been selected, deselect it.
        If lst_availableShifts.SelectedItems.Count > 1 Then lst_availableShifts.SelectedItems(0).Selected = False

        ' If a shift is deselected, clear the labels
        If lst_suggestedShifts.SelectedItems.Count = 0 Then
            'Reset the labels
            lbl_shiftID_dynamic.Text = "<ShiftID>"
            lbl_startDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
            lbl_endDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
            Exit Sub
        End If

        ' Get the selected shift
        Dim tmpShift As Shift = DataStructures.ShiftLL.find(Integer.Parse(lst_suggestedShifts.SelectedItems(0).Text))
        ' Display the shift details
        lbl_shiftID_dynamic.Text = tmpShift.shiftID
        lbl_startDateTime_dynamic.Text = tmpShift.startTime
        lbl_endDateTime_dynamic.Text = tmpShift.endTime
    End Sub

    Private Sub lst_availableShifts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_availableShifts.SelectedIndexChanged
        ' Check if a shift has been selected in suggestedShifts (if it has deselect it)
        If lst_suggestedShifts.SelectedItems.Count > 0 Then lst_suggestedShifts.SelectedItems(0).Selected = False
        ' If a shift has already been selected, deselect it.
        If lst_availableShifts.SelectedItems.Count > 1 Then lst_availableShifts.SelectedItems(0).Selected = False

        ' If a shift is deselected, clear the labels
        If lst_availableShifts.SelectedItems.Count = 0 Then
            'Reset the labels
            lbl_shiftID_dynamic.Text = "<ShiftID>"
            lbl_startDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
            lbl_endDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
            Exit Sub
        End If

        ' Get the selected shift
        Dim tmpShift As Shift = DataStructures.ShiftLL.find(Integer.Parse(lst_availableShifts.SelectedItems(0).Text))
        ' Display the shift details
        lbl_shiftID_dynamic.Text = tmpShift.shiftID
        lbl_startDateTime_dynamic.Text = tmpShift.startTime
        lbl_endDateTime_dynamic.Text = tmpShift.endTime
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

    Private Sub btn_takeShift_process_Click(sender As Object, e As EventArgs) Handles btn_takeShift_process.Click
        ' Check if a shift has been selected
        If lbl_shiftID_dynamic.Text = "<ShiftID>" Then
            MsgBox("Please select a shift to take.")
            Exit Sub
        End If

        ' Call the assign Shift function (although function - contains error handling so no need to have response here but no time to change it to procedure)
        If DataStructures.ShiftLL.assignShift(txt_startTime_inp.Text, txt_endTime_inp.Text, Integer.Parse(lbl_shiftID_dynamic.Text), activeUser) Then
            ' Shift has been successfully assigned so update the list boxes
            frm_takeShifts_VisibleChanged(sender, e)
        End If
    End Sub
End Class