using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class DAPersonaa
    {
        static public List<Persona> ListadoPersona()
        {
            List<Persona> listado = new List<Persona>();

            using (var data = new CineDBEntities())
            {
                listado = data.Persona.ToList();
            }

            return listado;
        }
        
        static public bool RegistrarPersona(Persona persona)
        {
            bool exito = true;

            try
            {
                using (var data = new CineDBEntities())
                {
                    data.Persona.Add(persona);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }
        
        static public bool ActualizarPersona(Persona persona) 
        {
            bool exito = true; 
            try
            {
                using (var data = new CineDBEntities())
                {
                    
                    Persona actual = data.Persona.Where(x => x.CodPersona == persona.CodPersona).FirstOrDefault();
                    actual.Paterno = persona.Paterno;
                    actual.Materno = persona.Materno;
                    actual.Nombres = persona.Nombres;
                    actual.Direccion = persona.Direccion;
                    actual.Email = persona.Email;
                    actual.FechaNacimiento = persona.FechaNacimiento;
                    actual.NroDocumento = persona.NroDocumento;
                    actual.foto = persona.foto;
                    actual.doc = persona.doc;

                    data.SaveChanges(); 
                }
            }
            catch (Exception)
            {
                // error
                exito = false;
            }
            return exito;

        }
        static public bool EliminarPersona(int CodPersona) // referido a borrar
        {
            bool exito = true;
            try
            {

                using (var data = new CineDBEntities())
                {
                    Persona actual = data.Persona.Where(z => z.CodPersona == CodPersona).FirstOrDefault();// alias
                    data.Persona.Remove(actual);
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
