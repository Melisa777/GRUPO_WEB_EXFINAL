using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace General
{
    public class DAProtagonista
    {

        static public List<Protagonista> ListadoProtagonista()
        {
            List<Protagonista> listado = new List<Protagonista>();
            using (var data = new CineDBEntities())
            {
                return data.Protagonista.ToList();
            }
        }

        static public List<Pelicula> ListadoPelicula()
        {
            using (var data = new CineDBEntities())
            {
                return data.Pelicula.ToList();
            }

        }

        static public List<Interprete> ListadoInterprete()
        {
            using (var data = new CineDBEntities())
            {
                return data.Interprete.ToList();
            }

        }

        //

        static public bool RegistrarProtagonista(Protagonista protagonista)
        {
            bool exito = true;

            try
            {
                using (var data = new CineDBEntities())
                {
                    data.Protagonista.Add(protagonista);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }

        static public bool ActualizarProtagonista(Protagonista cinePeli) // referido a objeto
        {
            bool exito = true; // validación del registro
            // para el manejo de excepciones
            try
            {
                using (var data = new CineDBEntities())
                {
                    // realizar la consulta y actualizar
                    Protagonista actual = data.Protagonista.Where(x => x.NombreProtagonista == cinePeli.NombreProtagonista).FirstOrDefault();// alias
                    
                    actual.EsPrincipal = cinePeli.EsPrincipal;
               
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

        static public bool EliminarProtagonista(int CodCine) // referido a borrar
        {
            bool exito = true;
            try
            {

                using (var data = new CineDBEntities())
                {
                    Protagonista actual = data.Protagonista.Where(z => z.CodInterprete == CodCine).FirstOrDefault();// alias
                    data.Protagonista.Remove(actual);
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
}

