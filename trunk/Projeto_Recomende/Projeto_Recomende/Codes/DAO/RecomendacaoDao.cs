using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Projeto_Recomende.Codes.OBJ;
using Projeto_Recomende.Util;

namespace Projeto_Recomende.Codes.DAO
{
    public class RecomendacaoDao
    {
        public bool Recomendar(Recomendacao recomendacao)
        {
            AdoUtils ado = new AdoUtils();
            string query = "INSERT INTO tb_recomendacao (id_usuario, cod_filme)" +
                "VALUES(@id_usuario, @cod_filme);";
            List<KeyValuePair<string, object>> parametros = new List<KeyValuePair<string, object>>();
            parametros.Add(new KeyValuePair<string, object>("@id_usuario", recomendacao.id_usuario));
            parametros.Add(new KeyValuePair<string, object>("@cod_filme", recomendacao.cod_filme));
            return ado.ExecuteCommand(query, parametros.ToArray());
        }

        public Recomendacao LoadRecomendacao(int id_usuario, int cod_filme)
        {
            Recomendacao recomendacao = null;
            string query = "SELECT * FROM tb_recomendacao WHERE id_usuario = @id_usuario AND cod_filme = @cod_filme;";
            List<KeyValuePair<string, object>> parametros = new List<KeyValuePair<string, object>>();
            parametros.Add(new KeyValuePair<string, object>("@id_usuario", id_usuario));
            parametros.Add(new KeyValuePair<string, object>("@cod_filme", cod_filme));
            AdoUtils ado = new AdoUtils();
            DataTable dt = ado.GetDataTable(query);
            if (dt.Rows.Count >= 1)
            {
                recomendacao = new Recomendacao(dt.Rows[0]);
            }
            return recomendacao;
        }
    }
}