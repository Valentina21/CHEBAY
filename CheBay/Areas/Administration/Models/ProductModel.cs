using CheBay.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheBay.Areas.Administration.Models
{
    public class ProductModel
    {
        public List<Producto> productoListCollction { get; set; }
        public List<Categoria> categoriaListCollction { get; set; }
        public Producto producto { get; set; }
    }
}