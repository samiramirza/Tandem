<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Thankyou.aspx.cs" Inherits="Tandem.Thankyou" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
    <title>Thank You</title>
    <link rel="stylesheet" type="text/css" href="Scripts/siteSpecific.css" />
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />
    <style type="text/css">form{width:960px; margin:0 auto;}</style>
</head>
<body style="background-color:white">
   
    <form>
                <div class="outer-div" id="thanksMSG" runat="server" style="padding-left:10px;padding-right:10px;" visible="false">
      
     <div class="inner-div" >
        <h1  class="section-header">Thank you!</h1>
        <p  class="section-summary">We have received your information.  A member of our team will reach out to you in the next two business days.  If you have any questions in the meantime, or if you don’t hear from us soon, please feel free to contact us at (877) 801-6901.</p>
        </div >
                    </div>
    <div  id="errorMsg" runat="server" visible="false"><br />
                <asp:Label ID="lblError" runat="server" style="color: #696A6C;font-family: 'Open Sans',sans-serif,Helvetica,Arial;font-size:14px" Text="Your session time has expired. Please re-submit your information. " ></asp:Label>
        </div >
	
   </form>
        
</body>
</html>
