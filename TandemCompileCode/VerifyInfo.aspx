<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerifyInfo.aspx.cs" Inherits="Tandem.VerifyInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css'>
      <style type="text/css">form{width:772px; margin:0 auto;}</style>
     <script type="text/javascript" src="http://ajax.aspnetcdn.com/ajax/jquery/jquery-1.9.0.js"></script>
</head>
<body>
     <label id="ss" style="display:none;color:#696a6c;text-align:center;margin:0 auto;width:960px;">Please do not press either Back Button or Refresh until you are redirected to Thank You Page.<img alt="loading.." src="Patient_Images/loading.gif" style="border:0px"/><br /></label>
    <form id="form1" runat="server" >
         
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
    <div>
        <asp:Label ID="lblError" runat="server" style="color: #696A6C;font-family: 'Open Sans',sans-serif,Helvetica,Arial;font-size:14px" Text="Your session time has expired. Please re-submit your information. " Visible="false"></asp:Label>
    
    </div>
      
    </form>

    <script language="javascript" type="text/javascript">
        $(document).ready(function () {
          getUserInfo();
        });

        function getUserInfo() {
            $.ajax({
               type: "POST",
               contentType: "application/json; charset=utf-8",
               dataType: "json",
                async: true,
                url: 'VerifyInfo.aspx/checkDocumentStatus',
                success: function (resp) {
                  
                    if (resp.d == "false") {
                        getUserInfo();
                    }
                    else {
                        document.getElementById('ss').style.display = "block";
                        window.location.href = "Thankyou.aspx";
                    }

                },
                error: function (result) {
                getUserInfo();
                }
            });
        }
    </script>
</body>
</html>
