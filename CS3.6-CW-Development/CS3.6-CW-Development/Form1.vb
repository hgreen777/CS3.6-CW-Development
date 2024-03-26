Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        readAllData()
        standardProcedures.automaticShiftGeneration()
        Exit Sub


        Dim testSet As String() = {"00:00", "99:99", "19:00", "23:59", "12", "12:3123123", "James", "Ja:Me"}
        For Each strs In testSet
            MsgBox(strs & Validation.correctTimeFormat(strs))
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' read all the data from files for testing
        FileHandler.readAllData()
        FileHandler.writeAllData()


        activeUser = "HarrisonGreen0"

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
        DataStructures.StaffHashTable.addStaffMember(tmpStaff, True)

        tmpStaff.firstName = "James"
        tmpStaff.lastName = "Smith"
        tmpStaff.isManager = False
        tmpStaff.isFullTime = False
        tmpStaff.password = "password"
        tmpStaff.staffID = 1
        tmpStaff.userName = "JamesSmith1"
        DataStructures.StaffHashTable.addStaffMember(tmpStaff, True)

        tmpStaff.firstName = "James"
        tmpStaff.lastName = "Davies"
        tmpStaff.isManager = True
        tmpStaff.isFullTime = False
        tmpStaff.password = "password"
        tmpStaff.staffID = 2
        tmpStaff.userName = "JamesDavies2"
        DataStructures.StaffHashTable.addStaffMember(tmpStaff, True)

        FileHandler.staffWrite()

        Dim tmpShift As Shift

        tmpShift.shiftID = 1
        tmpShift.startTime = "27/07/2006 00:01"
        tmpShift.endTime = "27/07/2006 23:59"
        tmpShift.isTaken = False
        tmpShift.staffUserName = "HarrisonGreen0"
        DataStructures.ShiftLL.newList(tmpShift)

        tmpShift.shiftID = 2
        tmpShift.startTime = "25/07/2006 00:01"
        tmpShift.endTime = "25/07/2006 23:59"
        tmpShift.isTaken = True
        tmpShift.staffUserName = "HarrisonGreen0"
        DataStructures.ShiftLL.append(tmpShift)

        tmpShift.shiftID = 3
        tmpShift.startTime = "25/07/2006 00:01"
        tmpShift.endTime = "25/07/2006 23:59"
        tmpShift.isTaken = True
        tmpShift.staffUserName = "JamesSmith1"
        DataStructures.ShiftLL.append(tmpShift)

        tmpShift.shiftID = 4
        'Include date
        tmpShift.startTime = "25/07/2007 00:01"
        tmpShift.endTime = "25/07/2007 23:59"
        tmpShift.isTaken = True
        tmpShift.staffUserName = "HarrisonGreen0"
        DataStructures.ShiftLL.append(tmpShift)

        tmpShift.shiftID = 5
        tmpShift.startTime = "25/07/2006 00:01"
        tmpShift.endTime = "25/07/2006 23:59"
        tmpShift.isTaken = False
        DataStructures.ShiftLL.append(tmpShift)

        tmpShift.shiftID = 6
        tmpShift.startTime = "25/07/2005 00:01"
        tmpShift.endTime = "25/07/2005 23:59"
        tmpShift.isTaken = True
        tmpShift.staffUserName = "HarrisonGreen0"
        DataStructures.ShiftLL.append(tmpShift)

        tmpShift.shiftID = 7
        tmpShift.startTime = "26/07/2006 00:01"
        tmpShift.endTime = "26/07/2006 23:59"
        tmpShift.isTaken = False
        DataStructures.ShiftLL.append(tmpShift)

        tmpShift.shiftID = 8
        tmpShift.startTime = "25/07/2006 00:01"
        tmpShift.endTime = "25/07/2006 23:59"
        tmpShift.isTaken = False
        tmpShift.staffUserName = "HarrisonGreen0"
        DataStructures.ShiftLL.append(tmpShift)

        FileHandler.shiftWrite()

        ' Notification Test data
        Dim tmpNotification As Notification

        tmpNotification.notificationID = 0
        tmpNotification.content = "0"
        DataStructures.NotificationTree.newTree(tmpNotification)

        tmpNotification.notificationID = 1
        tmpNotification.content = "1"
        DataStructures.NotificationTree.add(tmpNotification)

        tmpNotification.notificationID = 2
        tmpNotification.content = "2"
        DataStructures.NotificationTree.add(tmpNotification)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frm_login_screen.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        ' Gain input from user any valid string
        Dim input As String = "HarrisonGreen0"

        Dim encryptedString As String = standardProcedures.encryptString(input)
        Dim decrypted As String = standardProcedures.decryptString(encryptedString)


        MsgBox(decrypted)


    End Sub
End Class
