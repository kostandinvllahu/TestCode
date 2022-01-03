<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendMoney.aspx.cs" Inherits="test23.SendMoney" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="lib/twitter-bootstrap/css/bootstrap.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 103px;

            hr {
    margin:20px 0;
    border:0;
    border-top:1px solid #eeeeee;
    border-bottom:1px solid #ffffff;
}
        }
    </style>
</head>
<body>
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
                        <asp:TextBox ID="txtSurname" runat="server" OnTextChanged="txtSurname_TextChanged"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Card ID"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtIdCard" runat="server" OnTextChanged="txtIdCard_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="IBAN"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtIBAN" runat="server" OnTextChanged="txtIBAN_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Amount"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtAmount" type="number" min="0" MaxLength="9" runat="server" OnTextChanged="txtAmount_TextChanged"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Transaction Id"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtRecID" type="number" min="0" MaxLength="9" runat="server" OnTextChanged="txtRecID_TextChanged"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Exchange Rate"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtExchange" type="number" min="0" MaxLength="9" runat="server" OnTextChanged="txtRecID_TextChanged"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Receiver ID"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtReceiverID" runat="server" OnTextChanged="txtRecID_TextChanged"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Status"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtStatus" runat="server" Text="Pending" OnTextChanged="txtStatus_TextChanged"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Date Out"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtDateOut" runat="server" Text = OnTextChanged="txtStatus_TextChanged"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Your amount"></asp:Label>
                </td>
                <td colspan="2">
                        <asp:TextBox ID="txtTotalAmount" runat="server" OnTextChanged="txtTotalAmount_TextChanged"></asp:TextBox>
                </td>
            </tr>
            
         <tr>
                    <td>

                        &nbsp;</td>
                    <td colspan="2">
                        <asp:Button ID="btnUpdate" runat="server" Text="Action" OnClick="btnUpdate_Click" />
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
             <tr>
                    <td colspan="2">
                        &nbsp;</td>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
             <tr>
                    <td colspan="2">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Accept" />
                    </td>
                    <td class="auto-style1">
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="Delete" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
        </table>
        <asp:Panel ID="Panel2" runat="server" Height="31px">
        </asp:Panel>
    </form>
</body>
</html>
