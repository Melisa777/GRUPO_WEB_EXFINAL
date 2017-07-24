using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
   public  class DASala
    {
        static public List<Sala> ListadoSala()
        {
            List<Sala> listado = new List<Sala>();
            using (var data = new CineDBEntities())
            {
                return data.Sala.ToList();
            }
        }

        static public List<Cine> ListadoCine()

        {



            using (var data = new CineDBEntities())
            {
                return data.Cine.ToList();
            }

        }



        static public bool RegistrarSala(Sala sala)
        {
            bool exito = true;

            try
            {
                using (var data = new CineDBEntities())
                {
                    data.Sala.Add(sala);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }


        static public bool ActualizarSala(Sala sala) // referido a objeto
        {
            bool exito = true; // validación del registro
            // para el manejo de excepciones
            try
            {
                using (var data = new CineDBEntities())
                {
                    // realizar la consulta y actualizar
                    Sala actual = data.Sala.Where(x => x.CodSala == sala.CodSala).FirstOrDefault();// alias
                    //actual.ID_Empresa = empresa.ID_Empresa;
                    //actual.ID_Usuario = empresa.ID_Usuario;
                    actual.NombreSala = sala.NombreSala;
                    actual.Capacidad = sala.Capacidad;
                    actual.Tipo = sala.Tipo;
                    actual.CodCine = sala.CodCine;




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

        static public bool EliminarSala(int CodSala) // referido a borrar
        {
            bool exito = true;
            try
            {

                using (var data = new CineDBEntities())
                {
                    Sala actual = data.Sala.Where(z => z.CodSala == CodSala).FirstOrDefault();// alias
                    data.Sala.Remove(actual);
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

