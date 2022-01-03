<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="test23.Settings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <link href="lib/twitter-bootstrap/css/bootstrap.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 268435456px;
        }
        body{
            background-image: url('settings.jpg');
             background-repeat: no-repeat;
             background-attachment: fixed;
            background-size: cover;
        }

        dr {
    border-top:1px solid black;

}
        

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblId" runat="server"></asp:Label><br />
            <br />
            <asp:Panel ID="Panel1" runat="server"></asp:Panel>
            <br />
            <br />
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Phone Number"></asp:Label>
                  </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                    &nbsp;<asp:CheckBox ID="chkNumber" runat="server" Text="Change Number" OnCheckedChanged="chkNumber_CheckedChanged" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="chkBoth" runat="server" Text="Change Both Fields" />
                        &nbsp;&nbsp;
                        <asp:CheckBox ID="chkPassword" runat="server" Text="Change Password" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>

                        &nbsp;</td>
                    <td colspan="2">
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnSend_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnBack" runat="server" Text="Return Menu" OnClick="btnBack_Click"  />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblSuccess" runat="server" Text="" ForeColor="Green"></asp:Label>                      
                    </td>
                    <td colspan="2" class="auto-style1">
                        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </td>
                    <td colspan="2">
                        &nbsp;</td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
