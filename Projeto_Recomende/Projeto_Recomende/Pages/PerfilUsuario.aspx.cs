using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Projeto_Recomende.Codes.OBJ;
using Projeto_Recomende.Codes.BLL;


namespace Projeto_Recomende.Pages
{
    public partial class PerfilUsuario : System.Web.UI.Page
    {
        Usuario user;
        UsuarioBll userBll;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                user = (Usuario)Session["usuario"];
                lblNome.Text = user.nm_usuario;
                imgPerfil.ImageUrl = user.end_foto;
            }
            else
            {
                Response.Redirect("~/Pages/Home.aspx");
            }

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