# TP4: gestión de ocupación y estadísticas de vuelos

Trabajo final de Programación I, en grupo.

Aplicación de consola en C# para gestionar la ocupación de los vuelos de una aerolínea y calcular estadísticas.

## Características

La aplicación ofrece las siguientes funcionalidades:

- **Agregar un vuelo:** Permite al usuario agregar un vuelo especificando el código de vuelo, fecha y hora de salida, fecha y hora de llegada, nombres del piloto y copiloto, y capacidad máxima de pasajeros.
  
- **Registrar pasajeros en un vuelo:** Permite registrar el número de pasajeros que han abordado un vuelo específico, verificando que no se exceda la capacidad máxima.

- **Calcular ocupación media de la flota:** Calcula el porcentaje promedio de ocupación de todos los vuelos registrados.

- **Mostrar vuelo con mayor ocupación:** Muestra el vuelo con el mayor porcentaje de ocupación registrado.

- **Buscar vuelo por código:** Permite ingresar un código de vuelo específico y muestra sus detalles junto con el porcentaje de ocupación.

- **Listar vuelos:** muestra todos los vuelos con su porcentaje de ocupación. Ordenarlos de mayor a menor quedó pendiente.

- **Guardar y recuperar datos (pendiente):** la idea era guardar los datos de la aerolínea en un archivo XML. Los métodos `GuardarDatos` y `CargarDatos` están declarados pero quedaron sin implementar, así que por ahora los datos se pierden al cerrar el programa.

## Estructura del Proyecto

- **Clase Vuelo:** Contiene la información de cada vuelo, como el código, fechas, capacidad y pasajeros actuales. Incluye métodos para calcular el porcentaje de ocupación.

- **Clase Aerolinea:** Almacena la lista de vuelos y la información de contacto de la aerolínea. Incluye métodos para manejar los vuelos y calcular estadísticas.

- **Clase Menu:** muestra las opciones y llama a los métodos de `Aerolinea`.

- **Program.cs:** crea la aerolínea y arranca el menú.

## Integrantes del Proyecto

- Aguilera Nahuel
- Monelli Alexander
- Previgliano Milena
- Vigna Ruffino Gino

