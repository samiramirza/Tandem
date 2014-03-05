<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Thankyou.aspx.cs" Inherits="Tandem.Thankyou" %>


<html>
<head>
    <title>ThankYou</title>
    <link rel="stylesheet" type="text/css" href="Scripts/siteSpecific.css" />
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css'>
</head>
<body style="background-color:white">
   

                <div class="outer-div">
      
     <div class="inner-div" id="thanksMSG" runat="server" visible="false">
        <h1  class="section-header">Thank you!</h1>
        <p  class="section-summary">We have received your information.  A member of our team will reach out to you in the next two business days.  If you have any questions in the meantime, or if you don’t hear from us soon, please feel free to contact us at (877) 801-6901.</p>
        </div >
      <div class="inner-div" id="errorMsg" runat="server" visible="false">
        <p  class="section-summary"><asp:Label ID="lblError" runat="server" Text="Your session time has expired. Please re-submit your information. " ></asp:Label></p>
        </div >
	
 
                    </div>
   
        <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css'>
</body>
</html>
