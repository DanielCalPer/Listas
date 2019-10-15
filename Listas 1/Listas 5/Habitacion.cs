using System;
using System.Collections.Generic;
using System.Text;

namespace Listas_5
{
    class Habitacion
    {
        public int ID { get; set; }
        public string Estado { get; set; }

        public Habitacion(int iD, string estado)
        {
            ID = iD;
            Estado = estado;
        }
    }
}
