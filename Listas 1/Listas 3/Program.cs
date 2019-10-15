using System;
using System.Collections.Generic;

namespace Listas_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> decimales = new List<double>();
            List<int> enteros = new List<int>();

            int entero=0;
            double deci=0;
            string numero;

            do
            {
    
                Console.WriteLine("Introduce un número: ");
                numero = (Console.ReadLine());

                if (Int32.TryParse(numero, out entero)) // si puede convertirlo, lo mete en la lista
                {
                    if (entero >=0)
                    {
                        enteros.Add(entero);
                    }
                    
                }
                else if (Double.TryParse(numero, out deci))
                {
                    if (deci >= 0)
                    {
                        decimales.Add(deci);
                    }
                    
                }
                else
                {
                    Console.WriteLine("Introduce un número correcto");
                }

                //if (num % 1 != 0 && num >= 0) // mejor como arriba, el Try parse quita de errores del usuario
                //{
                    
                    
                //    decimales.Add(num);
                //}
                //else if (num >=0)
                //{
                //    enteros.Add(Convert.ToInt32(num));
                //}
                
                
            } while (deci >=0 && entero >= 0);

            double NumDecimales;

            foreach (double x in decimales)
            {
                NumDecimales = decimales.Count; 
                Console.WriteLine(x); 
            }

            Console.WriteLine();

            foreach (int y in enteros)
            {
                
                Console.WriteLine(y);

            }

            int sumaEnteros = 0;

            foreach (int z in enteros)
            {
                
                sumaEnteros += z; 
            }
            double sumaDecimales = 0; 

            foreach (double k in decimales)
            {
                sumaDecimales += k; 
            }
            Console.WriteLine((sumaEnteros + sumaDecimales));
            Console.WriteLine(); 
            Console.WriteLine((sumaEnteros + sumaDecimales)/(decimales.Count + enteros.Count)); 

            Console.ReadKey(); 
        }
    }
}
