using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Projeto_Recomende.Codes.BLL;
using Projeto_Recomende.Codes.OBJ;


namespace Projeto_Recomende.Pages
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NoticiaBll noticaBll = new NoticiaBll();
            List<Noticia> noticias = noticaBll.LoadNoticias();
            foreach (Noticia nova in noticias)
            {
                HtmlGenericControl novaNoticia = new HtmlGenericControl();
                string divNoticia = "<div  style=\"width:520px; margin-left:auto; margin-right:auto; font-family:Bernard MT Condensed; font-style:italic;color:#252525; font-size:x-large; height:30px; background-color:#D3D3D3; text-align:center; padding-top:10px\">" + nova.titulo + "</div>" +
                    "<div style=\" width:500px; margin-left:auto; margin-right:auto; margin-bottom:10px; background-color:#EEEEE0; font-size:medium; padding:10px\">" + nova.noticia + "</div>";
                novaNoticia.InnerHtml = divNoticia;
                Noticias.Controls.Add(novaNoticia);                          
            }
            
            

        }
    }
}