using System;
using System.Collections.Generic;
using System.Text;

namespace Listas_1
{
    class Pais
    {
        public string Nombre { get; set; }
        public string Capital { get; set; }
        public int Poblacion { get; set; }

        public Pais(string nombre, string capital, int poblacion)
        {
            Nombre = nombre;
            Capital = capital;
            Poblacion = poblacion;
        }
        
        
    }



}
