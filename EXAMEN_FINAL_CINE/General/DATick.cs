using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class DATick
    {
        static public List<Ticket> ListadoDirector()
        {

            List<Ticket> alumno = new List<Ticket>();
            using (var data = new CineDBEntities())
            {
                return data.Ticket.ToList();
            }
        }
    }
}
