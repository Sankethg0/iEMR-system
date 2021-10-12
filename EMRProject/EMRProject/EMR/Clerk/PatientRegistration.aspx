<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="~/Clerk/PatientRegistration.aspx.cs" Inherits="EMR.WebForm1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        ::placeholder{
             text-align:center;
         }
    </style>

    <body onload=display_ct();>
     <div class="centerblock">
    <h2><b>PATIENT REGISTRATION</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<input type="text" id="t1" name="txtDate" style="width:356px;border:none" autocomplete="off"/>        </h2>  </div>
    <br />
        <table>
            <tr >
              <div  class="centerblock" align="center" >
            <asp:TextBox ID="txtRBClerk" runat="server" AutoPostBack="true" OnTextChanged="txtRBClerk_TextChanged" spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="TYPE HERE/ADD/SER/CLR/DEL/LOGOUT" style="text-transform:uppercase;">    </asp:TextBox>                 
            </div> 
                 </tr></table>
   
    <br />

    <table >
            <tr>
                <div class="centerblock" align="center" >
                   
                        <asp:Button ID="btnAdd" class="btn btn-primary btn-lg" runat="server" Text="ADD" Width="90px" OnClick="Button1_Click"/>
                      
                 
                        <asp:Button class="btn btn-primary btn-lg" ID="btnClear" runat="server" Text="CLEAR" Width="90px" onClick="btnClear_Click" visibility="false"/>
                     
                        <asp:Button class="btn btn-primary btn-lg" ID="btnDelete" runat="server" Text="DELETE" Width="100px" OnClick="btnDelete_Click" visibility="false" />
                     <asp:Button class="btn btn-primary btn-lg" ID="btnLogOut" runat="server" Text="LOG OUT" Width="110px" OnClick="btnLogOut_Click" visibility="false"/>
                        <asp:Button class="btn btn-primary btn-lg" ID="btnSearch" Visible="false" runat="server" Text="SEARCH"  Width="100px" visibility="false"/>
                      
                   </div>
                </tr>
            </table>
    <br />
          
    <table  class="data" >
       <tr> 
            <td>
                <p style=" width: 310px">
        <asp:Label ID="Label3" runat="server"  ><b>Name<span style="color:red;">(PTN):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtName" runat="server" Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
        <td>
        <p style="width:300px">
        <asp:Label ID="Label1" runat="server"  Width="78" ><b>MRN<span style="color:red;">(MRN):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtMRN" runat="server"  Width="200px"  autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
       <td><p style="width: 300px">
        <asp:Label ID="Label2" runat="server"   Width="75"><b>NIC<span style="color:red;">(NIC):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtNIC" runat="server"  Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
           <td><p style="width: 300px">
               <asp:Label ID="Label12" runat="server" ><b>District<span style="color:red;">(DIS):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtDistrict" runat="server"  Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
        
        </td>
          
            </tr>
            <tr>
          
           <td><p style="width: 310px">
        <asp:Label ID="Label5" runat="server"  ><b>Contact<span style="color:red;">(CON) :</span></b></asp:Label>
           
        <asp:TextBox  ID="txtContact" runat="server"  Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
           <td><p style="width: 300px">
        <asp:Label ID="Label6" runat="server"  ><b>Email<span style="color:red;">(EML):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtEmail" runat="server" Width="300" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
                 <td><p style="width: 300px">
        <asp:Label ID="Label7" runat="server"  ><b>DOB<span style="color:red;">(DOB):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtDOB" runat="server"  Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
        </td>
                <td><p style="width: 300px">
        <asp:Label ID="Label8" runat="server"><b>Gender<span style="color:red;">(GEN):</span></b></asp:Label>
             
        <asp:TextBox  ID="txtGen" runat="server"  Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
        </td>
                </tr><tr>
          
           
        
  <td><p style="width: 300px">
        <asp:Label ID="Label9" runat="server"  Width="100"><b>BloodGroup<span style="color:red;">(BGP):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtBlGp" runat="server"  Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
       </td>
                     
        <td><p style="width: 300px">
          
        <asp:Label ID="Label10" runat="server"  Width="75"><b>Occupation<span style="color:red;">(OCC):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtOccupation" runat="server"  Width="300" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
        </td>
           <td colspan="2"><p >
        <asp:Label ID="Label4" runat="server" Width="126px" ><b>Address<span style="color:red;">(ADR):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtAddress" runat="server"  Width="580px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
           </td>
              
            </tr>
        <tr>
  <td><p style="width: 300px">
        <asp:Label ID="Label11" runat="server"  Width="100"><b>Primary Care Physician<span style="color:red;">(PCP):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtPCP" runat="server"  Width="310" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
       </td>
                     
        <td><p style="width: 300px">
          
        <asp:Label ID="Label13" runat="server"  Width="75"><b>Emergency Contact<span style="color:red;">(ECN):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtECN" runat="server"  Width="300" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"> </asp:TextBox></p>
        </td>
           <td ><p >
        <asp:Label ID="Label14" runat="server" Width="100" ><b>Pharmacy Fax No.<span style="color:red;">(PFX):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtPFX" runat="server"  Width="300" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
           </td>
              
            </tr>
        </table>
        
   
    
</asp:Content>
