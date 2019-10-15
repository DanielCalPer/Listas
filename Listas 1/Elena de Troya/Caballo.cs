using System;
using System.Collections.Generic;
using System.Text;

namespace Elena_de_Troya
{
    class Caballo
    {
        public int Capacidad;
        public int Ocupacion { get; set; }
        public List<Griego> Ocupantes { get; set; }

        public Caballo(int capacidad)
        {
            Capacidad = capacidad;
            Ocupantes = new List<Griego>();

        }
        public int Buscar(string nombre)
        {
            foreach (Griego x in Ocupantes)
            {
                if (nombre == x.Nombre)
                {
                    return Ocupantes.IndexOf(x);
                }
            }

            return -1;

        }
        public void MostrarGuerreroPosicion(int pos)
        {

            if (pos < Ocupantes.Count && pos >=0)
            {
                
                Ocupantes[pos].MostrarDatos();
            }
            else
            {
                Console.WriteLine($"No es posible localizar al guerrero");
            }

        }
        public void MontarseEnCaballo(Griego griego) // Los objetos y las listas se puede usar como variables de un parámetro
        {
            if (Ocupantes.Count < Capacidad)
            {
                Ocupantes.Add(griego);
                Ocupacion++;
                
                Console.WriteLine($"Guerrero griego de nombre {griego.Nombre} se ha montado en el caballo");
            }
            else
            {
                Console.WriteLine("No queda sitio en el caballo");
            }
        }
        public void MostrarCaballo()
        {
                Console.WriteLine($"{Capacidad}");
                Console.WriteLine($"{Ocupacion}");
 
                    foreach (Griego x in Ocupantes)
                    {
                        Console.WriteLine(x.Nombre, x.Edad, x.Fuerza); 
                    }
 
        }
    }

}
