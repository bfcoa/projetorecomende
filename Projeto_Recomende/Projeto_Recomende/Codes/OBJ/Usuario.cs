using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Recomende.Codes.OBJ
{
    public class Usuario
    {
        public Usuario(System.Data.DataRow registro)
        {
            int idUsuario = 0;

            int.TryParse(registro["id_usuario"].ToString(), out idUsuario);
            this.id_usuario = idUsuario;
            this.nm_usuario = registro["nm_usuario"].ToString();
            this.email = registro["email"].ToString();
            this.senha = registro["senha"].ToString();
            this.tipo_usuario = registro["tipo_usuario"].ToString();        
        }
        public Usuario()
        { }

        public int id_usuario { get; set; }
        public string  nm_usuario{ get; set; }
        public string email { get; set; }
        public string senha{ get; set; }
        public int id_grupo { get; set; }
        public string end_foto { get; set; }
        public string tipo_usuario{ get; set; }
    }
}