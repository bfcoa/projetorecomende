using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace Projeto_Recomende.Util
{
    public class Email
    {
        public bool EnviarEmail(string SMTP, string De, string Senha, string Para, string ParaC, string ParaCC, string Anexos, string Assunto, string Corpo, bool HTML, MailPriority MP)
        {
            try
            {
                int I = 0;
                string[] Array;
                MailMessage Mensagem = new MailMessage();
                SmtpClient mSmtpCliente = new SmtpClient(SMTP);

                Mensagem.From = new MailAddress(De);
                Array = Para.Split(';');
                for (I = 0; I < Array.Length; I++)
                {
                    Mensagem.To.Add(new MailAddress(Array[I]));
                }
                if (ParaC != null)
                {
                    Array = ParaC.Split(';');
                    for (I = 0; I < Array.Length; I++)
                    {
                        Mensagem.Bcc.Add(new MailAddress(Array[I]));
                    }
                }
                if (ParaCC != null)
                {
                    Array = ParaCC.Split(';');
                    for (I = 0; I <= Array.Length; I++)
                    {
                        Mensagem.CC.Add(new MailAddress(Array[I]));
                    }
                }
                if (Anexos != null)
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
            catch (Exception ex)
            {
                return false;
            }
            return true;

        }
    }
}