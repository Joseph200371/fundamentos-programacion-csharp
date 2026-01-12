namespace Ejercicio18_MenorDeCincoReales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 18 - Menor de cinco números reales
            // Objetivo:
            // Ingresar 5 números reales e informar el menor de ellos.
            // Las comparaciones se realizan luego de leer todos los números.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 18:\n" +
                "Ingresar 5 números reales e informar el menor de ellos.\n"
            );

            float num1 = 0;
            float num2 = 0;
            float num3 = 0;
            float num4 = 0;
            float num5 = 0;

            // Lectura de datos
            Console.Write("Ingrese el primer número: ");
            num1 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            num2 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            num3 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el cuarto número: ");
            num4 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el quinto número: ");
            num5 = float.Parse(Console.ReadLine());

            // Determinar el menor
            float menor = num1;

            if (num2 < menor)
            {
                menor = num2;
            }

            if (num3 < menor)
            {
                menor = num3;
            }

            if (num4 < menor)
            {
                menor = num4;
            }

            if (num5 < menor)
            {
                menor = num5;
            }

            // Mostrar resultado
            Console.WriteLine($"\nEl menor de los cinco números es: {menor}");

            Console.ReadKey();

        }
    }
}
