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



            Atributo atr = new Atributo();
            atr.titulo = "Peso";
            LogicLayer.AddAtributo(atr);


            Atributo atr2 = new Atributo();
            atr2.titulo = "Ancho";
            LogicLayer.AddAtributo(atr2);

            Atributo atr3 = new Atributo();
            atr3.titulo = "Altura";
            LogicLayer.AddAtributo(atr3);
        }
    }
}
