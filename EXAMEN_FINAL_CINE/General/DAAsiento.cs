using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
  public   class DAAsiento
    {
        static public List<Asiento> ListadoAsiento()
        {
            List<Asiento> listado = new List<Asiento>();
            using (var data = new CineDBEntities())
            {
                return data.Asiento.ToList();
            }
        }

        static public List<Sala> ListadoSala()

        {



            using (var data = new CineDBEntities())
            {
                return data.Sala.ToList();
            }

        }



        static public bool RegistrarAsiento(Asiento asiento)
        {
            bool exito = true;

            try
            {
                using (var data = new CineDBEntities())
                {
                    data.Asiento.Add(asiento);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }


        static public bool ActualizarAsiento(Asiento asiento) // referido a objeto
        {
            bool exito = true; // validación del registro
            // para el manejo de excepciones
            try
            {
                using (var data = new CineDBEntities())
                {
                    // realizar la consulta y actualizar
                    Asiento actual = data.Asiento.Where(x => x.CodAsiento == asiento.CodAsiento).FirstOrDefault();// alias
                    //actual.ID_Empresa = empresa.ID_Empresa;
                    //actual.ID_Usuario = empresa.ID_Usuario;
                    actual.DescripcionAsiento = asiento.DescripcionAsiento;
                    actual.CodSala = asiento.CodSala;
                    actual.TipoAsiento = asiento.TipoAsiento;
                    actual.Disponible = asiento.Disponible;




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

        static public bool EliminarAsiento(int CodAsiento) // referido a borrar
        {
            bool exito = true;
            try
            {

                using (var data = new CineDBEntities())
                {
                    Asiento actual = data.Asiento.Where(z => z.CodAsiento == CodAsiento).FirstOrDefault();// alias
                    data.Asiento.Remove(actual);
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
