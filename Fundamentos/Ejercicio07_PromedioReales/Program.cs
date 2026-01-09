namespace Ejercicio07_PromedioReales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 7 - Promedio de números reales
            // Objetivo:
            // Leer seis números reales ingresados por el usuario y
            // calcular el promedio de los mismos.
            //
            // Se utiliza el tipo 'float' ya que los valores pueden
            // contener decimales.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 7:\n" +
                "Ingresar 6 números reales y calcular su promedio.\n"
            );

            // Declaración de variables
            float num1 = 0;
            float num2 = 0;
            float num3 = 0;
            float num4 = 0;
            float num5 = 0;
            float num6 = 0;

            // Solicitud de datos al usuario
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

            Console.Write("Ingrese el sexto número: ");
            num6 = float.Parse(Console.ReadLine());

            // Cálculo de la suma y el promedio
            float suma = num1 + num2 + num3 + num4 + num5 + num6;
            float promedio = suma / 6;

            // Mostrar resultados
            Console.WriteLine(
                $"\nLa suma total de los números es: {suma}" +
                $"\nEl promedio de los 6 números reales es: {promedio}"
            );

        }
    }
}
