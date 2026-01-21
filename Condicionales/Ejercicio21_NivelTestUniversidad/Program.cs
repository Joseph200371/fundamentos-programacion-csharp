namespace Ejercicio21_NivelTestUniversidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 21
            // Objetivo:
            // A partir de la cantidad total de preguntas y la cantidad de
            // respuestas correctas, calcular el porcentaje obtenido y
            // mostrar el nivel alcanzado según el criterio dado.
            //
            // Niveles:
            // Nivel 1 -> Porcentaje >= 89
            // Nivel 2 -> 75 <= Porcentaje < 89
            // Nivel 3 -> 50 <= Porcentaje < 70
            // Nivel 4 -> Porcentaje < 50
            //
            // Error del algoritmo original:
            // Se utilizaban operadores lógicos incorrectos (OR ||),
            // lo que generaba rangos superpuestos.
            // La solución correcta utiliza AND (&&).
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 21:\n" +
                "Calcular el nivel obtenido según el porcentaje de respuestas correctas.\n"
            );

            // Declaración de variables
            int porcentaje;

            // Entrada de datos
            Console.Write("Ingrese el porcentaje de respuestas correctas: ");
            porcentaje = int.Parse(Console.ReadLine());

            // Evaluación del nivel
            if (porcentaje >= 89)
            {
                Console.WriteLine($"Nivel 1 - Porcentaje: {porcentaje}%");
            }
            else if (porcentaje >= 75 && porcentaje < 89)
            {
                Console.WriteLine($"Nivel 2 - Porcentaje: {porcentaje}%");
            }
            else if (porcentaje >= 50 && porcentaje < 75)
            {
                Console.WriteLine($"Nivel 3 - Porcentaje: {porcentaje}%");
            }
            else
            {
                Console.WriteLine($"Nivel 4 - Porcentaje: {porcentaje}%");
            }

            Console.ReadKey();


        }
    }
}
