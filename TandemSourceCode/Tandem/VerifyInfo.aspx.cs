using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Tandem.TandemEchoSign;
using System.Configuration;
using System.Xml;
using System.Web.Services;
using System.Net.Mail;
using System.Net;

namespace Tandem
{
    public partial class VerifyInfo : System.Web.UI.Page
    {
        #region "Events"

        /// <summary>
        /// Send file to echo sign and display widget for esignature.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["pifXML"] != null)
                {
                    Session["childKey"] = null;
                    string FirstName, MiddleName, LastName, Address, City, State, ZipCode, PrimaryPhone, SecondaryPhone, TertiaryPhone,
                    BestTimeToCall, Email, EmergencyContact, EmergencyPhone, EmergencyRelationship, Gender, DOB,
                    SSN, PMethodContact;

                    string Name, Speciality, OfficeAddress, PresCity, PresState, PresZipCode, GroupPracticeName, OfficeContactName, Phone, Fax;
                    string PName, PClaimsAddress, PCity, PState, PZipCode, PPolicyNo, PGroupNo, PPlanType, PPolicyHolderNameD,
                    PPatientRelationship, IfMedicare, PMedicareNo, PEmployerName, PPhoneNo, PFax, PPolicyHolderDOB, PPolicyHolderSSN,
                    SName, SClaimsAddress, SCity, SState, SZipCode, SPolicyNo, SGroupNo, SPlanType, SPolicyHolderNameD,
                    SPatientRelationship, SIfMedicare, SMedicareNo, SEmployerName, SPhoneNo, SFax, PPolicyHolderDOB1,
                    PPolicyHolderSSN1;

                    XmlDocument doc = new XmlDocument();
               //     doc.Load(Server.MapPath("sample1.xml"));
               doc.LoadXml(Session["pifXML"].ToString());
                  
                    //Step1
                    FirstName = doc.SelectSingleNode("descendant::Document/FirstName") != null ? doc.SelectSingleNode("descendant::Document/FirstName").InnerText : "";
                    MiddleName = doc.SelectSingleNode("descendant::Document/MiddleName") != null ? doc.SelectSingleNode("descendant::Document/MiddleName").InnerText : "";
                    LastName = doc.SelectSingleNode("descendant::Document/LastName") != null ? doc.SelectSingleNode("descendant::Document/LastName").InnerText : "";
                    Address = doc.SelectSingleNode("descendant::Document/Address") != null ? doc.SelectSingleNode("descendant::Document/Address").InnerText : "";
                    City = doc.SelectSingleNode("descendant::Document/City") != null ? doc.SelectSingleNode("descendant::Document/City").InnerText : "";
                    State = doc.SelectSingleNode("descendant::Document/State") != null ? doc.SelectSingleNode("descendant::Document/State").InnerText : "";
                    ZipCode = doc.SelectSingleNode("descendant::Document/Zipcode") != null ? doc.SelectSingleNode("descendant::Document/Zipcode").InnerText : "";
                    PrimaryPhone = doc.SelectSingleNode("descendant::Document/PrimaryPhone") != null ? doc.SelectSingleNode("descendant::Document/PrimaryPhone").InnerText : "";
                    SecondaryPhone = doc.SelectSingleNode("descendant::Document/SecondryPhone") != null ? doc.SelectSingleNode("descendant::Document/SecondryPhone").InnerText : "";
                    TertiaryPhone = doc.SelectSingleNode("descendant::Document/TeritaryPhone") != null ? doc.SelectSingleNode("descendant::Document/TeritaryPhone").InnerText : "";
                    BestTimeToCall = doc.SelectSingleNode("descendant::Document/BestTimeToCall") != null ? doc.SelectSingleNode("descendant::Document/BestTimeToCall").InnerText : "";
                    Email = doc.SelectSingleNode("descendant::Document/EmailAddress") != null ? doc.SelectSingleNode("descendant::Document/EmailAddress").InnerText : "";
                    EmergencyContact = doc.SelectSingleNode("descendant::Document/EmergencyContact") != null ? doc.SelectSingleNode("descendant::Document/EmergencyContact").InnerText : "";
                    EmergencyPhone = doc.SelectSingleNode("descendant::Document/EmergencyPhone") != null ? doc.SelectSingleNode("descendant::Document/EmergencyPhone").InnerText : "";
                    EmergencyRelationship = doc.SelectSingleNode("descendant::Document/EmergencyRelationship") != null ? doc.SelectSingleNode("descendant::Document/EmergencyRelationship").InnerText : "";
                    Gender = doc.SelectSingleNode("descendant::Document/Gender") != null ? doc.SelectSingleNode("descendant::Document/Gender").InnerText : "";
                    DOB = doc.SelectSingleNode("descendant::Document/DateOfBirth") != null ? doc.SelectSingleNode("descendant::Document/DateOfBirth").InnerText : "";
                    SSN = doc.SelectSingleNode("descendant::Document/SocialSecurityNumber") != null ? doc.SelectSingleNode("descendant::Document/SocialSecurityNumber").InnerText : "";
                    PMethodContact = doc.SelectSingleNode("descendant::Document/PrefferedContact") != null ? doc.SelectSingleNode("descendant::Document/PrefferedContact").InnerText : "";

                    //Step2
                    Name = doc.SelectSingleNode("descendant::Document/PrescriberInfo/PrescribingProviderName") != null ? doc.SelectSingleNode("descendant::Document/PrescriberInfo/PrescribingProviderName").InnerText : "";
                    Speciality = doc.SelectSingleNode("descendant::Document/PrescriberInfo/Speciality") != null ? doc.SelectSingleNode("descendant::Document/PrescriberInfo/Speciality").InnerText : "";
                    OfficeAddress = doc.SelectSingleNode("descendant::Document/PrescriberInfo/OfficeStreetAddress") != null ? doc.SelectSingleNode("descendant::Document/PrescriberInfo/OfficeStreetAddress").InnerText : "";
                    PresCity = doc.SelectSingleNode("descendant::Document/PrescriberInfo/City") != null ? doc.SelectSingleNode("descendant::Document/PrescriberInfo/City").InnerText : "";
                    PresState = doc.SelectSingleNode("descendant::Document/PrescriberInfo/State") != null ? doc.SelectSingleNode("descendant::Document/PrescriberInfo/State").InnerText : "";
                    PresZipCode = doc.SelectSingleNode("descendant::Document/PrescriberInfo/Zipcode") != null ? doc.SelectSingleNode("descendant::Document/PrescriberInfo/Zipcode").InnerText : "";
                    GroupPracticeName = doc.SelectSingleNode("descendant::Document/PrescriberInfo/GroupPracticeName") != null ? doc.SelectSingleNode("descendant::Document/PrescriberInfo/GroupPracticeName").InnerText : "";
                    OfficeContactName = doc.SelectSingleNode("descendant::Document/PrescriberInfo/OfficeContactName") != null ? doc.SelectSingleNode("descendant::Document/PrescriberInfo/OfficeContactName").InnerText : "";
                    Phone = doc.SelectSingleNode("descendant::Document/PrescriberInfo/PhoneNumber") != null ? doc.SelectSingleNode("descendant::Document/PrescriberInfo/PhoneNumber").InnerText : "";
                    Fax = doc.SelectSingleNode("descendant::Document/PrescriberInfo/FaxNumber") != null ? doc.SelectSingleNode("descendant::Document/PrescriberInfo/FaxNumber").InnerText : "";

                    //Step3 Primary
                    PName = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/InsuranceName") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/InsuranceName").InnerText : "";
                    PClaimsAddress = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/MailingStreetAddress") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/MailingStreetAddress").InnerText : "";
                    PCity = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/City") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/City").InnerText : "";
                    PState = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/State") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/State").InnerText : "";
                    PZipCode = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/ZipCode") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/ZipCode").InnerText : "";
                    PPolicyNo = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/PolicyNumber") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/PolicyNumber").InnerText : "";
                    PGroupNo = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/GroupNumber") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/GroupNumber").InnerText : "";
                    PPlanType = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/PlanType") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/PlanType").InnerText : "";
                    PPolicyHolderNameD = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/PolicyHolderName") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/PolicyHolderName").InnerText : "";
                    PPatientRelationship = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/Relationship") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/Relationship").InnerText : "";
                    IfMedicare = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/Medicare") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/Medicare").InnerText : "";
                    PMedicareNo = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/MedicareNumber") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/MedicareNumber").InnerText : "";
                    PEmployerName = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/EmployerName") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/EmployerName").InnerText : "";
                    PPhoneNo = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/PhoneNumber") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/PhoneNumber").InnerText : "";
                    PFax = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/FaxNumber") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/FaxNumber").InnerText : "";
                    PPolicyHolderDOB = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/PolicyHolderDOB") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/PolicyHolderDOB").InnerText : "";
                    PPolicyHolderSSN = doc.SelectSingleNode("descendant::Document/PrimaryInsurance/PolicyHolderSocialSecurityNumber") != null ? doc.SelectSingleNode("descendant::Document/PrimaryInsurance/PolicyHolderSocialSecurityNumber").InnerText : "";

                    //Step3 Secondry   
                    SName = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/InsuranceName") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/InsuranceName").InnerText : "";
                    SClaimsAddress = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/MailingStreetAddress") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/MailingStreetAddress").InnerText : "";
                    SCity = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/City") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/City").InnerText : "";
                    SState = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/State") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/State").InnerText : "";
                    SZipCode = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/ZipCode") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/ZipCode").InnerText : "";
                    SPolicyNo = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/PolicyNumber") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/PolicyNumber").InnerText : "";
                    SGroupNo = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/GroupNumber") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/GroupNumber").InnerText : "";
                    SPlanType = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/PlanType") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/PlanType").InnerText : "";
                    SPolicyHolderNameD = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/PolicyHolderName") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/PolicyHolderName").InnerText : "";
                    SPatientRelationship = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/Relationship") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/Relationship").InnerText : "";
                    SIfMedicare = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/Medicare") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/Medicare").InnerText : "";
                    SMedicareNo = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/MedicareNumber") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/MedicareNumber").InnerText : "";
                    SEmployerName = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/EmployerName") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/EmployerName").InnerText : "";
                    SPhoneNo = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/PhoneNumber") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/PhoneNumber").InnerText : "";
                    SFax = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/FaxNumber") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/FaxNumber").InnerText : "";
                    PPolicyHolderDOB1 = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/PolicyHolderDOB") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/PolicyHolderDOB").InnerText : "";
                    PPolicyHolderSSN1 = doc.SelectSingleNode("descendant::Document/SecondaryInsurance/PolicyHolderSocialSecurityNumber") != null ? doc.SelectSingleNode("descendant::Document/SecondaryInsurance/PolicyHolderSocialSecurityNumber").InnerText : "";

                    EchoSignDocumentService17PortTypeClient ES = new EchoSignDocumentService17PortTypeClient();
                    WidgetCreationInfo info = new WidgetCreationInfo();
                    TandemEchoSign.FileInfo[] fs = new TandemEchoSign.FileInfo[1];
                    Tandem.TandemEchoSign.FileInfo finfo = new Tandem.TandemEchoSign.FileInfo();
                    finfo.fileName = "PatientInfo";
                    finfo.mimeType = "text/html";
                    string sVal;

                    sVal = "<html><head><title>Patient_Info_AOB-1</title><style type='text/css'>body { background: #fff; color: #231F20; font:18px arial, Sans-Serif;  margin: 0; }.outerdiv{width:875px;background-color: #fff;margin:0 auto;padding:0px 27px;height:auto;float:left;}.uperdiv{float:left;width:100%;margin-top:-12px;margin-bottom:10px}table{border-collapse: collapse; width: 100%;float:left;border:0px solid #000;}table td{border-right: 1px solid #231F20; border-top: 1px solid #231F20;height:30px;border-left:0px; border-bottom:0px;}p{margin:0 !important;color: #231F20;}.s4 {font-size: 7pt; font-style: normal; font-weight: normal;text-decoration: none;vertical-align: top;  text-align: left;}.s1{font-size:10.7pt; font-style: normal; font-weight: bold;text-decoration: none;vertical-align: bottom !important;  text-align: left; height:10px}.Lowertext {text-decoration: none;margin-top:2px !important; font-family:Arial Narrow;font-size:10px;}.result{font-size:12px}</style></head>" +
                        "<body><div class='outerdiv'><div class='uperdiv' style='margin:6px 0 !important;'><div style='float:left;width:30%'><img src='" + ConfigurationManager.AppSettings["logo"] + "' /></div><div style='float:left;width:50%;text-align:center;padding-top:14px;'><p style='font-size:16pt;'>PATIENT INFORMATION / AOB</p><p style='font-size:7.8pt;margin-top:4px;'>This form can also be filled out online at</p><p style='font-size:8pt;font-weight:bold;font-style:normal;'>www.tandemdiabetes.com</p></div></div>" +
                        "<div id='main' style='float:left;'><div style='height:1080px;'><table style='margin-top:15px;margin-bottom:15px;' ><tr><td rowspan='6' style='width:43px;border-left: 1px solid #231F20;border-bottom: 1px solid #231F20;'><img src='" + ConfigurationManager.AppSettings["step1"] + "' style='width:40px;height:183px;border:0' /></td><td colspan='3' class='s4' style='width:65%;'>PATIENT' S NAME (FIRST MIDDLE LAST)<p class='result'>" + FirstName + " " + MiddleName + " " + LastName + "</p></td>" +
                    "<td class='s4'>GENDER" +
                    "<div style='font-size:8.8pt;'><input type='checkbox'" + (Gender == "Male" ? "checked=checked" : "") + "/>Male <input type='checkbox' value='Female'" + (Gender == "Male" ? "" : "checked=checked") + "/>Female</div></td></tr>" +
                    "<tr><td colspan='3' class='s4' >PATIENT' S STREET ADDRESS<p class='result' >" + Address + "</p></td>" +
                    "<td class='s4'>DATE OF BIRTH (MM/DD/YYYY)<p class='result'>" + DOB + "</p></td></tr>" +
                    "<tr><td colspan='3' class='s4'><table cellpadding='0' cellspacing='0' border='0'><tr><td width='60%' style='border:none;height:auto;' class='s4'>CITY</td><td width='20%' style='border:none;height:auto;' class='s4'>STATE</td><td width='20%' style='border:none;height:auto;' class='s4'>ZIP CODE</td></tr><tr><td width='60%' style='border:none;height:auto;' class='s4 result'>" + City + "</td> <td width='20%' style='border:none;height:auto;' class='s4 result'>" + State + "</td><td width='20%' style='border:none;height:auto;' class='s4 result'>" + ZipCode + "</td></tr></table></td>" +
                    "<td class='s4'>SOCIAL SECURITY NUMBER<p class='result'>" + SSN + "</p></td></tr>" +
                    "<tr><td class='s4' width='20%'>PRIMARY PHONE<p class='result'>" + PrimaryPhone + "</p></td>" +
                    "<td class='s4' width='20%'>SECONDARY PHONE<p class='result'>" + SecondaryPhone + "</p></td>" +
                    "<td class='s4' width='20%'>TERTIARY PHONE<p class='result'>" + TertiaryPhone + "</p></td> <td class='s4'>PREFERRED METHOD OF CONTACT<div style='font-size:10pt;'><input type='checkbox' value='Phone'" + (PMethodContact == "Phone" ? "checked=checked" : "") + "/>Phone <input type='checkbox' value='Email'" + (PMethodContact == "Email" ? "checked=checked" : "") + "/>Email</div></td></tr><tr><td colspan='2' class='s4'>BEST TIME TO CALL" +
                    "<div style='font-size:8.8pt;'><input type='checkbox' value='Morning'" + (BestTimeToCall == "Morning" ? "checked=checked" : "") + "/>Morning<input type='checkbox' value='Afternoon'" + (BestTimeToCall == "Afternoon" ? "checked=checked" : "") + "/>Afternoon <input type='checkbox' value='Evening'" + (BestTimeToCall == "Evening" ? "checked=checked" : "") + "/>Evening</div></td>" +
                    "<td colspan='3'  class='s4'>EMAIL ADDRESS<p class='result'>" + Email + "</p></td></tr>" +
                    "<tr><td  colspan='2' class='s4' style='border-bottom: 1px solid #231F20;'>EMERGENCY CONTACT<p class='result' >" + EmergencyContact + "</p></td>" +
                    "<td  class='s4'  style='border-bottom: 1px solid #231F20;'>PHONE NUMBER<p class='result'>" + EmergencyPhone + "</p></td>" +
                    "<td class='s4' style='border-bottom: 1px solid #231F20;'>RELATIONSHIP<p class='result'>" + EmergencyRelationship + "</p></td></tr>" +
                    "</table>" +
                    "<table style='margin-bottom:15px;'>" +
                    "<tr><td rowspan='4' style='width:43px;border-left: 1px solid #231F20;border-bottom: 1px solid #231F20;'><img src='" + ConfigurationManager.AppSettings["step2"] + "' style='width:41px;height:122px;border:0px;' /></td>" +
                    "<td colspan='3' style='width:67%;' class='s4' style='border-bottom: 2px solid #231F20;'>PRESCRIBING PROVIDER'S NAME<p class='result'>" + Name + "</p></td>" +
                    "<td  class='s4' style='border-bottom: 2px solid #231F20;'>SPECIALTY<p class='result'>" + Speciality + "</p></td></tr>" +
                    "<tr><td colspan='3' class='s4'>OFFICE STREET ADDRESS<p class='result'>" + OfficeAddress + "</p></td>" +
                    "<td class='s4'>PHONE NUMBER<p class='result'>" + Phone + "</p></td></tr>" +
                    "<tr><td colspan='3' class='s4'><table cellpadding='0' cellspacing='0' border='0'><tr><td width='60%' style='border:none;height:auto;' class='s4'>CITY</td><td width='20%' style='border:none;height:auto;' class='s4'>STATE</td><td width='20%' style='border:none;height:auto;' class='s4'>ZIP CODE</td></tr><tr><td width='60%' style='border:none;height:auto;' class='s4 result'>" + PresCity + "</td> <td width='20%' style='border:none;height:auto;' class='s4 result'>" + PresState + "</td><td width='20%' style='border:none;height:auto;' class='s4 result'>" + PresZipCode + "</td></tr></table></td>" +
                    "<td  class='s4'>FAX NUMBER<p class='result'>" + Fax + "</p></td></tr>" +
                    "<tr><td colspan='3' class='s4' style='border-bottom: 1px solid #231F20;'>GROUP PRACTICE NAME<p class='result'>" + GroupPracticeName + "</p></td>" +
                    "<td class='s4' style='border-bottom: 1px solid #231F20;'>OFFICE CONTACT NAME<p class='result'>" + OfficeContactName + "</p></td></tr>" +
                    //"<tr><td colspan='2' class='s4' style='width:60%;border-bottom: 1px solid #231F20;' >GROUP PRACTICE NAME<p class='result'>" + GroupPracticeName + "</p></td>" +
                    //"<td colspan='2' style='width:40%;border-bottom: 1px solid #231F20;border-left:0px;' class='s4'>OFFICE CONTACT NAME<p class='result'>" + OfficeContactName + "</p></td></tr>" +
                    "</table>" +
                    "<table style='margin-bottom:15px;'>" +
                   "<tr>" +
                   "<td rowspan='8' style='width:43px;border-left: 1px solid #231F20;border-bottom: 1px solid #231F20;'><img  src='" + ConfigurationManager.AppSettings["step3"] + "' style='width:39px;height:209px;border:0' /></td>" +
                    "<td colspan='4' class='s1' ><img src='" + ConfigurationManager.AppSettings["arrow"] + "'/> PRIMARY INSURANCE INFORMATION (please provide a copy of the <span style='font-style:italic;font-weight:bold;text-decoration: underline;'>front and back</span> of your insurance card) <img src='" + ConfigurationManager.AppSettings["arrow"] + "'/></td></tr>" +
                    "<tr><td colspan='4' class='s4'>INSURANCE NAME<p class='result'>" + PName + "</p></td></tr>" +
                    "<tr><td colspan='3' style='width:65%;' class='s4'>CLAIMS MAILING STREET ADDRESS<p class='result'>" + PClaimsAddress + "</p></td>" +
                    "<td class='s4'>PHONE NUMBER<p class='result'>" + PPhoneNo + "</p></td></tr>" +
                    "<tr><td colspan='3' class='s4'><table cellpadding='0' cellspacing='0' border='0'><tr><td width='60%' style='border:none;height:auto;' class='s4'>CITY</td><td width='20%' style='border:none;height:auto;' class='s4' style='border:none;height:auto;' class='s4'>STATE</td><td width='20%' style='border:none;height:auto;' class='s4'>ZIP CODE</td></tr><tr><td width='60%' style='border:none;height:auto;' class='s4 result'>" + PCity + "</td> <td width='20%' style='border:none;height:auto;' class='s4 result'>" + PState + "</td><td width='20%' style='border:none;height:auto;' class='s4 result'>" + PZipCode + "</td></tr></table></td>" +
                    "<td class='s4'>FAX NUMBER<p class='result'>" + PFax + "</p></td></tr><tr><td  class='s4'>POLICY NUMBER<p class='result'>" + PPolicyNo + "</p></td>" +
                    "<td class='s4' colspan='2'>GROUP NUMBER<p class='result'>" + PGroupNo + "</p></td>" +
                    "<td colspan='2'  class='s4'>PLAN TYPE (PPO, HMO, ETC.)<p class='result'>" + PPlanType + "</p></td></tr>" +
                    "<tr><td colspan='3'  class='s4'>POLICY HOLDER'S NAME IF DIFFERENT THAN ABOVE (FIRST, MIDDLE, LAST)<p class='result'>" + PPolicyHolderNameD + "</p></td>" +
                    "<td  class='s4'>POLICY HOLDER'S DATE OF BIRTH (MM/DD/YYYY)<p class='result'>" + PPolicyHolderDOB + "</p></td></tr>" +
                    "<tr><td colspan='3'  class='s4'>RELATIONSHIP TO PATIENT" +
                    "<div style='font-size:8.8pt;'><input type='checkbox' value='Self'" + (PPatientRelationship == "Self" ? "checked=checked" : "") + "/>Self<input type='checkbox' value='Spouse'" + (PPatientRelationship == "Spouse" ? "checked=checked" : "") + "/>Spouse<input type='checkbox' value='Child'" + (PPatientRelationship == "Child" ? "checked=checked" : "") + "/>Child <input type='checkbox' value='Other'" + (PPatientRelationship == "Other" ? "checked=checked" : "") + "/>Other</div></td>" +
                    "<td class='s4'>POLICY HOLDER'S SOCIAL SECURITY NUMBER<p class='result'>" + PPolicyHolderSSN + "</p></td></tr>" +
                    "<tr style='height:10px'><td  class='s4' style='border-bottom: 1px solid #231F20;'>IF MEDICARE" +
                    "<div style='font-size:8.8pt;'><input type='checkbox' value='PartB'" + (IfMedicare == "true" ? "checked=checked" : "") + "/>Part B</div></td>" +
                    "<td  class='s4' colspan='2' style='border-bottom: 1px solid #231F20;'>MEDICARE NUMBER<p class='result'>" + PMedicareNo + "</p></td>" +
                    "<td   style='border-bottom: 1px solid #231F20;'   class='s4'>EMPLOYER'S NAME<p class='result'>" + PEmployerName + "</p></td>	</tr>" +
                    "</table></div>" +
                    "<table style='margin-bottom:25px;margin-top:10px;'>" +
                   "<tr>" +
                   "<td rowspan='8' style='width:43px;border-left: 1px solid #231F20;border-bottom: 1px solid #231F20;'><img  src='" + ConfigurationManager.AppSettings["step4"] + "' style='width:39px;height:209px;border:0' /></td>" +
                    "<td colspan='4' class='s1' ><img src='" + ConfigurationManager.AppSettings["arrow"] + "'/> SECONDARY INSURANCE INFORMATION (please provide a copy of the <span style='font-style:italic;font-weight:bold;text-decoration: underline;'>front and back</span> of your insurance card) <img src='" + ConfigurationManager.AppSettings["arrow"] + "'/></td></tr>" +
                    "<tr><td colspan='4' class='s4'>INSURANCE NAME<p class='result'>" + SName + "</p></td></tr>" +
                    "<tr><td colspan='3' style='width:65%;' class='s4'>CLAIMS MAILING STREET ADDRESS<p class='result'>" + SClaimsAddress + "</p></td>" +
                    "<td class='s4'>PHONE NUMBER<p class='result'>" + SPhoneNo + "</p></td></tr>" +
                    "<tr><td colspan='3' class='s4'><table cellpadding='0' cellspacing='0' border='0'><tr><td width='60%' style='border:none;height:auto;' class='s4'>CITY</td><td width='20%' style='border:none;height:auto;' class='s4' style='border:none;height:auto;' class='s4'>STATE</td><td width='20%' style='border:none;height:auto;' class='s4'>ZIP CODE</td></tr><tr><td width='60%' style='border:none;height:auto;' class='s4 result'>" + SCity + "</td> <td width='20%' style='border:none;height:auto;' class='s4 result'>" + SState + "</td><td width='20%' style='border:none;height:auto;' class='s4 result'>" + SZipCode + "</td></tr></table></td>" +
                    "<td class='s4'>FAX NUMBER<p class='result'>" + SFax + "</p></td></tr><tr><td  class='s4'>POLICY NUMBER<p class='result'>" + SPolicyNo + "</p></td>" +
                    "<td class='s4' colspan='2'>GROUP NUMBER<p class='result'>" + SGroupNo + "</p></td>" +
                    "<td colspan='2'  class='s4'>PLAN TYPE (PPO, HMO, ETC.)<p class='result'>" + SPlanType + "</p></td></tr>" +
                    "<tr><td colspan='3'  class='s4'>POLICY HOLDER'S NAME IF DIFFERENT THAN ABOVE (FIRST, MIDDLE, LAST)<p class='result'>" + SPolicyHolderNameD + "</p></td>" +
                    "<td  class='s4'>POLICY HOLDER'S DATE OF BIRTH (MM/DD/YYYY)<p class='result'>" + PPolicyHolderDOB1 + "</p></td></tr>" +
                    "<tr><td colspan='3'  class='s4'>RELATIONSHIP TO PATIENT" +
                    "<div style='font-size:8.8pt;'><input type='checkbox' value='Self'" + (SPatientRelationship == "Self" ? "checked=checked" : "") + "/>Self<input type='checkbox' value='Spouse'" + (SPatientRelationship == "Spouse" ? "checked=checked" : "") + "/>Spouse<input type='checkbox' value='Child'" + (SPatientRelationship == "Child" ? "checked=checked" : "") + "/>Child <input type='checkbox' value='Other'" + (SPatientRelationship == "Other" ? "checked=checked" : "") + "/>Other</div></td>" +
                    "<td class='s4'>POLICY HOLDER'S SOCIAL SECURITY NUMBER<p class='result'>" + PPolicyHolderSSN1 + "</p></td></tr>" +
                    "<tr style='height:10px'><td  class='s4' style='border-bottom: 1px solid #231F20;'>IF MEDICARE" +
                    "<div style='font-size:8.8pt;'><input type='checkbox' value='PartB'" + (SIfMedicare == "true" ? "checked=checked" : "") + "/>Part B</div></td>" +
                    "<td  class='s4' colspan='2' style='border-bottom: 1px solid #231F20;'>MEDICARE NUMBER<p class='result'>" + SMedicareNo + "</p></td>" +
                    "<td   style='border-bottom: 1px solid #231F20;'   class='s4'>EMPLOYER'S NAME<p class='result'>" + SEmployerName + "</p></td>	</tr>" +
                    "</table>" +
                    "<div style='float:left;'><p style='font-size:10px;font-family:Arial Narrow;'>Assignment of Insurance Benefits and Authorization to Release Information</p>" +
                    "<p  class='Lowertext'>Please be aware that all medical information is confidential under certain state and federal laws. Such information may not be released without your consent. Many insurance carriers require medical information to be submitted with claims to evaluate medical necessity. Please provide your written consent to release related information when required or requested to your insurance company(s) and/or your healthcare team.<br />" +
                    "I,<u>" + FirstName + " " + MiddleName + " " + LastName + "</u>, do hereby authorize Tandem Diabetes Care to acquire from and/or release to my healthcare team, and/or my insurance company(s), and/or contracted distributors any information required for the purposes of healthcare management and/or for processing all past, present and future medical claims on my behalf. I understand that upon acceptance of products from Tandem Diabetes Care," +
                     "I assume responsibility for any deductible, co-pay, or other balance not covered by my insurance carrier. I authorize Tandem Diabetes Care to submit claims to my insurance company on my behalf, and my insurance company to pay benefits directly to Tandem Diabetes Care. Should any insurance payment be made directly to the insured for monies due on this account, I agree to immediately pay over these funds to Tandem Diabetes Care. I will be informed of my insurance coverage and estimated out-of-pocket expense prior to any shipment of product or any bills being sent. This authorization will remain in effect until I revoke it in writing. I acknowledge that I have received a copy of the Notice of Privacy Practices for Tandem Diabetes Care or have reviewed the privacy policy online at tandemdiabetes.com. I will notify Tandem Diabetes Care in the event my insurance changes. If the recipient of the Tandem product is a minor, then you represent that you are the minor's guardian and you are signing on their behalf and that this signature also releases Tandem Customer " +
                     "Support to assist the minor or caretaker to provide product support at no additional charge for Tandem product and services. " +
                     "You further acknowledge that Tandem has various policies posted on Tandem's website (including Patient's Rights Policy and Privacy Policy) " +
                     "and that you agree to the terms of those policies.</p><div style='position:relative;'><div  class='Lowertext' style='position:absolute;top:100px;left:0px;' >©" + DateTime.Now.Year + " Tandem Diabetes Care, Inc. All rights reserved. 11045 Roselle Street • San Diego, California 92121 • www.tandemdiabetes.com • Customer Support (877) 801-6901</div></div><div style='position:relative;'><div style='position:absolute;top:35px;left:550px;margin-right:90px;margin-top:-15px;float:right;clear:both;'>{{S1Sig1_es_:signer1:signature}}<div style='height:15px;'></div>{{!S1Email1_es_:signer1:email}}</div></div>" +
                     "</div></div>" +
                    "</div></body></html>";

                    finfo.file = System.Text.Encoding.Default.GetBytes(sVal);
                    finfo.fileName = "Patient.html";
                    finfo.mimeType = "text/html";
                    fs[0] = finfo;
                    info.name = "Patient Info";
                    info.fileInfos = fs;
                    MergeFieldInfo minfo = new MergeFieldInfo();
                    MergeField[] mMergeFields = new MergeField[1];
                    MergeField mfield = new MergeField();
                    mfield.fieldName = "S1Email1";
                    mfield.defaultValue = Email;
                    mMergeFields[0] = mfield;
                    minfo.mergeFields = mMergeFields;

                    info.mergeFieldInfo = minfo;
                    SenderInfo sinfo = new SenderInfo();
                    sinfo.email = ConfigurationManager.AppSettings["EchoSignUsername"].ToString();
                    sinfo.password = ConfigurationManager.AppSettings["EchoSignPassword"].ToString();
                    EmbeddedWidgetCreationResult ews = ES.createEmbeddedWidget(ConfigurationManager.AppSettings["APIKey"].ToString(), sinfo, info);
                    if (ews.success)
                    {
                        Session["childKey"] = ews.documentKey;
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "echoscript", ews.javascript);
                    }
                    else
                    {
                     
                        lblError.Visible = true;
                        lblError.Text = "Error processing your request. Please try after some time.";
                        SendErrorMail(ews.errorMessage);
                    }
                }
                else
                {
                    
                    lblError.Visible = true;
                }
            }
            catch (Exception ex)
            {
                
                lblError.Visible = true;
                lblError.Text = "Error processing your request. Please try after some time.";
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

            string err = "Error Caught in \n" +
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
      
    
        [WebMethod]
        public static string checkDocumentStatus()
        {
            if (HttpContext.Current.Session["childKey"] != null && HttpContext.Current.Session["pifXML"] != null)
            {
                string childKey = HttpContext.Current.Session["childKey"].ToString();
                EchoSignDocumentService17PortTypeClient ES = new EchoSignDocumentService17PortTypeClient();
                GetFormDataResult sss = ES.getFormData(ConfigurationManager.AppSettings["APIKey"], childKey);

                if (sss.success)
                    return "true";
                else
                    return "false";

            }
            return "false";
        }
          #endregion
    }
}






          

        
    

            
 