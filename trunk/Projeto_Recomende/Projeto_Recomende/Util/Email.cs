using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Configuration;

namespace Projeto_Recomende.Util
{
    public class Email
    {
        public bool EnviarEmail(string Para, string ParaC, string ParaCC, string ReplyTo, string Anexos, string Assunto, string Corpo, bool HTML, MailPriority MP)
        {
            string SMTP = ConfigurationManager.AppSettings["smtp"];
            string De = ConfigurationManager.AppSettings["emailSender"];
            string Senha = ConfigurationManager.AppSettings["emailPass"];
                
            try
            {
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
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
    }
}