using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheBay.Shared.Entities
{
    public class Producto
    {
        public int idproducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fechacierre { get; set; }
        public float preciobase { get; set; }
        public float preciocomdirecta { get; set; }

        }
}
