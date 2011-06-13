using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto_Recomende.Codes.OBJ;
using Projeto_Recomende.Codes.BLL;

namespace Projeto_Recomende.Pages
{
    public partial class UpdateFoto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                Usuario user = (Usuario)Session["usuario"];
                Image1.ResolveUrl(user.end_foto);
                Image1.DataBind();
            }
        }

        protected void btnAtualizaFoto_Click(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                Usuario user = (Usuario)Session["usuario"];
                user.end_foto = Server.MapPath(@"~\Util\Imagens\ImagensUsuarios\" + FileUpload1.FileName);
                UsuarioBll userBll = new UsuarioBll();
                userBll.updateFoto(user);
                Response.Redirect("~/Pages/PerfilUsuario.aspx");
            }
        }
    }
}