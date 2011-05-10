using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Projeto_Recomende.Pages
{
    public partial class PerfilUsuario : System.Web.UI.Page
    {
        recomendeEntities entities = new recomendeEntities();
        tb_usuario user = new tb_usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["usuario"] = Session["usuario"];
                Session.Remove("usuario");
            }
            if (ViewState["usuario"] != null)
            {
                user = (tb_usuario)ViewState["usuario"];

                var query = from usuario in entities.tb_usuario
                            where usuario.id_usuario == user.id_usuario
                            select usuario;


                lblNome.Text = user.nm_usuario;
                imgPerfil.ImageUrl = query.ToList<tb_usuario>().ElementAt(0).end_foto;

            }
           /* else
                Response.Redirect("/Pages/SessaoExpirou.aspx");*/
        }

        protected void bntConfirma_Click(object sender, EventArgs e)
        {

        }

        protected void lbEditar_Click(object sender, EventArgs e)
        {
            Session["User"] = ViewState["usuario"];
            Response.Redirect("~/Pages/CadastroUsuario.aspx");
        }
    }
}