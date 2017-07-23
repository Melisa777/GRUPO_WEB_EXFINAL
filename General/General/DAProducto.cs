using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
   public  class DAProducto
    {
        static public List<Products> ListadoProducto()
        {
            List<Products> listado = new List<Products>();
            using (var data = new northwindEntities())
            {
                return data.Products.ToList();
            }
        }

        static public List<Suppliers> ListadoProveedor()
        {
            using (var data = new northwindEntities())
            {
                return data.Suppliers.ToList();
            }

        }

        static public List<Categories> ListadoCategoria()
        {
            using (var data = new northwindEntities())
            {
                return data.Categories.ToList();
            }

        }

        //

        static public bool RegistrarProducto(Products producto)
        {
            bool exito = true;

            try
            {
                using (var data = new northwindEntities())
                {
                    data.Products.Add(producto);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }


        static public bool ActualizarProducto(Products producto) // referido a objeto
        {
            bool exito = true; // validación del registro
            // para el manejo de excepciones
            try
            {
                using (var data = new northwindEntities())
                {
                    // realizar la consulta y actualizar
                    Products actual = data.Products.Where(x => x.ProductID == producto.ProductID).FirstOrDefault();// alias
                    //actual.ID_Empresa = empresa.ID_Empresa;
                    //actual.ID_Usuario = empresa.ID_Usuario;
                    actual.ProductName = producto.ProductName;
                    actual.SupplierID = producto.SupplierID;
                    actual.CategoryID = producto.CategoryID;
                    actual.QuantityPerUnit = producto.QuantityPerUnit;
                    actual.UnitPrice = producto.UnitPrice;
                    actual.UnitsInStock = producto.UnitsInStock;
                    actual.ReorderLevel = producto.ReorderLevel;
                    actual.Discontinued = producto.Discontinued;





                    // transaccion landa express
                    // data.GEPOSTULANTEs.InsertOnSubmit(postulante);
                    data.SaveChanges(); // guarda los cambios
                }
            }
            catch (Exception)
            {
                // cuando ocurre el error
                exito = false;
            }
            return exito;

        }

        static public bool EliminarProducto(int ProductID) // referido a borrar
        {
            bool exito = true;
            try
            {

                using (var data = new northwindEntities())
                {
                    Products actual = data.Products.Where(z => z.ProductID == ProductID).FirstOrDefault();// alias
                    data.Products.Remove(actual);
                    data.SaveChanges();
                }
            }
            catch (Exception)
            {

                exito = false;
            }

            return exito;
        }
    }
}

