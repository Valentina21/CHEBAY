using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheBay.Shared.Entities
{
    public class Producto
    {
        [Required]
        public int? idTienda { get; set; }
        [ForeignKey("idTienda")]
        public Tienda tienda { get; set; }
         [Key]
        public int id { get; set; }
         [Required]
        public string nombre { get; set; }
         [Required]
        public string descripcion { get; set; }
         [Required]
        public DateTime fechacierre { get; set; }
         [Required]
        public float preciobase { get; set; }
         [Required]
        public float preciocomdirecta { get; set; }

         public int? idcategoria { get; set; }
         [ForeignKey("idcategoria")]
         public Categoria categoria { get; set; }
         [Required]
         public List<AtributoValor> atributosvalores { get; set; }

         public List<Imagen> imagenes { get; set; }
        }

   
}
