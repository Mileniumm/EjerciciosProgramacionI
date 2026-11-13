using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listas_Ejercicios
{
    internal class Program
    {
        static void Main()
        {
            /*
            Crea un programa que gestione una lista de tareas.El sistema debe permitir:
            Agregar una nueva tarea a la lista.
            Eliminar una tarea existente.
            Modificar una tarea existente.
            Eliminar todas las tareas de la lista.
            */

            //Ejercicio 4

            //Declarar variables
            List<string> tareas = new List<string>();
            string tarea;
            int contador = 0;
            /*
            List<string> tareas = new List<string>();: Se crea una lista llamada tareas que almacenará cadenas de texto (tareas).
            string tarea;: Se declara una variable tarea que se usará para almacenar temporalmente cada tarea ingresada por el usuario.
            int contador = 0;: Se inicializa un contador en 0, que se usará para controlar cuántas tareas se han ingresado.
            */

            //Ciclo de Ingresar Tareas

            while (contador < 5)
            {

                Console.WriteLine("Ingrese una tarea");
                tarea = Console.ReadLine();
                tareas.Add(tarea);
                contador++;
            }
            /*
            while (contador < 5): Este bucle se repetirá mientras el contador sea menor que 5, permitiendo al usuario ingresar hasta 5 tareas.
            Console.WriteLine("Ingrese una tarea");: Se solicita al usuario que ingrese una tarea.
            tarea = Console.ReadLine();: Se lee la entrada del usuario y se almacena en la variable tarea.
            tareas.Add(tarea);: Se agrega la tarea ingresada a la lista tareas.
            contador++;: Se incrementa el contador en 1.
            */

            //Mostrar Tareas Ingresadas

            foreach (string item in tareas)
            {
                Console.WriteLine(item);
            }

            //Este bloque de código recorre cada elemento en la lista tareas y lo imprime en la consola.

            //Modificar una Tarea
            Console.WriteLine("Cual desea modificar");
            string modificar = Console.ReadLine();
            Console.WriteLine("la posicion de " + modificar + " es" + tareas.IndexOf(modificar));
            Console.WriteLine("por cual desea cambiar");
            string nuevatarea = Console.ReadLine();
            int index = tareas.IndexOf(modificar);
            tareas[index] = tareas[index].Replace(modificar, nuevatarea);
            /*
            Console.WriteLine("Cual desea modificar");: Se pregunta al usuario qué tarea desea modificar.
            string modificar = Console.ReadLine();: Se lee la tarea que el usuario quiere modificar.
            tareas.IndexOf(modificar): Se obtiene la posición de la tarea en la lista y se imprime.
            string nuevatarea = Console.ReadLine();: Se solicita al usuario la nueva tarea que reemplazará a la anterior.
            int index = tareas.IndexOf(modificar);: Se obtiene el índice de la tarea a modificar.
            tareas[index] = tareas[index].Replace(modificar, nuevatarea);: Se reemplaza la tarea antigua por la nueva en la lista.
            */

            //Mostrar Tareas Modificadas
            foreach (string item in tareas)
            {
                Console.WriteLine(item);
            }
            //Se vuelve a imprimir la lista de tareas, mostrando la modificación realizada.

            tareas.Clear();

            //Le eliminan todas las tareas de la lista.
             
            foreach (string item in tareas)
            {
                Console.WriteLine(item);
            }
            //Se intenta imprimir la lista de tareas nuevamente, pero como se ha limpiado, no mostrará nada.
              
        }
    }
}