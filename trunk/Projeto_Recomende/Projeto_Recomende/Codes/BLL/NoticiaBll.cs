using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto_Recomende.Codes.OBJ;
using Projeto_Recomende.Codes.DAO;
using System.Data;
using Projeto_Recomende.Util;

namespace Projeto_Recomende.Codes.BLL
{
    public class NoticiaBll
    {
        public object PostarNoticia(HttpContext Context)
        {
            ExtJSAjaxResponse res = new ExtJSAjaxResponse();
            try
            {
                string titulo = Context.Request.Params["txtTitulo"];
                string noticia = Context.Request.Params["txtCorpo"];
                
                if (string.IsNullOrEmpty(titulo))
                    new Exception("Titulo não pode ser vazio");
                if (string.IsNullOrEmpty(noticia))
                    new Exception("Noticia não pode estar vazia");
                NoticiaDao dao = new NoticiaDao();
                res.success = dao.CadastrarNoticia(titulo, noticia, DateTime.Now, 1);
                if(!res.success)
                    res.message = "Noticia não pode ser cadastrada!<br/> Tente Novamente!";
            }catch(Exception Ex){
                res.errors = 1;
                res.success = false;
                res.message = Ex.Message;
            }
            return res;
        }

        public List<Noticia> LoadNoticias()
        {
            NoticiaDao dao = new NoticiaDao();
            List<Noticia> noticias = dao.LoadNoticias();
            return noticias;
        }
    }
}