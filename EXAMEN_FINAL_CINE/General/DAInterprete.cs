using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class DAInterprete
    {
        static public List<Interprete> ListadoInterprete()
        {
            List<Interprete> listado = new List<Interprete>();

            using (var data = new CineDBEntities())
            {
                listado = data.Interprete.ToList();
            }

            return listado;
        }




        static public bool RegistrarInterprete(Interprete interprete)
        {
            bool exito = true;

            try
            {
                using (var data = new CineDBEntities())
                {
                    data.Interprete.Add(interprete);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }


        static public bool ActualizarInterprete(Interprete interprete) // referido a objeto
        {
            bool exito = true; // validación del registro
                               // para el manejo de excepciones
            try
            {
                using (var data = new CineDBEntities())
                {
                    // realizar la consulta y actualizar
                    Interprete actual = data.Interprete.Where(x => x.CodInterprete == interprete.CodInterprete).FirstOrDefault();// alias
                                                                                                                       //actual.ID_Empresa = empresa.ID_Empresa;
                                                                                                                       //actual.ID_Usuario = empresa.ID_Usuario;
                    actual.Paterno = interprete.Paterno;
                    actual.Materno = interprete.Materno;
                    actual.Nombres = interprete.Nombres;
                    actual.Nacionalidad = interprete.Nacionalidad;
                    actual.Foto = interprete.Foto;
                    actual.Bio = interprete.Bio;

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

        static public bool EliminarInterprete(int CodInterprete) // referido a borrar
        {
            bool exito = true;
            try
            {

                using (var data = new CineDBEntities())
                {
                    Interprete actual = data.Interprete.Where(z => z.CodInterprete == CodInterprete).FirstOrDefault();// alias
                    data.Interprete.Remove(actual);
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
