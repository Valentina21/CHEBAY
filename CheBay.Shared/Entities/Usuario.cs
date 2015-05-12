using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CheBay.Shared.Entities
{
    public class Usuario
    {
         [Required]
        public string nombre { get; set; }
         [Required]
        public string apellido { get; set; }
         [Required]
        public string mail { get; set; }
         [Required]
        public string imagen { get; set; }
         [Required]
        public string contrasena { get; set; }
         [Required]
        public string geo { get; set; }
         [Required]
        public float reputacion { get; set; }
        [Key]
        public int id { get; set; }
    }

   
}
