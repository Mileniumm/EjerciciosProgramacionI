using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial2
{
    internal class Program
    {
        static void Main()
        {
            int tarifaBase = 50;
            int costoKm = 10;
            int cargoExtra = 20;
         

            Console.WriteLine("Por favor, ingresa la distancia del viaje en kilómetros:");
            double distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la duración del viaje en minutos");
            int tiempo = int.Parse(Console.ReadLine());
            double costoViaje = tarifaBase + (distancia * costoKm);
            if (tiempo > 30)
            {
                costoViaje += cargoExtra;
            }
            Console.WriteLine("El costo total del viaje es:" + costoViaje);
            Console.Read();

        }
    }
}
