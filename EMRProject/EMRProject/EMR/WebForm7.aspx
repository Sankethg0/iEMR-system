﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="EMR.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  <style>


        .m {
  width: 1410px;
  border: 5px solid brown;
  padding: 2px 2px 0px 4px;
  align-content:initial;
 
}
        .n {
  width: 1410px;
  border: 5px solid #000066;
  padding: 0px 0px 0px 4px;
  margin-bottom:2px;
  align-content:initial;
}
        .centerblock {
  width: 30%;
  border:5px solid  brown ;
  padding: 0px 0px 0px 7px;
  margin: 20px;
  margin-left:25px;
  align-content:initial;
  float:left;
}


       
        input[type="checkbox"] {
            /* remove standard background appearance */
            -webkit-appearance: none;
            -moz-appearance: none;
            appearance: none;
            /* create custom radiobutton appearance */
            display: inline-block;
            width: 15px;
            height: 15px;
            /* background-color only for content */
            background-clip: content-box;
            border: 2px solid #bbbbbb;
            background-color: white;
            border-radius: 50%;
        }

        /* appearance for checked radiobutton */
        .gr input[type="checkbox"]:checked {
            background-color: green;
        }

        .re input[type="checkbox"]:checked {
            background-color: red;
        }

        .leftdiv1 {
            float: left;
            width: 180px;
            height: auto;

            
 
        }
        .leftdiv1n {
            float: left;
            width: 100px;
            height: auto;
        }
        .leftdiv2 {
            float: left;
            width: 200px;
            height: auto;
        }

        .leftdiv3 {
            float: left;
            width: 180px;
            height: 100px;
            background-color: lightyellow;
        }




        .auto-style2 {
            width: 165px;
        }

        .auto-style3 {
            width: 154px;
        }
        .auto-style5 {
            width: 140px;
        }
                 
         
       
        
        .auto-style13 {
            width: 146px;
            height: 25px;
        }
        #space{
              float: left;
            width: 100%;
             height: 10px;
         } 
         
       
        
        .auto-style14 {
            float: left;
            width: 160px;
            height: auto;
        }
         .auto-style14n {
            float: left;
            width: 240px;
            height: auto;
        }


        .auto-style15 {
            float: left;
            width: 150px;
            height: auto;
        }



        .auto-style16 {
            float: left;
            width: 140px;
            height: auto;
        }
         
       
        
        </style>
   
    <body onload=display_ct();>
      <div class="n">
     <div class="centerblock">
    <h3><b>DOCTOR'S DASHBOARD</b>       </h3>  </div>
         
           <div class="centerblock">
    <h3>  <b>INTELLIGENT PATIENT CARE</b>  </h3>  </div>
           <div class="centerblock">
    <h3> <b> <input type="text" id="t1" style="width:367px;border:none"/>   </b></h3>  </div>
    <br />
    <table>
            <tr>
