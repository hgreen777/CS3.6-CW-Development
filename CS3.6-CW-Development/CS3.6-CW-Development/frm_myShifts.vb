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
            ' Update listbox with all shifts
            Dim staffShifts As List(Of Integer) = DataStructures.ShiftLL.findStaffShifts(activeUser)


            For i = 0 To staffShifts.Count - 1
                Dim tmpShift As Shift = DataStructures.ShiftLL.find(staffShifts(i))
                ' Add Shift to mulitcolumned ListBox adding the shiftID, Start Time and End Time in columns
                lst_myShifts.Items.Add(tmpShift.shiftID)
                lst_myShifts.Items(i).SubItems.Add(tmpShift.startTime)
                lst_myShifts.Items(i).SubItems.Add(tmpShift.endTime)

                lst_myShifts1.Items.Add(tmpShift.shiftID & "     |     " & tmpShift.startTime & "      |      " & tmpShift.endTime)

            Next
        End If
    End Sub

    Private Sub btn_removeShift_process_Click(sender As Object, e As EventArgs) Handles btn_removeShift_process.Click
        ' Check that a shift has been selected
        If lbl_shiftID_dynamic.Text = "<ShiftID>" Then MsgBox("Please select a shift to remove.") : Exit Sub


        'Reset the labels
        lbl_shiftID_dynamic.Text = "<ShiftID>"
        lbl_startDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
        lbl_endDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
    End Sub
End Class