using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto_Recomende.Codes.OBJ;
using Projeto_Recomende.Codes.DAO;

namespace Projeto_Recomende.Codes.BLL
{
    public class FilmeBll
    {

        public string BuscarFilmes(int id_usuario, string nomeFilme, string ator, int genero, int ordenarPor)
        {
            string query = "";
            if (!string.IsNullOrEmpty(nomeFilme.Trim()) && nomeFilme != "Titulo Do Filme" || !string.IsNullOrEmpty(ator.Trim()) && ator != "Ator")
            {
                try
                {
                    string select = "SELECT " +
                                    "'<table>" +
                                        "<tbody>" +
                                            "<tr style=\"width: 120px; height: 120px;\">" +
                                                "<td style=\"width: 120px; height: 120px;\">" +
                                                    "<img width=\"120px\" src=\"../Util/Imagens/ImagensFilmes/'+f.foto+'\" style=\"margin: 0px\"" +
                                                        "alt=\"Não há foto disponível\">" +
                                                    "<center><br /><div> " +
                                                        "<input type=\"image\" src=\"../Util/Imagens/ImagensSite/recomendar.png\" title=\"Recomendar Este Filme\" onclick=\"Recomendar('+CONVERT(VARCHAR(8000),f.cod_filme)+', "+id_usuario+"); return false; \"  />" +
                                                        "<input type=\"image\" style=\"margin-left:20px\" src=\"../Util/Imagens/ImagensSite/comentar.png\" title=\"Fazer Comentário Sobre o Filme\" onclick=\"ExibirElemento('+CONVERT(VARCHAR(8000),f.cod_filme)+'," + id_usuario + "); return false; \" />" +
                                                    "</div></center>" +
                                                "</td>" +
                                                "<td valign=\"top\">" +
                                                    "<strong>Titulo:</strong><span>'+f.nm_titulo+'</span><br>" +
                                                    "<strong>Titulo Original:</strong><span>'+f.nm_tituloOriginal+'</span><br>" +
                                                    "<strong>Gênero:</strong><span>'+g.tp_genero+'</span><br>" +
                                                    "<strong>Ano de Produção:</strong><span>'+f.ano_producao+'</span><br>" +
                                                    "<strong>Duração:</strong><span>'+f.duracao+'</span><br>" +
                                                    "<strong>Elenco:</strong><span>'+f.elenco+'</span><br>" +
                                                    "<strong>Sinopse:</strong><span>'+CONVERT(VARCHAR(8000), f.txt_sinopse)+'</span><br><br>" +
                                                    "<div id=\"Comentario'+CONVERT(VARCHAR(8000),f.cod_filme)+'\" hidden=\"true\"> "+
                                                        "<strong>Comentário</strong> "+
                                                        "<textarea style=\"height: 208px;  width: 500px; background-color: #E0E0E0\" cols=\"20\" rows=\"2\"></textarea><br> " +
                                                        "<input id=\"btnComentario\" type=\"button\" value=\"Comentar\" onclick=\"Comentar('+CONVERT(VARCHAR(8000),f.cod_filme)+',1);\" /> " +
                                                    "</div> "+
                                                "</td>" +
                                            "</tr>" +
                                        "</tbody>" +
                                    "</table>' AS trFilme " +
                                    "FROM danilos5.dbo.tb_filme f " +
                                    "INNER JOIN danilos5.dbo.tb_genero g " +
                                    "ON(f.id_genero = g.id_genero)";


                    string where = " WHERE ";
                    string orderBy = "";

                    if (!string.IsNullOrEmpty(nomeFilme) && nomeFilme != "Titulo Do Filme")
                        where += " (f.nm_titulo LIKE '" + nomeFilme + "%') ";
                    if (!string.IsNullOrEmpty(ator) && ator != "Ator")
                        where += " AND f.elenco LIKE '%" + ator + "%'";
                    if (genero != 1)
                        where += " AND f.id_genero = " + genero + " ";
                    if (ordenarPor != 0)
                    {
                        switch (ordenarPor)
                        {
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:
                                orderBy += "ORDER BY f.nm_titulo ASC;";
                                break;
                            case 4:
                                orderBy += "ORDER BY f.nm_titulo DESC;";
                                break;
                        }
                    }
                    if (where.Contains("WHERE  AND"))
                    {
                        where = where.Replace("WHERE  AND", "WHERE");
                    }

                    FilmeDao dao = new FilmeDao();
                    query = select + where + orderBy;
                    //return dao.BuscarFilmes(where, orderBy);               
                    return query;
                }
                catch (Exception ex)
                {

                }
            }
            return query;
        }



    }
}