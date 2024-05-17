<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplicationView.aspx.cs" Inherits="SE.ApplicationView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Application Form</title>
    <link rel="stylesheet" href="CSS/StudentRequest.css" />
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
            <h1 class="fh1"> DEGREE REQUEST FORM </h1>
            <div class="form1">
                <div>
                    <label class="l1" for="rollno">Roll No</label>
                    <asp:TextBox class="t1" ID="rollno" name="rollno" runat="server" type="text" placeholder="I211234"></asp:TextBox> 
                    <br />
                    <label class="l1" for="name">Name</label>
                    <asp:TextBox class="t1" ID="name" name="name" runat="server" type="text"></asp:TextBox> 
                    <br />
                    <label class="l1" for="fname">Father Name</label>
                    <asp:TextBox class="t1" ID="fname" name="fname" runat="server" type="text"></asp:TextBox> 
                    <br />
                    <div class="wrapper">
                        <label class="l1">Gender</label>
                        <asp:RadioButtonList ID="gender" name="gender" runat="server" CssClass="radio">
                            <asp:ListItem selected="True" Text="Male" Value="Male" color="black"/>
                            <asp:ListItem Text="Female" Value="Female" color="black" />
                        </asp:RadioButtonList>
                    </div>

                </div>
                
                <div>
                    <span class="l1">Program</span>
                    <br />
                    <asp:DropDownList class="t1" ID="program" runat="server">
                        <asp:ListItem selected="True" Value="BS">BS</asp:ListItem>
                        <asp:ListItem Value="MS">MS</asp:ListItem>
                        <asp:ListItem Value="PhD">PhD</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <span class="l1">Department</span>
                    <br />
                    <asp:DropDownList class="t1" ID="dept" runat="server">
                        <asp:ListItem selected="True" Value="CS">Computer Science</asp:ListItem>
                        <asp:ListItem Value="SE">Software Engineering</asp:ListItem>
                        <asp:ListItem Value="CY">Cyber Security</asp:ListItem>
                        <asp:ListItem Value="AI">Artificial Intelligence</asp:ListItem>
                        <asp:ListItem Value="DS">Data Science</asp:ListItem>
                    </asp:DropDownList>
                    <div class="wrapper">
                        <label class="l1">University Dues</label>
                        <asp:RadioButtonList ID="RadioButtonList1" name="udues" runat="server" CssClass="radio">
                            <asp:ListItem Text="Paid" Value="paid" class="r1g"/>
                            <asp:ListItem selected="True" Text="UnPaid" Value="unpaid" class="r1r"/>
                        </asp:RadioButtonList>
                    </div>
                    <div class="wrapper">
                        <label class="l1">Degree Fee</label>
                        <asp:RadioButtonList ID="RadioButtonList2" name="ddue" runat="server" CssClass="radio">
                            <asp:ListItem Text="Paid" Value="paid" class="r1g"/>
                            <asp:ListItem selected="True" Text="UnPaid" Value="unpaid" class="r1r"/>
                        </asp:RadioButtonList>
                    </div>
                    <div class="wrapper">   
                        <label class="l1">FYP Status</label>
                        <asp:RadioButtonList ID="RadioButtonList3" name="fyp" runat="server" CssClass="radio">
                            <asp:ListItem Text="Complete" Value="complete" class="r1g"/>
                            <asp:ListItem selected="True" Text="Incomplete" Value="incomplete" class="r1r"/>
                        </asp:RadioButtonList>
                    </div>


                </div>
        </form>
    </div>
</body>
</html>
