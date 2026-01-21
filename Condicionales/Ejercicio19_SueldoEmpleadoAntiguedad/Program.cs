namespace Ejercicio19_SueldoEmpleadoAntiguedad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 19 - Cálculo de sueldo según antigüedad
            // Objetivo:
            // Leer el nombre, apellido, sueldo básico y antigüedad de un
            // empleado. Si la antigüedad supera los 9 años, se adiciona un
            // 40% al sueldo básico.
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 19:\n" +
                "Cálculo de sueldo según antigüedad del empleado.\n"
            );

            string nombre = "";
            string apellido = "";
            int antiguedad = 0;
            double sueldoBasico = 0;

            const double PORCENTAJE_ADICIONAL = 0.40;

            // Lectura de datos
            Console.Write("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido del empleado: ");
            apellido = Console.ReadLine();

            Console.Write("Ingrese el sueldo básico: ");
            sueldoBasico = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la antigüedad del empleado (en años): ");
            antiguedad = int.Parse(Console.ReadLine());

            // Cálculo del sueldo final
            double sueldoFinal = sueldoBasico;

            if (antiguedad > 9)
            {
                sueldoFinal += sueldoBasico * PORCENTAJE_ADICIONAL;
            }

            // Mostrar resultado
            Console.WriteLine(
                $"\nEl sueldo a cobrar por {nombre} {apellido} es: ${sueldoFinal}"
            );

            Console.ReadKey();

        }
    }
}
