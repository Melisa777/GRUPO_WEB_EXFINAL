using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General;

namespace General
{
    public class DACine
    {
        static public List<Cine> ListadoCine()
        {
            List<Cine> listado = new List<Cine>();

            using (var data = new CineDBEntities())
            {
                listado = data.Cine.ToList();
            }

            return listado;
        }
 
    static public bool RegistrarCine(Cine cine)
    {
        bool exito = true;
        
        try
        {
            using (var data = new CineDBEntities())
            {
                data.Cine.Add(cine);
                data.SaveChanges();
            }
        }
        catch
        {
            exito = false;
        }

        return exito;
    }


    static public bool ActualizarCine(Cine cine) // referido a objeto
    {
        bool exito = true; // validación del registro
                           // para el manejo de excepciones
        try
        {
            using (var data = new CineDBEntities())
            {
                    // realizar la consulta y actualizar
                    Cine actual = data.Cine.Where(x => x.CodCine == cine.CodCine).FirstOrDefault();// alias
                                                                                                                   //actual.ID_Empresa = empresa.ID_Empresa;
                                                                                                                   //actual.ID_Usuario = empresa.ID_Usuario;
                actual.NombreCine = cine.NombreCine;
                actual.Direccion = cine.Direccion;
                
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

    static public bool EliminarCine(int CodCine) // referido a borrar
    {
        bool exito = true;
        try
        {

            using (var data = new CineDBEntities())
            {
                Cine actual = data.Cine.Where(z => z.CodCine == CodCine).FirstOrDefault();// alias
                data.Cine.Remove(actual);
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


