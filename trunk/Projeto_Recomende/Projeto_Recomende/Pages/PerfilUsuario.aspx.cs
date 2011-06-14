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
        Grupo grupo;
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
            grupo = new Grupo();
            userBll = new UsuarioBll();
            // Max Pontos = 225
            // Min Pontos = 45
            #region PERGUNTAS
            if (rblPergunta1.SelectedValue == "1")
            {
                grupo.Pontos += 5; 
            }
            else if (rblPergunta1.SelectedValue == "2")
            {
                grupo.Pontos += 10;
            }
            else if (rblPergunta1.SelectedValue == "3")
            {
                grupo.Pontos += 15;
            }
            else if (rblPergunta1.SelectedValue == "4")
            {
                grupo.Pontos += 20;
            }
            else if (rblPergunta1.SelectedValue == "5")
            {
                grupo.Pontos += 25;
            }

            if (rblPergunta2.SelectedValue == "1")
            {
                grupo.Pontos += 5;
            }
            else if (rblPergunta2.SelectedValue == "2")
            {
                grupo.Pontos += 10;
            }
            else if (rblPergunta2.SelectedValue == "3")
            {
                grupo.Pontos += 15;
            }
            else if (rblPergunta2.SelectedValue == "4")
            {
                grupo.Pontos += 20;
            }
            else if (rblPergunta2.SelectedValue == "5")
            {
                grupo.Pontos += 25;
            }

            if (rblPergunta3.SelectedValue == "1")
            {
                grupo.Pontos += 5;
            }
            else if (rblPergunta3.SelectedValue == "2")
            {
                grupo.Pontos += 10;
            }
            else if (rblPergunta3.SelectedValue == "3")
            {
                grupo.Pontos += 15;
            }
            else if (rblPergunta3.SelectedValue == "4")
            {
                grupo.Pontos += 20;
            }
            else if (rblPergunta3.SelectedValue == "5")
            {
                grupo.Pontos += 25;
            }

            if (rblPergunta4.SelectedValue == "1")
            {
                grupo.Pontos += 5;
            }
            else if (rblPergunta4.SelectedValue == "2")
            {
                grupo.Pontos += 10;
            }
            else if (rblPergunta4.SelectedValue == "3")
            {
                grupo.Pontos += 15;
            }
            else if (rblPergunta4.SelectedValue == "4")
            {
                grupo.Pontos += 20;
            }
            else if (rblPergunta4.SelectedValue == "5")
            {
                grupo.Pontos += 25;
            }

            if (rblPergunta5.SelectedValue == "1")
            {
                grupo.Pontos += 5;
            }
            else if (rblPergunta5.SelectedValue == "2")
            {
                grupo.Pontos += 10;
            }
            else if (rblPergunta5.SelectedValue == "3")
            {
                grupo.Pontos += 15;
            }
            else if (rblPergunta5.SelectedValue == "4")
            {
                grupo.Pontos += 20;
            }
            else if (rblPergunta5.SelectedValue == "5")
            {
                grupo.Pontos += 25;
            }

            if (rblPergunta6.SelectedValue == "1")
            {
                grupo.Pontos += 5;
            }
            else if (rblPergunta6.SelectedValue == "3")
            {
                grupo.Pontos += 15;
            }          
            else if (rblPergunta6.SelectedValue == "5")
            {
                grupo.Pontos += 25;
            }

            else if (rblPergunta7.SelectedValue == "2")
            {
                grupo.Pontos += 10;
            }
            else if (rblPergunta7.SelectedValue == "3")
            {
                grupo.Pontos += 15;
            }
            else if (rblPergunta7.SelectedValue == "4")
            {
                grupo.Pontos += 20;
            }
            else if (rblPergunta7.SelectedValue == "5")
            {
                grupo.Pontos += 25;
            }

            if (rblPergunta8.SelectedValue == "1")
            {
                grupo.Pontos += 5;
            }
            else if (rblPergunta8.SelectedValue == "2")
            {
                grupo.Pontos += 10;
            }
            else if (rblPergunta8.SelectedValue == "3")
            {
                grupo.Pontos += 15;
            }
            else if (rblPergunta8.SelectedValue == "4")
            {
                grupo.Pontos += 20;
            }
            else if (rblPergunta8.SelectedValue == "5")
            {
                grupo.Pontos += 25;
            }

            if (rblPergunta9.SelectedValue == "1")
            {
                grupo.Pontos += 5;
            }
            else if (rblPergunta9.SelectedValue == "2")
            {
                grupo.Pontos += 10;
            }
            else if (rblPergunta9.SelectedValue == "3")
            {
                grupo.Pontos += 15;
            }
            else if (rblPergunta9.SelectedValue == "4")
            {
                grupo.Pontos += 20;
            }
            else if (rblPergunta9.SelectedValue == "5")
            {
                grupo.Pontos += 25;
            }

            #endregion

            if (grupo.Pontos <= 105 )
            {
                grupo.Grup = 'a';
            }
            else if (grupo.Pontos > 105 && grupo.Pontos <= 150)
            {
                grupo.Grup = 'b';
            }
            else if(grupo.Pontos > 150)
            {
                grupo.Grup = 'c';
            }

            userBll.insertGRupo(grupo, user);

        }
        protected void lbEditar_Click(object sender, EventArgs e)
        {
            Session["User"] = ViewState["usuario"];
            Response.Redirect("~/Pages/CadastroUsuario.aspx");
        }
    }
}