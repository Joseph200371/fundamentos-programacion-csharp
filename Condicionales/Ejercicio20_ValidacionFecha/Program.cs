namespace Ejercicio20_ValidacionFecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 20 - Validación de fecha
            // Objetivo:
            // Leer una fecha en formato DDMMAAAA y determinar si es válida.
            // En caso de error, informar la primera parte inconsistente.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 20:\n" +
                "Validación de una fecha ingresada en formato DDMMAAAA.\n"
            );

            int fecha;
            int dia, mes, anio;

            // Lectura de la fecha
            Console.Write("Ingrese la fecha (DDMMAAAA): ");
            fecha = int.Parse(Console.ReadLine());

            // Descomposición de la fecha
            dia = fecha / 1000000;
            mes = (fecha % 1000000) / 10000;
            anio = fecha % 10000;

            // Validación
            if (anio <= 0)
            {
                Console.WriteLine("Año inválido.");
            }
            else if (mes < 1 || mes > 12)
            {
                Console.WriteLine("Mes inválido.");
            }
            else if (dia < 1 || dia > 31)
            {
                Console.WriteLine("Día inválido.");
            }
            else
            {
                Console.WriteLine($"La fecha es válida: {dia}-{mes}-{anio}");
            }

            Console.ReadKey();

        }
    }
}
