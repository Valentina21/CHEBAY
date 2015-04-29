using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheBay.Shared.Entities
{
    public class Comentario
    {
        public int idUsuario { get; set; }
        public int idproducto { get; set; }
        public string texto { get; set; }
    }
}
