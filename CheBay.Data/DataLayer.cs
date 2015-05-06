using CheBay.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheBay.Data
{
    public static class DataLayer
    {
        public static void AddTienda(Tienda tienda)
        {
            using (var context = new InheritanceMappingContext())
            {
                context.Tiendas.Add(tienda);
            }
        }
    }  
}
