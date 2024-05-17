<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SE.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="CSS/Login.css" />
    <link rel="icon" type="image/x-icon" href="Images/Logo.png" />   
</head>
<body>
    <div class="login">
        <form id="form1" runat="server">
            <div>
                <h1 class="h1c">LOGIN</h1>
                <label class="l1" for="email"> Email </label>
                <br />
                <asp:TextBox class="t1" ID="email" name="email" runat="server" TYPE="email" placeholder="NU ID ONLY"></asp:TextBox>
                <br />
                <label class="l1" for="password"> Password </label>
                <br />
                <asp:TextBox class="t1" ID="Password" name="password" runat="server" TYPE ="password"></asp:TextBox>
                <br />
                <asp:TextBox class="err" ID="error" runat="server" name="error" type="text"></asp:TextBox>
                <asp:Button class="b1" ID="Button1" runat="server" Text="LOGIN" BorderStyle="Solid" OnClick="Login_button"/>
                <br />
                <asp:TextBox class="b1" ID = "register" runat = "server" TYPE="submit" VALUE="SIGN UP" OnTextCHanged = "Register_button"> </asp:TextBox>
            </div>    
        </form>
    </div>
    <div class ="Img">
        <img src="Images/Login.jpg" alt="Alternate Text" />
        
    </div>
</body>
</html>