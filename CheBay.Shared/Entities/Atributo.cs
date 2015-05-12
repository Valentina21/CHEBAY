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
    public class Atributo
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string titulo { get; set; }
    }

    
}
