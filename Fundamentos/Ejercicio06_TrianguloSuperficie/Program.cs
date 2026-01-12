namespace Ejercicio06_TrianguloSuperficie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 6 - Superficie de un triángulo
            // Objetivo:
            // Calcular la superficie de un triángulo a partir de su base
            // y altura, ingresadas por el usuario.
            //
            // Fórmula utilizada:
            // Superficie = (base * altura) / 2
            //
            // Se utiliza el tipo 'float' ya que los valores pueden incluir
            // decimales (por ejemplo, 5.5 cm).
            // No se usan valores fijos en la fórmula, solo variables
            // y constantes, tal como indica la consigna.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 6:\n" +
                "Calcular la superficie de un triángulo a partir de su base y altura.\n"
            );

            // Declaración de variables
            float baseTriangulo = 0;
            float alturaTriangulo = 0;

            // Constante utilizada en la fórmula (división por 2)
            const int DIVISOR = 2;

            // Solicitud de datos al usuario
            Console.Write("Ingrese la base del triángulo: ");
            baseTriangulo = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura del triángulo: ");
            alturaTriangulo = float.Parse(Console.ReadLine());

            // Cálculo de la superficie
            float superficie = (baseTriangulo * alturaTriangulo) / DIVISOR;

            // Mostrar el resultado
            Console.WriteLine(
                $"\nLa superficie del triángulo es:\n" +
                $"({baseTriangulo} x {alturaTriangulo}) / {DIVISOR} = {superficie}"
            );

            Console.ReadKey();

        }
    }
}
