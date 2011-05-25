using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto_Recomende.Util;
using Projeto_Recomende.Codes.OBJ;
using System.Data;

namespace Projeto_Recomende.Codes.DAO
{
    public class UsuarioDao
    {
        public bool CadastrarUsuario(Usuario usuario)
        {
            AdoUtils ado = new AdoUtils();
            string query = "INSERT INTO tb_noticias (titulo, noticia, data, id_usuario) " +
                           "VALUES (@titulo, @noticia, @data, @id_usuario);";
            List<KeyValuePair<string, object>> parametros = new List<KeyValuePair<string, object>>();
            parametros.Add(new KeyValuePair<string, object>("@nm_usuario", usuario.nm_usuario));
            parametros.Add(new KeyValuePair<string, object>("@email", usuario.email));
            parametros.Add(new KeyValuePair<string, object>("@senha", usuario.senha));
            parametros.Add(new KeyValuePair<string, object>("@id_usuario", usuario.id_usuario));
            parametros.Add(new KeyValuePair<string, object>("@tipo_usuario", usuario.tipo_usuario));
            parametros.Add(new KeyValuePair<string, object>("@end_foto", usuario.end_foto));
            
            return ado.ExecuteCommand(query, parametros.ToArray());

        }

        public Usuario LoadUsuario(string email, string senha)
        {
            Usuario usuario = null;
            try
            {
                string query = "SELECT * FROM tb_usuario where email = " + email + " AND senha = " + senha;
                AdoUtils ado = new AdoUtils();
                
                //   Boolean user = ado.ExecuteCommand(query);
                DataTable dt = ado.GetDataTable(query);
                if (dt.Rows.Count > 0)
                {
                    usuario = new Usuario(dt.Rows[0]);
                }                
            }
            catch (System.Data.SqlClient.SqlException ex)
            {

            }
            return usuario;
        }


    }
}