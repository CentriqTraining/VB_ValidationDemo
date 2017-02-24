Public MustInherit Class Validator(Of T)
    Private _errors As Dictionary(Of String, String)
    Public Sub New()
        _errors = New Dictionary(Of String, String)()
    End Sub
    Protected Sub AddError(prop As String, errorMessage As String)
        If Not _errors.ContainsKey(prop) Then
            _errors.Add(prop, errorMessage)
        End If
    End Sub
    Protected Sub RemoveError(prop As String)
        If _errors.ContainsKey(prop) Then
            _errors.Remove(prop)
        End If
    End Sub
    Default Public ReadOnly Property Index(propertyName As String)
        Get
            If _errors.ContainsKey(propertyName) Then
                Return _errors(propertyName)
            Else
                Return String.Empty
            End If
        End Get
    End Property
    Public MustOverride Sub ValidateProperty(propertyName As String, obj As T)
End Class

