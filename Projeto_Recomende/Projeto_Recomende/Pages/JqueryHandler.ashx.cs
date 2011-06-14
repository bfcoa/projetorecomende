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
            Usuario usuario = (Usuario)context.Session["usuario"];
            string action = context.Request.Params["action"];
            string cod_filme = "0";
            string mensagemResposta = "0";
            switch (action)
            {
                case "Recomendar":
                    cod_filme = context.Request.Params["cod_filme"];
                    RecomendacaoBll recomendacaobll = new RecomendacaoBll();
                    if(recomendacaobll.Recomendar(usuario.id_usuario, int.Parse(cod_filme), out mensagemResposta)){
                        context.Response.Write("1");
                    }else{
                        context.Response.Write(mensagemResposta);
                    }
                    break;
                case "Comentar":                    
                    cod_filme = context.Request.Params["cod_filme"];
                    string comentario = context.Request.Params["comentario"];
                    ComentarioBll comentarioBll = new ComentarioBll();
                    if (comentarioBll.PostarComentario(usuario.id_usuario, int.Parse(cod_filme), comentario, out mensagemResposta))
                    {
                        context.Response.Write("1");
                    }else{
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