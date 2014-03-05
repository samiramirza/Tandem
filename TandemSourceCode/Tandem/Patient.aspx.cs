using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;

namespace Tandem
{
    public partial class Patient : System.Web.UI.Page
    {
        #region Events
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
       
        /// <summary>
        /// To proceess the Patient AOB info and send the info to echosign.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnInsurance_Click(object sender, EventArgs e)
        {
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                
                using (MemoryStream ms = new MemoryStream())
                {
                    using (XmlWriter writer = XmlWriter.Create(ms))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("Document");
                        writer.WriteAttributeString("type", "WebPIF");
                        writer.WriteElementString("FirstName", txtFrst.Text.Trim());
                        writer.WriteElementString("MiddleName", txtMiddle.Text.Trim());
                        writer.WriteElementString("LastName", txtLast.Text.Trim());
                        writer.WriteElementString("Gender", radGender.SelectedValue);
                        writer.WriteElementString("DateOfBirth", txtDOB.Text.Trim());
                        writer.WriteElementString("SocialSecurityNumber", txtSecurity.Text.Trim());
                        writer.WriteElementString("Address", txtaddress.Text.Trim());
                        writer.WriteElementString("City", txtCity.Text.Trim());
                        writer.WriteElementString("State", txtState.Text.Trim());
                        writer.WriteElementString("Zipcode", txtZip.Text.Trim());
                        writer.WriteElementString("PrimaryPhone", txtPrimry.Text.Trim());
                        writer.WriteElementString("SecondryPhone", txtSecondry.Text.Trim());
                        writer.WriteElementString("TeritaryPhone", txtTertry.Text.Trim());
                        writer.WriteElementString("EmailAddress", txtEmail.Text.Trim());
                        writer.WriteElementString("PrefferedContact", radMethdofContect.SelectedValue);
                        writer.WriteElementString("BestTimeToCall", radBstTime.SelectedValue);
                        writer.WriteElementString("EmergencyContact", txtEmrgncyContct.Text.Trim());
                        writer.WriteElementString("EmergencyPhone", txtEmrgncyPhone.Text.Trim());
                        writer.WriteElementString("EmergencyRelationship", txtEmrgncyRealtnship.Text.Trim());

                        writer.WriteStartElement("PrescriberInfo");
                        writer.WriteElementString("PrescribingProviderName", txtProviderName.Text.Trim());
                        writer.WriteElementString("OfficeStreetAddress", txtStreetAddress.Text.Trim());
                        writer.WriteElementString("City", txtCityPres.Text.Trim());
                        writer.WriteElementString("State", txtStatePres.Text.Trim());
                        writer.WriteElementString("Zipcode", txtZipPres.Text.Trim());
                        writer.WriteElementString("Speciality", txtSpeciality.Text.Trim());
                        writer.WriteElementString("PhoneNumber", txtPhonePres.Text.Trim());
                        writer.WriteElementString("FaxNumber", txtFaxPres.Text.Trim());
                        writer.WriteElementString("GroupPracticeName", txtGrupPractis.Text.Trim());
                        writer.WriteElementString("OfficeContactName", txtOfficeContct.Text.Trim());
                        writer.WriteEndElement();

                        writer.WriteStartElement("PrimaryInsurance");
                        writer.WriteElementString("InsuranceName", txtNameIns.Text.Trim());
                        writer.WriteElementString("MailingStreetAddress", txtStreetAdressIns.Text.Trim());
                        writer.WriteElementString("City", txtCityIns.Text.Trim());
                        writer.WriteElementString("State", txtStateIns.Text.Trim());
                        writer.WriteElementString("ZipCode", txtZipIns.Text.Trim());
                        writer.WriteElementString("PolicyHolderName", txtPolNameIns.Text.Trim());
                        writer.WriteElementString("Relationship", radRelationIns.SelectedValue);
                        if (radMedicareIns.Checked)
                            writer.WriteElementString("Medicare", "true");
                        else
                            writer.WriteElementString("Medicare", "false");

                        writer.WriteElementString("MedicareNumber", txtMediNumIns.Text.Trim());
                        writer.WriteElementString("EmployerName", txtEmplolyerIns.Text.Trim());
                        writer.WriteElementString("PhoneNumber", txtPhoneIns.Text.Trim());
                        writer.WriteElementString("FaxNumber", txtFaxIns.Text.Trim());
                        writer.WriteElementString("PolicyNumber", txtPolNumIns.Text.Trim());
                        writer.WriteElementString("GroupNumber", txtGrupIns.Text.Trim());
                        writer.WriteElementString("PlanType", radPlanTypeIns.SelectedValue);
                        writer.WriteElementString("PolicyHolderDOB", txtPolDOBIns.Text.Trim());
                        writer.WriteElementString("PolicyHolderSocialSecurityNumber", txtPolSSNIns.Text.Trim());
                        writer.WriteEndElement();

                        writer.WriteStartElement("SecondaryInsurance");
                        writer.WriteElementString("InsuranceName", txtNameSec.Text.Trim());
                        writer.WriteElementString("MailingStreetAddress", txtStreetAdresSec.Text.Trim());
                        writer.WriteElementString("City", txtCitySec.Text.Trim());
                        writer.WriteElementString("State", txtStateSec.Text.Trim());
                        writer.WriteElementString("ZipCode", txtZipSec.Text.Trim());
                        writer.WriteElementString("PolicyHolderName", txtPolNameSec.Text.Trim());
                        writer.WriteElementString("Relationship", radRelationSec.SelectedValue);

                        if (radMedicareSec.Checked)
                            writer.WriteElementString("Medicare", "true");
                        else
                            writer.WriteElementString("Medicare", "false");

                        writer.WriteElementString("MedicareNumber", txtMediNumSec.Text.Trim());
                        writer.WriteElementString("EmployerName", txtEmployerSec.Text.Trim());
                        writer.WriteElementString("PhoneNumber", txtPhnSec.Text.Trim());
                        writer.WriteElementString("FaxNumber", txtFaxSec.Text.Trim());
                        writer.WriteElementString("PolicyNumber", txtPolNumSec.Text.Trim());
                        writer.WriteElementString("GroupNumber", txtGroupSec.Text.Trim());
                        writer.WriteElementString("PlanType", radPlanTypeSec.SelectedValue);
                        writer.WriteElementString("PolicyHolderDOB", txtPolDOBSec.Text.Trim());
                        writer.WriteElementString("PolicyHolderSocialSecurityNumber", txtPolSSNSec.Text.Trim());
                        writer.WriteEndElement();

                        string docName = txtFrst.Text.Trim() + txtLast.Text.Trim() + "_" + DateTime.Now.ToString("MMddyy") + DateTime.Now.Hour + DateTime.Now.Minute + ".pdf";
                        writer.WriteStartElement("SignedDocument");
                        writer.WriteElementString("Name", docName);
                        writer.WriteElementString("Content", "");
                        writer.WriteEndElement();


                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                        writer.Flush();
                        writer.Close();
                    }
                    XmlDocument doc = new XmlDocument();
                    ms.Position = 0;
                    doc.Load(ms);

                    string pifXML = doc.OuterXml.ToString();
                    Session["pifXML"] = pifXML;
                }
                Response.Redirect("VerifyInfo.aspx");
            }
            catch (Exception ex)
            {
                if ((ex is System.Threading.ThreadAbortException))
                {
                    return;
                }
                else
                {
                    SendErrorMail(ex.Message);
                }
            }
        }

        #endregion

        #region Methods
        void SendErrorMail(string msg)
        {

            string err = "Error Caught \n" +
                          "Error in: " + Request.Url.ToString() +
                          "\nError Message:" + msg;
                    
            MailMessage mMailMessage = new MailMessage();
            mMailMessage.To.Add(ConfigurationManager.AppSettings["ErrorEmail"]);
            mMailMessage.Bcc.Add("samiram@grazitti.com");
            mMailMessage.From = new MailAddress(ConfigurationManager.AppSettings["FromEmail"], ConfigurationManager.AppSettings["FromName"]);
            mMailMessage.Subject = ConfigurationManager.AppSettings["Subject"];
            mMailMessage.Body = err;

            var client = new SmtpClient(ConfigurationManager.AppSettings["SMTPSERVER"], Convert.ToInt32(ConfigurationManager.AppSettings["SMTPPORT"]));

            if(ConfigurationManager.AppSettings["UserName"].ToString()!="")
                client.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["UserName"], ConfigurationManager.AppSettings["Password"]);

            if(ConfigurationManager.AppSettings["IsSSL"].ToString()=="1")
                client.EnableSsl = true;
            
            client.Send(mMailMessage);
            mMailMessage.Dispose();
            client.Dispose();
        }
       #endregion
    }
}