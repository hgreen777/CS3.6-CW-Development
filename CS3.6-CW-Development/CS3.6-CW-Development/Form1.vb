Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim testSet As String() = {"00:00", "99:99", "19:00", "23:59", "12", "12:3123123", "James", "Ja:Me"}
        For Each strs In testSet
            MsgBox(strs & Validation.CorrectTimeFormat(strs))
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_managerMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        activeUser = "HarrisonGreen0"
        Dim tmpStaff As StaffMember

        tmpStaff.firstName = "Harrison"
        tmpStaff.lastName = "Green"
        tmpStaff.isManager = True
        tmpStaff.isFullTime = True
        tmpStaff.password = "password"
        tmpStaff.staffID = 0
        tmpStaff.userName = "HarrisonGreen0"
        DataStructures.StaffHashTable.addStaffMember(tmpStaff)

        tmpStaff.firstName = "James"
        tmpStaff.lastName = "Smith"
        tmpStaff.isManager = False
        tmpStaff.isFullTime = False
        tmpStaff.password = "password"
        tmpStaff.staffID = 1
        tmpStaff.userName = "JamesSmith1"
        DataStructures.StaffHashTable.addStaffMember(tmpStaff)

        tmpStaff.firstName = "James"
        tmpStaff.lastName = "Davies"
        tmpStaff.isManager = True
        tmpStaff.isFullTime = False
        tmpStaff.password = "password"
        tmpStaff.staffID = 2
        tmpStaff.userName = "JamesDavies2"
        DataStructures.StaffHashTable.addStaffMember(tmpStaff)

        Dim tmpShift As Shift
        tmpShift.shiftID = 0
        tmpShift.startTime = "00:00"
        tmpShift.endTime = "23:59"
        tmpShift.isTaken = False
        tmpShift.staffUserName = "HarrisonGreen0"
        DataStructures.ShiftLL.append(tmpShift)

        tmpShift.shiftID = 1
        tmpShift.startTime = "00:00"
        tmpShift.endTime = "23:59"
        tmpShift.isTaken = False
        DataStructures.ShiftLL.append(tmpShift)

        tmpShift.shiftID = 2
        tmpShift.startTime = "00:00"
        tmpShift.endTime = "23:59"
        tmpShift.isTaken = True
        tmpShift.staffUserName = "HarrisonGreen0"
        DataStructures.ShiftLL.append(tmpShift)

        tmpShift.shiftID = 3
        tmpShift.startTime = "00:00"
        tmpShift.endTime = "23:59"
        tmpShift.isTaken = True
        tmpShift.staffUserName = "JamesSmith1"
        DataStructures.ShiftLL.append(tmpShift)

        tmpShift.shiftID = 4
        tmpShift.startTime = "00:00"
        tmpShift.endTime = "23:59"
        tmpShift.isTaken = True
        tmpShift.staffUserName = "HarrisonGreen0"
        DataStructures.ShiftLL.append(tmpShift)

        tmpShift.shiftID = 5
        tmpShift.startTime = "00:00"
        tmpShift.endTime = "23:59"
        tmpShift.isTaken = False
        DataStructures.ShiftLL.append(tmpShift)

        tmpShift.shiftID = 6
        tmpShift.startTime = "00:00"
        tmpShift.endTime = "23:59"
        tmpShift.isTaken = True
        tmpShift.staffUserName = "HarrisonGreen0"
        DataStructures.ShiftLL.append(tmpShift)

        tmpShift.shiftID = 7
        tmpShift.startTime = "00:00"
        tmpShift.endTime = "23:59"
        tmpShift.isTaken = False
        DataStructures.ShiftLL.append(tmpShift)



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frm_login_screen.Show()
        Me.Hide()
    End Sub
End Class
