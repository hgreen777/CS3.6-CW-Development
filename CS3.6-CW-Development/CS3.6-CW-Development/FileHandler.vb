Imports System.Security.Cryptography
Imports DataStructures
Module FileHandler
    ' This module is responsible for handling all of the reading and writing between the datastructures and the persistent data files.
    ' Declaring all filenames as constant strings to reduce bugs in code
    Const staffFile As String = "staff.txt"     ' FilePath for staff File storing all staff data.
    Const shiftFile As String = "shifts.txt"    ' FilePath for shift file storing all shift data.
    Const notificationFile As String = "notification.txt" ' FilePath for notification file storing all shift data.
    Const notificationInstanceFile As String = "notificationInstance.txt" ' FilePath for notification file storing all shift data.
    '
    ' Read/Write For Staff File (Hash Table <-> List of records in file)
    '
    '
    ' Reading from staff file
    ' Thie function reads from the staff file into the hashTable data structure. Returns True if process was successful.
    Public Function staffRead() As Boolean
        ' Linearly read all records from file and create a new node out of them then add node to Hash Table.

        ' Create a new staff member to store the data from the file
        Dim tmpStaff As StaffMember

        ' Try to read from file and add to hash table
        Try
            ' Open file for reading.
            FileOpen(1, staffFile, OpenMode.Input)

            ' Clear the old hash table
            DataStructures.StaffHashTable.clearHashTable()

            ' While not end of file read in all the data for one record and add to hash table
            While Not EOF(1)
                Input(1, tmpStaff.staffID)                                      ' Read staffID from file.
                Input(1, tmpStaff.firstName) : Input(1, tmpStaff.lastName)      ' Read user's personal details from file.
                Input(1, tmpStaff.isFullTime) : Input(1, tmpStaff.isManager)    ' Read staff type from file.
                Input(1, tmpStaff.userName) : Input(1, tmpStaff.password)       ' Read user's loging details from file.

                ' Decrypt the staff member's password
                Dim tmpPassword As String = standardProcedures.decryptString(tmpStaff.password)
                tmpStaff.password = tmpPassword

                ' Add the staff member to the hash table
                DataStructures.StaffHashTable.addStaffMember(tmpStaff, False)
            End While
            FileClose(1)    ' Close the file
            Return True     ' Return True if process was successful
        Catch ex As Exception
            ' If an error occurs close the file and return false
            FileClose(1)
            MsgBox("Error Accessing Staff Data, try restarting program. " & ex.ToString())  ' Display error message to user
            Return False
        End Try
    End Function
    '
    ' Writing to staff file
    ' This function writs all the data from the hash table to the staff persistent file.
    Public Function staffWrite() As Boolean

        Try
            FileOpen(1, staffFile, OpenMode.Output)

            ' For each cell in HashTable linearly run through the LL and write each one
            For i = 0 To DataStructures.StaffHashTable._hashTable.Length - 1
                ' Create a new pointer to node to store the current staff member
                Dim currentNode As StaffMemberNode
                ' Set the current node to the first node in the linked list
                currentNode = StaffHashTable._hashTable(i)
                ' While the current node is not nothing write the data to the file
                While currentNode IsNot Nothing
                    ' Encypt the staff member's password of the node
                    Dim tmpPassword As String = standardProcedures.encryptString(currentNode.staffMemberData.password)

                    ' Write one record at a time to file
                    WriteLine(1,
                              currentNode.staffMemberData.staffID,
                              currentNode.staffMemberData.firstName,
                              currentNode.staffMemberData.lastName,
                              currentNode.staffMemberData.isFullTime,
                              currentNode.staffMemberData.isManager,
                              currentNode.staffMemberData.userName,
                              tmpPassword)

                    ' Move to the next node in the linked list
                    currentNode = currentNode.nextStaffMember
                End While
            Next
            ' Close the file and return true if process was successful
            FileClose(1)
            Return True
        Catch ex As Exception
            ' If an error occurs close the file and return false
            FileClose(1)
            MsgBox("Error Writing Staff Data, try restarting program." & " " & ex.ToString())  ' Display error message to user
            Return False
        End Try

    End Function
    '
    ' Read/Write For Shift File (Linked List <-> List of records in file)
    '
    '
    ' Writing to shift file
    ' This function writes all the data from the linked list to the shift persistent file.
    Public Function shiftWrite()
        Try
            ' Open file for writing
            FileOpen(1, shiftFile, OpenMode.Output)

            ' Create a pointer to the root node used to traverse the linked list.
            Dim currentNode As ShiftNode = DataStructures.ShiftLL._root

            ' Loop over the linked list and write each node to the file.
            While currentNode IsNot Nothing
                ' Write the record to the file.
                WriteLine(1,
                          currentNode.shiftData.shiftID,
                          currentNode.shiftData.startTime, currentNode.shiftData.endTime,
                          currentNode.shiftData.isTaken, currentNode.shiftData.staffUserName)

                ' Move to the next node in the linked list.
                currentNode = currentNode.nextShift
            End While

            ' Close the file and return true if process was successful.
            FileClose(1)
            Return True
        Catch ex As Exception
            'If an error occurs close the file and return false.
            FileClose(1)
            MsgBox("Error Writing to the shift file. Please Retry process then restart system.")
            Return False
        End Try
    End Function
    '
    ' Reading from shift file
    ' This function reads from the shift file into the linked list data structure. Returns True if process was successful.
    Public Function shiftRead()
        Try
            ' Open file for reading
            FileOpen(1, shiftFile, OpenMode.Input)

            ' Create a new shift to store a record from the file
            Dim tmpShift As Shift

            ' Create a new list with the first record
            If Not EOF(1) Then
                ' Read in the data for one record from the file
                Input(1, tmpShift.shiftID)
                Input(1, tmpShift.startTime) : Input(1, tmpShift.endTime)
                Input(1, tmpShift.isTaken) : Input(1, tmpShift.staffUserName)

                ' Create a new linked list with the first record
                DataStructures.ShiftLL.newList(tmpShift)
            End If


            ' Try to read from file and add to linked list
            While Not EOF(1)
                ' Read in the data for one record from the file
                Input(1, tmpShift.shiftID)
                Input(1, tmpShift.startTime) : Input(1, tmpShift.endTime)
                Input(1, tmpShift.isTaken) : Input(1, tmpShift.staffUserName)

                ' Add the shift to the linked list
                DataStructures.ShiftLL.append(tmpShift)
            End While

            ' Close the file and return true if process was successful.
            FileClose(1)
            Return True
        Catch ex As Exception
            ' If an error occurs close the file and return false
            FileClose(1)
            MsgBox("Error Reading Shift File: Please restart Program." & " " & ex.ToString())
            Return False
        End Try
    End Function
    '
    ' Read/Write For Notification File (Binary Tree <-> List of records in file)
    '
    '
    ' Reading from notification file
    ' This function reads from the notification file into the binary tree data structure. Returns True if process was successful.
    Public Function notificationRead() As Boolean
        ' Linearly read all records from file and create a new node out of them then add node to Hash Table.
        ' Create a new notification to store the data from the file
        Dim tmpNotification As Notification

        ' Try to read from file and add to binary tree
        Try
            ' Open file for reading.
            FileOpen(1, notificationFile, OpenMode.Input)

            ' Create a new binary tree with the first record
            If Not EOF(1) Then
                ' Read in the data for one record from the file
                Input(1, tmpNotification.notificationID) : Input(1, tmpNotification.content) ' Read notificationID and content from file.
                Input(1, tmpNotification.sender) : Input(1, tmpNotification.sentDate)       ' Read sender and sentDate from file.

                ' Create a new binary tree with the first record
                DataStructures.NotificationTree.newTree(tmpNotification)
            End If

            ' While not end of file read in all the data for one record and add to binary tree
            While Not EOF(1)
                Input(1, tmpNotification.notificationID) : Input(1, tmpNotification.content) ' Read notificationID and content from file.
                Input(1, tmpNotification.sender) : Input(1, tmpNotification.sentDate)       ' Read sender and sentDate from file.

                ' Add the notification to the binary tree
                DataStructures.NotificationTree.add(tmpNotification)
            End While
            FileClose(1)    ' Close the file
            Return True     ' Return True if process was successful
        Catch ex As Exception
            ' If an error occurs close the file and return false
            FileClose(1)
            MsgBox("Error Accessing Notification Data, try restarting program. " & ex.ToString())  ' Display error message to user
            Return False
        End Try
    End Function
    '
    ' Writing to notification file
    ' This function writes all the data from the binary tree to the notification persistent file.
    Public Function notificationWrite() As Boolean
        Try
            ' Open file for writing
            FileOpen(1, notificationFile, OpenMode.Output)

            ' Get a list of all the notifications in the tree.
            Dim preOrderedIDs As List(Of Integer) = DataStructures.NotificationTree.preOrderTraversal(DataStructures.NotificationTree._root, preOrderedIDs)
            ' Create a new notification to store the data from the file
            Dim tmpNotification As Notification     ' Create a new notification to store the data of a notification to be written to a file.

            ' Loop over the list of all the notifications.
            For Each id In preOrderedIDs
                ' Find the notification in the tree.
                tmpNotification = DataStructures.NotificationTree.find(DataStructures.NotificationTree._root, id)

                ' Check node is not nothing.
                If tmpNotification.notificationID = Nothing Then Return False

                ' Write node to file.
                WriteLine(1, tmpNotification.notificationID,
                          tmpNotification.content,
                          tmpNotification.sender, tmpNotification.sentDate)
            Next
            ' Close the file and return true if process was successful.
            FileClose(1)
            Return True
        Catch ex As Exception
            ' If an error occurs close the file and return false.
            FileClose(1)
            MsgBox("Error Writing to the notification file. Please Retry process then restart system.") ' Display error message to user.
            Return False
        End Try
    End Function
    '
    ' Read/Write For Notification Instance File (Linked List <-> List of records in file)
    '
    '
    ' Reading from notification instance file
    ' This function reads from the notification instance file into the linked list data structure. Returns True if process was successful.
    Public Function notificationInstanceRead() As Boolean
        Try
            ' Open file for reading
            FileOpen(1, notificationInstanceFile, OpenMode.Input)

            ' Create a new notification instance to store a record from the file
            Dim tmpNotificationInstance As NotificationInstance

            ' Create a new list with the first record
            If Not EOF(1) Then
                ' Read in the data for one record from the file
                Input(1, tmpNotificationInstance.notificationInstanceID)
                Input(1, tmpNotificationInstance.notificationID)
                Input(1, tmpNotificationInstance.recipient)

                ' Create a new linked list with the first record
                DataStructures.NotificationInstanceLL.newList(tmpNotificationInstance)
            End If

            ' Try to read from file and add to linked list
            ' Loop over the file and read in all the data for one record and add to the linked list
            While Not EOF(1)
                ' Read in the data for one record from the file
                Input(1, tmpNotificationInstance.notificationInstanceID)
                Input(1, tmpNotificationInstance.notificationID)
                Input(1, tmpNotificationInstance.recipient)

                ' Add the notification instance to the linked list
                DataStructures.NotificationInstanceLL.append(tmpNotificationInstance)
            End While

            ' Close the file and return true if process was successful.
            FileClose(1)
            Return True
        Catch ex As Exception
            ' If an error occurs close the file and return false
            FileClose(1)
            MsgBox("Error Accessing Notification Instance Data, try restarting program. " & ex.ToString())  ' Display error message to user
            Return False
        End Try
    End Function
    '
    ' Writing to notification instance file
    ' This function writes all the data from the linked list to the notification instance persistent file.
    Public Function notificationInstanceWrite() As Boolean
        Try
            ' Open file for writing
            FileOpen(1, notificationInstanceFile, OpenMode.Output)

            ' Create a pointer to the root node used to traverse the linked list.
            Dim currentNode As NotificationInstanceNode = DataStructures.NotificationInstanceLL._root

            ' Loop over the linked list and write each node to the file.
            While currentNode IsNot Nothing
                ' Write the record to the file.
                WriteLine(1,
                          currentNode.notificationInstanceData.notificationInstanceID,
                          currentNode.notificationInstanceData.notificationID,
                          currentNode.notificationInstanceData.recipient)

                ' Move to the next node in the linked list.
                currentNode = currentNode.nextNotificationInstance
            End While

            ' Close the file and return true if process was successful.
            FileClose(1)
            Return True
        Catch ex As Exception
            ' If an error occurs close the file and return false.
            FileClose(1)
            MsgBox("Error Writing to the shift file. Please Retry process then restart system.")
            Return False
        End Try
    End Function
    '
    ' Read All Data
    ' This function reads all the data from the persistent files into the data structures. Returns True if process was successful.
    Public Function readAllData() As Boolean
        ' Read all data from files into data structures
        If Not staffRead() Then Return False
        If Not shiftRead() Then Return False
        If Not notificationRead() Then Return False
        If Not notificationInstanceRead() Then Return False
        Return True
    End Function
    '
    ' Write All Data
    ' This function writes all the data from the data structures to the persistent files. Returns True if process was successful.
    Public Function writeAllData() As Boolean
        ' Write all data from data structures to files
        If Not staffWrite() Then Return False
        If Not shiftWrite() Then Return False
        If Not notificationWrite() Then Return False
        If Not notificationInstanceWrite() Then Return False
        Return True
    End Function
End Module