using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class DAPELICULA
    {
        static public List<Pelicula> ListadoPelicula()
        {
            List<Pelicula> listado = new List<Pelicula>();

            using (var data = new CineDBEntities())
            {
                listado = data.Pelicula.ToList();
            }

            return listado;
        }


        static public bool RegistrarPelicula(Pelicula pelicula)
        {
            bool exito = true;

            try
            {
                using (var data = new CineDBEntities())
                {
                    data.Pelicula.Add(pelicula);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }


        static public bool ActualizarPelicula(Pelicula pelicula) // referido a objeto
        {
            bool exito = true; // validación del registro
            // para el manejo de excepciones
            try
            {
                using (var data = new CineDBEntities())
                {
                    // realizar la consulta y actualizar
                    Pelicula actual = data.Pelicula.Where(x => x.CodPelicula == pelicula.CodPelicula).FirstOrDefault();// alias
                    //actual.ID_Empresa = empresa.ID_Empresa;
                    //actual.ID_Usuario = empresa.ID_Usuario;
                    actual.NombrePelicula= pelicula.NombrePelicula;
                    actual.Duracion = pelicula.Duracion;
                    actual.FechaEstreno = pelicula.FechaEstreno;
                    actual.CodDirector = pelicula.CodDirector;
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

        static public bool EliminarPelicula(int CodPelicula) // referido a borrar
        {
            bool exito = true;
            try
            {

                using (var data = new CineDBEntities())
                {
                    Pelicula actual = data.Pelicula.Where(z => z.CodPelicula == CodPelicula).FirstOrDefault();// alias
                    data.Pelicula.Remove(actual);
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

