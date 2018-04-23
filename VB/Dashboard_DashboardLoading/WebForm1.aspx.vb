Imports System
Imports System.IO
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DashboardWeb

Namespace Dashboard_DashboardLoading
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Specifies the dashboard identifier.
            ASPxDashboardViewer1.DashboardId = "SalesDashboard"
        End Sub

        ' Handles the DashboardLoading event.
        Protected Sub ASPxDashboardViewer1_DashboardLoading(ByVal sender As Object, _
                                           ByVal e As DashboardLoadingEventArgs)

            ' Checks the identifier of the required dashboard.
            If e.DashboardId = "SalesDashboard" Then

                ' Writes the dashboard XML definition from a file to a string.
                Dim definitionPath As String = Server.MapPath("App_Data/SalesDashboard.xml")
                Dim dashboardDefinition As String = File.ReadAllText(definitionPath)

                ' Specifies the dashboard XML definition.
                e.DashboardXml = dashboardDefinition
            End If
        End Sub

        ' Handles the ConfigureDataConnection event.
        Protected Sub ASPxDashboardViewer1_ConfigureDataConnection(ByVal sender As Object, _
                                           ByVal e As ConfigureDataConnectionWebEventArgs)
            If e.DataSourceName = "SQL Data Source 1" Then

                ' Gets connection parameters used to establish a connection to the database.
                Dim parameters As Access97ConnectionParameters =
                    CType(e.ConnectionParameters, Access97ConnectionParameters)
                Dim databasePath As String = Server.MapPath("App_Data/nwind.mdb")

                ' Specifies the path to a database file.                    
                parameters.FileName = databasePath
            End If
        End Sub
    End Class
End Namespace