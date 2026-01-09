namespace Ejercicio01_SumaDosNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 1 - Suma de dos números enteros
            // Objetivo:
            // Leer dos números enteros ingresados por el usuario,
            // calcular la suma total e informar el resultado.
            //
            // Tipo de dato recomendado:
            // Se utiliza 'int' ya que se trabajan números enteros.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 1:\n" +
                "Ingresar dos números enteros y calcular su suma.\n"
            );

            // Declaración de variables
            int numero1 = 0;
            int numero2 = 0;

            // Solicitud de datos al usuario
            Console.Write("Ingrese el primer número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            // Cálculo de la suma
            int sumaTotal = numero1 + numero2;

            // Mostrar resultado
            Console.WriteLine($"\nEl resultado de la suma es: {sumaTotal}");

        }
    }
}
