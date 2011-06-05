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

        public string BuscarFilmes(string nomeFilme, string ator, int genero, int ordenarPor)
        {
            string query = "";
            if (!string.IsNullOrEmpty(nomeFilme))
            {
                try
                {
                    string select = "SELECT " +
                                    "'<table>" +
                                        "<tbody>" +
                                            "<tr>" +
                                                "<td>" +
                                                    "<img width=\"120px\" src=\"../Util/Imagens/ImagensFilmes/'+f.foto+'\" style=\"margin: 0px\"" +
                                                        "alt=\"Não há foto disponível\">" +
                                                "</td>" +
                                                "<td valign=\"top\">" +
                                                    "<strong>Titulo:</strong><span>'+f.nm_titulo+'</span><br>" +
                                                    "<strong>Titulo Original:</strong><span>'+f.nm_tituloOriginal+'</span><br>" +
                                                    "<strong>Gênero:</strong><span>'+g.tp_genero+'</span><br>" +
                                                    "<strong>Ano de Produção:</strong><span>'+f.ano_producao+'</span><br>" +
                                                    "<strong>Duração:</strong><span>'+f.duracao+'</span><br>" +
                                                    "<strong>Elenco:</strong><span>'+f.elenco+'</span><br>" +
                                                    "<strong>Sinopse:</strong><span>'+CONVERT(VARCHAR(8000), f.txt_sinopse)+'</span><br>" +
                                                "</td>" +
                                            "</tr>" +
                                        "</tbody>" +
                                    "</table>' AS trFilme " +
                                    "FROM danilos5.dbo.tb_filme f " +
                                    "INNER JOIN danilos5.dbo.tb_genero g " +
                                    "ON(f.id_genero = g.id_genero)";


                    string where = " WHERE ";
                    string orderBy = "";

                    if (!string.IsNullOrEmpty(nomeFilme))
                        where += " (f.nm_titulo LIKE '%" + nomeFilme + "%' OR f.nm_tituloOriginal LIKE '%" + nomeFilme + "%') ";
                    if (!string.IsNullOrEmpty(ator))
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