<div align="center">
            <asp:TextBox ID="txtRBDoctor" runat="server" AutoPostBack="true"  spellcheck="false" Width="1340px" autocomplete="off" Height="70px" BorderColor="brown" BorderWidth="4px"  placeholder="Enter here">    </asp:TextBox>                 
            </div>
                </tr>
                    
                </table>
     
               <table>
            <tr>
                <div align="center" >
                  
                     <asp:Button ID="Button1" class="btn btn-primary btn-lg"  runat="server" Text="ADD" Width="90px"  />
                  <asp:Button ID="Button2" class="btn btn-primary btn-lg"  runat="server" Text="CLEAR" Width="90px"  />
                  <asp:Button ID="Button3" class="btn btn-primary btn-lg"  runat="server" Text="DELETE" Width="95px" />
                 <asp:Button ID="btnLogOut" class="btn btn-primary btn-lg"  runat="server" Text="LOG OUT" Width="110px" /> 

                  <asp:Button ID="Button4" Visible="false" class="btn btn-primary btn-lg" runat="server" Text="SEARCH"   />

                    </div>
                </tr>
            </table>

           
          </div>
          <div class="m">
   <table class="data">
       <tr>
            <td class="auto-style26">
        
         <asp:Label ID="Label2" runat="server" colspan="3" BackColor="#D1D7D8" Width="246px" Height="30px"> <b >Name<span style="color:red;"  >(PTN):</span></b></asp:Label>
        <asp:TextBox ID="txtPTN" runat="server" Width="235px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center" CssClass="auto-style22" ></asp:TextBox>
       </td>
        <td class="auto-style3"> 
        <asp:Label ID="Label1" runat="server" BackColor="#D1D7D8" Width="183px" Height="30px"><b>AppointmentCode<span style="color:red;" >(APC):</span></b></asp:Label>
         <asp:TextBox ID="txtApCode" runat="server" Width="180px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
       </td>
       <td class="auto-style3">
           
        <asp:Label ID="Label3" runat="server" BackColor="#D1D7D8" Width="183px" Height="30px"><b>MRN<span style="color:red;">(MRN):</span></b></asp:Label>
       <asp:TextBox ID="txtMRN" runat="server" Width="180px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
       </td>
        <td class="auto-style3">
        <asp:Label ID="Label11" runat="server" BackColor="#D1D7D8" Width="159px" Height="30px" ><b>VID<span style="color:red;">(VID):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtVID" runat="server"  Width="104px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
        </td>   
           <td class="auto-style3">
                
        <asp:Label ID="Label12" runat="server" BackColor="#D1D7D8" Width="164px" Height="30px" ><b>Age:</b></asp:Label>
          
        <asp:TextBox  ID="txtAge" runat="server" Width="119px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true"  Font-Size="Large" style="text-align: center"></asp:TextBox>
       </td>
          <td class="auto-style3">
        <asp:Label ID="Label13" runat="server" BackColor="#D1D7D8" Width="160px" Height="30px"><b>District<span style="color:red;">(DIS):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtDistrict" runat="server"  Width="100" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
        
        </td>
           <td class="auto-style3">
        <asp:Label ID="Label14" runat="server" BackColor="#D1D7D8" Width="149px" Height="30px" ><b>Gender<span style="color:red;">(GEN):</span></b></asp:Label>
             
        <asp:TextBox  ID="txtGen" runat="server"  Width="143px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox> 
        </td>
             <td class="auto-style21">
          
        <asp:Label ID="Label17" runat="server" BackColor="#D1D7D8" Width="131px" Height="30px"  ><b>BMI<span style="color:red;">(BMI):</span></b></asp:Label>
        <asp:TextBox  ID="txtBMI" runat="server"  Width="123px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
        </td>  
       
                </tr><tr>
           <td class="auto-style26">
               <asp:Label ID="Label4" runat="server"  width="244px" BackColor="#D1D7D8"  Height="30px"><b>BloodPressure<span style="color:red;">(BP):</span></b></asp:Label> 
        <asp:TextBox ID="txtBP" runat="server" Width="100px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
       </td>
                    <td class="auto-style2">
                <asp:Label ID="Label7" runat="server"  BackColor="#D1D7D8" Width="182px" Height="30px"><b>Pulse<span style="color:red;">(PUL):</span></b></asp:Label> 
                <asp:TextBox ID="txtPulse" runat="server" Width="100px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
        </td>
           <td class="auto-style2">
        <asp:Label ID="Label8" runat="server" BackColor="#D1D7D8" Width="183px" Height="30px"><b>Temperature<span style="color:red;">(TEM):</span></b></asp:Label>
        <asp:TextBox ID="txtTemp" runat="server" Width="100px"  autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
                   
        </td>
         <td class="auto-style2">
         <asp:Label ID="Label6" runat="server" BackColor="#D1D7D8" Width="157px" Height="30px" CssClass="auto-style20"><b>Height<span style="color:red;">(HEI):</span></b></asp:Label>
          <asp:TextBox ID="txtHei" runat="server" Width="100px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
       </td>
                    <td class="auto-style2">
                     
        <asp:Label ID="Label5" runat="server" BackColor="#D1D7D8" Width="162px" Height="30px" ><b>Weight<span style="color:red;">(WEI):</span></b></asp:Label>
        <asp:TextBox ID="txtWei" runat="server" Width="100px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
        </td>
                     <td class="auto-style2">
            <asp:Label ID="Label9" runat="server" BackColor="#D1D7D8" Width="158px" Height="30px" ><b>PO2<span style="color:red;">(PO2):</span></b></asp:Label>
       <asp:TextBox ID="txtPO2" runat="server" Width="100px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
       </td>
          <td class="auto-style2">
          <asp:Label ID="Label18" runat="server" BackColor="#D1D7D8" Width="149px" Height="30px" ><b>BloodGroup<span style="color:red;">(BGP):</span></b></asp:Label>
        <asp:TextBox  ID="txtBGP" runat="server"  Width="100px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
       
        </td>
             <td class="auto-style21" colspan="2">
        <asp:Label ID="Label21" runat="server" BackColor="#D1D7D8" Width="131px" Height="30px" CssClass="auto-style17"  ><b>DOB<span style="color:red;">(DOB):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtDOB" runat="server" Width="108px" autocomplete="off" placeholder="yyyy/mm/dd" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
       </td>       
  
    
           </tr>
        <tr>
