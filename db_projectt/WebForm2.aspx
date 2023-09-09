<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="db_projectt.WebForm2" %>


<!DOCTYPE html>
<html lang="en">

  <head runat="server" >
  

    <meta charset="utf-8">
    <meta name="author" content="templatemo">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@100;300;400;500;700;900&display=swap" rel="stylesheet">

    <title>FEEDBACK</title>

    <!-- Bootstrap core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">


    <!-- Additional CSS Files -->
    <link rel="stylesheet" href="assets/css/fontawesome.css">
    <link rel="stylesheet" href="assets/css/templatemo-snapx-photography.css">
    <link rel="stylesheet" href="assets/css/owl.css">
    <link rel="stylesheet" href="assets/css/animate.css">
    <link rel="stylesheet"href="https://unpkg.com/swiper@7/swiper-bundle.min.css"/>

</head>

<body>


  
    <form id="form2" runat="server"> 
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


  



      <br>
      <br>
    <hr>
      <br>
      <br>

      
  <section class="contact-us">
    <div class="container">
      <div class="row">
        <div class="col-lg-12">
          <div class="section-heading text-center">
		  
 
            <h1 style = " margin:auto;" >Feed back </h1>
              <div style =" background-color :yellow; ">
              <h1 style =" z-index :999;color :blue ;" id ="message_t1" runat="server" ></h1>

              </div>

        </div>

        </div>

        </div>

        </div>
      </section>

      


      <br>
    
        <div style =" display: flex;  justify-content: center;">
          
            <div class="row">        
    <hr>
              <div class="col-lg-6">
                <fieldset></fieldset> 

                 <h6>Name :  </h6> <br><asp:TextBox ID="name_t1" Text="" runat="server"></asp:TextBox>
                
              </div>
                <br>
              <div class="col-lg-6">
                <fieldset>
                 
  <!-- ***** Header Area Start ***** <h6>Emial :  </h6><br> <asp:TextBox ID="email_t1" Text="" runat="server"></asp:TextBox>-->
                </fieldset>
              </div>
            <br>
              <div class="col-lg-12">
                <fieldset>
            <br>
                <h6>Feedback :  </h6><br>  <asp:TextBox ID="txt_t1" TextMode="multiline" runat="server"></asp:TextBox>
                </fieldset>
              </div>
               
            <br>
              <div class="col-lg-12">
                <fieldset> </fieldset>
            <br>
                  <asp:Button ID="btnSave_t1" Text="Save Form" runat="server" OnClick ="Save_feeback" />
               
       <asp:GridView ID="ItemGrid" runat="server"></asp:GridView>
     
              </div>
            </div>
            <hr>
            <br>
    
    <hr>
         
        </div>
      </div>    
        
    <br>   
    <br>
    <hr>

        <h2>INFO</h2> <br><br>

    <div style =" display: flex;  justify-content: center;">
        

       <asp:GridView ID="ItemGrid2" runat="server"></asp:GridView>


    </div>
            
    <br>   
    <br>    
    <br>   
    <br>

  <section class="contact-us">
    <div class="container">
      <div class="row">
        <div class="col-lg-12">
          <div class="section-heading text-center">
		  
		  
 
            <h4>Contact us</h4>
          </div>
        </div>
        <div class="col-lg-4">
          <div class="info-item">
            <i class="fa fa-phone"></i>
			<h4 >Phone Number<br>
            
            <span><a href="#">010-020-0340</a><br><a href="#">090-080-0760</a></span></h4>
          </div>  
        </div>
		
        <div class="col-lg-4">
          <div class="info-item">
            <i class="fa fa-envelope"></i>
            <h4 >Email<br>
            <span><a href="#">confinity_info@company.com</a><br><a href="#">confinity@company.com</a></span></h4>
          </div>
        </div>
          
          <div class="col-lg-4">
          <div class="info-item">
            <i class="fa fa-envelope"></i>
            <h4 >address<br>
            <span><a href="#">confinity_info@company.com</a><br><a href="#">confinity@company.com</a></span></h4>
          </div>
        </div> 
        
		</div>
       
       
        </div>
      </section>

      
  <footer>
    <div class="container">
      <div class="row">
        <div class="col-lg-12">
          
        </div>
      </div>
    </div>
  </footer>


    </form>


   </body>
</html>
