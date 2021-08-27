<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580276/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4761)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx](./CS/Dashboard_DashboardLoading/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/Dashboard_DashboardLoading/WebForm1.aspx))
* [WebForm1.aspx.cs](./CS/Dashboard_DashboardLoading/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/Dashboard_DashboardLoading/WebForm1.aspx.vb))
<!-- default file list end -->
# How to load a dashboard at runtime using Web Viewer
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4761/)**
<!-- run online end -->


<p><strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx">ASPxDashboard control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.<br></em><br>The following example demonstrates how to load a dashboard at runtime using the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboardViewer_DashboardLoadingtopic"><u>ASPxDashboardViewer.DashboardLoading</u></a> event.</p>
<p>In this example, the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboardViewer_DashboardIdtopic"><u>ASPxDashboardViewer.DashboardId</u></a> property is set at first to introduce a unique dashboard identifier. Then the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboardViewer_DashboardLoadingtopic"><u>ASPxDashboardViewer.DashboardLoading</u></a> event is handled to load the dashboard XML definition. Its <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebDashboardLoadingEventArgs_DashboardIdtopic"><u>DashboardId</u></a> parameter is used to get the identifier of the required dashboard. The <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebDashboardLoadingEventArgs_DashboardXmltopic"><u>DashboardXml</u></a> property is used to specify the dashboard XML definition as a string.</p>
<p>The <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboardViewer_ConfigureDataConnectiontopic"><u>ASPxDashboardViewer.ConfigureDataConnection</u></a> event is handled to provide connection settings before the Dashboard Viewer connects to the database. The <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataAccessConnectionParametersFileConnectionParametersBase_FileNametopic"><u>FileConnectionParametersBase.FileName</u></a> property is used to set the path to the database file.</p>

<br/>


