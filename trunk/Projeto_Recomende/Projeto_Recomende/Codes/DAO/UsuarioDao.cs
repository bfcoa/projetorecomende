using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto_Recomende.Util;
using Projeto_Recomende.Codes.OBJ;
using System.Data;
using Projeto_Recomende.Codes.BLL;

namespace Projeto_Recomende.Codes.DAO
{
    [Serializable]
    public class UsuarioDao
    {
        public bool CadastrarUsuario(Usuario usuario)
        {
            AdoUtils ado = new AdoUtils();
            string query = "INSERT INTO tb_usuario (nm_usuario, email, senha, tipo_usuario, end_foto) " +
                           "VALUES (@nm_usuario, @email, @senha, @tipo_usuario, @end_foto);";
            List<KeyValuePair<string, object>> parametros = new List<KeyValuePair<string, object>>();
            parametros.Add(new KeyValuePair<string, object>("@nm_usuario", usuario.nm_usuario));
            parametros.Add(new KeyValuePair<string, object>("@email", usuario.email));
            parametros.Add(new KeyValuePair<string, object>("@senha", usuario.senha));
            //parametros.Add(new KeyValuePair<string, object>("@id_usuario", usuario.id_usuario));
            parametros.Add(new KeyValuePair<string, object>("@tipo_usuario", usuario.tipo_usuario));
            parametros.Add(new KeyValuePair<string, object>("@end_foto", usuario.end_foto));
            int codUsuario = 0;
            if (ado.ExecuteCommand(query, parametros.ToArray()))
            {
                query = "SELECT TOP 1 id_usuario FROM tb_usuario ORDER BY id_usuario DESC";
                int.TryParse(ado.GetObject(query).ToString(), out codUsuario);
                usuario.id_usuario = codUsuario;
                return true;
            }
            else
            {
                return false;
            }


        }
        public bool UpdateFoto(Usuario usuario)
        {
            AdoUtils ado = new AdoUtils();
            //UsuarioBll userBll = new UsuarioBll();
            //string query = "UPDATE tb_usuario SET end_foto = ('../Util/Imagens/ImagensUsuarios/" + usuario.id_usuario + extencao + "') where id_usuario = " + usuario.id_usuario;
            string query = "UPDATE tb_usuario SET end_foto = '"+usuario.end_foto+"' where id_usuario = " + usuario.id_usuario;
            return ado.ExecuteCommand(query);
            //return usuario.end_foto;
        }

        public Usuario LoadUsuario(string email, string senha)
        {
            Usuario usuario = null;
                string query = "SELECT * FROM tb_usuario WHERE email = '" + email + "' AND senha = '" + senha + "'";
                AdoUtils ado = new AdoUtils();
                //   Boolean user = ado.ExecuteCommand(query);
                DataTable dt = ado.GetDataTable(query);
                if (dt.Rows.Count > 0)
                {
                    usuario = new Usuario(dt.Rows[0]);
                }            
            return usuario;
        }

        public Usuario UpdateDadosUsuario(Usuario usuario)
        {
            AdoUtils ado = new AdoUtils();
            string query = "UPDATE tb_usuario SET nm_usuario = ('" + usuario.nm_usuario + "'), email = ('" + usuario.email + "'), senha = ('" + usuario.senha + "') where id_usuario = " + usuario.id_usuario;
            ado.ExecuteCommand(query);
            return usuario;
        }


        public void InsertUsuarioGrupo(int grupo, Usuario user)
        {
            AdoUtils ado = new AdoUtils();
            string query = "UPDATE tb_usuario SET id_grupo =('" + grupo +"') where id_usuario = " + user.id_usuario;
            ado.ExecuteCommand(query);
        }
    }
}