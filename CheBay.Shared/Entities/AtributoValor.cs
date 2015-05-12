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
    public class AtributoValor
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string valor { get; set; }
        [Required]
        public Atributo atributo { get; set; }
    }

   
}
