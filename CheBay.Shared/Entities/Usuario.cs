using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheBay.Shared.Entities
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public string imagen { get; set; }
        public string contrasena { get; set; }
        public string geo { get; set; }
        public float reputacion { get; set; }
        public int Id { get; set; }
    }
}
