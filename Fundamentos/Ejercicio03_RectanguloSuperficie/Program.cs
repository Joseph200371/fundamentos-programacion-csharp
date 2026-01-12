namespace Ejercicio03_RectanguloSuperficie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 3 - Superficie de un rectángulo
            // Objetivo:
            // Calcular la superficie de un rectángulo a partir de los valores
            // de su base y altura.
            //
            // Tipo de dato recomendado:
            // Se utiliza 'int' ya que los valores ingresados son números
            // enteros y el resultado no requiere decimales.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 3:\n" +
                "Ingresar la base y la altura de un rectángulo y calcular\n" +
                "su superficie.\n"
            );

            // Declaración de variables
            int baseRectangulo = 0;
            int alturaRectangulo = 0;

            // Solicitud de datos al usuario
            Console.Write("Ingrese la base del rectángulo: ");
            baseRectangulo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura del rectángulo: ");
            alturaRectangulo = int.Parse(Console.ReadLine());

            // Cálculo de la superficie
            int superficie = baseRectangulo * alturaRectangulo;

            // Mostrar resultado
            Console.WriteLine(
                $"\nLa superficie del rectángulo es:\n" +
                $"{baseRectangulo} x {alturaRectangulo} = {superficie} cm²"
            );

            Console.ReadKey();

        }
    }
}
