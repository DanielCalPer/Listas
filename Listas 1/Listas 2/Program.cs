using System;
using System.Collections.Generic;

namespace Listas_2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> frutas = new List<string>();

            CrearLista(frutas);
            MostrarLista(frutas);
            Console.WriteLine(); 
            OrdenarLista(frutas);
            
            Console.WriteLine(); 
            BorrarDeLaLista(frutas, "platanos");
            BorrarDeLaLista(frutas, "platanos");
            
            Console.WriteLine(); 
            Console.WriteLine($"La lista contiene {ContarElementos(frutas)} elementos");


            Console.ReadKey();
            
        }

        public static void CrearLista(List<string> frutas)
        {
            frutas.Add("manzanas");
            frutas.Add("albaricoques");
            frutas.Add("platanos");

            
        }

        public static void MostrarLista(List<string> lista) //es un método generico. No tiene por que llamarse igual.
        {
            foreach (string x in lista)
            {
                Console.WriteLine(x);
            }
            
        }
        public static void OrdenarLista(List<string> lista)
        {
            lista.Sort();
            MostrarLista(lista);
        }
        public static void BorrarDeLaLista(List<string> lista, string borrar)
        {
            if (lista.Remove(borrar))
            {
                Console.WriteLine($"{borrar} borrado satisfactoriamente");
            }
            else
            {
                Console.WriteLine($"El elemento no se ha encontrado en la lista");
            }
            
            MostrarLista(lista);
        }
        public static int ContarElementos(List<string> lista)
        {
            
            return lista.Count;
            
        }
    }
}
