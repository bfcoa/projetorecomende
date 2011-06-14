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
        public bool PostarNoticia(int id_usuario, string titulo, string noticia,out string mensagemErro )
        {
            mensagemErro = "";
            try
            {
                if (string.IsNullOrEmpty(titulo))
                    throw new Exception("Titulo não pode ser vazio");
                if (string.IsNullOrEmpty(noticia))
                    throw new Exception("Noticia não pode estar vazia");
                
                //montando o objto noticia
                Noticia nova = new Noticia();
                nova.titulo = titulo;
                nova.noticia = noticia;
                nova.data = DateTime.Now;
                nova.id_usuario = id_usuario;

                NoticiaDao dao = new NoticiaDao();
                if(dao.CadastrarNoticia(nova))                
                    throw new Exception("Noticia não pode ser cadastrada!<br/> Tente Novamente!");
            
            }catch(Exception Ex){
                mensagemErro = Ex.Message;
                return false;
            }
            return true;
        }

        public List<Noticia> LoadNoticias()
        {
            NoticiaDao dao = new NoticiaDao();
            List<Noticia> noticias = dao.LoadNoticias();
            return noticias;
        }
    }
}