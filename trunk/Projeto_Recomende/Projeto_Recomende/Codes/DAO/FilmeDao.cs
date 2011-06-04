using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto_Recomende.Codes.OBJ;
using Projeto_Recomende.Util;
using System.Data;

namespace Projeto_Recomende.Codes.DAO
{
    public class FilmeDao
    {
        public List<Filme> BuscarFilmes(string where, string orderBy)
        {
            List<Filme> listFilme = null;
            
            string query = "SELECT f.cod_filme,f.nm_titulo,f.nm_tituloOriginal,f.ano_producao,f.txt_sinopse,f.duracao,f.elenco,f.id_genero,f.foto, g.tp_genero AS genero " +
                " FROM danilos5.dbo.tb_filme f " +
                " INNER JOIN danilos5.dbo.tb_genero g " +
                " ON(f.id_genero = g.id_genero) "+
                where +
                orderBy;
                AdoUtils ado = new AdoUtils();
                DataTable dt = ado.GetDataTable(query);

                listFilme = new List<Filme>();
                foreach (DataRow dr in dt.Rows)
                {
                    listFilme.Add(new Filme(dr));
                }
            
            return listFilme;
        }
    }
}