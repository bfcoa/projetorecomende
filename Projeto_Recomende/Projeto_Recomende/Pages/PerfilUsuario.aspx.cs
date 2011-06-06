using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Projeto_Recomende.Codes.BLL;
using Projeto_Recomende.Codes.OBJ;

namespace Projeto_Recomende.Pages
{
    public partial class PerfilUsuario : System.Web.UI.Page
    {
        Usuario user;
        UsuarioBll userBll;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["usuario"] = Session["usuario"];
                user = (Usuario)ViewState["usuario"];
                Session.Remove("usuario");
                
            }
            if (ViewState["usuario"] != null)
            {
                userBll = new UsuarioBll();
                user = userBll.loadUsuario(user);

                if (user != null)
                {
                    ViewState["usuario"] = user;
                    lblNome.Text = user.nm_usuario;
                    imgPerfil.ImageUrl = user.end_foto;
                }                

                //lblNome.Text = user.nm_usuario;
                //imgPerfil.ImageUrl = query.ToList<tb_usuario>().ElementAt(0).end_foto;

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