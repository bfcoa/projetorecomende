using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Recomende.Pages
{
    /// <summary>
    /// Summary description for ExtHandler
    /// </summary>
    public class ExtHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string titulo = context.Request.Params["txtTitulo"];
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