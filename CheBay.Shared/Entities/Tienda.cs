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
    public class Tienda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string idadministrador { get; set; }
        [Required]
        public string slogan { get; set; }
        [Required]
        public string tema { get; set; }
        [Required]
        public string basededatos { get; set; }
    }


    public class InheritanceMappingContext : DbContext
    {
        public DbSet<Tienda> Tiendas { get; set; }
    }


}
