<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminNew.aspx.cs" Inherits="SE.AdminNew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin New Requests</title>
    <link rel="stylesheet" href="CSS/Admin.css" />
    <link rel="icon" type="image/x-icon" href="Images/Logo.png" />   
</head>
<body>
    <div class="header">
        
        <div class="logo">
            <img src="Images/Logo.png" alt="Logo" />
        </div>
        
        <div class="title">
            <h1>One Stop Student Service Centre</h1>
        </div>
    </div>
    
    <form runat="server">
        <div class="main">
        

            <div class="left">
                <asp:Button class="sb" ID="new" runat="server" Text="New Requests" OnClick="New_Request"/>
                <asp:Button class="sb" ID="pending" runat="server" Text="Pending Requests" OnClick="Pending_Request"/>
                <asp:Button class="sb" ID="completed" runat="server" Text="Completed Requests" OnClick="Completed_Request"/>
            </div>
            <div class="mainbg">
                <div class="f1">
                    <h1 class="fh1">APPLICATIONS</h1>
                    <br />
                   <asp:GridView style="margin-left: 25px" ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="12" OnRowDataBound = "GridView1_RowDataBound">
                        <Columns>
                            <asp:BoundField DataField="requestid" HeaderText="ID" />
                            <asp:BoundField DataField="Name" HeaderText="Name"/>
                            <asp:BoundField DataField="Date" HeaderText="Start Date"/>
                            <asp:BoundField HeaderText="Controls"/>
                            <asp:BoundField HeaderText="Remarks"/>
                        </Columns>
                    </asp:GridView>
                    
                </div>
            </div>
        </div>
    </form>
    </body>
</html>
