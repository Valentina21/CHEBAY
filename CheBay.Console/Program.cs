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
            t.nombre = "Automotora"; 
            t.slogan = "La mejor automotora";
            t.tema = "azul";
            t.basededatos = "Ebay";
            t.idadministrador = "agustin";
            LogicLayer.AddTienda(t);

            Atributo atr = new Atributo();
            atr.titulo = "Color";
            LogicLayer.AddAtributo(atr);

            Atributo atr2 = new Atributo();
            atr2.titulo = "Anio";
            LogicLayer.AddAtributo(atr2);

            Atributo atr3 = new Atributo();
            atr3.titulo = "Motor";
            LogicLayer.AddAtributo(atr3);

            Atributo atr4 = new Atributo();
            atr4.titulo = "Marca";
            LogicLayer.AddAtributo(atr4);

            Categoria cat1 = new Categoria();
            cat1.nombre = "Autos";
            cat1.tienda = LogicLayer.GetTiendaByName("Automotora");
            cat1.atributos.Add(LogicLayer.GetAtributo(1));
            cat1.atributos.Add(LogicLayer.GetAtributo(2));
            cat1.atributos.Add(LogicLayer.GetAtributo(3));
        }
    }
}
