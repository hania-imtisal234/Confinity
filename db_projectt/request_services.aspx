<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="request_services.aspx.cs" Inherits="db_projectt.request_services" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">

  <head runat="server">

    <meta charset="utf-8">
    <meta name="author" content="templatemo">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@100;300;400;500;700;900&display=swap" rel="stylesheet">

    <title>REQUEST SERVICES

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

<section class="Requestservices">
      <form id="form2" runat="server">
<div>
    <center>
      <asp:Button ID="Button1" runat="server" Text="Request Debit Card" BorderColor="#36c4ed" BackColor="#36c4ed" Height="50px" Width="280px" OnClick="Button1_Click1" ></asp:Button>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Request Credit Card" BorderColor="#36c4ed" BackColor="#36c4ed" Height="50px" Width="280px" OnClick="Button2_Click"></asp:Button>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Request Cheque Book" BorderColor="#36c4ed" BackColor="#36c4ed" Height="50px" Width="280px" OnClick="Button3_Click"></asp:Button>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </center>
    
</div>
          </form>
  </section>
    
  <footer>
    <div class="container">
      <div class="row">
        <div class="col-lg-12">
          <p>Copyright © 2022 <a href="#">Confinity</a> Co., Ltd. All rights reserved. 
          
          
        </div>
      </div>
    </div>
  </footer>
    </body>
    </html>