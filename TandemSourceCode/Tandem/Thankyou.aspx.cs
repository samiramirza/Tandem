using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using Tandem.TandemEchoSign;
using Tandem.TandemIntegration;
using System.Xml;
using System.Net.Mail;
using System.Net;
using Tandem.Common;

namespace Tandem
{
    public partial class Thankyou : System.Web.UI.Page
    {
        #region "Events"
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //get the signed document from echo sign and send info to tandem api
                if (Session["childKey"] != null && Session["pifXML"] != null)
                {
                    string childKey = Session["childKey"].ToString();
                    EchoSignDocumentService17PortTypeClient ES = new EchoSignDocumentService17PortTypeClient();
                    GetFormDataResult sss = ES.getFormData(ConfigurationManager.AppSettings["APIKey"], childKey);
                    string[] latestDoc = sss.formDataCsv.ToString().Split(',');
                    byte[] data = ES.getLatestDocument(ConfigurationManager.AppSettings["APIKey"], latestDoc[14].Replace("\"", "").Replace("\n", ""));
                    string base64String;
                    base64String = System.Convert.ToBase64String(data, 0, data.Length);
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(Session["pifXML"].ToString());

                    doc.SelectSingleNode("descendant::Document/SignedDocument/Content").InnerText = base64String;
                    TandemIntegrationClient objClient = new TandemIntegrationClient();
                    string msg = objClient.ReceiveXMLMessage(doc.OuterXml.Replace("<?xml version=\"1.0\" encoding=\"utf-8\"?>",""));
                    if (msg.ToLower() == "success")
                        thanksMSG.Visible = true;
                    else
                    {
                        errorMsg.Visible = true;
                        lblError.Text = "Error processing your request. Please try after some time.";
                        ErrorLogs.SendErrorMail(msg, Request.Url.ToString());
                    }

                }
                else
                {
                    errorMsg.Visible = true;
                }
                Session.Clear();
                Session.Abandon();
            }
            catch (Exception ex)
            {
                errorMsg.Visible = true;
                lblError.Text = "Error processing your request. Please try after some time.";
                if ((ex is System.Threading.ThreadAbortException))
                {
                    return;
                }
                else
                {
                    ErrorLogs.SendErrorMail(ex.Message, Request.Url.ToString());
                }
            }
        }
        #endregion
    }
}
