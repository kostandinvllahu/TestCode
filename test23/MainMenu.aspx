<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="test23.MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="lib/twitter-bootstrap/css/bootstrap.css" rel="stylesheet" />
    <title></title>
    <script type = "text/javascript" >
   function preventBack(){window.history.forward();}
    setTimeout("preventBack()", 0);
    window.onunload=function(){null};
    </script>
    <style type="text/css">
                
        .Ammount{
            text-decoration-color:blue;

        }

        .auto-style1 {
            margin-bottom: 0px;
            margin-left:30px;
            font-family:Lucida Console;
        }
        .auto-style2 {
            margin-left: 80px;

        }

        .auto-style3 {
            margin-left: 550px;
        }
        .auto-style4 {
            margin-top:40px;
           margin-left:30px;
           font-family:Lucida Console;
        }
        
        body{
            
     background-image: url('menu.jpg');
             background-repeat: no-repeat;
             background-attachment: fixed;
            background-size: cover;

        }

       /* #form1 {
            background-color: rgba(0,0,0,.5);
            color: black;
            border-style: solid;
            max-width: 40%;
            margin-left: 30%;
            margin-top: 80px;
        }*/

       /*CSS TEST PER TE BERE BUTONA ME FOTO*/
       .img{
         width: 100px;
        height: auto;
        margin-left:50px;
       }

       
        .auto-style6 {
           margin-top:40px;
           margin-left:30px;
           max-width:160px;
           font-family:Lucida Console;
        }

        .containerOne{
            color: black;
            border-style: solid;
            width:15%;
            height:200px;
            margin-left:10%;
            background-color: rgba(0,0,0,.5);
            color: black;
        }

        .containerTwo{
            color: black;
            border-style: solid;
            width:15%;
            height:200px;
            margin-left:500px;
            margin-top:-200px;
            background-color: rgba(0,0,0,.5);
            color: black;
        }

       .btnTwo{
           margin-top:40px;
           margin-left:30px;
          font-family:Lucida Console;
       }


       .containerThree{
           color: black;
           border-style: solid;
           width:15%;
           height:200px;
           margin-left:800px;
           margin-top:-200px;
           background-color: rgba(0,0,0,.5);
           color: black;
       }

       .containterFour{
           color: black;
           border-style: solid;
           width:15%;
           height:200px;
           margin-left:139px;
           margin-top:50px;
           background-color: rgba(0,0,0,.5);
           color: black;
       }

       .containterFive{
           color: black;
           border-style: solid;
           width:15%;
           height:200px;
           margin-left:500px;
           margin-top:-200px;
           background-color: rgba(0,0,0,.5);
           color: black;
       }

       .containterSix{
           margin-top:-590px;
           margin-left:1050px;
           font-weight: bold;
           font-family:Lucida Console;
       }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblId" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<h2 class="auto-style3"></h2>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;

        <div class="containerOne">
        <asp:Image ID="image" class="img" runat="server" src="gears.png" alt="snow"></asp:Image>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" class="btn" runat="server" CssClass="auto-style1" OnClick="Button4_Click" Text="SETTINGS" Width="143px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
        
          
        <div class="containerTwo">
        <asp:Image ID="image1" class="img" runat="server" src="sendmoney.png" alt="snow"></asp:Image>
        <asp:Button ID="Button5" CssClass="btnTwo" runat="server" Text="SEND MONEY" Width="143px" OnClick="Button5_Click" />
         </div>
          

        <div class="containerThree">
            <asp:Image ID="image2" class="img" runat="server" src="requestmoney.png" alt="snow"></asp:Image>
          <asp:Button ID="Button6" runat="server" Text="REQUEST MONEY" Width="143px" CssClass="auto-style4" OnClick="Button6_Click" />
            </div>
      
            <div class="containterFour">
            <asp:Image ID="image3" class="img" runat="server" src="transactionhistory.png" alt="snow"></asp:Image>
            <asp:Button ID="Button8" runat="server" Text="HISTORY" Width="143px" OnClick="Button8_Click" CssClass="auto-style6" />
            </div>
         <div class="containterFive">
        <asp:Image ID="image4" class="img" runat="server" src="logout.png" alt="snow"></asp:Image>
        <asp:Button ID="Button7" runat="server" Text="LOGOUT" Width="150px" CssClass="auto-style4" OnClick="Button7_Click" />
        </div>

        <div class="containterSix">
            <asp:Label ID="Label1" runat="server" Text="TOTAL AMOUNT: "></asp:Label>
            <asp:Label ID="lblAmount" runat="server"></asp:Label>
            <asp:Label ID="lblCurrency" runat="server"></asp:Label>
        </div>
    </form>
         </body>
</html>
