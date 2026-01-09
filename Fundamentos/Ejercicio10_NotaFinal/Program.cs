namespace Ejercicio10_NotaFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 10 - Cálculo de nota final
            // Objetivo:
            // Calcular la calificación final de un estudiante a partir de
            // tres evaluaciones con diferentes ponderaciones.
            //
            // Ponderaciones:
            // - Exámenes parciales: 30%
            // - Trabajos prácticos: 20%
            // - Examen integrador: 50%
            //
            // Las notas se ingresan en un rango de 0 a 10.
            // Se utiliza 'float' ya que el cálculo puede generar decimales.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 10:\n" +
                "Calcular la nota final de un estudiante a partir de tres\n" +
                "instancias de evaluación con ponderaciones definidas.\n"
            );

            // Declaración de variables
            float notaParcial = 0;
            float notaTrabajosPracticos = 0;
            float notaExamenIntegrador = 0;

            // Constantes para las ponderaciones
            const float PORC_PARCIAL = 0.30f;
            const float PORC_TRABAJOS = 0.20f;
            const float PORC_INTEGRADOR = 0.50f;

            // Solicitud de datos al usuario
            Console.Write("Ingrese la nota del examen parcial (0 a 10): ");
            notaParcial = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota de los trabajos prácticos (0 a 10): ");
            notaTrabajosPracticos = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del examen integrador (0 a 10): ");
            notaExamenIntegrador = float.Parse(Console.ReadLine());

            // Cálculo de la nota final
            float notaFinal =
                (notaParcial * PORC_PARCIAL) +
                (notaTrabajosPracticos * PORC_TRABAJOS) +
                (notaExamenIntegrador * PORC_INTEGRADOR);

            // Mostrar el resultado
            Console.WriteLine($"\nLa nota final del estudiante es: {notaFinal}");

        }
    }
}
