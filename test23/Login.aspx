<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="test23.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblLastName" runat="server">Password</asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblUSernme" runat="server">Username</asp:Label>
            <asp:TextBox ID="txtUser" runat="server" style="margin-left: 206px" Width="214px"></asp:TextBox>
             </p>
        <p>
            &nbsp;</p>
        <p>
             <asp:Label ID="lblPass" runat="server">Password</asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 211px" Width="206px"></asp:TextBox>
           </p>
        <p>
            <asp:Button id ="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" style="margin-left: 270px" Width="214px"/>
            </p>
        <p>
            <asp:Label ID="lblStatus" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
