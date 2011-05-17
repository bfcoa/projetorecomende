using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Recomende.Codes.OBJ
{
    public class Noticia
    {
        public Noticia() { }
        public Noticia(System.Data.DataRow registro)
        {
            int idNoticia = 0;
            int idUsuario = 0;

            int.TryParse(registro["id_noticia"].ToString(), out idNoticia);
            int.TryParse(registro["id_usuario"].ToString(), out idUsuario);

            this.id_noticia = idNoticia;
            this.id_usuario = idUsuario;
            this.titulo = registro["titulo"].ToString();
            this.noticia = registro["noticia"].ToString();
        }


        public int? id_noticia { get; set; }
        public int? id_usuario { get; set; }
        public string titulo { get; set; }
        public string noticia { get; set; }
        public DateTime data { get; set; }        
    }
}