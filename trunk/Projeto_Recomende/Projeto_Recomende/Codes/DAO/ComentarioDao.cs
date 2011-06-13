using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto_Recomende.Codes.OBJ;
using Projeto_Recomende.Util;
using System.Data;

namespace Projeto_Recomende.Codes.DAO
{
    public class ComentarioDao
    {
        public bool PostarComentario(Comentario comentario)
        {
            AdoUtils ado = new AdoUtils();
            string query = "INSERT INTO tb_comentario (id_usuario, cod_filme, comentario, dataComentario)"+
                "VALUES(@id_usuario, @cod_filme, @comentario, @dataComentario);";
            List<KeyValuePair<string, object>> parametros = new List<KeyValuePair<string, object>>();
            parametros.Add(new KeyValuePair<string, object>("@id_usuario", comentario.id_usuario));
            parametros.Add(new KeyValuePair<string, object>("@cod_filme", comentario.cod_filme));
            parametros.Add(new KeyValuePair<string, object>("@comentario", comentario.comentario));
            parametros.Add(new KeyValuePair<string, object>("@dataComentario", comentario.dataComentario));           
            return ado.ExecuteCommand(query, parametros.ToArray());
        }
    }
}