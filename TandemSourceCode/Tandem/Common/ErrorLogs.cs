using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Net.Mail;
using System.Configuration;
using System.Net;

namespace Tandem.Common
{
    public class ErrorLogs
    {
        public static void SendErrorMail(string msg,string url)
        {
            try
            {
                string sSource;
                string sLog;
                
                sSource = "Tandem Patient AOB Error Logs";
                sLog = DateTime.Now.ToString() + " " + msg + "Url: " + url;
             

                if (!EventLog.SourceExists(sSource))
                    EventLog.CreateEventSource(sSource, DateTime.Now.ToString() +" Tandem Error Logs");


                EventLog.WriteEntry(sSource, sLog,
                    EventLogEntryType.Error);


                string err = "Error Caught \n" +
                              "Error in: " + url +
                              "\nError Message:" + msg;

                MailMessage mMailMessage = new MailMessage();
                mMailMessage.To.Add(ConfigurationManager.AppSettings["ErrorEmail"]);
                mMailMessage.From = new MailAddress(ConfigurationManager.AppSettings["FromEmail"], ConfigurationManager.AppSettings["FromName"]);
                mMailMessage.Subject = ConfigurationManager.AppSettings["Subject"];
                mMailMessage.Body = err;

                var client = new SmtpClient(ConfigurationManager.AppSettings["SMTPSERVER"], Convert.ToInt32(ConfigurationManager.AppSettings["SMTPPORT"]));

                if (ConfigurationManager.AppSettings["UserName"].ToString() != "")
                    client.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["UserName"], ConfigurationManager.AppSettings["Password"]);

                if (ConfigurationManager.AppSettings["IsSSL"].ToString() == "1")
                    client.EnableSsl = true;

                client.Send(mMailMessage);
                mMailMessage.Dispose();
                client.Dispose();
            }
            catch (Exception ex) { HttpContext.Current.Response.Write(ex.Message); }
        }
    }
}