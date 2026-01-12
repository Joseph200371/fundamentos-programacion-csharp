namespace Ejercicio12_PromedioYEstadoAlumno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 12 - Promedio y estado de aprobación de un alumno
            // Objetivo:
            // Leer cuatro notas obtenidas por un alumno, calcular el
            // promedio e informar si el alumno está aprobado o no.
            //
            // La condición de aprobación se define mediante una constante
            // que no puede modificarse durante la ejecución del programa.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 12:\n" +
                "Calcular el promedio de cuatro notas e informar si el\n" +
                "alumno está aprobado.\n"
            );

            // Declaración de constantes
            const float NOTA_MINIMA_APROBACION = 6.0f;

            // Declaración de variables
            float nota1 = 0;
            float nota2 = 0;
            float nota3 = 0;
            float nota4 = 0;

            // Solicitud de datos al usuario
            Console.Write("Ingrese la primera nota del alumno: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda nota del alumno: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la tercera nota del alumno: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la cuarta nota del alumno: ");
            nota4 = float.Parse(Console.ReadLine());

            // Cálculo del promedio
            float promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            // Evaluación del estado del alumno
            if (promedio >= NOTA_MINIMA_APROBACION)
            {
                Console.WriteLine($"El alumno está APROBADO con un promedio de {promedio}");
            }
            else
            {
                Console.WriteLine($"El alumno está DESAPROBADO. Promedio obtenido: {promedio}");
            }

            Console.ReadKey();

        }
    }
}
