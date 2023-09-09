<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="db_projectt.WebForm1" %>

 <!DOCTYPE html>
<html lang="en">

  <head runat="server">

    <meta charset="utf-8">
    <meta name="author" content="templatemo">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@100;300;400;500;700;900&display=swap" rel="stylesheet">

    <title>SnapX Photography by TemplateMo</title>

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
    



<form id="form1" runat="server">
        <div>


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


<section class="Requestservices">
<br>
<div class = "col-lg-12">
   
    <hr>
    <br>
   <h1 style =" color :#42d5e6;"><center> Request Services</center></h1>
    <br>
    <hr>
</div>
<center>
   <div>

       <br>
       <hr><h2>Kindly Click On The Item That You Need </h2><hr>
       <br>
        <div style =" background-color :yellow;">
              <h1 style =" z-index :999;color :blue ;" id ="message_t2" runat="server" ></h1>

              </div>
     
       <h3 style =" color :#00bdfe;">Request credit card</h3><br> <asp:CheckBox ID="CheckBox1" runat="server" />
       <br>
       <br>
            
       <h2 style =" color :#00bdfe;">Request debit card </h2><br> <asp:CheckBox ID="CheckBox2" runat="server" />
       <br>
       <br>
            
       <h2 style =" color :#00bdfe;">Request check book</h2> <br><asp:CheckBox ID="CheckBox3" runat="server" />
       <br>
       <br>

       <h4> <asp:Button ID="Button1" Text="Submit" runat="server" OnClick ="Save_request" /></h4>
           
       <asp:GridView ID="ItemGrid" runat="server" style ="display:none;">

    </asp:GridView>

    <br>
    <br>
    <br>
    <br>

   </div>
</center>
  </section>


<!-- ***** footer ***** -->

<footer style =" width : 100% ;position: fixed; bottom: 0;" >
  <div class="container">
    <div class="row">
      <div class="col-lg-12">
        <p>DB Project  <a href="#">Confinity</a> Fast 2020 Ltd. All rights reserved. 
        
        Design: <a title="CSS Templates" rel="sponsored" href="https://templatemo.com" target="_blank">db project</a></p>
      </div>
    </div>
  </div>
</footer>

<!-- Scripts -->
<!-- Bootstrap core JavaScript -->
<script src="vendor/jquery/jquery.min.js"></script>
<script src="vendor/bootstrap/js/bootstrap.min.js"></script>

<script src="assets/js/isotope.min.js"></script>
<script src="assets/js/owl-carousel.js"></script>
<script src="assets/js/wow.js"></script>
<script src="assets/js/tabs.js"></script>
<script src="assets/js/popup.js"></script>
<script src="assets/js/custom.js"></script>


 </div>
</form>

</body>
</html>
