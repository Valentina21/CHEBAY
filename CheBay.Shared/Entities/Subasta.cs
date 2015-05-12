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
    public class Subasta
    {
        [Required]
        public int? idsubastador { get; set; }
        [ForeignKey("idsubastador")]
        public Usuario subastador { get; set; }
        public int? idofertante { get; set; }
        [ForeignKey("idofertante")]
        public Usuario ofertante { get; set; }
        public int? idproducto { get; set; }
        [ForeignKey("idproducto")]
        public Producto producto { get; set; }
        public float compradirecta { get; set; }
        public float preciobase { get; set; }
        public DateTime fecha { get; set; }
         [Key]
        public int id { get; set; }
    }

   
}
