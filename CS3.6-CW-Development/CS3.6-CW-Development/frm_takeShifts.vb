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
            ' Update the suggested shifts list box
            Dim suggestedShifts As List(Of Integer) = DataStructures.ShiftLL.usersSuggestedShifts()
            For i = 0 To suggestedShifts.Count - 1
                Dim tmpShift As Shift = DataStructures.ShiftLL.find(suggestedShifts(i))
                ' Add Shift to mulitcolumned ListBox adding the shiftID, Start Time and End Time in columns
                lst_suggestedShifts.Items.Add(tmpShift.shiftID)
                lst_suggestedShifts.Items(i).SubItems.Add(tmpShift.startTime)
                lst_suggestedShifts.Items(i).SubItems.Add(tmpShift.endTime)

            Next

            'Update the all availabler shifts list box
            Dim allShifts As List(Of Integer) = DataStructures.ShiftLL.availableShifts()
            For i = 0 To allShifts.Count - 1
                Dim tmpShift As Shift = DataStructures.ShiftLL.find(allShifts(i))
                ' Add Shift to mulitcolumned ListBox adding the shiftID, Start Time and End Time in columns
                lst_availableShifts.Items.Add(tmpShift.shiftID)
                lst_availableShifts.Items(i).SubItems.Add(tmpShift.startTime)
                lst_availableShifts.Items(i).SubItems.Add(tmpShift.endTime)

            Next
        End If
    End Sub
End Class