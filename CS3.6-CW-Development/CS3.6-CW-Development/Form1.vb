Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim testSet As String() = {"00:00", "99:99", "19:00", "23:59", "12", "12:3123123", "James", "Ja:Me"}
        For Each strs In testSet
            MsgBox(strs & Validation.CorrectTimeFormat(strs))
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_accountEditor.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        activeUser = "HarrisonGreen0"
        Dim tmpStaff As StaffMember

        tmpStaff.firstName = "Harrison"
        tmpStaff.lastName = "Green"
        tmpStaff.isManager = False
        tmpStaff.fullTimeNO = 0
        tmpStaff.password = "password"
        tmpStaff.staffID = 0
        tmpStaff.userName = "HarrisonGreen0"
        DataStructures.StaffHashTable.addStaffMember(tmpStaff)

        tmpStaff.firstName = "James"
        tmpStaff.lastName = "Smith"
        tmpStaff.isManager = False
        tmpStaff.fullTimeNO = 0
        tmpStaff.password = "password"
        tmpStaff.staffID = 1
        tmpStaff.userName = "JamesSmith1"
        DataStructures.StaffHashTable.addStaffMember(tmpStaff)


    End Sub
End Class
