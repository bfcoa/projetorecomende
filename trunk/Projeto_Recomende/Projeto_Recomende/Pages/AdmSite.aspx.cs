using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto_Recomende.Codes.BLL;
using Projeto_Recomende.Codes.OBJ;
using Projeto_Recomende.Util;

namespace Projeto_Recomende.Pages
{
    public partial class AdmSite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                string mesnagemErro = "";
                Usuario usuario = (Usuario)Session["usuario"];
                NoticiaBll bll = new NoticiaBll();
                if (!bll.PostarNoticia(usuario.id_usuario, txtTitulo.Text, Editor1.Content, out mesnagemErro))
                {
                    lblMensagem.Text = mesnagemErro;
                    lblMensagem.Visible = true;
                }
            }
            else
            {
                Response.Redirect("~/Pages/SessaoExpirou.aspx");
            }

            
                
        }
    }
}