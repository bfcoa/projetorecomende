using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_Recomende
{
    public partial class MasterPageRecomende : System.Web.UI.MasterPage
    {
        recomendeEntities entities = new recomendeEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        tb_usuario user = new tb_usuario();
        protected void bntLogar_Click(object sender, EventArgs e)
        {
            var query = from user in entities.tb_usuario
                        where user.email == txtEmail.Text && user.senha == txtSenha.Text
                        select user;

            if (query.ToList<tb_usuario>().Count == 1)
            {
                user = query.ToList<tb_usuario>().ElementAt(0);
                Session["usuario"] = user;
               // Session["Email"] = query.ToList<tb_usuario>().ElementAt(0).email;
               // Session["Senha"] = query.ToList<tb_usuario>().ElementAt(0).senha;
                Response.Redirect("../Pages/PerfilUsuario.aspx");
            }
            else
            {
                lblMensagem.Text = "Email ou senha incorretos!";
            }   

        }
    }
}