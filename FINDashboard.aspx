<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FINDashboard.aspx.cs" Inherits="SE.FINDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Finance Dashboard</title>
    <link rel="stylesheet" href="CSS/FINDashboard.css" />
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
            <h1 class="fh1">APPLICATIONS</h1>
            <br />
            <asp:Table class="t1" ID="table1" name="table1" runat="server" Width="100%">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>Roll Number</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Applicant Name</asp:TableHeaderCell>
                    <asp:TableHeaderCell>University Dues</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Degree Fee</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Decision</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Comments</asp:TableHeaderCell>
                </asp:TableHeaderRow> 
                    <asp:TableRow>
                    <asp:TableCell>I210503</asp:TableCell>
                    <asp:TableCell>
                        <a href="ApplicationDetails.aspx">Zian Ahmed</a>
                    </asp:TableCell>
                    <asp:TableCell>Paid</asp:TableCell>
                    <asp:TableCell>
                    Paid
                    </asp:TableCell>
                    <asp:TableCell>
                            <asp:dropdownlist runat="server">
                            <asp:listitem text="None" />
                            <asp:listitem text="Accept" />
                            <asp:listitem text="Reject" />
                        </asp:dropdownlist>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:textbox runat="server" id="comments" name="comments" placeholder="Add comments"/>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            
            <asp:TextBox class="b1" ID="decision" runat="server" TYPE="SUBMIT" VALUE="Make Decision" name="decision"></asp:TextBox>
        </form>
    </div>
</body>
</html>