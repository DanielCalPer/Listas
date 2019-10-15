using System;
using System.Collections.Generic;

namespace Elena_de_Troya
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo caballo = new Caballo(20);

            Griego griego1 = new Griego("Aquiles", 20, 8);
            Griego griego2 = new Griego("Agamenon", 30, 10);
            Griego griego3 = new Griego("Ajax", 40, 3);


            caballo.MontarseEnCaballo(griego1);
            caballo.MontarseEnCaballo(griego2);
            caballo.MontarseEnCaballo(griego3);

            caballo.MostrarCaballo();

            Console.WriteLine();

            Griego griego4 = new Griego();
            caballo.MontarseEnCaballo(griego4);
            caballo.MostrarCaballo();

            Console.WriteLine();

       
            caballo.MostrarGuerreroPosicion(caballo.Buscar("Agamenon"));

            Console.WriteLine();

            
            caballo.MostrarGuerreroPosicion(caballo.Buscar("Odiseo"));
            Console.WriteLine();

            //Troyano troyano = new Troyano("Paris", 20, 25);
            //caballo.MontarseEnCaballo(troyano);
            //caballo.MostrarCaballo();

            Console.ReadLine();
        }
    }
}
