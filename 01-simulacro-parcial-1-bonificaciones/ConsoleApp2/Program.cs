using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el rendimiento del empleado (1 para Bueno, 2 para Regular, 3 para Malo):");
            string resultado = Console.ReadLine();
            if (resultado.All(char.IsDigit))
            {
                int rendimiento = int.Parse(resultado);
                Console.WriteLine("Ingrese salario del empleado:");
                int salario = int.Parse(Console.ReadLine());

                switch (rendimiento)
                {
                    case 1:
                        Console.WriteLine("Rendimeinto: bueno");
                        double bonificacion = salario * 0.1;
                        double salarioTotal = salario + bonificacion;
                        Console.WriteLine("Su bonificacion es:" + bonificacion);
                        Console.WriteLine("Su salario total es de:" + salarioTotal);
                        break;


                    case 2:
                        Console.WriteLine("Rendimeinto: bueno");
                        double bonificacion1 = salario * 0.05;
                        double salarioTotal1 = salario + bonificacion1;
                        Console.WriteLine("Su bonificacion es:" + bonificacion1);
                        Console.WriteLine("Su salario total es de:" + salarioTotal1);
                        break;

                    case 3:
                        Console.WriteLine("Rendeimiento: Malo");
                        Console.WriteLine("Usted no recibe bonificación");
                        Console.WriteLine("Su salario total es de:" + salario);
                        break;

                    default:
                        Console.WriteLine("Valor incorrecto ingrese un número del 1 al 3");
                        break;
                }
            }
            else 
            {
                Console.WriteLine("Usted ha ingresado una letra, por lo tanto no es valido");
            }

            Console.Read();
            
        }
    }
}
