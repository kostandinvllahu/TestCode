<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="test23.TransactionHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <%--  <link href="lib/twitter-bootstrap/css/bootstrap.css" rel="stylesheet" />--%>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <asp:Label ID="lblId" runat="server" Visible="False"></asp:Label>
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
