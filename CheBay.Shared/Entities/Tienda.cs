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
        [Key]
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
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Imagen> Imagenes { get; set; }
        public DbSet<AtributoValor> AtributosValores { get; set; }
        public DbSet<Atributo> Atributos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Subasta> Subastas { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
    }


}
