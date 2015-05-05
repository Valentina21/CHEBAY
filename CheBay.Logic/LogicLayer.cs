using CheBay.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheBay.Logic
{
    public static class LogicLayer
    {
        public static void AddTienda(Tienda tienda)
        {
            Data.DataLayer.AddTienda(tienda);
        }
    } 
}
