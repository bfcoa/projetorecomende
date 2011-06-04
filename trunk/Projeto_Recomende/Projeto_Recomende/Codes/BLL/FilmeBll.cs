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

        public List<Filme> BuscarFilmes(string nomeFilme, string ator, int genero, int ordenarPor)
        {
            try
            {
                string where = " WHERE ";
                string orderBy = "";
                if (!string.IsNullOrEmpty(nomeFilme))
                    where += " (f.nm_titulo LIKE '%" + nomeFilme + "%' OR f.nm_tituloOriginal LIKE '%"+nomeFilme+"%') ";
                if (!string.IsNullOrEmpty(ator))
                    where += " AND f.elenco LIKE '%" + ator + "%'";
                if (genero != 0)
                    where += " AND f.id_genero = " + genero + " ";                 
                if (ordenarPor != 0)
                {
                    switch(ordenarPor){
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:
                            orderBy += "ORDER BY f.nm_titulo, f.nm_tituloOriginal ASC";
                            break;
                        case 4:
                            orderBy += "ORDER BY f.nm_titulo, f.nm_tituloOriginal DESC";
                            break;                       
                    }
                }

                FilmeDao dao = new FilmeDao();
                return dao.BuscarFilmes(where, orderBy);               

            }catch(Exception ex){

            }
            return null;
        }
        
        

    }
}