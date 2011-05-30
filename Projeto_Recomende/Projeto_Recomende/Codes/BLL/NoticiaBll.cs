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
        public object PostarNoticia(string titulo, string noticia)
        {
            ExtJSAjaxResponse res = new ExtJSAjaxResponse();
            try
            {
                
                
                if (string.IsNullOrEmpty(titulo))
                    new Exception("Titulo não pode ser vazio");
                if (string.IsNullOrEmpty(noticia))
                    new Exception("Noticia não pode estar vazia");
                
                //montando o objto noticia
                Noticia nova = new Noticia();
                nova.titulo = titulo;
                nova.noticia = noticia;
                nova.data = DateTime.Now;
                nova.id_usuario = 1;

                NoticiaDao dao = new NoticiaDao();
                res.success = dao.CadastrarNoticia(nova);
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