Imports System.ComponentModel

Public Class Employee
    Implements IDataErrorInfo

    Public Sub New()
        _Val = IocManager.Current.FetchDependency(Of Validator(Of Employee))()

    End Sub
    Private _Val As Validator(Of Employee)
    Private _ID As Integer
    Private _FirstName As String
    Private _LastName As String
    Private _Position As String
    Private _Salary As Decimal
    Private _TerminationDate As DateTime?
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property
    Public Property FirstName() As String
        Get
            Return _FirstName
        End Get
        Set(ByVal value As String)
            _FirstName = value
            _Val.ValidateProperty("FirstName", Me)
        End Set
    End Property
    Public Property LastName() As String
        Get
            Return _LastName
        End Get
        Set(ByVal value As String)
            _LastName = value
            _Val.ValidateProperty("LastName", Me)
        End Set
    End Property
    Public Property Position() As String
        Get
            Return _Position
        End Get
        Set(ByVal value As String)
            _Position = value
        End Set
    End Property
    Public Property Salary() As Decimal
        Get
            Return _Salary
        End Get
        Set(ByVal value As Decimal)
            _Salary = value
        End Set
    End Property
    Public Property TerminationDate() As DateTime?
        Get
            Return _TerminationDate
        End Get
        Set(ByVal value As DateTime?)
            _TerminationDate = value
        End Set
    End Property

    Default Public ReadOnly Property Item(columnName As String) As String Implements IDataErrorInfo.Item
        Get
            Return _Val(columnName)
        End Get
    End Property

    Public ReadOnly Property [Error] As String Implements IDataErrorInfo.Error
        Get
            Return String.Empty
        End Get
    End Property
End Class

