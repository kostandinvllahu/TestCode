<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequestMoney.aspx.cs" Inherits="test23.RequestMoney" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="lib/twitter-bootstrap/css/bootstrap.css" rel="stylesheet" />
    <title></title>
</head>
<body style="height: 394px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblId" runat="server"></asp:Label>
        </div>
        <asp:Panel ID="Panel1" runat="server"></asp:Panel>
        <br />
        <br />
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="ID"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtID" runat="server" OnTextChanged="txtID_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtName" runat="server" OnTextChanged="txtName_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Surname"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Card ID"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtIdCard" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Request Date"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtDatIn" runat="server" OnTextChanged="txtDatIn_TextChanged"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="IBAN"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtIBAN" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Amount"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                 </td>
            </tr>

             <tr>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Valut"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtValut" runat="server"></asp:TextBox>
                 </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Exchange Rate"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtexchange" runat="server"></asp:TextBox>
                 </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Receiver Id"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtRecID" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Status"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtStatus" runat="server" Text ="Pending"></asp:TextBox>
                </td>
            </tr>
         <tr>
                    <td>

                        &nbsp;</td>
                    <td colspan="2">
                        <asp:Button ID="btnUpdate" runat="server" Text="Send" OnClick="btnUpdate_Click" />
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
                    <td class="auto-style1">
                        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
        </table>
        <asp:Panel ID="Panel2" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
