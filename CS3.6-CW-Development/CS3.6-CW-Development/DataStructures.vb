' Variables, methods, function = camelCase
' Classes Structures = PascalCase
' Files and objects = snake_case
'DS assumes data has all been validated
Imports Validation
Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports System.Text.RegularExpressions

Module DataStructures
    '
    ' Declaring all the Structures to be used throughout the system to store data.
    '
    ' Declaring the strucutre to store the data related to a staff member.
    Structure StaffMember
        Dim staffID As Integer      ' Unique ID for each staff member.
        Dim firstName As String     ' Stores the first name of a staff member.
        Dim lastName As String      ' Stores the last name of the staff member.
        Dim isManager As Boolean    ' Boolean stating wether the user is a manager or staff member.
        Dim isFullTime As Boolean   ' Boolean Stating whether the user is a full time staff member.
        Dim userName As String      ' Stores the Auto-generated username based of other fields.
        Dim password As String      ' Stored the encrypted password for a user.
    End Structure

    ' Declaring the structure (class) that turns the staff details into a node.
    Public Class StaffMemberNode
        Public staffMemberData As StaffMember       ' Stores the staff member's data.
        Public nextStaffMember As StaffMemberNode   ' Used as a pointer to next staff member in a linked list (if a collision occurs in the hash table).
        Public lastStaffMember As StaffMemberNode   ' Used as a pointer to the last staff member in a linked list,
    End Class

    ' Declaring the structure to store the shift data for a particular node.
    Public Structure Shift
        Dim shiftID As Integer          ' Unique ID for a shift.
        Dim startTime As DateTime       ' Defines the start time of the shift.
        Dim endTime As DateTime         ' Defines the end time of the shift.
        Dim isTaken As Boolean          ' Shows if a shift has been taken by a user or not.
        Dim staffUserName As String     ' Stores the staffUserName of the user that has taken the shift.
    End Structure

    ' Declaring the structure (class) that turns the shift details into a node.
    Public Class ShiftNode
        Public shiftData As Shift       ' Stores the data for a shift for the particular node.
        Public nextShift As ShiftNode   ' Pointer to the next shift in the linked list.
        Public lastShift As ShiftNode   ' Pointer to the last shift in the linked list.
    End Class

    ' Declaring the structure that stores the notification Data.
    Structure Notification
        Dim notificationID As Integer   ' Unique ID for each notification.
        Dim content As String           ' Stores the content for the notification.
        Dim sender As String            ' Stores the staffUserName of the staff member that sent the notification.
        Dim sentDate As DateTime        ' Stores the date & time of when the notification was sent.
    End Structure

    ' Declaring the structure (class) that turns the notication data into a node.
    Public Class NotificationNode
        Public notificationData As Notification     ' Stores the data for a particular notification.
        Public leftPointer As NotificationNode      ' Pointer to the left sub-tree (points to left node).
        Public rightPointer As NotificationNode     ' Pointer to the right sub-tre (points to right node).
    End Class

    ' Declaring the structure that stores the data required to make an instance of a notification.
    Structure NotificationInstance
        Dim notificationInstanceID As Integer       ' Unique ID for each instance of a notification
        Dim notificationID As Integer               ' Stores the ID of the notification so the notification data can be retrieved.
        Dim recipient As String                     ' Stores the staffUserName of the recipient of the notification.
    End Structure

    ' Declaring the structure (class) that turns the notification instance data into a node.
    Public Class NotificationInstanceNode
        Public notificationInstanceData As NotificationInstance         ' Stores the data for a particular notification instance.
        Public nextNotificationInstance As NotificationInstanceNode     ' Pointer to the next notification instance in the linked list.
        Public lastNotificationInstance As NotificationInstanceNode     ' Pointer to the next notification instance in the linked list.
    End Class

    ' Declaring the structre used in the 2D array to create a shift pattern that can be used to automatically assign shifts to user.
    Structure ShiftPattern
        Dim startTime As DateTime           ' Stores the start Time of the of the new shift to be created.
        Dim endTime As DateTime             ' Stores the end time of the new shift to be created.
        Dim fullTimeStaffNO As Integer      ' Stores the number of the full time staff member that needs to be assigned to this shift.
    End Structure

    '
    ' All class definitions for required datastructures in the system.
    '
    '
    ' Class Design for all functions related to storing staff member details.
    ' Stored in a hash table using linear probing for collisions (ie hash table (array) with linked lists in cells).
    ' Hash Table will store users based of a first name
    ' Add, Find, Change, Delete
    Public Class StaffMembersHashTableDesign
        Public _hashTable(100) As StaffMemberNode     ' Creates a hash table with 100 cells (0-99) to store staff members.
        Dim _size As Integer = 100                 ' Stores the size of the hash table (used to calculate the hash value).
        '
        ' FirstName from UserName
        ' Function to find the first name of a staff member given the staff member's username.
        Public Function firstFromUserName(ByVal userName As String) As String
            Dim firstName As String                                     ' Stores the first name of the staff member.
            Dim secondCapIndex As Integer                               ' Stores the index of the second capital letter in the username.
            Dim allFoundCaps As MatchCollection                         ' Stores all the capital letters in the username.

            allFoundCaps = Regex.Matches(userName, "[A-Z]")             ' Finds all the capital letters in the username.

            secondCapIndex = userName.IndexOf(allFoundCaps(1).Value)    ' Finds the index of the second capital letter in the username.
            firstName = userName.Substring(0, secondCapIndex)           ' Extracts the first name from the username.
            Return firstName
        End Function

        '
        ' Hash Function
        ' Function to calculate the hash value for a staff member based of the first name.
        ' Simple hash adding up all ascii codes and modding by size of hash table.
        Private Function hashValue(ByVal firstName As String) As Integer
            Dim total As Integer = 0     ' Stores the total of the ASCII values of the characters in the first name.
            Dim hash As Integer          ' Stores the hash value to be returned to the calling function.

            ' Loop over the whole string to calculate the total of the ASCII values of the characters in the string.
            For i = 0 To firstName.Length - 1
                total += Asc(firstName(i))  ' Adds the ASCII value of the current character to the total.
            Next

            hash = total Mod _size          ' Calculates the hash value using the total and the size of the hash table.
            Return hash                     ' Returns the hash value to the calling function.
        End Function
        '
        ' Adding a new staff member
        ' Function to add a new staff member to the hash table.
        '
        Public Sub addStaffMember(ByVal staffMember As StaffMember)
            Dim hash As Integer = hashValue(staffMember.firstName)  ' Calculates the hash value for the staff member to be added.
            Dim currentNode As StaffMemberNode = _hashTable(hash)    ' Creates a pointer to the current node in the linked list.

            ' Checks if the current cell in the hash table is empty (ie no staff members with a name that hashed to the same location).
            If currentNode Is Nothing Then
                _hashTable(hash) = New StaffMemberNode()  ' Creates a new node in the hash table.
                _hashTable(hash).staffMemberData = staffMember  ' Sets the data in the new node to the staff member data.

                ' Write to file
                If FileHandler.staffWrite() = False Then MsgBox("Error: Writing to file. Staff Member not added") : Return
            Else
                ' Loop over the linked list to find the end of the list.
                While currentNode.nextStaffMember IsNot Nothing
                    currentNode = currentNode.nextStaffMember  ' Sets the current node to the next node in the linked list.
                End While

                currentNode.nextStaffMember = New StaffMemberNode()  ' Creates a new node at the end of the linked list.
                currentNode.nextStaffMember.staffMemberData = staffMember  ' Sets the data in the new node to the staff member data.

                ' Write to file
                If FileHandler.staffWrite() = False Then MsgBox("Error: Writing to file. Staff Member not added") : Return

            End If
        End Sub
        '
        ' Finding a staff member.
        ' Function to find a staff member in the hash table.
        '
        Public Function findStaffMember(ByVal staffUserName As String, ByVal isUserName As Boolean) As StaffMember

            If isUserName = True Then
                Dim staffFirstName As String = firstFromUserName(staffUserName)  ' Finds the first name of the staff member using the username.
                Dim hash As Integer = hashValue(staffFirstName)  ' Calculates the hash value for the staff member to be found.
                Dim currentNode As StaffMemberNode = _hashTable(hash)    ' Creates a pointer to the current node in the linked list.

                ' Checks if the current cell in the hash table is empty (ie no staff members with a name that hashed to the same location).
                If currentNode IsNot Nothing Then
                    ' Loop over the linked list to find the staff member.
                    While currentNode IsNot Nothing
                        ' Checks if the current node is the staff member being searched for.
                        If currentNode.staffMemberData.userName = staffUserName Then
                            Return currentNode.staffMemberData  ' Returns the staff member data to the calling function.
                        End If

                        currentNode = currentNode.nextStaffMember  ' Sets the current node to the next node in the linked list.
                    End While
                End If
            Else
                ' Check if its the only node in the LL if it is then return that user
                Dim hash As Integer = hashValue(staffUserName)  ' Calculates the hash value for the staff member to be found.
                Dim currentNode As StaffMemberNode = _hashTable(hash)    ' Creates a pointer to the current node in the linked list.
                If currentNode IsNot Nothing Then
                    If currentNode.staffMemberData.firstName = staffUserName And currentNode.nextStaffMember Is Nothing Then
                        Return currentNode.staffMemberData
                    End If

                    'Returns either way fix result bit
                    While currentNode IsNot Nothing
                        If currentNode.staffMemberData.firstName = staffUserName Then
                            Dim result As Integer = MsgBox("Is the user you are searching for :" & currentNode.staffMemberData.userName, MsgBoxStyle.YesNo)

                            If result = 6 Then
                                Return currentNode.staffMemberData
                            End If
                        End If
                        currentNode = currentNode.nextStaffMember
                    End While
                End If

                ' If not then loop through LL and check if the name of the next node is the same as the input name and if it is put a yesno box to user to select the correct one once user says yes return that user.
            End If



            MsgBox("Error: Staff Member Does not exist")  ' Informs the user that the staff member was not found in the hash table.
            Return Nothing  ' Returns nothing to the calling function if the staff member was not found in the hash table.
        End Function
        '
        ' Updating a staff member.
        ' Function to update a staff member in the hash table.
        ' Error 1: By changing the username (firstname) it means that first name does not hash to the same location anymore, therefore to update, the old node should be deleted and new one added.
        Public Function updateStaffMember(ByVal oldUserName As String, ByVal newStaffMember As StaffMember)

            ' Remove the old node
            removeStaffMember(oldUserName)

            'Add new node
            addStaffMember(newStaffMember)

            Return True
        End Function
        '
        ' Removing a staffmember from the hash table (deleting).
        ' Function to remove a staff member from the hash table.
        '
        Public Function removeStaffMember(ByVal staffUserName As String) As Boolean
            Dim staffFirstName As String = firstFromUserName(staffUserName)  ' Finds the first name of the staff member using the username.
            Dim hash As Integer = hashValue(staffFirstName)  ' Calculates the hash value for the staff member to be removed.
            Dim currentNode As StaffMemberNode = _hashTable(hash)    ' Creates a pointer to the current node in the linked list.

            ' Checks if the current cell in the hash table is empty (ie no staff members with a name that hashed to the same location).
            If currentNode IsNot Nothing Then
                ' Checks if the first node in the linked list is the staff member to be removed.
                If currentNode.staffMemberData.userName = staffUserName Then
                    _hashTable(hash) = currentNode.nextStaffMember  ' Sets the next node in the linked list to be the first node in the linked list.
                    'MsgBox("User Removed")  ' Informs the user that the staff member has been removed.
                    ' Write data to file
                    If FileHandler.staffWrite() = False Then MsgBox("Error: Writing to file. Staff Member not removed") : Return False
                    Return True

                Else
                    ' Loop over the linked list to find the staff member to be removed.
                    While currentNode.nextStaffMember IsNot Nothing
                        ' Checks if the next node in the linked list is the staff member to be removed.
                        If currentNode.nextStaffMember.staffMemberData.userName = staffUserName Then
                            currentNode.nextStaffMember = currentNode.nextStaffMember.nextStaffMember  ' Sets the next node in the linked list to the node after the next node.
                            'MsgBox("User Removed")  ' Informs the user that the staff member has been removed.
                            If FileHandler.staffWrite() = False Then MsgBox("Error: Writing to file. Staff Member not removed") : Return False
                            Return True
                        End If

                        currentNode = currentNode.nextStaffMember  ' Sets the current node to the next node in the linked list.
                    End While
                End If
            Else
                MsgBox("Error: Staff Member Does not exist - User already Removed")  ' Informs the user that the staff member was not found in the hash table.
                Return False
            End If
            MsgBox("Error: User Not removed - Retry process or reset system")  ' Informs the user that the staff member was not removed from the hash table.
            Return False
        End Function
        '
        ' Function to find a unique ID.
        '
        Public Function findUniqueID() As Integer
            Dim uniqueID As Integer = 0  ' Stores the unique ID to be returned to the calling function.

            ' Loop over the whole hash table to find the highest unique ID.
            For i = 0 To _hashTable.Length - 1
                Dim currentNode As StaffMemberNode = _hashTable(i)  ' Creates a pointer to the current node in the linked list.

                ' Checks if the current cell in the hash table is empty (ie no staff members with a name that hashed to the same location).
                If currentNode IsNot Nothing Then
                    ' Loop over the linked list to find the staff member with the highest unique ID.
                    While currentNode IsNot Nothing
                        ' Checks if the current node has a higher unique ID then the current highest unique ID.
                        If currentNode.staffMemberData.staffID > uniqueID Then
                            uniqueID = currentNode.staffMemberData.staffID  ' Sets the current highest unique ID to the unique ID of the current node.
                        End If

                        currentNode = currentNode.nextStaffMember  ' Sets the current node to the next node in the linked list.
                    End While
                End If
            Next

            uniqueID += 1  ' Increments the unique ID by 1 to ensure the next unique ID is unique.
            Return uniqueID  ' Returns the unique ID to the calling function.
        End Function
    End Class

    '
    ' Class Design for all functions related to storing shift data in a linked list.
    '
    Public Class ShiftsLinkedListDesign
        Public _root As ShiftNode       ' Stores the root of the linked list.
        '
        ' Function that creates a new node given shift data
        '
        Private Function getNode(ByVal data As Shift) As ShiftNode
            Dim node As New ShiftNode()     ' Creates a new node.
            node.shiftData = data           ' Sets the node data as the data passed into function.
            Return node                     ' returns the node back to calling function
        End Function
        '
        ' Procedure used to create a new linked list passing in the data to be stored as the root.
        '
        Sub newList(ByVal shiftData As Shift)
            ' Calls get node to create a node from the shift data.
            ' Then sets the root of the linked list to the newly created node.
            _root = getNode(shiftData)
        End Sub
        '
        ' Procedure that adds a new node to the end of the linked list.
        ' instead of append add should be used to ensure node is added in order in linked list working with nextavailableID.
        Public Sub append(ByVal newShiftData As Shift)
            ' Check list is not empty - If list is empty create a new list with the data.
            If _root Is Nothing Then
                newList(newShiftData)               ' Create a new list using the data as the LL is empty.
                Return                              ' Return to prevent any further processing which could cause a bug.
            End If

            Dim currentNode As ShiftNode = _root            ' Sets the currentNode as the root of the LL.
            Dim nextNode As ShiftNode = _root.nextShift     ' Creates a pointer to the next node in the LL.

            ' Loop over the whole LL to find either the end of the LL.
            ' Check if the next node to be checked is empty (if it is end of LL has been found).
            While nextNode IsNot Nothing And newShiftData.shiftID > nextNode.shiftData.shiftID
                ' Process to repeat process using next node.
                currentNode = nextNode          ' Sets the current node to move the process ine node along.
                nextNode = nextNode.nextShift   ' Sets the next node to the next node after the current node.
            End While

            ' Process for adding a new shift to end of linked list.
            ' Checks if an error has occured earlier in terms of shiftID generation (ensures no further error created with find etc).
            If currentNode.shiftData.shiftID = newShiftData.shiftID Then
                MsgBox("Error: Duplicate Data (Node not inserted) - Try action again.") ' Informs user of error and potential to fix error
            Else
                currentNode.nextShift = getNode(newShiftData)   ' Sets the next shift equal to the creation of a new node using the data passed into procedure.
                nextNode = currentNode.nextShift                ' Sets the next node to the new shift being created so pointers can be setup.
                nextNode.lastShift = currentNode                ' Stes the lastShift pointer to the shift just before the new shift being added to the LL.
                ' No need to set next shift as pointer should be left as nothing as is the end of the LL.
            End If
        End Sub
        '
        ' Procedure that adds a new node to the linked list (based of ID to ensure the LL is kept in order).
        ' **INCOMPLETE**? TEST
        Public Sub add(ByVal newShiftData As Shift)
            ' Check list is not empty - If list is empty create a new list with the data.
            If _root Is Nothing Then
                newList(newShiftData)               ' Create a new list using the data as the LL is empty.
                Return                              ' Return to prevent any further processing which could cause a bug.
            End If

            Dim currentNode As ShiftNode = _root            ' Sets the currentNode as the root of the LL.
            Dim nextNode As ShiftNode = _root.nextShift     ' Creates a pointer to the next node in the LL.

            ' Loop over the whole LL to find either the end of the LL or the next node has a higher id then the cureent nodeID.
            ' Check if the next node to be checked is empty (if it is end of LL has been found).
            While nextNode IsNot Nothing Or Not (newShiftData.shiftID < nextNode.shiftData.shiftID And newShiftData.shiftID > currentNode.shiftData.shiftID)
                ' Process to repeat process using next node.
                currentNode = nextNode          ' Sets the current node to move the process ine node along.
                nextNode = nextNode.nextShift   ' Sets the next node to the next node after the current node.
            End While

            ' Process for adding a new shift to end of linked list.
            ' Checks if an error has occured earlier in terms of shiftID generation (ensures no further error created with find etc).
            If currentNode.shiftData.shiftID = newShiftData.shiftID Then
                MsgBox("Error: Duplicate Data (Node not inserted) - Try action again.") ' Informs user of error and potential to fix error
            ElseIf nextNode Is Nothing Then
                ' Node is being added to the end of the LL.
                currentNode.nextShift = getNode(newShiftData)   ' Sets the next shift equal to the creation of a new node using the data passed into procedure.
                nextNode = currentNode.nextShift                ' Sets the next node to the new shift being created so pointers can be setup.
                nextNode.lastShift = currentNode                ' Stes the lastShift pointer to the shift just before the new shift being added to the LL.
                ' No need to set next shift as pointer should be left as nothing as is the end of the LL.
            Else
                ' Node is being inserted between 2 nodes.
                currentNode.nextShift = getNode(newShiftData)
                currentNode.nextShift.lastShift = currentNode
                nextNode.lastShift = currentNode.nextShift
            End If
        End Sub
        '
        ' Update Shift Data - This function update the data attached to a shift node. And returns if the operation was successfull to the calling subroutine.
        '
        Public Function updateShiftData(ByVal oldData As Shift, ByVal newData As Shift) As Boolean
            Dim currentNode As ShiftNode = _root                            'Sets a pointer to the current node to search for the node to be updated

            While currentNode IsNot Nothing                                 ' Loop through the LL to find the node that needs to be updated
                If currentNode.shiftData.shiftID = oldData.shiftID Then     ' Checks to see if the current node matches the old data (ie if the node being searched has been found).
                    currentNode.shiftData = newData                         ' Sets the data in the shift node to the new data that was passed into the function.
                    Return True                                             ' Returns the result ofoperation back to calling subroutine.
                End If
                currentNode = currentNode.nextShift                         ' Sets the current node to the next node in the LL to ensure whole list is searched.
            End While

            Return False                                                    ' Returns the result ofoperation back to calling subroutine.
        End Function
        '
        ' Remove Shift - This function will remove a shift node given the shiftID.
        '
        Public Sub remove(ByVal nodeID As Integer)
            Dim currentNode As ShiftNode = _root                                    ' Sets a pointer to the current node to search for the node to be deleted.

            While _                                                                 ' Loops through the LL looking for the node to be removed.
                currentNode IsNot Nothing _                                         ' Check that the end of the LL has not been found (ie shift does not exist (and problem elsewhere)
                And nodeID <> currentNode.shiftData.shiftID                         ' Checks if the current node is the one being searched for - loop condition

                currentNode = currentNode.nextShift                                 ' Sets the pointer to the next node to ensure lops through whole LL
            End While
            ' Test Process
            If nodeID = currentNode.shiftData.shiftID And                           ' Checks if the found node actually matches the search data.
               currentNode.shiftData.shiftID <> _root.shiftData.shiftID And         ' Checks if the node is the root of the LL.
               currentNode.nextShift IsNot Nothing Then                             ' Checks if the node is at the end of the LL.
                currentNode.lastShift.nextShift = currentNode.nextShift             ' Sets the pointer for the shift before it to point at the shift after the current node.
                currentNode.nextShift.lastShift = currentNode.lastShift             ' Sets the pointer for the shift after it to point to the shift before the current node.
                ' This means that there is nothing pointing to this node and when the procedure finished running the node data will be lost and collected by garbage collection.
            ElseIf nodeID = _root.shiftData.shiftID Then                            ' Checks to see if the node is the root (could be put before loop to prevent unnecessary processing)
                _root = currentNode.nextShift                                       ' Sets the root to be the next node in the LL.
            ElseIf currentNode.nextShift Is Nothing Then                            ' Checks to see if th enode is the last in the LL.
                currentNode.lastShift.nextShift = Nothing                           ' Sets the one pointer to the node to nothing.
            Else                                                                    ' Null case
                MsgBox("Error: Shift Not Deleted - Try restarting program and attempting to use feature again.") ' Error caused elsewehre ie nodeID given is not valid.
            End If
        End Sub
        '
        ' Function which finds a node given a shiftID and returns the shift data if found (else returns nothing)
        ' Ensure caller function validates that something has returned.
        '
        Public Function find(ByVal findData As Integer) As Shift
            Dim currentNode As ShiftNode = _root    ' Sets the currentNode as the root of the LL.

            ' Looping over the LL to try and find the shift. 
            While currentNode IsNot Nothing
                ' Looks at the current node and compares the shiftId to the ID of the shift being searched for.
                If currentNode.shiftData.shiftID = findData Then
                    ' Returns the shiftData of the shift being looked for if the IDs match.
                    Return currentNode.shiftData
                End If

                currentNode = currentNode.nextShift     ' Sets the current node to the next node in the LL to prevent infinite loop and ensure whole LL is checked.
            End While

            ' Either LL is empty or the node is not in the LL.
            ' Let calling function deal with error message as calling function may expect Nothing meaning no error has been created.
            Return Nothing
        End Function
        '
        ' Next Available ShiftID 
        ' This function will find the next available ID. This will be used when crating a new node.
        ' This function will work by traversing the LL and checking if the next nodes id has a difference > 1 and if it does then there is a gap and the node can have the id of i pluss the last as the gap will be minimum 2.
        Public Function nextAvailableID() As Integer
            Dim currentNode As ShiftNode = _root                ' Set the currentNode pointer to the root of the LL.
            Dim nextNode As ShiftNode = _root.nextShift         ' Pointer to the next node in the LL (ensures no error thrown from difference calculation)
            Dim total As Integer                                ' Create a variable for the total ID (if LL is already ordered perfectly).
            Dim difference As Integer                           ' Stores the difference betweeen 2 node IDs

            ' Sets the total to the ID of the first node as long as it is not nothing
            If _root IsNot Nothing Then
                total = _root.shiftData.shiftID
            End If

            ' Loop over the whole LL.
            While nextNode IsNot Nothing
                ' Checks if the next node ID is more then 2 away from the current node. If it is then there is a gap in the IDs (and therefore an available id)
                difference = nextNode.shiftData.shiftID - currentNode.shiftData.shiftID 'What if nextShift is nothing?
                If difference >= 2 Then
                    ' If there is a gap then return the currentID + 1 (ie the new ID will fill that gap_
                    Return currentNode.shiftData.shiftID + 1
                End If

                ' Keep a track of the current highest nodeID incase if the end of the LL is reached.
                total = currentNode.shiftData.shiftID
                ' Move onto the next node.
                currentNode = currentNode.nextShift
                nextNode = nextNode.nextShift
            End While

            ' If the end of the LL is reached and the function as not returned it means there are no gaps and the new node should be added at the end of the LL.
            Return total + 1
        End Function
        '
        ' Assign Shift
        '  Ensure startTime and endTime has been validated before being passed in.....
        Public Function assignShift(ByVal startTime As String, ByVal endTime As String, ByVal shiftID As String, ByVal staffUserName As String) As Boolean
            Dim startTimeValid As Boolean = True    ' Stores the result of the validation of the start time.
            Dim endTimeValid As Boolean = True      ' Stores the result of the validation of the end time.

            ' Check the shiftID is of valid format
            If Validation.TypeInteger(shiftID) = False Then MsgBox("No shift Selected!") : Return False
            Dim oldData As Shift = find(shiftID)

            ' Validate oldData is not nothing
            If oldData.shiftID = Nothing Then MsgBox("Error: Shift not found") : Return False

            ' Validate TimeFormat
            If Validation.correctTimeFormat(startTime) = False Then startTimeValid = False
            If Validation.correctTimeFormat(endTime) = False Then endTimeValid = False

            ' If there are no time alterations for the shift.
            If startTime = "HH:mm" And endTime = "HH:mm" And shiftID <> "<ShiftID>" And staffUserName <> "<StaffUserName>" Then
                ' Updating the shift data if there are no time alterations.
                Dim newData As Shift = oldData              ' Creates a new shift to store the new data.
                newData.isTaken = True                      ' Sets the new shift to be taken.
                newData.staffUserName = staffUserName       ' Sets the staff member that has taken the shift.

                updateShiftData(oldData, newData)           ' Updates the shift data in the linked list.

            ElseIf startTimeValid And endTimeValid And shiftID <> "<ShiftID>" And staffUserName <> "<StaffUserName" Then
                ' Code for updating a shift if there are time alterations
                Dim newStartTime As DateTime                ' Stores the new start time of the shift.
                Dim temp As String                          ' Stores the temporary string to be used to manipulate the time.
                Dim newEndTime As DateTime                  ' Stores the new end time of the shift.

                newStartTime = oldData.startTime            ' Sets the new start time to be the same as the old start time.
                newEndTime = oldData.endTime                ' Sets the new end time to be the same as the old end time.

                ' Convert time to readable format
                temp = newStartTime.ToString()
                temp = temp.Substring(0, 11)
                temp = "#" & temp & " " & startTime & ":00" & "#"
                newStartTime = temp

                ' Convert time to readable format
                temp = newEndTime.ToString()
                temp = temp.Substring(0, 11)
                temp = "#" & temp & " " & endTime & ":00" & "#"
                newEndTime = temp

                ' Check if the new times are within the old shift time bounds
                If oldData.startTime > newStartTime Or oldData.endTime < newEndTime Then
                    ' If the new times are not within the old shift time bounds then inform the user and return false.
                    MsgBox("New Times are not in old shift time bounds")
                    Return False
                End If

                ' Updating the original shift times
                Dim newData As Shift = oldData
                newData.isTaken = True
                newData.staffUserName = staffUserName
                newData.startTime = newStartTime
                newData.endTime = newEndTime

                updateShiftData(oldData, newData)

                ' Adding new shifts if the times have been altered. Early Shift
                If oldData.startTime <> newStartTime Then
                    Dim newEarlyShift As Shift
                    newEarlyShift.shiftID = nextAvailableID()       ' Sets the shiftID of the new shift to be the next available ID.
                    newEarlyShift.startTime = oldData.startTime     ' Sets the start time of the new shift to be the same as the old start time.
                    newEarlyShift.endTime = newStartTime            ' Sets the end time of the new shift to be the new start time.
                    add(newEarlyShift)                              ' Adds the new shift to the linked list.
                End If

                ' Adding new shifts if the times have been altered. Late Shift
                If oldData.endTime <> newEndTime Then
                    Dim newLateShift As Shift
                    newLateShift.shiftID = nextAvailableID()
                    newLateShift.startTime = newEndTime
                    newLateShift.endTime = oldData.endTime

                    add(newLateShift)
                End If

                ' If the shift times have been changed then the persistent data needs to be updated.
                If FileHandler.shiftWrite() = False Then MsgBox("Error: Writing to file. Shift not added") : If FileHandler.shiftRead() = False Then MsgBox("Fatel Error: Please Restart Program") : Return False

                MsgBox("Shift Successfully assigned to user") ' Informs the user that the shift has been successfully assigned to the user.
                ' Return result to calling function
                Return True
            Else
                ' If the start time and end time are not valid then inform the user and return false.
                MsgBox("Error: If you are trying to add custom times you must input a new start & end time. If you wish to keep the same end time then input that end time.")
                Return False
            End If
        End Function
        '
        ' findstaffshifts
        ' A function that finds all the shifts a staff member has given a staffusername and returns a list of shiftIDs
        Public Function findStaffShifts(ByVal inputUserName As Integer) As List(Of Integer)
            Dim returnArr As New List(Of Integer)   ' Creates a new list which will contain the list of shiftIDs to be returned to calling subroutine

            Dim currentNode As ShiftNode = _root    ' Creates a pointer to shift node which will be used to traverse the LL to find all the shifts which a staff member has.

            ' Loop over the LL until the end of the LL has been found.
            While Not currentNode Is Nothing
                ' Checks if the shift has been taken and if the shift has been taken by the user that it is being checked for
                If currentNode.shiftData.staffUserName = inputUserName And currentNode.shiftData.isTaken = True Then
                    returnArr.Add(currentNode.shiftData.shiftID)    ' If the shift is taken by the user then add the shift to the return list.
                End If

                currentNode = currentNode.nextShift                 ' Move onto the next node.
            End While

            Return returnArr        ' Return all the user's shifts' to the calling subroutine.
        End Function
        '
        ' availableshifts
        ' Function that finds all the shifts that are available and returns a list of all the shiftIDs.
        Public Function availableShifts() As List(Of Integer)
            Dim returnArr As New List(Of Integer)       ' Creates a new list of integers to store shiftIDs to be returned to calling subroutine.
            Dim currentNode As ShiftNode = _root        ' Creates a pointer to the first node which will be used to traverse the linked list.

            ' Used to loop over the whole LL to check every node to see if the shift is taken 
            ' Checks if the currentNode is nothing as if it is then the end of the LL has been found.
            While currentNode IsNot Nothing
                If currentNode.shiftData.isTaken = False Then       ' Checks if the current node has been taken by a user.
                    returnArr.Add(currentNode.shiftData.shiftID)    ' If the current node has not been taken by a user then the shift is availabel and the shiftID is added to the returnL.
                End If
                currentNode = currentNode.nextShift         ' Sets the current node to the next node to prevent endless loop and to ensure whole LL is traversed.
            End While

            Return returnArr            ' Returns the array back to the calling subroutine to manipulate the data.
        End Function
        '
        ' User's suggested shift
        ' Function that finds shifts that are similiar to the shifts a staff member already has and the shift must be available.
        ' Ensure that if no shift is found then it skips it (counts as error but system not working perfectly is better then an error)
        Public Function usersSuggestedShifts() As List(Of Integer)
            Dim staffShifts As New List(Of Integer)                         ' Creates a new list of integers to store the shiftIDs of all the current shifts a user has.
            staffShifts = findStaffShifts(activeUser)     ' Finds all the shifts that a user owns and adds them to the list.
            Dim available As New List(Of Integer)                           ' Creates a new list of integers to store all the shifts that are currently available for a staff member to take.
            available = availableShifts()                                   ' Populates the available List with all the available shifts.

            Dim currentShift As Shift                                       ' Creates a new shift variable to store a particular shift's data so it can be manipulated.

            Dim days As New List(Of Integer)                                ' Creates a new list of integers to store the days of the week which a user has shifts on.
            Dim suggested As New List(Of Integer)                           ' Creates a new list of integers to store the shiftIDs of the shifts that will be suggested to the user.

            For i = 0 To staffShifts.Count - 1                              ' Loops over the staffShifts to obtain all the days which a user currently has shifts on.
                currentShift = find(staffShifts(i))                         ' Gets the current shift data so the day of the week can be accessed.
                If Not currentShift.staffUserName Is Nothing Then
                    If Not days.Contains(currentShift.startTime.DayOfWeek) Then ' Checks if the list already contains the day of the week of the shift.
                        days.Add(currentShift.startTime.DayOfWeek)              ' If it doesn't then the dat of the week is added to the list of integers.
                    End If
                End If
            Next

            For i = 0 To available.Count - 1                                ' Loops over the available shifts 
                currentShift = find(available(i))                           ' Finds the current shift data so the node data can be manipulated.
                If Not currentShift.staffUserName Is Nothing Then                      ' Ensures that find has returned something else it will just skip that shift as it is not vital and skipping a shift is better then whole system crashing.
                    If days.Contains(currentShift.startTime.DayOfWeek) Then     ' If the shift's day of the week is in the days list then there is an available shift on the same day as a shift the user already has
                        suggested.Add(currentShift.shiftID)                     ' So add shift to the suggested list which will be returned to the calling subroutine.
                    End If
                End If
            Next

            Return suggested                                                ' Return the list of shiftIDs of suggested shifts to the calling subroutine
        End Function
    End Class

    ' ** LEAVE TILL LAST IN DEVELLOPMENT CAN BE RUSHED AS LONG AS SHIFT SUBROUTINES ARE SUFFICIENTLY TESTED **


    '
    ' Class design for storing all subroutines related to storing and manipulating notification data
    ' Notification Binary Tree

    '
    ' Class design for storing all subroutines related to storng and manupulating notification instance data
    ' Notificatyion Instance linked list

    '
    ' New Class Instance Creation.
    '
    Public StaffHashTable As New StaffMembersHashTableDesign    ' Creates a new instance of the StaffMembersHashTableDesign class.
    Public ShiftLL As New ShiftsLinkedListDesign                ' Creates a new instance of the ShiftsLinkedListDesign class.

    ' Public variable to store the active user's username as it needs to be persistent throughout forms.
    Public activeUser As String
End Module
