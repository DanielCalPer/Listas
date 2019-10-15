using System;
using System.Collections.Generic;
using System.Text;

namespace Listas_4
{
    class CantanteFamoso
    {
        public string Nombre { get; set; }
        public string DiscoConMasVentas { get; set; }

        public CantanteFamoso(string nombre, string discoConMasVentas)
        {
            Nombre = nombre;
            DiscoConMasVentas = discoConMasVentas;
        }

        public CantanteFamoso()
        {
        }

    }
}
