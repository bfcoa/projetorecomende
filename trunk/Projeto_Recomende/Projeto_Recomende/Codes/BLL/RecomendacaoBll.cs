using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto_Recomende.Codes.OBJ;
using Projeto_Recomende.Codes.DAO;

namespace Projeto_Recomende.Codes.BLL
{
    public class RecomendacaoBll
    {
        public bool Recomendar(int id_usuario, int cod_filme, out string mensagemResposta)
        {
            mensagemResposta = "";
            try
            {
                RecomendacaoDao dao = new RecomendacaoDao();
                if (id_usuario == 0)
                    throw new Exception("Usuário não existente no sistema!");
                if (id_usuario == 0)
                    throw new Exception("Filme não existente no sistema!");
                if (dao.LoadRecomendacao(id_usuario, cod_filme) != null)
                    throw new Exception("Você ja recomendou esse filme anteriormente!!");
                Recomendacao recomendacao = new Recomendacao();
                recomendacao.id_usuario = id_usuario;
                recomendacao.cod_filme = cod_filme;
                if (!dao.Recomendar(recomendacao))
                    throw new Exception("Não foi possivel recomendar este filme!!<br> Tente mais tarde");
                return true;

            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                mensagemResposta = "Houve um erro no banco de dados, contate o administrador!! <br> Erro de número: " + sqlEx.Number;
                return false;
            }
            catch (Exception ex)
            {
                mensagemResposta = ex.Message;
                return false;
            }
            return true;
        }
    }
}