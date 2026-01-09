namespace Ejercicio05_TiempoASegundos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 5 - Conversión de tiempo a segundos
            // Objetivo:
            // Ingresar horas, minutos y segundos y expresar el tiempo total
            // únicamente en segundos.
            //
            // Tipo de dato recomendado:
            // Se utiliza 'int' porque se trabajan valores enteros y no se
            // requieren decimales en el cálculo.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 5:\n" +
                "Ingresar horas, minutos y segundos y convertir el tiempo\n" +
                "total a segundos.\n"
            );

            // Declaración de variables
            int horas = 0;
            int minutos = 0;
            int segundos = 0;

            // Solicitud de datos al usuario
            Console.Write("Ingrese la cantidad de horas: ");
            horas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de minutos: ");
            minutos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de segundos: ");
            segundos = int.Parse(Console.ReadLine());

            // Conversión a segundos
            int horasEnSegundos = horas * 3600;
            int minutosEnSegundos = minutos * 60;

            // Cálculo del total
            int totalSegundos = horasEnSegundos + minutosEnSegundos + segundos;

            // Mostrar resultados
            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Horas a segundos: {horasEnSegundos}s");
            Console.WriteLine($"Minutos a segundos: {minutosEnSegundos}s");
            Console.WriteLine($"Segundos: {segundos}s");
            Console.WriteLine($"Tiempo total en segundos: {totalSegundos}s");

        }
    }
}
