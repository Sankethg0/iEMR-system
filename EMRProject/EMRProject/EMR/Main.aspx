<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="EMR._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       
    <div class="row">
            <img class="img-responsive center-block" src="images\hospital-1-992x558.jpg"  />
          </div>
          <br />
    <div class="centerblock">
        
            
            <p align="center">
                <asp:Button class="btn btn-primary btn-lg" ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="174px" Height="77px" style="margin-top: 12" />
            </p>
       
        
    </div>
    
</asp:Content>
