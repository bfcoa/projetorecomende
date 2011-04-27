using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_Recomende.Pages
{
    public partial class PerfilUsuario : System.Web.UI.Page
    {
        tb_usuario user = new tb_usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["usuario"] = Session["usuario"];
                Session.Remove("usuario");
            }
            user = (tb_usuario)ViewState["usuario"];
            lblNome.Text = user.nm_usuario;
            imgLogo.ImageUrl = user.end_foto;

        }

        protected void bntConfirma_Click(object sender, EventArgs e)
        {

        }
    }
}