<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="WebForm1.aspx.vb" 
         Inherits="Dashboard_DashboardLoading.WebForm1" %>

<%@ Register assembly="DevExpress.Dashboard.v14.1.Web, Version=14.1.6.0, 
             Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
             namespace="DevExpress.DashboardWeb" 
             tagprefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
                      "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    </div>
    <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server" 
        ondashboardloading="ASPxDashboardViewer1_DashboardLoading" 
        onconfiguredataconnection="ASPxDashboardViewer1_ConfigureDataConnection">
    </dx:ASPxDashboardViewer>
    </form>
</body>
</html>