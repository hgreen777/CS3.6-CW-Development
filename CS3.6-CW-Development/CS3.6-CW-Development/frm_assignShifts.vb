Public Class frm_assignShifts
    Private Sub frm_assignShifts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Formatting Buttons
        ' Loop through all buttons on the form and set the colour and round the edges.
        For Each btn As Button In Me.Controls.OfType(Of Button)
            standardProcedures.RoundButton(btn)
        Next
    End Sub
End Class