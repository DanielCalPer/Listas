using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Listas_5
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-575QA94\\SQLEXPRESS;Initial Catalog=Hotel;Integrated Security=True");
            
            string query = $"SELECT * from HABITACIONES"; // consultamos lo que necesitamos en la BBDD
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection); // RELACION QUERY Y CONEXION
            SqlDataReader reader = command.ExecuteReader(); // Mientras lee en la base de datos, que meta esos valores en una lista. 
            
            List<Habitacion> habitaciones = new List<Habitacion>(); // Lista de Objetos/habitaciones con sus 2 atributos por objeto.

            while   (reader.Read())
            {
                Habitacion hab1 = new Habitacion(Convert.ToInt32(reader[0].ToString()), reader[1].ToString()); //IMPORTANTE, VARCHAR NO ES STRING, HAY QUE CONVERTIRLO
                habitaciones.Add(hab1);
            }

            connection.Close();

            foreach (Habitacion x in habitaciones)
            {
                Console.WriteLine(x.ID + " " + x.Estado); // MOSTRAMOS LOS ATRIBUTOS DE LA LISTA
            }

            Console.ReadLine();
        }
    }
}
