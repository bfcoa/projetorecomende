using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto_Recomende.Util;

namespace Projeto_Recomende.Codes.BLL
{
    public class NoticiaBll
    {
        public object PostarNoticia(HttpContext Context)
        {
            //faz validações
            
            //cria a query
            string query = "";
            
            //cria o objeto Ado
            AdoUtils ado = new AdoUtils();
            

            //passaos parametros
            List<KeyValuePair<string, object>> parametros = new List<KeyValuePair<string, object>>();

            //executa comando sql
            ado.ExecuteCommand(query, parametros.ToArray());
            return null;
        }
    }
}