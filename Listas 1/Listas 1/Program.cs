using System;
using System.Collections.Generic;
using System.Linq;

namespace Listas_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejemplos listas

            //List<string> paises = new List<string>()
            //{
            //    "Francia, Alemania, Inglaterra, Polonia" // para añadir varias variables a la vez. Tb se puede hacer con objetos etc.
            //};

            //    paises.Add("italia);");
            //paises.Insert(3, "Austria"); // entre Inglaterra y Polonia
            //paises.Insert(6, "Suecia"); // se mete en esa posicion y la 5 quedaría vacía. 
            //paises.RemoveAt(3);
            //paises.Remove("Francia"); // Si tienes 2 elementos que se llaman igual. Borra los 2.
            //paises.Remove(""); // elimina todas las posiciones vacias. 
            //paises.ElementAt(2); // estas 2 expresiones son iguales. Usar la segunda. 
            //paises[2];
            //int posicion = paises.IndexOf("Francia"); // devuelve un número, en este caso 0. Si hay más de 1 valor igual, devuelve la posición del primero. 
            //                                          // si no encuentra nada. Devuelve un -1. 
            //                                          // Recorrer Lista: 
            //for (int i = 0; i < paises.Count; i++)
            //{
            //    Console.WriteLine(paises[i]);
            //}

            //foreach (string x in paises) // Nuevo tipo de Bucle. definir variable, darle un  nombre y decir en que lista quieres que lo busque. 
            //{
            //    Console.WriteLine(x);

            //}

            //Pais p1 = new Pais("Francia", "Paris", 20000000);
            //Pais p2 = new Pais("Italia", "Roma", 10000000);
            //Pais p3 = new Pais("Portugal", "Lisboa", 120000);



            //List<Pais> paises = new List<Pais>()
            //{
            //    new Pais("España", "Madrid", 40000000),
            //    new Pais("Inglaterra", "Londres", 30000000)

            //};

            //foreach (Pais pais in paises)
            //{
            //    Console.WriteLine(pais.Capital);
            //    Console.WriteLine(pais.Nombre + " " + pais.Capital);
            //}

            try
            {
                int num1 = 1;
                int num2 = Convert.ToInt32(Console.ReadLine());
                int suma = num1 / num2; 
                
            }
            //catch (DivideByZeroException) // Aqui solo tienes en cuenta este tipo de excepcion. Si pones Exception, tiene en cuenta todos. 
            //{
            //    Console.WriteLine("No se puede dividir entre 0");
                
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Error, tienes que introducir un número");

            //}
            //finally
            //{
            //    Console.WriteLine("Error, vuelve a intentarlo");

            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            
        }
    }
}
