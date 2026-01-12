namespace Ejercicio02_SumaCuatroNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 2 - Suma de cuatro números enteros
            // Objetivo:
            // Leer cuatro números enteros ingresados por el usuario,
            // calcular la suma total e informar el resultado.
            //
            // Tipo de dato recomendado:
            // Se utiliza 'int' ya que se trabajan números enteros.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 2:\n" +
                "Ingresar cuatro números enteros y calcular su suma.\n"
            );

            // Declaración de variables
            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;
            int numero4 = 0;

            // Solicitud de datos al usuario
            Console.Write("Ingrese el primer número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            numero3 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el cuarto número: ");
            numero4 = int.Parse(Console.ReadLine());

            // Cálculo de la suma
            int sumaTotal = numero1 + numero2 + numero3 + numero4;

            // Mostrar resultado
            Console.WriteLine($"\nEl resultado de la suma es: {sumaTotal}");

            Console.ReadKey();

        }
    }
}
