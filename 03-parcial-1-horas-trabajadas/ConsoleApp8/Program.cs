using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1 
{
    internal class Program
    {
        static void Main()
        {
            int horaSemana1, horaSemana2, horaSemana3;
            Console.WriteLine("Ingrese la cantidad de horas trabajadas  en la semana 1:");
            horaSemana1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de horas trabajadas  en la semana 2:");
            horaSemana2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de horas trabajadas  en la semana 3:");
            horaSemana3 = int.Parse(Console.ReadLine());
            int totalHoras = horaSemana1 + horaSemana2 + horaSemana3;
            Console.WriteLine("La suma total de las horas trabajadas es:" + totalHoras);

            if (horaSemana1 == 40)
            {
                Console.WriteLine("En la primera semana trabajó 40 hs semanales");
            }
            else
            {
                Console.WriteLine("En la primera semana no trabajó 40 hs");
            }
            int SemanaMasHoras = 1;
            int Maxhoras = horaSemana1;

            if (horaSemana2 > Maxhoras)
            {
            SemanaMasHoras = 2;
            Maxhoras = horaSemana2;
            }
            if (horaSemana3 > Maxhoras)
            {
            SemanaMasHoras = 3;
            Maxhoras = horaSemana3;
            }
            Console.WriteLine("La semana con mas horas trabajadas fue la semana "  + SemanaMasHoras + " con " + Maxhoras + " horas ");
            Console.Read();






        }
    }
}
