Imports System.Configuration
Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Unity.Configuration

Public Class IocManager
    Private Shared _Instance As IocManager
    Private _Ioc As IUnityContainer

    Private Sub New()
        Try
            ' This creates a new unitycontainer object 
            '  It does all the injection work for us
            _Ioc = New UnityContainer()

            '  Load the app.config section titled "unity"
            Dim section As UnityConfigurationSection =
                CType(ConfigurationManager.GetSection("unity"), UnityConfigurationSection)

            '  Point that section to the new container and 
            '  Tell it to add all dependancies found in the config
            '  INto the UnityContainer
            section.Configure(_Ioc)
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Shared ReadOnly Property Current
        Get
            If _Instance Is Nothing Then
                _Instance = New IocManager()
            End If
            Return _Instance
        End Get
    End Property

    Public Function FetchDependency(Of T)() As T
        Return _Ioc.Resolve(Of T)()
    End Function
End Class

