<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginClient.aspx.cs" Inherits="test23.LoginClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <%-- <link href="lib/twitter-bootstrap/css/bootstrap.css" rel="stylesheet" />--%>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
    <title></title>
    <style type="text/css">
        .auto-style1 {
           /* text-align: center;*/
            margin-left:200px;
        }
        .auto-style2 {
            width: 100%;

        }
        .auto-style3 {
            width: 234px;
        }
        .auto-style4 {
            width: 234px;
            height: 26px;
            text-align: right;
        }
        .auto-style5 {
            height: 26px;
        }
        .auto-style6 {
            width: 234px;
            text-align: right;
        }

        .login {

            margin-left:-30px;
            margin-top:33px;
        }

        body{

            background-image: url('login.jpg');
             background-repeat: no-repeat;
             background-attachment: fixed;
            background-size: cover;
        }

        #form1 {
            background-color: rgba(0,0,0,.5);
            color: black;
            border-style: solid;
            max-width: 40%;
            margin-left: 30%;
            margin-top: 80px;
            height:300px;
        }
      
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style="font-size: xx-large; font-weight: 700" >
            Login Page</div>
        <div class="login">
        <table class="auto-style2">
            <tr>
                <td class="auto-style4">ID Card Number</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtIdCard" runat="server" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtIdCard" ErrorMessage="Please enter ID Card number"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style5"></td>
            </tr>

            <tr>
                <td class="auto-style6">Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please enter password"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="LOGIN" Width="184px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
            </div>
    </form>
</body>
</html>
