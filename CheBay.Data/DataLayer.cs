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
        #region Tienda

        public static void AddTienda(Tienda tienda)
        {
            using (var context = new InheritanceMappingContext())
            {
                context.Tiendas.Add(tienda);
                context.SaveChanges();
            }
        }

        public static Tienda GetTiendaByName(string name)
        {
            using (var context = new InheritanceMappingContext())
            {
                if (context.Tiendas.Where(p => p.nombre == name).Count() > 0)
                {
                    return context.Tiendas.First(p => p.nombre == name);
                }
                return null;
            }
        }

        #endregion

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
                Atributo aux = (context.Atributos.First(p => p.id == atr.id));

                if (atr != null)
                {
                    context.Entry(aux).CurrentValues.SetValues(atr);
                    context.SaveChanges();
                }
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

        #region Products

        public static List<Producto> GetProducts()
        {
            using (var context = new InheritanceMappingContext())
            {
                return context.Productos.ToList();
            }
        }

        public static void DeleteProduct(int id)
        {
            using (var context = new InheritanceMappingContext())
            {
                Producto prd = GetProducto(id);
                context.Productos.Attach(prd);
                context.Productos.Remove(prd);
                context.SaveChanges();
            }
        }

        public static void UpdateProduct(Producto prd)
        {
            using (var context = new InheritanceMappingContext())
            {
                Producto aux = (context.Productos.First(p => p.id == prd.id));

                if (prd != null)
                {
                    context.Entry(aux).CurrentValues.SetValues(prd);
                    context.SaveChanges();
                }
            }
        }

        public static Producto GetProducto(int id)
        {
            using (var context = new InheritanceMappingContext())
            {
                if (context.Productos.Where(p => p.id == id).Count() > 0)
                {
                    return context.Productos.First(p => p.id == id);
                }
                return null;
            }
        }

        public static void AddProducto(Producto prd)
        {
            using (var context = new InheritanceMappingContext())
            {
                context.Productos.Add(prd);

                context.SaveChanges();
            }
        }

        #endregion

        #region Categories

        public static List<Categoria> GetCategories()
        {
            using (var context = new InheritanceMappingContext())
            {
                return context.Categorias.ToList();
            }
        }

        public static void AddCategoria(Categoria cat)
        {
            using (var context = new InheritanceMappingContext())
            {
                context.Categorias.Add(cat);

                context.SaveChanges();
            }
        }

        #endregion
    }  
}
