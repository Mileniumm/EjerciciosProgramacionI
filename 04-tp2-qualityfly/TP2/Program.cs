
//Importación de bibliotecas
//Se importan varias bibliotecas que permiten el uso de funcionalidades como entrada/salida, colecciones, y expresiones regulares.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TP_Programacion
{
    //Definición del espacio de nombres y clase
    //Se define un espacio de nombres TP_Programacion y una clase Program que contendrá el código principal.
    internal class Program
    {
        //Método Main
        //Se inicializan variables para controlar el flujo del programa, como si se debe cerrar el sistema y las opciones elegidas por el usuario.
        static void Main(string[] args)
        {
            bool cerrarSistema = false;
            int opcionElegida = 0;
            int abrirCerrar = 0;
            //se puede hacer un string.empty para verificar si el usuario esta registrado o con sesion iniciada, si no no dejar entrar a carrito

            //Mensaje de bienvenida y opciones
            //Se presenta un mensaje de bienvenida y se muestran las opciones disponibles para el usuario.
            Console.WriteLine("-----BIENVENIDO A QUALITYFLY----- \nA continuacion podra ver las opciones, elija la que desee realizar");
            Console.WriteLine("1) Ver vuelos disponibles \n2) Agregar al carrito \n3) Pagar pasajes \n4) Registrarse \n5) Iniciar sesión \n6) Cerrar sesión \n7) Salir del sistema");

            // Lectura de la opción elegida
            //Se lee la opción ingresada por el usuario y se convierte a un entero. 
            opcionElegida = int.Parse(Console.ReadLine());
            //Bucle principal
            //Se inicia un bucle que continuará hasta que cerrarSistema sea verdadero.
            while (cerrarSistema != true)
            {

                //Validación de la opción elegida
                if (opcionElegida >= 1 && opcionElegida <= 7)
                {
                    //Llamadas a métodos según la opción
                    //Dependiendo de la opción elegida, se llaman a diferentes métodos que realizan acciones específicas.
                    /*
                     Los métodos como MostrarVuelosDisponibles, Carrito, VueloElegido, PreciosPasajes, etc.,
                     son responsables de manejar las diferentes acciones que el usuario puede realizar,
                    */

                    MostrarVuelosDisponibles(opcionElegida);
                    Carrito(opcionElegida);
                    Desvio(opcionElegida);
                    Registrarse(opcionElegida);
                    IniciarSesion(opcionElegida);
                    CerrarSesion(opcionElegida);

                    //Cierre del programa
                    if (opcionElegida == 7)
                    {
                        Console.WriteLine("Adiós esperamos su regreso");
                        break;
                    }
                }
                //Manejo de opciones no válidas
                else
                {
                    Console.WriteLine("Opcion no valida");
                }

                Console.WriteLine("Desea ver el menu nuevamente? \n1(SI)  2(NO)");
                abrirCerrar = int.Parse(Console.ReadLine());
                if (abrirCerrar >= 2 || abrirCerrar <= 0)
                {
                    Console.WriteLine("Adiós esperamos su regreso");
                    break;
                }

                Console.WriteLine("1) Ver vuelos disponibles \n2) Agregar al carrito \n3) Pagar pasajes \n4) Registrarse \n5) Iniciar sesión \n6) Cerrar sesión \n7) Salir del sistema");
                opcionElegida = int.Parse(Console.ReadLine());
            }




            Console.ReadKey();

        }

        static void MostrarVuelosDisponibles(int a)
        {

            if (a == 1)
            {

                Console.WriteLine("| Nro Vuelo | Origen      | Destino               | Hora de Salida | Hora de Llegada | Precio (en pesos) |");
                Console.WriteLine("|-----------|-------------|-----------------------|----------------|-----------------|-------------------|");
                Console.WriteLine("| 1         | Córdoba     | Buenos Aires (Ezeiza) | 21:50          | 23:10           | 43.700,00         |");
                Console.WriteLine("| 2         | Buenos Aires (Ezeiza) | Córdoba     | 19:50          | 21:10           | 43.700,00         |");
                Console.WriteLine("| 3         | Córdoba     | Mendoza               | 16:45          | 17:55           | 52.000,00         |");
                Console.WriteLine("| 4         | Mendoza     | Córdoba               | 21:50          | 23:10           | 52.000,00         |");
                Console.WriteLine("| 5         | Córdoba     | Bariloche             | 21:50          | 07:35           | 183.000,00        |");
                Console.WriteLine("| 6         | Bariloche   | Córdoba               | 13:00          | 15:00           | 183.000,00        |");

            }

        }


        static void Carrito(int b)
        { 
            int nroVuelo = 0, pasajes = 0, salirQuedarse = 0;
            bool vueloCorrecto = false, pasajesCorrecto = false, fechaCorrecta = false;
            string fechaVuelo;

            if (b == 2)
            {
                while (salirQuedarse != 2)
                {
                    Console.WriteLine("Ingrese el numero de vuelo");
                    nroVuelo = int.Parse(Console.ReadLine());
                    while (vueloCorrecto != true)
                    {
                        if (nroVuelo > 0 && nroVuelo <= 6)
                        {
                            VueloElegido(nroVuelo);
                            break;
                        }
                        Console.WriteLine("Ingrese un vuelo valido");
                        nroVuelo = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Cuantos pasajes desea comprar?");
                    pasajes = int.Parse(Console.ReadLine());
                    while (pasajesCorrecto != true)
                    {
                        if (pasajes > 0 && pasajes <= 10)
                        {
                            break;
                        }
                        Console.WriteLine("Ingrese una cantidad permitida");
                        pasajes = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("En que fecha desea realizar el viaje? (Ingrese la fecha en formato dd/mm/aaaa)");
                    fechaVuelo = Console.ReadLine();
                    DateTime fecha = DateTime.Now;
                    while (fechaCorrecta != true)
                    {
                        if (DateTime.TryParse(fechaVuelo, out fecha))
                        {


                            if (fecha < DateTime.Now)
                            {
                                Console.WriteLine("No puede ingresar una fecha anterior a esta, por favor intente nuevamente");
                                fechaVuelo = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Fecha disponible confirmada");
                                break;

                            }


                        }
                        else
                        {
                            Console.WriteLine("no ingreso correctamente, intente nuevamente");
                            fechaVuelo = Console.ReadLine();
                        }


                    }



                    Console.WriteLine("Desea abonar lo seleccionado o se arrepiente de su selección?\n1(PAGAR)   2(CANCELAR)");
                    salirQuedarse = int.Parse(Console.ReadLine());
                    if (salirQuedarse == 1)
                    {
                        Console.WriteLine("Usted está por abonar el total por " + pasajes + " pasajes");
                        PreciosPasajes(nroVuelo, pasajes);
                        break;
                    }





                }
            }




        }

        static void VueloElegido(int eleccion)
        {
            switch (eleccion)
            {
                case 1:
                    Console.WriteLine("Usted seleccionó el vuelo:\n| Nro Vuelo | Origen      | Destino               | Hora de Salida | Hora de Llegada | Precio (en pesos) | \n| 1         | Córdoba     | Buenos Aires (Ezeiza) | 21:50          | 23:10           | 43.700,00         |");
                    break;
                case 2:
                    Console.WriteLine("Usted seleccionó el vuelo:\n| Nro Vuelo | Origen      | Destino               | Hora de Salida | Hora de Llegada | Precio (en pesos) | \n| 2         | Buenos Aires (Ezeiza) | Córdoba     | 19:50          | 21:10           | 43.700,00         |");
                    break;
                case 3:
                    Console.WriteLine("Usted seleccionó el vuelo:\n| Nro Vuelo | Origen      | Destino               | Hora de Salida | Hora de Llegada | Precio (en pesos) | \n| 3         | Córdoba     | Mendoza               | 16:45          | 17:55           | 52.000,00         |");
                    break;
                case 4:
                    Console.WriteLine("Usted seleccionó el vuelo:\n| Nro Vuelo | Origen      | Destino               | Hora de Salida | Hora de Llegada | Precio (en pesos) | \n| 4         | Mendoza     | Córdoba               | 21:50          | 23:10           | 52.000,00         |");
                    break;
                case 5:
                    Console.WriteLine("Usted seleccionó el vuelo:\n| Nro Vuelo | Origen      | Destino               | Hora de Salida | Hora de Llegada | Precio (en pesos) | \n| 5         | Córdoba     | Bariloche             | 21:50          | 07:35           | 183.000,00        |");
                    break;
                case 6:
                    Console.WriteLine("Usted seleccionó el vuelo:\n| Nro Vuelo | Origen      | Destino               | Hora de Salida | Hora de Llegada | Precio (en pesos) | \n| 6         | Bariloche   | Córdoba               | 13:00          | 15:00           | 183.000,00        |");
                    break;
                default:
                    Console.WriteLine("Error al seleccionar");
                    break;
            }
        }

        static double AgregarIVA(double monto)
        {


            return monto * 1.105;
        }

        static void PreciosPasajes(int numeroVuelo, int cantidadPasaje)
        {

            int precio = 0;
            switch (numeroVuelo)
            {

                case 1:
                    precio = 43700 * cantidadPasaje;
                    Console.WriteLine("El total de su compra +IVA es $" + ((double)AgregarIVA(precio)));
                    break;
                case 2:
                    precio = 43700 * cantidadPasaje;
                    Console.WriteLine("El total de su compra +IVA es $" + ((double)AgregarIVA(precio)));

                    break;
                case 3:
                    precio = 52000 * cantidadPasaje;
                    Console.WriteLine("El total de su compra +IVA es $" + ((double)AgregarIVA(precio)));

                    break;
                case 4:
                    precio = 52000 * cantidadPasaje;
                    Console.WriteLine("El total de su compra +IVA es $" + ((double)AgregarIVA(precio)));

                    break;
                case 5:
                    precio = 183000 * cantidadPasaje;
                    Console.WriteLine("El total de su compra +IVA es $" + ((double)AgregarIVA(precio)));

                    break;
                case 6:
                    precio = 183000 * cantidadPasaje;
                    Console.WriteLine("El total de su compra +IVA es $" + ((double)AgregarIVA(precio)));
                    break;
                default:
                    Console.WriteLine("no valido");
                    break;

            }


        }

        static void Desvio(int c)
        {
            if (c == 3)
            {
                Console.WriteLine("Usted tiene el carrito vacio!\nSeleccione la opcion 2 para elegir su vuelo y pasajes\nLuego procedera a abonar");
            }
        }
        static string nombreUsuario;
        static string contraseña;
        static void Registrarse(int d)
        {
            string nombreCompleto, telefono, documento, correoElectronico; ;
            bool verificar = false;
            if (d == 4)
            {
                Console.WriteLine("Está a punto de registrarse, a continuacion le pediremos una serie de datos a completar\n");
                Console.WriteLine("Ingrese su Nombre y Apellido");
                nombreCompleto = Console.ReadLine();
                Console.WriteLine("Ingrese su número de teléfono");
                telefono = Console.ReadLine();
                Console.WriteLine("Ingrese su DNI");
                documento = Console.ReadLine();
                Console.WriteLine("Ingrese su correo electronico");
                correoElectronico = Console.ReadLine();
                while (verificar == false)
                {
                    if (correoElectronico.Contains("@") && correoElectronico.Contains("."))
                    {

                        break;
                    }
                    else
                        Console.WriteLine("Su correo debe contener un al menos un @ y un punto\nTrate nuevamente");

                    correoElectronico = Console.ReadLine();

                }
                Console.WriteLine("Ingrese su nombre de usuario");
                nombreUsuario = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña");
                contraseña = Console.ReadLine();

            }
        }

        static void IniciarSesion(int e)
        {
            string nombreDeUsuario, contraseñaUsuario;
            int contador = 0, intentos = 4;
            bool usuarioCorrecto = false, contraseñaCorrecta = false;

            if (e == 5)
            {
                Console.WriteLine("---INICIO DE SESION---\nIngrese su nombre de usuario:");
                nombreDeUsuario = Console.ReadLine();
                while (contador < 3 && usuarioCorrecto != true)
                {
                    contador++;
                    intentos--;
                    if (nombreDeUsuario == nombreUsuario)
                    {
                        Console.WriteLine("Usuario valido");
                        usuarioCorrecto = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Usuario invalido, pruebe nuevamente tiene " + intentos + " intentos");

                    }

                    nombreDeUsuario = Console.ReadLine();

                }
                intentos = 4;
                contador = 0;
                if (usuarioCorrecto == true)
                {
                    Console.WriteLine("Ingrese su contraseña:");
                    contraseñaUsuario = Console.ReadLine();
                    while (contador < 3 && contraseñaCorrecta != true)
                    {
                        contador++;
                        intentos--;
                        if (contraseñaUsuario == contraseña)
                        {
                            Console.WriteLine("Constraseña correcta\n\nBIENVENIDO " + nombreDeUsuario + "!");
                            contraseñaCorrecta = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Contraseña invalida, pruebe nuevamente, tiene " + intentos + " intentos");

                        }
                        contraseñaUsuario = Console.ReadLine();
                    }
                    if (contraseña != contraseñaUsuario)
                    {
                        Console.WriteLine("Alcanzo el limite de intentos, salga y vuelva a ingresar");

                    }
                }
                else
                    Console.WriteLine("Alcanzo el limite de intentos, salga y vuelva a ingresar");






            }
        }

        static void CerrarSesion(int f)
        {
            if (f == 6)
            {
                nombreUsuario = string.Empty;
                contraseña = string.Empty;
                Console.WriteLine("Sesion cerrada exitosamente!");

            }

        }
    }


}
