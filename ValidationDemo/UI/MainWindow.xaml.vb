Imports BusinessObjects

Class MainWindow
    Private _Employee As Employee
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _Employee = New Employee() With {.FirstName = "Mike", .LastName = "Rissen", .ID = 5}
        grdData.DataContext = _Employee
    End Sub
End Class
