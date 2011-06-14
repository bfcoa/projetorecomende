using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Recomende.Codes.OBJ
{
    public class Recomendacao
    {
        public Recomendacao() { }

        public Recomendacao(System.Data.DataRow dr)
        {
            int idRecomendacao = 0;
            int idUsuario = 0;
            int codFilme = 0;

            int.TryParse(dr["id_recomendacao"].ToString(), out idRecomendacao);
            int.TryParse(dr["id_usuario"].ToString(), out idUsuario);
            int.TryParse(dr["cod_filme"].ToString(), out codFilme);

            this.id_recomendacao = idRecomendacao;
            this.id_usuario = idUsuario;
            this.cod_filme = codFilme;

        }

        public int? id_recomendacao { get; set; }
        public int? id_usuario { get; set; }
        public int? cod_filme { get; set; }
    }
}