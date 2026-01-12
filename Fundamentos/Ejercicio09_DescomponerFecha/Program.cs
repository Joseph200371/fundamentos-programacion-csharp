namespace Ejercicio09_DescomponerFecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 9 - Descomposición de una fecha (DDMMAAAA)
            // Objetivo:
            // Leer una fecha ingresada como un número entero en formato
            // DDMMAAAA y obtener por separado el día, el mes y el año
            // utilizando únicamente descomposición matemática.
            //
            // Ejemplo:
            // Entrada: 23052024
            // Salida: 23 / 05 / 2024
            //
            // Se utiliza el tipo 'int' ya que la fecha se maneja como
            // un valor numérico sin operaciones de calendario.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 9:\n" +
                "Ingresar una fecha en formato DDMMAAAA y obtener el día,\n" +
                "el mes y el año por separado.\n"
            );

            // Declaración de variables
            int fechaNumerica = 0;
            int dia = 0;
            int mes = 0;
            int anio = 0;

            // Solicitud de datos al usuario
            Console.Write("Ingrese la fecha (DDMMAAAA): ");
            fechaNumerica = int.Parse(Console.ReadLine());

            // Descomposición matemática de la fecha
            dia = fechaNumerica / 1000000;
            mes = (fechaNumerica % 1000000) / 10000;
            anio = fechaNumerica % 10000;

            // Mostrar el resultado
            Console.WriteLine(
                $"\nLa fecha ingresada corresponde a:\n" +
                $"{dia:D2}/{mes:D2}/{anio}"
            );

            Console.ReadKey();

        }
    }
}
