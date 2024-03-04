Imports System.Text.RegularExpressions

Module Validation
    ' Ensure the name is good and the parameters are passed in properly
    Function CharacterValidation(str As String)
        ' Declaring a regex pattern to match to the input string 
        Dim pattern As String = "[^a-zA-Z]" ' Creating a pattern which will detect all characters which are not in range a-z A-Z
        Dim reg As New Regex(pattern) ' Create a new regex (Regular Expression) based of the pattern)

        ' Checks if the input string matches the pattern (ie if there are any characters which are not a-Z
        If reg.IsMatch(str) Then
            ' Returns false as the input contains special characters which is not allowed
            Return False
        End If

        ' Returns True if the string has not failed validation
        Return True
    End Function

    ''' <summary>
    ''' Function used to check if input strings are empty.
    ''' </summary>
    ''' <param name="str">Input String to be checked if empty</param>
    ''' <returns>Boolean Result</returns>
    Function PresenceValidation(str As String)
        If str Is Nothing Or str = "" Then
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Used to format Name Inputs to be in title case (ie first letter capitilized)
    ''' Important for later in system to split first names from last names etc
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns></returns>
    Function FormatName(ByRef name As String)
        ' Function assumes that input has been presense and character validated

        ' Set's the whole input string to lower case 
        name = name.ToLower()

        ' Strings are immutable so a new string must be created to be manipulated and returned to user
        Dim returnString As String

        ' Creates a string which takes the lowecase name and makes the first letter uppercase and
        ' then concatenates the rest of the string
        returnString = Chr(Asc(name(0)) - 32) & name.Substring(1)

        'Returns the result to calling function
        Return returnString

    End Function

    Public Function TypeInteger(inp As String)
        Return True
    End Function

    Public Function correctTimeFormat(inp As String)
        Return True
    End Function

End Module
