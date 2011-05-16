using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Recomende.Codes.OBJ
{
    public class Noticia
    {
        public int id_noticia { get; set; }
        public int id_usuario { get; set; }
        public string titulo { get; set; }
        public string noticia { get; set; }
        public DateTime data { get; set; }        
    }
}