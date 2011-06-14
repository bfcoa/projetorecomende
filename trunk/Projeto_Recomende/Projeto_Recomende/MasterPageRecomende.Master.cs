using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Projeto_Recomende.Codes.OBJ;
using Projeto_Recomende.Codes.BLL;

namespace Projeto_Recomende
{
    public partial class MasterPageRecomende : System.Web.UI.MasterPage
    {
        //recomendeEntities entities = new recomendeEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

            //servira para incluir na pagina se o usu´pario for Admin
            //HtmlGenericControl admControl = new HtmlGenericControl("li");
            //admControl.InnerHtml = "<a href=\"#\" style=\"color:Red \" onClick=\"clickAdm()\">ADM</a>";
            //menuSuperior.Controls.Add(admControl);

            if (Session["usuario"] != null)
            {
                txtEmail.Visible = false;
                txtSenha.Visible = false;
                Usuario user = (Usuario)Session["usuario"];
                lblEmail.Text = "Bem vindo <b>" + user.nm_usuario + "</b>";
                HyperLinkCadastro.Visible = false;
                HyperLinkPerfil.Visible = true;
                btnLogar.Visible = false;
                btnLogout.Visible = true;
                if (user.tipo_usuario == "")
                {

                }
            }
            else
            {
                HyperLinkCadastro.Visible = true;
                HyperLinkPerfil.Visible = false;
                HyperLinkAdm.Visible = false;

            }
        }

        protected void bntLogar_Click(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                UsuarioBll bll = new UsuarioBll();
                string mensagemErro = "";
                Usuario usuario = bll.loadUsuario(txtEmail.Text, txtSenha.Text, out mensagemErro);
                if (usuario == null)
                {
                    lblMensagem.Text = mensagemErro;
                    lblMensagem.Visible = true;
                }
                else
                {
                    lblMensagem.Text = "";
                    lblMensagem.Visible = false;
                    Session["usuario"] = usuario;
                    txtEmail.Visible = false;
                    txtSenha.Visible = false;
                    lblEmail.Text = "Bem vindo <b>" + usuario.nm_usuario + "</b>";
                    HyperLinkCadastro.Visible = false;
                    HyperLinkPerfil.Visible = true;
                    btnLogar.Visible = false;
                    btnLogout.Visible = true;
                    lblSenha.Visible = false;
                    Response.Redirect("~/Pages/Perfilusuario.aspx");
                }
            }
            else
            {
                Response.Redirect("~/Pages/SessaoExpirou.aspx");
            }

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            txtEmail.Visible = true;
            txtSenha.Visible = true;
            lblEmail.Text = "E-MAIL";
            btnLogar.Visible = true;
            btnLogout.Visible = false;
            Response.Redirect("~/Pages/Home.aspx");
        }
    }
}