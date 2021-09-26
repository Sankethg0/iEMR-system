<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EMR.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <div class="centerblock" align="center">
    <h2>Login</h2>
        </div>
    
   <body  onkeydown="javascript:if(window.event.keyCode == 13) window.event.keyCode = 9;">
   
    <div class="centerblock"  align="center"> <img src="images/login.png"  style="width: 371px; height: 318px;" /></div>
    <div class="centerblock"  align="center">
    <p style="width: 400px;">
        <script type="text/javascript">
            function focuson(obj) {

                var a = obj.name;

                if (event.keycode = 13) {

                    window.document.all(a).focus();

                }

            }
            }
        </script>
    <asp:Label ID="Label1" runat="server" Text="User Name : " Width="90"></asp:Label>
      
    <asp:TextBox ID="txtUser" runat="server" Width="300px" autocomplete="off" onkeydown="focuson(this)"></asp:TextBox>
    </p>
    <br />
   
   <p style="width: 400px;">
    <asp:Label ID="Label2" runat="server" Text="Password : " Width="90"></asp:Label>
    
    <asp:TextBox ID="txtPass" runat="server" Width="300px" autocomplete="off" TextMode="Password" onkeydown="focuson(this)"></asp:TextBox>
    </p>
        <br />
        <p style="width: 300px;">
    
            <br />
             <asp:Button ID="Button2" class="btn btn-primary btn-lg" runat="server" Text="CLEAR" Width="120px" OnClick="Button2_Click" />   
            <asp:Button ID="Button1" class="btn btn-primary btn-lg" runat="server" Text="LOGIN" Width="115px" OnClick="Button1_Click" onkeydown="focuson(this)"/>
    </p>
    <br />
         <p style="width: 300px;">
    
            <br />
            <asp:Label ID="Label4" runat="server" Text="Label" ><a  href="/Main.aspx"><b>Go Back</b></a></asp:Label> 
    </p>
        </div>
    </body>
</asp:Content>
