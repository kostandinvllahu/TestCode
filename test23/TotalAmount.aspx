<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TotalAmount.aspx.cs" Inherits="test23.TotalAmount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="lib/twitter-bootstrap/css/bootstrap.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblId" runat="server"></asp:Label>
        </div>
        <asp:Panel ID="Panel1" runat="server">
            <br />
            <br />
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Totam Amount"></asp:Label>
                  </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                        </table>
        </asp:Panel>
    </form>
</body>
</html>
