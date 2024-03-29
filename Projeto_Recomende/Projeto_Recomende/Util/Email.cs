﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Configuration;

namespace Projeto_Recomende.Util
{
    public class Email
    {
        public bool EnviarEmail(string Para, string EmailUsuario, string Anexos, string Assunto, string Corpo, bool HTML, MailPriority MP)
        {
            string SMTP = ConfigurationManager.AppSettings["smtp"];
            string De = ConfigurationManager.AppSettings["emailSender"];
            string Senha = ConfigurationManager.AppSettings["emailPass"];

            try
            {
                System.Web.Mail.MailMessage eMail = new System.Web.Mail.MailMessage();
                eMail.BodyFormat = System.Web.Mail.MailFormat.Text;
                eMail.From = ConfigurationManager.AppSettings["emailSender"];
                eMail.Fields["http://schemas.microsoft.com/cdo/configuration/smtpserver"] = SMTP;
                eMail.Fields["http://schemas.microsoft.com/cdo/configuration/smtpserverport"] = 25;
                eMail.Fields["http://schemas.microsoft.com/cdo/configuration/sendusing"] = 2;
                eMail.Fields["http://schemas.microsoft.com/cdo/configuration/smtpauthenticate"] = 1;
                eMail.Fields["http://schemas.microsoft.com/cdo/configuration/sendusername"] = De;
                eMail.Fields["http://schemas.microsoft.com/cdo/configuration/sendpassword"] = Senha;
                eMail.To = Para;
                eMail.Subject = Assunto;
                eMail.Body = "<p>E-mail enviado pelo usuário: " + EmailUsuario + "</p>" + Corpo;

                System.Web.Mail.SmtpMail.SmtpServer = SMTP;
                System.Web.Mail.SmtpMail.Send(eMail);

                #region Old
                /*
                int I = 0;
                string[] Array;
                MailMessage Mensagem = new MailMessage();
                SmtpClient mSmtpCliente = new SmtpClient(SMTP);

                Mensagem.ReplyTo = new MailAddress(ReplyTo);
                Mensagem.From = new MailAddress(De);
                Array = Para.Split(';');
                for (I = 0; I < Array.Length; I++)
                {
                    Mensagem.To.Add(new MailAddress(Array[I]));
                }
                if (!string.IsNullOrEmpty(ParaC))
                {
                    Array = ParaC.Split(';');
                    for (I = 0; I < Array.Length; I++)
                    {
                        Mensagem.Bcc.Add(new MailAddress(Array[I]));
                    }
                }
                if (!string.IsNullOrEmpty(ParaCC))
                {
                    Array = ParaCC.Split(';');
                    for (I = 0; I <= Array.Length; I++)
                    {
                        Mensagem.CC.Add(new MailAddress(Array[I]));
                    }
                }
                if (!string.IsNullOrEmpty(Anexos))
                {
                    Array = Anexos.Split(';');
                    for (I = 0; I <= Array.Length; I++)
                    {
                        Mensagem.Attachments.Add(new Attachment(Array[I]));
                    }
                }
                Mensagem.IsBodyHtml = HTML;
                Mensagem.Priority = MP;
                Mensagem.Subject = Assunto;
                Mensagem.Body = Corpo;
                mSmtpCliente.Credentials = new System.Net.NetworkCredential(De, Senha);
                mSmtpCliente.Send(Mensagem);
                 * */


                /*
                int I = 0;
                string[] Array;
                MailMessage Mensagem = new MailMessage();
                SmtpClient mSmtpCliente = new SmtpClient(SMTP);

                Mensagem.ReplyTo = new MailAddress(ReplyTo);
                Mensagem.From = new MailAddress(De);
                Array = Para.Split(';');
                for (I = 0; I < Array.Length; I++)
                {
                    Mensagem.To.Add(new MailAddress(Array[I]));
                }
                if (!string.IsNullOrEmpty(ParaC))
                {
                    Array = ParaC.Split(';');
                    for (I = 0; I < Array.Length; I++)
                    {
                        Mensagem.Bcc.Add(new MailAddress(Array[I]));
                    }
                }
                if (!string.IsNullOrEmpty(ParaCC))
                {
                    Array = ParaCC.Split(';');
                    for (I = 0; I <= Array.Length; I++)
                    {
                        Mensagem.CC.Add(new MailAddress(Array[I]));
                    }
                }
                if (!string.IsNullOrEmpty(Anexos))
                {
                    Array = Anexos.Split(';');
                    for (I = 0; I <= Array.Length; I++)
                    {
                        Mensagem.Attachments.Add(new Attachment(Array[I]));
                    }
                }
                Mensagem.IsBodyHtml = HTML;
                Mensagem.Priority = MP;
                Mensagem.Subject = Assunto;
                Mensagem.Body = Corpo;
                mSmtpCliente.Credentials = new System.Net.NetworkCredential(De, Senha);
                mSmtpCliente.Send(Mensagem);
                 * */
                #endregion
            }
            catch (Exception ex)
            {
                string teste = ex.Message;
                return false;
            }
            return true;

        }
    }
}