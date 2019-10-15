using System;
using System.Collections.Generic;

namespace Listas_4
{
    class Program
    {
        static void Main(string[] args)
        {

            CantanteFamoso Sabina = new CantanteFamoso("juaquín Sabina", "500 noches");
            CantanteFamoso MichaelJackson = new CantanteFamoso("Michael Jackson", "Thriller");

            List<CantanteFamoso> cantantesFamosos = new List<CantanteFamoso>()
            {
                Sabina, MichaelJackson
            };

            AnadirCantante(cantantesFamosos); 

            foreach (CantanteFamoso x in cantantesFamosos)
            {
                Console.WriteLine($"El artista es: {x.Nombre} y su disco más vendido es: {x.DiscoConMasVentas}");
            }


            Console.ReadKey();
        }
        public static void AnadirCantante(List<CantanteFamoso> cantantesFamosos) // Añadir Valores lista. 
        {
            string nombre, disco, respuesta;

            do
            {
                Console.WriteLine("Introduce el nombre de un cantante:");
                nombre = Console.ReadLine();
                Console.WriteLine("Introduce el nombre de su disco más vendido:");
                disco = Console.ReadLine();
                CantanteFamoso pepito = new CantanteFamoso(nombre, disco);
                cantantesFamosos.Add(pepito);

                foreach (CantanteFamoso x in cantantesFamosos)
                {
                    Console.WriteLine($"El artista es: {x.Nombre} y su disco más vendido es: {x.DiscoConMasVentas}");
                }

                Console.WriteLine("¿Deseas introducir otro artista?");
                respuesta = Console.ReadLine().ToLower();


            } while (respuesta == "si");
        }
    }
}
