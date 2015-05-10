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

                context.SaveChanges();
            }
        }

        #region Atributos

        public static List<Atributo> GetAtributos()
        {
            using (var context = new InheritanceMappingContext())
            {
                return context.Atributos.ToList();
            }
        }

        public static void DeleteAtributo(int id)
        {
            using (var context = new InheritanceMappingContext())
            {
                Atributo atr = GetAtributo(id);
                context.Atributos.Attach(atr);
                context.Atributos.Remove(atr);
                context.SaveChanges();
            }
        }

        public static void UpdateAtributo(Atributo atr)
        {
            using (var context = new InheritanceMappingContext())
            {
                context.Atributos.Attach(atr);
                context.SaveChanges();
            }
        }

        public static Atributo GetAtributo(int id)
        {
            using (var context = new InheritanceMappingContext())
            {
                if (context.Atributos.Where(p => p.id == id).Count() > 0)
                {
                    return context.Atributos.First(p => p.id == id);
                }
                return null;
            }
        }

        public static void AddAtributo(Atributo atr)
        {
            using (var context = new InheritanceMappingContext())
            {
                context.Atributos.Add(atr);

                context.SaveChanges();
            }
        }

        #endregion

    }  
}
