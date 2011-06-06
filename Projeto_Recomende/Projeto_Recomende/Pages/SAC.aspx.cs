using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using Projeto_Recomende.Util;

namespace Projeto_Recomende.Pages
{
    public partial class SAC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (false) // Verifica se existe uma Sessão de usuário logado
            {
                tbxNome.Text = "NomeCliente";
                tbxEMail.Text = "EmailCliente";
                tbxNome.ReadOnly = true;
                tbxEMail.ReadOnly = true;
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (tbxNome.Text != string.Empty && tbxEMail.Text != string.Empty && tbxMensagem.Text != string.Empty && ddlAssunto.SelectedValue != string.Empty)
            {
                Email objEmail = new Email();
                
                objEmail.EnviarEmail(ConfigurationManager.AppSettings["emailReceiver"],
                    "", "", tbxEMail.Text, "", "Contato Recomende: " + ddlAssunto.SelectedValue.Trim(), tbxMensagem.Text, false,
                    System.Net.Mail.MailPriority.High);

                btnEnviar.Visible = false;
                tbxNome.Visible = false;
                tbxEMail.Visible = false;
                ddlAssunto.Visible = false;
                tbxMensagem.Visible = false;
                Label1.Text = "<br>Email enviado com sucesso!";
                Label2.Text = "Em breve retornaremos seu contato.";
            }
        }
    }
}