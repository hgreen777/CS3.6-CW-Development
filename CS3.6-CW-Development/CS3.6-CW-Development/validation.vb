Imports System.Text.RegularExpressions

Module Validation
    ' Modul contains all validation functions used throughout the system to test user input.
    ' Important as it ensures the program will not fail and crash. - Functions should let calling function handle error messages.
    ' Functions stored in alphabetical order.
    '
    ' Character Validation
    ' Checks if the input contains any non alphabetical characters. If it does return false as the input fails validation.
    ' Reverse validation can be used to ensure a password is strong as checks if the input has numbers or special characters.
    Function CharacterValidation(str As String) As Boolean
        ' Declaring a regex pattern to match to the input string 
        Dim pattern As String = "[^a-zA-Z]" ' Creating a pattern which will detect all characters which are not in range a-z A-Z
        Dim reg As New Regex(pattern) ' Create a new regex (Regular Expression) based of the pattern)

        ' Checks if the input string matches the pattern (ie if there are any characters which are not a-Z)
        If reg.IsMatch(str) Then
            Return False    ' Returns false as the input contains special characters which is not allowed
        End If

        Return True         ' Returns True if the string has not failed validation
    End Function
    '
    ' Correct Time Format Validation
    ' This function checks if a string input is in the correct format to be a valid time so system does not fail if string is converted to datetime.
    Public Function correctTimeFormat(inp As String) As Boolean
        ' Checks if the input is not like the expected format ie a valid 24hr time. 
        If Not ((inp Like "[0-1]#:[0-5]#") Or (inp Like "2[0-3]:[0-5]#") Or (inp Like "[1-9]:[0-5]#")) Then
            Return False    ' Returns false if the inpu fails validation as the input is not in the correct format.
        End If

        Return True         ' Return true if the input passes validation as the input is in the correct format.
    End Function
    '
    ' Format Name
    ' Used to format a name to be in Title Case to ensure that the first letter is capitalized. 
    ' Used for searching a hash table.
    Function FormatName(ByRef name As String) As String
        ' Function assumes that input has been presense and character validated

        ' Set's the whole input string to lower case 
        name = name.ToLower()

        ' Error #7
        ' Strings are immutable so a new string must be created to be manipulated and returned to user
        Dim returnString As String

        ' Creates a string which takes the lowecase name and makes the first letter uppercase and
        ' then concatenates the rest of the string
        returnString = Chr(Asc(name(0)) - 32) & name.Substring(1)

        Return returnString ' Returns the result to calling function.
    End Function
    '
    ' Validate string is in username Format
    ' Ensure the input string is in a username format (FirstLastID) (ie HarrisonGreen0) String must contain exactly 2 capital letters and a number of x length at the end of the string.
    Public Function isUsernameFormat(ByVal inp As String) As Boolean
        ' Check if the input string has 2 capital letters.
        ' Check if the input string has a number at the end of the string
        ' Regex matches whether the input string as a character in range A-Z and then checks if there is a character in range 0-9 at the end of the (line) string.
        If Regex.Matches(inp, "[A-Z]").Count <> 2 Or Regex.Matches(inp, "[0-9]$").Count = 0 Then
            Return False ' Return False if the input string has failed validation
        End If
        ' Check if the first character is a capital letter.
        ' See CS3.7 Test #25
        If Not Char.IsUpper(inp(0)) Then
            Return False ' Return False if the input string has failed validation
        End If


        Return True ' Return True if the input string has passed validation
    End Function
    '
    ' String length check validation
    ' Checks the length of a string to an input length. (can be used for creating passwords to ensure they are strong passwords).
    Public Function lengthCheck(ByVal inp As String, ByVal length As Integer, ByVal checkMode As Integer)
        ' Check what kind of length check is needed using checkMode
        ' Check Mode 1 : Length of input < the length = pass
        ' Check Mode 2 : Length of input = the length = pass
        ' Check Mode 3 : Length of input > the length = pass

        ' Select path for checkMode 
        Select Case checkMode
            ' Case 1 : the length of input should be less then the length.
            Case 1
                ' Checks if the length of the input is less then the length.
                If inp.Length < length Then
                    Return True ' Return true as input has passed validation for this mode.
                End If
            Case 2
                ' Check if the length of th einut is equal to the length.
                If inp.Length = length Then
                    Return True ' Return true as input has passed validation for this mode.
                End If
            Case 3
                ' Check if the length of the input is greater then the length.
                If inp.Length > length Then
                    Return True ' Return true as input has passed validation for this mode.
                End If
        End Select

        Return False ' Return false as the input has failed validation for specific checkMode.
    End Function
    '
    ' Presence Check Validation
    ' This function is used to check if an input string is empty.
    Function PresenceValidation(str As String) As Boolean
        ' Checks if the input is not nothing
        If str Is Nothing Then
            Return False        ' String has failed validation so return false
        End If
        ' Replace any spaces with "" and if the string is empty then nothing is present except a space.
        If str.Replace(" ", "") = "" Then
            Return False        ' String ahs failed validation so return false.
        End If

        Return True             ' Return true as the string has passed validation.
    End Function

    '
    ' Integer Type Validation
    ' Takes an input as a string and checks if the string can be converted to an integer.
    Public Function typeIntegerCheck(inp As String) As Boolean
        Dim output As Integer   ' Create an empty integer variable to attempt to store the string in it.

        Try
            output = Integer.Parse(inp) ' Try to convert the input to a string and store it in the integer variable.
            Return True                 ' Return true to the calling function as the input has passed validation.
        Catch ex As Exception
            Return False                ' Return false as the input has failed validation and is not an intger.
        End Try
    End Function
End Module
