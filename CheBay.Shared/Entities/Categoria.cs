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
    public class Categoria
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public Tienda tienda { get; set; }
        public List<Atributo> atributos { get; set; }
    }

   
}
