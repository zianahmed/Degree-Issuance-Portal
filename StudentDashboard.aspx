<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDashboard.aspx.cs" Inherits="SE.StudentDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Dashboard</title>
    <link rel="stylesheet" href="CSS/StudentDashboard.css" />
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
    <div class="mainbg">
        <form class="f1" runat="server">
            <h1 class="fh1"> PROCESS TRACKING </h1>
            <br />
            <asp:Table class="t1" ID="table1" name="table1" runat="server" Width="100%">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>Process</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Last Update Date</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Status</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Remarks</asp:TableHeaderCell>
                </asp:TableHeaderRow> 
                <asp:TableRow>
                    <asp:TableCell>Application</asp:TableCell>
                    <asp:TableCell>--/--/-----</asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="Button1" runat="server" Text="Submit Form" BorderStyle="Solid" OnClick="Request_button"/>
                    </asp:TableCell>
                    <asp:TableCell>Kindly Submit Form</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Admin Token</asp:TableCell>
                    <asp:TableCell>--/--/-----</asp:TableCell>
                    <asp:TableCell>
                        Pending
                    </asp:TableCell>
                    <asp:TableCell>-----------------</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>FYP Aprroval</asp:TableCell>
                    <asp:TableCell>--/--/-----</asp:TableCell>
                    <asp:TableCell>
                        Pending
                    </asp:TableCell>
                    <asp:TableCell>-----------------</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>FIN Approval</asp:TableCell>
                    <asp:TableCell>--/--/-----</asp:TableCell>
                    <asp:TableCell>
                        Pending
                    </asp:TableCell>
                    <asp:TableCell>-----------------</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Admin Approval</asp:TableCell>
                    <asp:TableCell>--/--/-----</asp:TableCell>
                    <asp:TableCell>
                        Pending
                    </asp:TableCell>
                    <asp:TableCell>-----------------</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            
            <asp:Button class="b1" ID="Button2" runat="server" Text="Download Degree/Transcript" BorderStyle="Solid" Visible="false" OnClick="Download_button"/>
        </form>
    </div>
</body>
</html>
