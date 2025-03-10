﻿Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)


        Exit Sub

        Dim tmpStaff As StaffMember
        tmpStaff.staffID = 0
        tmpStaff.firstName = "Harrison"
        tmpStaff.lastName = "Green"
        tmpStaff.isManager = True
        tmpStaff.isFullTime = True
        tmpStaff.password = "password"
        tmpStaff.userName = "HarrisonGreen0"
        DataStructures.StaffHashTable.addStaffMember(tmpStaff, True)

        tmpStaff.staffID = 1
        tmpStaff.firstName = "Ellie"
        tmpStaff.lastName = "Mccartney"
        tmpStaff.isManager = False
        tmpStaff.isFullTime = False
        tmpStaff.password = "password"
        tmpStaff.userName = "EllieMccartney1"
        DataStructures.StaffHashTable.addStaffMember(tmpStaff, True)

        activeUser = "EllieMccartney1"

        Dim testData As Notification

        testData.notificationID = 3
        testData.content = "3"
        testData.sentDate = Date.Now
        testData.sender = "HarrisonGreen0"
        DataStructures.NotificationTree.add(testData)

        testData.notificationID = 2
        testData.content = "2"
        testData.sentDate = Date.Now
        testData.sender = "HarrisonGreen0"
        DataStructures.NotificationTree.add(testData)

        testData.notificationID = 5
        testData.content = "5"
        testData.sentDate = Date.Now
        testData.sender = "HarrisonGreen0"
        DataStructures.NotificationTree.add(testData)

        testData.notificationID = 1
        testData.content = "1"
        testData.sentDate = Date.Now
        testData.sentDate = testData.sentDate.AddDays(-7)
        testData.sender = "HarrisonGreen0"
        DataStructures.NotificationTree.add(testData)

        testData.notificationID = 4
        testData.content = "4"
        testData.sentDate = Date.Now
        testData.sender = "HarrisonGreen0"
        DataStructures.NotificationTree.add(testData)

        testData.notificationID = 6
        testData.content = "6"
        testData.sentDate = Date.Now
        testData.sender = "HarrisonGreen0"
        DataStructures.NotificationTree.add(testData)


        testData.notificationID = 2
        testData.content = "2"
        testData.sentDate = Date.Now
        testData.sender = "HarrisonGreen0"


        DataStructures.NotificationTree.remove(NotificationTree._root, 5)
        ' Inorder traversal of the tree to see if node removed
        Dim traversalList As List(Of Integer) = DataStructures.NotificationTree.inOrderTraversal(DataStructures.NotificationTree._root, traversalList)
        For Each item In traversalList
            MsgBox(item)
        Next







    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' read all the data from files for testing
        FileHandler.readAllData()


        activeUser = "HarrisonGreen0"

        frm_managerMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
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

    Private Sub Button5_Click(sender As Object, e As EventArgs)

        ' Gain input from user any valid string
        Dim input As String = "HarrisonGreen0"

        Dim encryptedString As String = standardProcedures.encryptString(input)
        Dim decrypted As String = standardProcedures.decryptString(encryptedString)


        MsgBox(decrypted)


    End Sub
End Class
