using System;
using System.IO;
using DevExpress.DataAccess.ConnectionParameters;

namespace Dashboard_DashboardLoading {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            // Specifies the dashboard identifier.
            ASPxDashboardViewer1.DashboardId = "SalesDashboard";
        }

        // Handles the DashboardLoading event.
        protected void ASPxDashboardViewer1_DashboardLoading(object sender, 
            DevExpress.DashboardWeb.DashboardLoadingEventArgs e) {

            // Checks the identifier of the required dashboard.
            if (e.DashboardId == "SalesDashboard") {

                // Writes the dashboard XML definition from a file to a string.
                string definitionPath = Server.MapPath("App_Data/SalesDashboard.xml");                
                string dashboardDefinition = File.ReadAllText(definitionPath);    
          
                // Specifies the dashboard XML definition.
                e.DashboardXml = dashboardDefinition;
            }
        }

        // Handles the ConfigureDataConnection event.
        protected void ASPxDashboardViewer1_ConfigureDataConnection(object sender, 
            DevExpress.DashboardWeb.ConfigureDataConnectionWebEventArgs e) {
                if (e.DataSourceName == "SQL Data Source 1") {

                    // Gets connection parameters used to establish a connection to the database.
                    Access97ConnectionParameters parameters =
                        (Access97ConnectionParameters)e.ConnectionParameters;
                    string databasePath = Server.MapPath("App_Data/nwind.mdb");
                    
                    // Specifies the path to a database file.                    
                    parameters.FileName = databasePath;
            }
        }
    }
}