namespace Ejercicio16_OrdenAscendente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 16 - Orden ascendente
            // Objetivo:
            // Leer dos números enteros e informarlos en orden ascendente.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 16:\n" +
                "Ingresar dos números e informarlos en orden ascendente.\n"
            );

            int num1 = 0;
            int num2 = 0;

            // Lectura de datos
            Console.Write("Ingrese el primer número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            // Comparación y salida
            if (num1 < num2)
            {
                Console.WriteLine($"Orden ascendente: {num1}, {num2}");
            }
            else if (num2 < num1)
            {
                Console.WriteLine($"Orden ascendente: {num2}, {num1}");
            }
            else
            {
                Console.WriteLine($"Ambos números son iguales: {num1}, {num2}");
            }

            Console.ReadKey();

        }
    }
}
