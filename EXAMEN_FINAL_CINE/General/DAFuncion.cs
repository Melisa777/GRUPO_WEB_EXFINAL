using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class DAFuncion
    {

        static public List<Funcion> ListadoFuncion()
        {
            List<Funcion> listado = new List<Funcion>();

            using (var data = new CineDBEntities())
            {
                listado = data.Funcion.ToList();
            }

            return listado;
        }

        static public List<Pelicula> ListadoPelicula()
        {
            using (var data = new CineDBEntities())
            {
                return data.Pelicula.ToList();
            }

        }

        static public bool RegistrarFuncion(Funcion funcion)
        {
            bool exito = true;

            try
            {
                using (var data = new CineDBEntities())
                {
                    data.Funcion.Add(funcion);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }


        static public bool ActualizarFuncion(Funcion funcion) // referido a objeto
        {
            bool exito = true; // validación del registro
            // para el manejo de excepciones
            try
            {
                using (var data = new CineDBEntities())
                {
                    // realizar la consulta y actualizar
                    Funcion actual = data.Funcion.Where(x => x.CodFuncion == funcion.CodFuncion).FirstOrDefault();// alias
                    
                    actual.HoraInicio = funcion.HoraInicio;
                    actual.HoraFin = funcion.HoraFin;
                    actual.CodPelicula = funcion.CodPelicula;
                    actual.FechaFuncion = funcion.FechaFuncion;
                    actual.Precio = funcion.Precio;

                    data.SaveChanges(); // guarda los cambios
                }
            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;

        }

        static public bool EliminarFuncion(int CodFuncion) 
        {
            bool exito = true;
            try
            {

                using (var data = new CineDBEntities())
                {
                    Funcion actual = data.Funcion.Where(z => z.CodFuncion == CodFuncion).FirstOrDefault();// alias
                    data.Funcion.Remove(actual);
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

