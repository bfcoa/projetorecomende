using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto_Recomende.Codes.BLL;
using Projeto_Recomende.Codes.OBJ;

namespace Projeto_Recomende.Pages
{
    /// <summary>
    /// Summary description for JqueryHandler
    /// </summary>
    public class JqueryHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string action = context.Request.Params["action"];
            

            switch (action)
            {
                case "Recomendar":
                    break;
                case "Comentar":
                    //Usuario usuario = (Usuario)context.Session["usuario"];
                    int idUsuario = 1;
                    string cod_filme = context.Request.Params["cod_filme"];
                    string comentario = context.Request.Params["comentario"];
                    string mensagemResposta = "";
                    ComentarioBll bll = new ComentarioBll();
                    if (bll.PostarComentario(idUsuario, int.Parse(cod_filme), comentario, out mensagemResposta))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write(mensagemResposta);
                    }
                    break;
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}