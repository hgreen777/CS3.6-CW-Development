Public Class frm_notifications
    Private Sub frm_notifications_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Formatting Buttons
        ' Loop through all buttons on the form and set the colour and round the edges.
        For Each btn As Button In Me.Controls.OfType(Of Button)
            standardProcedures.RoundButton(btn)
        Next
    End Sub

    Private Sub btn_back_redir_Click(sender As Object, e As EventArgs) Handles btn_back_redir.Click
        ' Show the previous form (depending on if user is a manager) and hide this one.
        Dim tmpStaff As StaffMember = DataStructures.StaffHashTable.findStaffMember(activeUser, True)

        If tmpStaff.isManager Then
            frm_managerMenu.Show()
        Else
            frm_staffMenu.Show()
        End If
        Me.Hide()
    End Sub
End Class