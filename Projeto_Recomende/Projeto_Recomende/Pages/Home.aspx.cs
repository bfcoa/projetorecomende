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
            
            //noticiabll noticabll = new noticiabll();
            //list<noticia> noticias = noticabll.loadnoticias();
            //foreach (noticia nova in noticias)
            //{
            //    htmlgenericcontrol novanoticia = new htmlgenericcontrol();
            //    string divnoticia = "<div  style=\"width:520px; margin-left:auto; margin-right:auto; font-family:bernard mt condensed; font-style:italic;color:#252525; font-size:x-large; height:30px; background-color:#d3d3d3; text-align:center; padding-top:10px\">" + nova.titulo + "</div>" +
            //        "<div style=\" width:500px; margin-left:auto; margin-right:auto; margin-bottom:10px; background-color:#eeeee0; font-size:medium; padding:10px\">" + nova.noticia + "</div>";
            //    novanoticia.innerhtml = divnoticia;
            //    noticias.controls.add(novanoticia);                          
            //}
        }
    }
}