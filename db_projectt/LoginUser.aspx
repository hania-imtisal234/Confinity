<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginUser.aspx.cs" Inherits="db_projectt.LoginUser" %>


<!DOCTYPE html>
<html lang="en" >
<head>
  <meta charset="UTF-8">
  <title>Confinity</title>
  <link rel="stylesheet" href="./style.css">

</head>


	
<img src="assets/images/logo.png" style = "display: block; margin-left: auto ; margin-right : auto; width: 30%" >
	
<!-- partial:index.partial.html -->
<body cssclass="body">
   
      <form id="form1" runat="server">
            
              <div class="divi">
			  <br />
       		  <asp:Image ID="Image1" cssclass="center"  runat="server" height="0px" Width="0px"/>
			  <br />
		      <br />
   
	          <div class="form">
           
               <br />        
               <div class="col">
               <asp:TextBox ID="username" cssclass="textbox" runat="server" placeholder="Username"  ></asp:TextBox>
			   <span class="focus-border"></span>
			   </div>     
               <br />
			   <div class="col"> <asp:TextBox ID="password" TextMode="Password" cssclass="textbox" runat="server"  placeholder="Password" ></asp:TextBox>   <span class="focus-border"></span> </div><br /><br /></div> 
                    <div class="centeral"><center></center>   </div>
               <div class="centeral"><center><asp:Button ID="login" CssClass="button1" runat="server" BorderColor="#00ccff" BackColor="#00ccff" Text="Login" Width="268px" Height="40px" OnClick="login_Click" /></center>   </div>

              
			   
                  
               <br />
               <asp:Label class="centeral" style="color:red; font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif" ID="Msg" runat="server" Text=" "></asp:Label>               
               <br />
           
       </div>
    </form>
</body>



</html>
</body>

