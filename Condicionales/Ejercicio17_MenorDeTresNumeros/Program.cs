namespace Ejercicio17_MenorDeTresNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 17 - Menor de tres números
            // Objetivo:
            // Ingresar 3 números enteros e informar el menor de ellos.
            // Las comparaciones se realizan luego de leer todos los números.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 17:\n" +
                "Ingresar 3 números enteros e informar el menor de ellos.\n"
            );

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            // Lectura de datos
            Console.Write("Ingrese el primer número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            num3 = int.Parse(Console.ReadLine());

            // Determinar el menor
            int menor = num1;

            if (num2 < menor)
            {
                menor = num2;
            }

            if (num3 < menor)
            {
                menor = num3;
            }

            // Mostrar resultado
            Console.WriteLine($"El menor de los tres números es: {menor}");

            Console.ReadKey();

        }
    }
}
