using System;
using System.Collections.Generic;
using System.Text;

namespace Elena_de_Troya
{
    class Griego
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Fuerza { get; set; }
        public bool Herido { get; set; }
        public bool Muerto { get; set; }

        public Griego(string nombre, int edad, int fuerza)
        {

            Nombre = nombre;

            if (ComprobarEdad(edad))
            {
                Edad = edad;
            }
            else
            {
                Edad = 25;
            }
            if (ComprobarFuerza(fuerza))
            {
                Fuerza = fuerza;
            }
            else
            {
                Fuerza = 5;
            }

            Herido = false;
            Muerto = false;

        }

        public Griego()
        {
            Nombre = "GriegoX";
            Edad = 20;
            Fuerza = 8;
            Herido = false;
            Muerto = false;
        }

        public bool Retirarse()
        {

            Console.WriteLine($"Accion Retirarse");
            Console.WriteLine($"----------------");
            Console.WriteLine($"Griego: {Nombre}");
            Console.WriteLine($"Edad: {Edad} Fuerza: {Fuerza}");

            if (Herido && !Muerto)
            {
                Console.WriteLine($"Esta herido ==> RETIRADA!!!");
                return true;
            }


            return false;
        }
        public bool ComprobarEdad(int edad)
        {
            if (edad >= 15 && edad <= 60)
            {
                return false;
            }
            return true;
        }
        public bool ComprobarFuerza(int fuerza)
        {
            if (fuerza >= 1 && fuerza <= 10)
            {
                return false;
            }
            return true;
        }
        public void MostrarDatos()
        {
            Console.WriteLine($"El Griego de Nombre: {Nombre} tiene {Edad} años y una fuerza de {Fuerza}");
        }
    }
    
}