<td class="auto-style25">
        <asp:Label ID="Label19" runat="server" BackColor="#D1D7D8" Width="247px" Height="30px" CssClass="auto-style20"><b>Pharmacy Fax<span style="color:red;">(PFX):</span></b></asp:Label>

           
        <asp:TextBox  ID="txtPFX" runat="server"  Width="240px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
       </td> 
             <td class="auto-style13" colspan="2">
        <asp:Label ID="Label20" runat="server" BackColor="#D1D7D8" Width="368px" Height="30px" CssClass="auto-style20"><b>Primary Care Physician<span style="color:red;">(PCP):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtPPH" runat="server"  Width="300" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
           </td>
            <td class="auto-style2" colspan="2">
          
        <asp:Label ID="Label10" runat="server"  BackColor="#D1D7D8" Width="323px" Height="30px" CssClass="auto-style20" ><b>Emergency Contact<span style="color:red;">(ECN):</span></b></asp:Label>
        <asp:TextBox  ID="txtECN" runat="server"  Width="110px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
        </td>
            
            <td class="auto-style3" colspan="2">
        <asp:Label ID="Label15" runat="server" BackColor="#D1D7D8" Width="310px" Height="30px" ><b>Email<span style="color:red;">(EML):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtEmail" runat="server" Width="248px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
       </td>
            <td class="auto-style21">
        <asp:Label ID="Label16" runat="server" BackColor="#D1D7D8" Width="130px" Height="30px"><b>Contact<span style="color:red;">(CON) :</span></b></asp:Label>
           
        <asp:TextBox  ID="txtContact" runat="server"  Width="120" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
       </td>
        </tr>
        </table>
    <br />

      <div> 
    <table>
            
        <tr>
            <td>
        <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center" Width="180" BackColor="#ffff66" CssClass="auto-style5">

           <b>Past Medical History <br />
           <span style="color:red;">(PMH)</span> </b>
        </asp:Panel></td>
            <td>
                <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Center" Width="200" BackColor="#ffff66">
                <b>Family History <br />
                <span style="color:red;">(FH)</span> </b>
                </asp:Panel>
            </td>
             <td>
                <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Center" Width="180" BackColor="#ffff66">
                <b>Social History <br />
           <span style="color:red;">(SH)</span> </b>
                </asp:Panel>
            </td>
             <td>
                <asp:Panel ID="Panel4" runat="server" HorizontalAlign="Center" Width="180" BackColor="#ffff66">
                <b>Allergies<br />
           <span style="color:red;">(ALL)</span> </b>
                </asp:Panel>
            </td>
             <td>
                <asp:Panel ID="Panel5" runat="server" HorizontalAlign="Center" Width="340" BackColor="#ffff66">
                <b>Current Medications <br />
           <span style="color:red;">(CM)</span> </b>
                </asp:Panel>
            </td>
            <td>
                <asp:Panel ID="Panel6" runat="server" HorizontalAlign="Center" Width="100" BackColor="#ffff66">
                <b>Lab Reports <br />
           <span style="color:red;">(LR)</span> </b>
                </asp:Panel>
            </td>
            <td>
                <asp:Panel ID="Panel12" runat="server" HorizontalAlign="Center" Width="100" BackColor="#ffff66">
                <b>Images<br />
           <span style="color:red;">(IMG)</span> </b>
                </asp:Panel>
            </td>
         </tr>
        </table>
    </div>
        <table>
            <tr>
                <td>
                    <div class="leftdiv1" align="center">
                        
                         <asp:CheckBoxList ID="CheckBoxList2" runat="server" CssClass="re" ></asp:CheckBoxList>
                                   
                                 
                          
                    </div>
                </td>
                <td>
                    <div class="leftdiv2" align="center">
                      <asp:CheckBoxList ID="CheckBoxList3" runat="server" CssClass="re" ></asp:CheckBoxList>
                    </div>
                </td>
                <td>
                    <div class="leftdiv1" align="center">
                         <asp:CheckBoxList ID="CheckBoxList4" runat="server" CssClass="re" ></asp:CheckBoxList> 
                    </div>
                </td>
                <td>
                    <div class="leftdiv1" align="center">
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" CssClass="re" ></asp:CheckBoxList>
                    </div>
                </td>
                <td>
                    <div width="340px" ID="addControl1" runat="server" align="center" spellcheck="false" >

                    </div>
                </td>
                <td>
                    <div class="leftdiv1">

                    </div>
                </td>
                <td>
                    <div class="leftdiv1">

                    </div>
                </td>
            </tr>
        </table>
        <br />
   <div class="centerblockn">
        <table>
            
        <tr>
            <td>
                
        <asp:Panel ID="Panel7" runat="server" HorizontalAlign="Center" Width="180" BackColor="#ffff66">
           <b>Presenting Illness <br />
           
           <span style="color:red;">(PI)</span> </b>
        </asp:Panel></td>
            <td>
                <asp:Panel ID="Panel8" runat="server" HorizontalAlign="Center" Width="100" BackColor="#ffff66">
                <b>Snapshot <br />
                <span style="color:red;">(90DAY)</span> </b>
                </asp:Panel>
            </td>
             <td>
                <asp:Panel ID="Panel9" runat="server" HorizontalAlign="Center" Width="160" BackColor="#ffff66">
                <b>Review of System<br />
           <span style="color:red;">(ROS)</span> </b>
                </asp:Panel>
            </td>
             <td>
                <asp:Panel ID="Panel10" runat="server" HorizontalAlign="Center" Width="240" BackColor="#ffff66">
                <b>Assessment<br />
           <span style="color:red;">(ASS)</span> </b>
                </asp:Panel>
            </td>
             <td>
                <asp:Panel ID="Panel11" runat="server" HorizontalAlign="Center" Width="160" BackColor="#ffff66">
                <b>Orders<br />
           <span style="color:red;">(ORD)</span> </b>
                </asp:Panel>
            </td>
            <td>
                <asp:Panel ID="Panel13" runat="server" HorizontalAlign="Center" Width="150" BackColor="#ffff66">
                <b>Referrals<br />
           <span style="color:red;">(REF)</span> </b>
                </asp:Panel>
            </td>
            <td>
            <asp:Panel ID="Panel14" runat="server" HorizontalAlign="Center" Width="150" BackColor="#ffff66">
                <b>Follow Up<br />
           <span style="color:red;">(FOLUP)</span> </b>
                </asp:Panel>
            </td>
            <td>
            <asp:Panel ID="Panel15" runat="server" HorizontalAlign="Center" Width="140" BackColor="#ffff66">
                <b>PT Education<br />
           <span style="color:red;">(PTED)</span> </b>
                </asp:Panel>
            </td>
</tr>
        </table>
    </div>
        <br />
         <table>
            <tr>
                <td>
                    <div class="leftdiv1" align="center">
                        
                         <asp:CheckBoxList ID="CheckBoxList5" runat="server" CssClass="re" ></asp:CheckBoxList>
                    </div>
                </td>
                <td>
                    <div class="leftdiv1n" align="center" ID="addControl3" runat="server" spellcheck="false">
                      
                    </div>
                </td>
                <td>
                    <div class="auto-style14" align="center">
                          
                    </div>
                </td>
                <td>
                    <div class="auto-style14n"  ID="addControl2" runat="server" align="center" spellcheck="false">
                        
                    </div>
                </td>
                <td>
                    <div class="auto-style14" ID="Div1" runat="server" align="center">

                    </div>
                </td>
                <td>
                    <div class="auto-style15" align="center">
                         <asp:CheckBoxList ID="CheckBoxList6" runat="server" CssClass="re" ></asp:CheckBoxList>
                    </div>
                </td>
                <td>
                    <div class="auto-style15">

                    </div>
                </td>
                 <td>
                    <div class="auto-style16">

                    </div>
                </td>
            </tr>
        </table>
         </div>
        </body>
</body>
</html>
