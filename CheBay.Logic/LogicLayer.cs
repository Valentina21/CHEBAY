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

        #region Atributos

        public static List<Atributo> GetAtributos()
        {
            return Data.DataLayer.GetAtributos();
        }

        public static void DeleteAtributo(int id)
        {
            Data.DataLayer.DeleteAtributo(id);
        }

        public static void UpdateAtributo(Atributo atr)
        {
            Data.DataLayer.UpdateAtributo(atr);
        }

        public static Atributo GetAtributo(int id)
        {
            return Data.DataLayer.GetAtributo(id);
        }

        public static void AddAtributo(Atributo atr)
        {
            Data.DataLayer.AddAtributo(atr);
        }

        #endregion

    } 
}
