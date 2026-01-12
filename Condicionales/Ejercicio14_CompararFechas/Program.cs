namespace Ejercicio14_CompararFechas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 14 - Comparación de fechas
            // Objetivo:
            // Leer dos fechas en formato DDMMAAAA y determinar cuál de ellas
            // es la menor o si ambas son iguales, utilizando descomposición
            // matemática (sin usar librerías de fecha).
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 14:\n" +
                "Ingresar dos fechas en formato DDMMAAAA y determinar cuál es menor.\n"
            );

            // FECHA 1
            int fecha1 = 0;
            int dia1 = 0;
            int mes1 = 0;
            int anio1 = 0;

            // FECHA 2
            int fecha2 = 0;
            int dia2 = 0;
            int mes2 = 0;
            int anio2 = 0;

            // Lectura de datos
            Console.Write("Ingrese la primera fecha (DDMMAAAA): ");
            fecha1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda fecha (DDMMAAAA): ");
            fecha2 = int.Parse(Console.ReadLine());

            // Descomposición de la primera fecha
            dia1 = fecha1 / 1000000;
            mes1 = (fecha1 % 1000000) / 10000;
            anio1 = fecha1 % 10000;

            // Descomposición de la segunda fecha
            dia2 = fecha2 / 1000000;
            mes2 = (fecha2 % 1000000) / 10000;
            anio2 = fecha2 % 10000;

            // Comparación de fechas (año → mes → día)
            if (anio1 < anio2 ||
               (anio1 == anio2 && mes1 < mes2) ||
               (anio1 == anio2 && mes1 == mes2 && dia1 < dia2))
            {
                Console.WriteLine("La primera fecha es menor.");
            }
            else if (anio2 < anio1 ||
                    (anio2 == anio1 && mes2 < mes1) ||
                    (anio2 == anio1 && mes2 == mes1 && dia2 < dia1))
            {
                Console.WriteLine("La segunda fecha es menor.");
            }
            else
            {
                Console.WriteLine("Ambas fechas son iguales.");
            }

            Console.ReadKey();

        }
    }
}
