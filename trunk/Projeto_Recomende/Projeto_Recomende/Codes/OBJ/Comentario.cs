using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Recomende.Codes.OBJ
{
    public class Comentario
    {
        public Comentario(System.Data.DataRow dr)
        {
            int idUsuario = 0;
            int.TryParse(dr["id_usuario"].ToString(),out idUsuario);
            int codFilme = 0;
            int.TryParse(dr["cod_filme"].ToString(), out codFilme);
            int idComentario = 0;
            int.TryParse(dr["id_comentario"].ToString(), out idComentario);
        }

        public Comentario() { }

        public int? id_comentario { get; set; }
        public string comentario { get; set; }
        public DateTime dataComentario { get; set; }
        public int? id_usuario { get; set; }
        public int? cod_filme { get; set; }
    }
}