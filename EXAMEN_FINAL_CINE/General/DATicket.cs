using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
   public  class DATicket
    {
        static public List<Ticket> ListadoTicket()
        {
            List<Ticket> listado = new List<Ticket>();

            using (var data = new CineDBEntities())
            {
                listado = data.Ticket.ToList();
            }

            return listado;
        }




        static public bool RegistrarTicket(Ticket ticket)
        {
            bool exito = true;

            try
            {
                using (var data = new CineDBEntities())
                {
                    data.Ticket.Add(ticket);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }


        static public bool ActualizarTicket(Ticket ticket) // referido a objeto
        {
            bool exito = true; // validación del registro
                               // para el manejo de excepciones
            try
            {
                using (var data = new CineDBEntities())
                {
                    // realizar la consulta y actualizar
                    Ticket actual = data.Ticket.Where(x => x.CodTicket == ticket.CodTicket).FirstOrDefault();// alias
                                                                                                                       //actual.ID_Empresa = empresa.ID_Empresa;
                                                                                                                       //actual.ID_Usuario = empresa.ID_Usuario;
                    actual.Descripcion = ticket.Descripcion;
                    actual.CodAsiento = ticket.CodAsiento;
                    actual.CodPersona = ticket.CodPersona;
                    actual.CodFuncion = ticket.CodFuncion;
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

        static public bool EliminarTicket(int CodTicket) // referido a borrar
        {
            bool exito = true;
            try
            {

                using (var data = new CineDBEntities())
                {
                    Ticket actual = data.Ticket.Where(z => z.CodTicket == CodTicket).FirstOrDefault();// alias
                    data.Ticket.Remove(actual);
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
