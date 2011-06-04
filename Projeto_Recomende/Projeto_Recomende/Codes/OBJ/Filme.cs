using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Projeto_Recomende.Codes.OBJ
{
    public class Filme
    {
        public Filme() { }
        public Filme(DataRow dr)
        {
            int codFilme = 0;
            int.TryParse(dr["cod_filme"].ToString(), out codFilme);
            int idGenero = 0;            
            int.TryParse(dr["id_genero"].ToString(), out idGenero);
            int anoProducao = 0;
            int.TryParse(dr["ano_producao"].ToString(), out anoProducao);

            this.cod_filme = codFilme;
            this.nm_titulo = dr["nm_titulo"].ToString();
            this.nm_tituloOriginal = dr["nm_tituloOriginal"].ToString();
            this.ano_producao = anoProducao;
            this.txt_sinopse = dr["txt_sinopse"].ToString();
            this.duracao = dr["duracao"].ToString();
            this.elenco = dr["elenco"].ToString();
            this.id_genero = idGenero;
            this.foto = dr["foto"].ToString();
        }

        public int cod_filme { get; set; }
        public string nm_titulo { get; set; }
        public string nm_tituloOriginal { get; set; }
        public int ano_producao { get; set; }
        public string txt_sinopse { get; set; }
        public string duracao { get; set; }
        public string elenco { get; set; }
        public int id_genero { get; set; }
        public string foto { get; set; }
    }
}