<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceApproval.aspx.cs" Inherits="db_projectt.ServiceApproval" %>



<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">

  <head runat="server">

    <meta charset="utf-8">
    <meta name="author" content="templatemo">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@100;300;400;500;700;900&display=swap" rel="stylesheet">

    <title>Book appointment

    </title>

    <!-- Bootstrap core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">


    <!-- Additional CSS Files -->
    <link rel="stylesheet" href="assets/css/fontawesome.css">
    <link rel="stylesheet" href="assets/css/templatemo-snapx-photography.css">
    <link rel="stylesheet" href="assets/css/owl.css">
    <link rel="stylesheet" href="assets/css/animate.css">
    <link rel="stylesheet"href="https://unpkg.com/swiper@7/swiper-bundle.min.css"/>
<!--

TemplateMo 576 SnapX Photography

https://templatemo.com/tm-576-snapx-photography

-->
  </head>
    
<body>


  <!-- ***** Header Area Start ***** -->
  <header class="header-area header-sticky">
    <div class="container">
        <div class="row">
            <div class="col-12">
                <nav class="main-nav">
                    <!-- ***** Logo Start ***** -->
                    <a href="WebForm3.aspx" class="logo">
                        <img src="assets/images/logo.png" alt="logo">
                    </a>
                    <!-- ***** Logo End ***** -->

                    <!-- ***** Menu Start ***** -->
                     <ul class="nav">
                        <li><a href="WebForm3.aspx" class="active">Home</a></li>
                        <li class="has-sub">
                            <a href="javascript:void(0)">other &amp; services</a>
                            <ul class="sub-menu">
                              <li><a href="WebForm2.aspx">Feedback</a></li> <!--Request loan-->
                              <li><a href="checkTransaction.aspx">History</a></li> <!--transaction history-->
                              <li><a href="payBill.aspx">Bills</a></li> <!--pay bills-->
                              <li><a href="book appoitnment.aspx">Appointment</a></li> <!--pay bills-->
                                <li><a href="view_income_statement.aspx">Statement</a></li>
                                <li><a href="ServiceApproval.aspx">Request_Status</a></li>
                            </ul>
                        </li>
                        <li><a href="WebForm1.aspx">Request services</a></li> <!-- request services-->
                        <li><a href="Transaction.aspx">Transaction</a></li> <!-- make Transactions-->
                    </ul>   
                    <div class="border-button">
                      <a  href="LoginUser.aspx" class="sign-in-up"><i class="fa fa-user"></i> Sign out</a>
                    </div>
                    <a class='menu-trigger'>
                        <span>Menu</span>
                    </a>
                    <!-- ***** Menu End ***** -->
                </nav>
            </div>
        </div>
    </div>
  </header>
	
<!-- partial:index.partial.html -->
<body cssclass="body">
   
      <form id="form1" runat="server">
     <center>     
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
     <asp:Label ID="Label1" runat="server" Text="Enter your requestId"></asp:Label>
         <asp:TextBox ID="requestid" runat="server"></asp:TextBox>
         <br />
         <br />
     <asp:Label ID="Label2" runat="server" Text="Enter your request type"></asp:Label>
         <asp:TextBox ID="requesttype" runat="server"></asp:TextBox>
          <br />
         <br />
   
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" Height="39px" Width="108px"></asp:Button>
         <br />
         <br />
    <asp:MultiView ID="MultiView1" runat="server">
<asp:View ID="View1" runat="server">
<asp:Label ID="Label3" runat="server" ></asp:Label>
</asp:View>
    </asp:MultiView>
               <asp:Label class="centeral" style="color:red; font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif" ID="Msg" runat="server" Text=" "></asp:Label>               
               <br />
          </center> 
    </form>
</body>



</html>
</body>

