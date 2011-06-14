using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto_Recomende.Codes.OBJ;
using Projeto_Recomende.Codes.DAO;

namespace Projeto_Recomende.Codes.BLL
{
    public class ComentarioBll
    {
        public bool PostarComentario(int id_usuario, int cod_filme, string coment, out string mensagemResposta)
        {
            mensagemResposta = "";
            try
            {
                
                if (cod_filme <= 0)
                    throw new Exception("Código Do filme é inválido");
                                        
                if (string.IsNullOrEmpty(coment))
                    throw new Exception("Comentário não pode estar vazio");
                
                Comentario comentario = new Comentario();
                comentario.id_usuario = id_usuario;
                comentario.cod_filme = cod_filme;
                comentario.comentario = coment;
                comentario.dataComentario = DateTime.Now;

                ComentarioDao dao = new ComentarioDao();

                if (!dao.PostarComentario(comentario))
                    throw new Exception("Não foi possível postar o seu comentário!");                    

            }catch(Exception ex){
                mensagemResposta = ex.Message;
                return false;
            }
            return true;
        }
    }
}