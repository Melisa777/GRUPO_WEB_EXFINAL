using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class DACinePelicula
    {
        static public List<CinePelicula> ListadoCinePelicula()
        {
            List<CinePelicula> listado = new List<CinePelicula>();
            using (var data = new CineDBEntities())
            {
                return data.CinePelicula.ToList();
            }
        }

        static public List<Pelicula> ListadoPelicula()
        {
            using (var data = new CineDBEntities())
            {
                return data.Pelicula.ToList();
            }

        }

        static public List<Cine> ListadoCine()
        {
            using (var data = new CineDBEntities())
            {
                return data.Cine.ToList();
            }

        }

        //

        static public bool RegistrarCinePelicula(CinePelicula cinepelicula)
        {
            bool exito = true;

            try
            {
                using (var data = new CineDBEntities())
                {
                    data.CinePelicula.Add(cinepelicula);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }


        static public bool ActualizarCinePelicula(CinePelicula cinePeli) // referido a objeto
        {
            bool exito = true; // validación del registro
            // para el manejo de excepciones
            try
            {
                using (var data = new CineDBEntities())
                {
                    // realizar la consulta y actualizar
                    CinePelicula actual = data.CinePelicula.Where(x => x.EnCartelera == cinePeli.EnCartelera).FirstOrDefault();// alias
                    //actual.ID_Empresa = empresa.ID_Empresa;
                    actual.CodCine = cinePeli.CodCine;
                    actual.CodPelicula = cinePeli.CodPelicula;
                   
                  
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

        static public bool EliminarCinePelicula(int CodCine) // referido a borrar
        {
            bool exito = true;
            try
            {

                using (var data = new CineDBEntities())
                {
                    CinePelicula actual = data.CinePelicula.Where(z => z.CodCine == CodCine).FirstOrDefault();// alias
                    data.CinePelicula.Remove(actual);
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
