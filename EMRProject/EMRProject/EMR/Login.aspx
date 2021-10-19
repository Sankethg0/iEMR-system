<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EMR.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <div class="centerblock" align="center">
    
        </div>
    
   <body>
   
    <div class="centerblock"  align="center"> <img src="images/login.png"  style="width: 371px; height: 318px;" /></div>
    <div class="centerblock"  align="center">
    <asp:Label ID="label11" runat="server" Text="Login Here" Font-Bold="true" Font-Size="Large"></asp:Label><br />
    <p style="width: 400px;">
        <script type="text/javascript">
            $(document).on('keypress', 'input', function (e) {
                if (e.which == 13) {
                    e.preventDefault();
                    var $next = $('[tabIndex=' + (+this.tabIndex + 1) + ']');
                    console.log($next.length);
                    if (!$next.length) {
                        $next = $('[tabIndex=1]');
                    }
                    $next.focus().click();
                }
            });
        </script>
    <asp:Label ID="Label1" runat="server" Text="Username" Width="90" Font-Size="Medium"></asp:Label><br />
      
    <asp:TextBox ID="txtUser" runat="server" Width="300px" autocomplete="off" onkeydown="focusNext(event)" TabIndex="1"></asp:TextBox>
    </p>
    <br />
   
   <p style="width: 400px;">
    <asp:Label ID="Label2" runat="server" Text="Password" Width="90" Font-Size="Medium"></asp:Label><br />
    
    <asp:TextBox ID="txtPass" runat="server" Width="300px" autocomplete="off" TextMode="Password" onkeydown="focusNext(event)" tabIndex="2"></asp:TextBox>
    </p>
        <br />
        <p style="width: 300px;">
    
            <br />
             <asp:Button ID="Button2" class="btn btn-primary btn-lg" runat="server" Text="CLEAR" Width="120px" OnClick="Button2_Click" tabIndex="4"/>   
            <asp:Button ID="Button1" class="btn btn-primary btn-lg" runat="server" Text="LOGIN" Width="115px" OnClick="Button1_Click" tabIndex="3"/>
    </p>
    <br />
         <p style="width: 300px;">
    
            <br />
            <asp:Label ID="Label4" runat="server" Text="Label" ><a  href="/Main.aspx"><b>Go Back</b></a></asp:Label> 
    </p>
        </div>
    </body>
</asp:Content>
