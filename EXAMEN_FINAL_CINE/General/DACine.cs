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
    }
}
