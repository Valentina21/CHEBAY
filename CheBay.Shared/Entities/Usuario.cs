using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CheBay.Shared.Entities
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellido { get; set; }
        [Required]
        public string mail { get; set; }
        public string imagen { get; set; }
        [Required]
        public string contrasena { get; set; }       
        public float reputacion { get; set; }      
    }
}
