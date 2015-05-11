using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace CheBay.Shared.Entities
{
    public class Imagen
    {
        [Key]
        public int id { get; set; }
        public string ruta { get; set; }
    }

   
}
