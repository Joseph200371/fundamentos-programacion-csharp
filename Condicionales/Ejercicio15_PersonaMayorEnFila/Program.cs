namespace Ejercicio15_PersonaMayorEnFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 15 - Prioridad en fila de banco
            // Objetivo:
            // Dados los datos de nacimiento de dos personas (día, mes y año),
            // determinar cuál es la persona mayor y asignarle el primer lugar
            // en la fila del banco.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 15:\n" +
                "Determinar cuál de las dos personas es mayor según su fecha de nacimiento.\n"
            );

            // FECHA PERSONA 1
            int fecha1 = 0;
            int dia1 = 0;
            int mes1 = 0;
            int anio1 = 0;

            // FECHA PERSONA 2
            int fecha2 = 0;
            int dia2 = 0;
            int mes2 = 0;
            int anio2 = 0;

            // Lectura de datos
            Console.Write("Ingrese la fecha de nacimiento de la primera persona (DDMMAAAA): ");
            fecha1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la fecha de nacimiento de la segunda persona (DDMMAAAA): ");
            fecha2 = int.Parse(Console.ReadLine());

            // Descomposición de fechas
            dia1 = fecha1 / 1000000;
            mes1 = (fecha1 % 1000000) / 10000;
            anio1 = fecha1 % 10000;

            dia2 = fecha2 / 1000000;
            mes2 = (fecha2 % 1000000) / 10000;
            anio2 = fecha2 % 10000;

            // Comparación de fechas (año → mes → día)
            if (anio1 < anio2 ||
               (anio1 == anio2 && mes1 < mes2) ||
               (anio1 == anio2 && mes1 == mes2 && dia1 < dia2))
            {
                Console.WriteLine("La segunda persona es mayor.");
            }
            else if (anio2 < anio1 ||
                    (anio2 == anio1 && mes2 < mes1) ||
                    (anio2 == anio1 && mes2 == mes1 && dia2 < dia1))
            {
                Console.WriteLine("La primera persona es mayor.");
            }
            else
            {
                Console.WriteLine("Ambas personas tienen la misma fecha de nacimiento.");
            }

            Console.ReadKey();

        }
    }
}
