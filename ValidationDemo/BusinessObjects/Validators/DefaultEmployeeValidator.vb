Imports BusinessObjects

Public Class DefaultEmployeeValidator
    Inherits Validator(Of Employee)

    Public Overrides Sub ValidateProperty(propertyName As String, obj As Employee)
        RemoveError(propertyName)
        Select Case propertyName
            Case "FirstName"
                ValidateFirstName(obj)
            Case "LastName"
                ValidateLastName(obj)
        End Select
    End Sub
    Private Sub ValidateLastName(obj As Employee)
        If obj IsNot Nothing AndAlso obj.LastName.Length > 10 Then
            AddError("LastName", "Last name is too long, yo")
        End If
    End Sub

    Private Sub ValidateFirstName(obj As Employee)
        If obj IsNot Nothing And obj.FirstName.Length > 10 Then
            AddError("FirstName", "First name is too long, yo")
        End If
    End Sub
End Class

