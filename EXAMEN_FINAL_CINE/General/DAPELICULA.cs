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
    }
}
