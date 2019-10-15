using System;
using System.Collections.Generic;
using System.Text;

namespace Elena_de_Troya
{
    class Troyano
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Fuerza { get; set; }
        public bool Herido { get; set; }
        public bool Muerto { get; set; }

        
        public Troyano(string nombre, int edad, int fuerza)
        {

            Nombre = nombre;
           
            if (ComprobarEdad())
            {
                Edad = edad;
            }
            else
            {
                Edad = 25;
            }
            if (ComprobarFuerza())
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

        public Troyano()
        {
            Nombre = "TroyanoX";
            Edad = 18;
            Fuerza = 10; 
            Herido = false;
            Muerto = false;
        }

        public bool Retirarse()
        {
            
                Console.WriteLine($"Accion Retirarse");
                Console.WriteLine($"----------------");
                Console.WriteLine($"Troyano: {Nombre}");
                Console.WriteLine($"Edad: {Edad} Fuerza: {Fuerza}");

            if (Herido && !Muerto)
            {
                Console.WriteLine($"Esta herido ==> Pero los guerreros troyanos nunca se retiran");
            }
                
            
            return false; 
        }
        public bool ComprobarEdad()
        {
            if (Edad >=15 && Edad<= 60)
            {
                return true; 
            }
            return false; 
        }
        public bool ComprobarFuerza()
        {
            if (Fuerza >= 1 && Fuerza <= 10)
            {
                return true;
            }
            return false;
        }
       
    }
}
