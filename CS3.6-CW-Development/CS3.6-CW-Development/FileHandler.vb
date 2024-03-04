﻿Imports DataStructures


Module FileHandler
    ' This module is responsible for handling all of the reading and writing between the datastructures and the persistent data files.
    ' Declaring all filenames as constant strings to reduce bugs in code
    Const staffFile As String = "staff.txt"     ' FilePath for staff File storing all staff data.
    Const shiftFile As String = "shifts.txt"    ' FilePath for shift file storing all shift data.
    '
    ' Read/Write For Staff File (Hash Table <-> List of records in file)
    '
    '
    ' Reading from staff file
    ' Thie function reads from the staff file into the hashTable data structure. Returns True if process was successful.
    Public Function staffRead() As Boolean
        ' Linearly read all records from file and create a new node out of them then add node to Hash Table.
        ' Open file for reading.
        FileOpen(1, staffFile, OpenMode.Input)

        ' Create a new staff member to store the data from the file
        Dim tmpStaff As StaffMember

        ' Try to read from file and add to hash table
        Try
            ' While not end of file read in all the data for one record and add to hash table
            While Not EOF(1)
                Input(1, tmpStaff.staffID)                                      ' Read staffID from file.
                Input(1, tmpStaff.firstName) : Input(1, tmpStaff.lastName)      ' Read user's personal details from file.
                Input(1, tmpStaff.isManager) : Input(1, tmpStaff.fullTimeNO)    ' Read staff type from file.
                Input(1, tmpStaff.userName) : Input(1, tmpStaff.password)       ' Read user's loging details from file.

                ' Add the staff member to the hash table
                DataStructures.StaffHashTable.addStaffMember(tmpStaff)
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
        FileOpen(1, staffFile, OpenMode.Output)

        Try
            ' For each cell in HashTable linearly run through the LL and write each one
            For i = 0 To DataStructures.StaffHashTable._hashTable.Length - 1
                ' Create a new pointer to node to store the current staff member
                Dim currentNode As StaffMemberNode
                ' Set the current node to the first node in the linked list
                currentNode = StaffHashTable._hashTable(i)
                ' While the current node is not nothing write the data to the file
                While currentNode IsNot Nothing
                    ' Write one record at a time to file
                    WriteLine(1,
                              currentNode.staffMemberData.staffID,
                              currentNode.staffMemberData.firstName,
                              currentNode.staffMemberData.lastName,
                              currentNode.staffMemberData.fullTimeNO,
                              currentNode.staffMemberData.isManager,
                              currentNode.staffMemberData.userName,
                              currentNode.staffMemberData.password)

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
            MsgBox("Error Writing Staff Data, try restarting program. " & ex.ToString())  ' Display error message to user
            Return False
        End Try

    End Function

    Public Function shiftWrite()

    End Function

    Public Function shiftRead()

    End Function


End Module