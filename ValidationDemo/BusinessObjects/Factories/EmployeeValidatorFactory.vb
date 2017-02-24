Public Module EmployeeValidatorFactory
    Public Function GetValidator() As Validator(Of Employee)
        Return New DefaultEmployeeValidatorV1()
    End Function
End Module
