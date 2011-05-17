using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto_Recomende.Codes.BLL;
using Projeto_Recomende.Util;

namespace Projeto_Recomende.Pages
{
    /// <summary>
    /// Summary description for ExtHandler
    /// </summary>
    public class ExtHandler : IHttpHandler
    {
        

        public void ProcessRequest(HttpContext context)
        {            
            
            ExtJSAjaxResponse res;
            System.Web.Script.Serialization.JavaScriptSerializer jss = new System.Web.Script.Serialization.JavaScriptSerializer();
            string acao = context.Request.Params["action"];
            
            switch (acao)
            {
                case "PostarNoticia":
                    NoticiaBll bll = new NoticiaBll();
                    res = (ExtJSAjaxResponse) bll.PostarNoticia(context);
                    context.Response.Write(jss.Serialize(res));
                    context.Response.End();
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