using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto_Recomende.Codes.OBJ;
using Projeto_Recomende.Util;
using System.Data;

namespace Projeto_Recomende.Codes.DAO
{
    public class NoticiaDao
    {
        public bool CadastrarNoticia(Noticia noticia)
        {

            AdoUtils ado = new AdoUtils();
            string query = "INSERT INTO tb_noticias (titulo, noticia, data, id_usuario) " +
                           "VALUES (@titulo, @noticia, @data, @id_usuario);";
            List<KeyValuePair<string, object>> parametros = new List<KeyValuePair<string, object>>();
            parametros.Add(new KeyValuePair<string, object>("@titulo", noticia.titulo));
            parametros.Add(new KeyValuePair<string, object>("@noticia", noticia.noticia));
            parametros.Add(new KeyValuePair<string, object>("@data", noticia.data));
            parametros.Add(new KeyValuePair<string, object>("@id_usuario", noticia.id_usuario));

            return ado.ExecuteCommand(query, parametros.ToArray());                                     
            }

        public List<Noticia> LoadNoticias()
        {
            List<Noticia> listNoticias = null;
            try
            {
                string query = "SELECT TOP 5 * FROM tb_noticias ORDER BY id_noticia DESC";
                AdoUtils ado = new AdoUtils();
                DataTable dt = ado.GetDataTable(query);

                listNoticias = new List<Noticia>();
                foreach (DataRow dr in dt.Rows)
                {
                    listNoticias.Add(new Noticia(dr));
                }


            }
            catch (System.Data.SqlClient.SqlException ex)
            {

            }
            return listNoticias;
        }
    }
}