namespace Ejercicio08_Porcentaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 8 - Cálculo de porcentaje
            // Objetivo:
            // Dados dos números enteros que representan una cantidad
            // parcial y una cantidad total, calcular el porcentaje que
            // representa la primera respecto de la segunda.
            //
            // Recomendación de tipos de datos:
            // - Se utilizan 'int' para las cantidades ingresadas.
            // - Se utiliza 'double' para el cálculo del porcentaje,
            //   ya que el resultado puede contener decimales.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 8:\n" +
                "Calcular el porcentaje que representa una cantidad parcial\n" +
                "respecto de una cantidad total.\n"
            );

            // Declaración de variables
            int cantidadParcial = 0;
            int cantidadTotal = 0;

            // Solicitud de datos al usuario
            Console.Write("Ingrese la cantidad parcial: ");
            cantidadParcial = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad total: ");
            cantidadTotal = int.Parse(Console.ReadLine());

            // Cálculo del porcentaje
            // Se realiza un casteo a double para evitar división entera
            double porcentaje = (double)cantidadParcial * 100 / cantidadTotal;

            // Mostrar el resultado
            Console.WriteLine(
                $"\nEl porcentaje que representa la cantidad parcial es:\n" +
                $"({cantidadParcial} x 100) / {cantidadTotal} = {porcentaje}%"
            );

            Console.ReadKey();

        }
    }
}
