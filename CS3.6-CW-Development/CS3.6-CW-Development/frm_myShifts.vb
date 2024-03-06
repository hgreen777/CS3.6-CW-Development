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
                lst_myShifts.Items.Add(tmpShift.shiftID & "     |     " & tmpShift.startTime & "      |      " & tmpShift.endTime)

            Next
        End If
    End Sub
End Class