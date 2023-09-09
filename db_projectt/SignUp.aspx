<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="db_projectt.SignUp" %>

<!DOCTYPE html>
<html lang="en" >
<head>
  <meta charset="UTF-8">
  <title>Confinity</title>
  <link rel="stylesheet" href="./style.css">

</head>

	<img src="assets/images/logo.png" style = "display: block; margin-left: auto ; margin-right : auto; width: 30%" >
	
<body cssclass="body">
   
      <form id="form1" runat="server">
            
               <div class="Reg_div">
			   <br /> <asp:Image ID="Image1" cssclass="center"  runat="server" height="0" Width="0"/> <br />
   
	           <div class="form">         
   
               <div class="col">  <asp:TextBox ID="username"   CssClass  ="textbox" runat="server" placeholder="User Name"  ></asp:TextBox>             <span class="focus-border"></span></div><br />
			   <div class="col">  <asp:TextBox ID="password"   cssclass="textbox" runat="server" placeholder="Password"  ></asp:TextBox>              <span class="focus-border"></span></div><br />

				   <div class="col">  <asp:TextBox ID="email"   cssclass="textbox" runat="server" placeholder="email"  ></asp:TextBox>              <span class="focus-border"></span></div><br />
				<div class="col">  <asp:TextBox ID="address"    cssclass="textbox" runat="server" placeholder="Address"  ></asp:TextBox>                 <span class="focus-border"></span></div><br />
				   
			   <div class="col">  <asp:TextBox ID="phone"      cssclass="textbox" runat="server" placeholder="Phone"  ></asp:TextBox>                     <span class="focus-border"></span></div><br />
			 
               <div class="col">  <asp:TextBox ID="accountno"       CssClass ="textbox" runat="server" placeholder="Account-no"  ></asp:TextBox>                       <span class="focus-border"></span></div><br />
				   <div class="col">  <asp:TextBox ID="amount"       CssClass ="textbox" runat="server" placeholder="Total Amount"  ></asp:TextBox>                       <span class="focus-border"></span></div>
		       

               </div>       
			
			

		      <div class="centeral"> <center><asp:Button ID="Register" CssClass="button1" runat="server" BorderColor="#00ccff" BackColor="#00ccff" Text="Register" Width="268px" Height="40px" OnClick="Register_Click"/></center>  </div>
			 

                
           
       </div>
    </form>
</body>



</html>

