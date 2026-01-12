namespace Ejercicio04_CuadradoSuperficie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 4 - Superficie de un cuadrado
            // Objetivo:
            // Calcular la superficie de un cuadrado a partir del valor
            // de su lado, el cual puede contener decimales.
            //
            // Tipo de dato recomendado:
            // Se utiliza 'float' porque el valor del lado puede ser decimal
            // y el resultado de la superficie también puede serlo.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 4:\n" +
                "Ingresar el lado de un cuadrado y calcular su superficie.\n"
            );

            // Declaración de variables
            float lado = 0;

            // Solicitud de datos al usuario
            Console.Write("Ingrese el valor del lado del cuadrado: ");
            lado = float.Parse(Console.ReadLine());

            // Cálculo de la superficie
            float superficie = lado * lado;

            // Mostrar resultado
            Console.WriteLine(
                $"\nLa superficie del cuadrado es:\n" +
                $"{lado} x {lado} = {superficie} cm²"
            );

            Console.ReadKey();

        }
    }
}
