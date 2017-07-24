using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
   public class DADirector
    {
        static public List<Director> ListadoDirector()
        {
            List<Director> listado = new List<Director>();

            using (var data = new CineDBEntities())
            {
                listado = data.Director.ToList();
            }

            return listado;
        }

    


    static public bool RegistrarDirector(Director director)
    {
        bool exito = true;

        try
        {
            using (var data = new CineDBEntities())
            {
                data.Director.Add(director);
                data.SaveChanges();
            }
        }
        catch
        {
            exito = false;
        }

        return exito;
    }


    static public bool ActualizarDirector(Director director) // referido a objeto
    {
        bool exito = true; // validación del registro
                           // para el manejo de excepciones
        try
        {
            using (var data = new CineDBEntities())
            {
                    // realizar la consulta y actualizar
                    Director actual = data.Director.Where(x => x.CodDirector == director.CodDirector).FirstOrDefault();// alias
                                                                                                                   //actual.ID_Empresa = empresa.ID_Empresa;
                                                                                                                   //actual.ID_Usuario = empresa.ID_Usuario;
                actual.NombreDirector = director.NombreDirector;
                
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

    static public bool EliminarDirector(int CodDirector) // referido a borrar
    {
        bool exito = true;
        try
        {

            using (var data = new CineDBEntities())
            {
                Director actual = data.Director.Where(z => z.CodDirector == CodDirector).FirstOrDefault();// alias
                data.Director.Remove(actual);
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
