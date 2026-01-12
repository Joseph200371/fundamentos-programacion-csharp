namespace Ejercicio13_DivisionConValidacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 13 - División con validación
            // Objetivo:
            // Ingresar dos números enteros y calcular el resultado de
            // la división entre ellos, validando que el divisor no sea cero.
            // En caso contrario, informar un mensaje de error.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 13:\n" +
                "Dividir dos números enteros validando que el divisor sea distinto de cero.\n"
            );

            // Declaración de variables
            int dividendo = 0;
            int divisor = 0;

            // Solicitud de datos al usuario
            Console.Write("Ingrese el dividendo: ");
            dividendo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el divisor: ");
            divisor = int.Parse(Console.ReadLine());

            // Validación y cálculo
            if (divisor != 0)
            {
                double resultado = (double)dividendo / divisor;
                Console.WriteLine($"El resultado de {dividendo} / {divisor} es: {resultado}");
            }
            else
            {
                Console.WriteLine("Error: no es posible dividir por cero.");
            }

            Console.ReadKey();

        }
    }
}
