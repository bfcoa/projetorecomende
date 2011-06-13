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
            if (Session["User"] != null){
                txtEmail.Visible = false;
                txtSenha.Visible = false;
                txtSenha.Visible = false;

                Usuario user = (Usuario)ViewState["usuario"];
                lblEmail.Text = "Bem vindo <b>" +user.nm_usuario + "</b>";
                HyperLinkCadastro.Visible = false;

                if (Session["User"] != null)
                {
                    bntLogar.Text = "Logout";
                }
            }
        }
        //tb_usuario user = new tb_usuario();

        protected void bntLogar_Click(object sender, EventArgs e)
        {
            if (bntLogar.Text != "Logout")
            {

            }
            else
            {
                Session["User"] = null;
                Response.Redirect("/Pages/Home.aspx");
            }
            
            //var query = from user in entities.tb_usuario
            //            where user.email == txtEmail.Text && user.senha == txtSenha.Text
            //            select user;

            //if (query.ToList<tb_usuario>().Count == 1)
            //{
            //    user = query.ToList<tb_usuario>().ElementAt(0);
            //    Session["usuario"] = user;
            //    // Session["Email"] = query.ToList<tb_usuario>().ElementAt(0).email;
            //    // Session["Senha"] = query.ToList<tb_usuario>().ElementAt(0).senha;
            //    Response.Redirect("../Pages/PerfilUsuario.aspx");
            //}
            //else
            //{
            //    lblMensagem.Text = "Email ou senha incorretos!";
            //}

        }
    }
}