using CheBay.Shared.Entities;
using CheBay.Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheBay.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tienda t = new Tienda();
            t.nombre = "Ebay";
            t.slogan = "El mejor local de ventas";
            t.tema = "azul";
            t.basededatos = "Ebay";
            t.idadministrador = "agustin";
            LogicLayer.AddTienda(t);
        }
    }
}
