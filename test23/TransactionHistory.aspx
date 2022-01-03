<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="test23.TransactionHistory" %>

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
        </asp:Panel>
        <br />
        <br />
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Search"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtSearch" type="number" min="0" MaxLength="10" runat="server" OnTextChanged="txtSearch_TextChanged"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                    <td>

                        &nbsp;</td>
                    <td colspan="2">
                        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
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
        <table ID="searchData">
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                 </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Surname"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                 </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Id Card"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                 </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Request Date"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                 </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="IBAN"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                 </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Amount"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                 </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Valut"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                 </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Exchange"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                 </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Receiver ID"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                 </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="Status"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                 </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label13" runat="server" Text="Sent Date"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                 </td>
            </tr>

        </table>
    </form>
</body>
</html>
