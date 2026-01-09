namespace Ejercicio11_SalarioVendedor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 11 - Cálculo del salario de un vendedor
            // Objetivo:
            // Calcular el salario total de un vendedor de una concesionaria
            // de autos a partir de:
            // - Un salario fijo mensual
            // - Una comisión fija por cada auto vendido
            // - Un adicional porcentual sobre el valor del auto vendido
            //
            // Datos conocidos:
            // - Salario fijo: $5500
            // - Comisión por auto vendido: $200
            // - Adicional: 5%
            //
            // Se conoce únicamente:
            // - Cantidad de autos vendidos
            // - Valor de venta de cada auto
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 11:\n" +
                "Calcular el salario total de un vendedor según autos vendidos\n" +
                "y valor de venta de cada unidad.\n"
            );

            // Declaración de constantes
            const float SALARIO_BASE = 5500f;
            const float COMISION_POR_AUTO = 200f;
            const float PORC_ADICIONAL = 0.05f;

            // Declaración de variables
            int cantidadAutosVendidos = 0;
            float valorAuto = 0;

            // Solicitud de datos al usuario
            Console.Write("Ingrese la cantidad de autos vendidos: ");
            cantidadAutosVendidos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de venta de cada auto: ");
            valorAuto = float.Parse(Console.ReadLine());

            // Cálculos
            float comisionTotal = cantidadAutosVendidos * COMISION_POR_AUTO;
            float adicionalPorVentas = cantidadAutosVendidos * valorAuto * PORC_ADICIONAL;

            float salarioTotal = SALARIO_BASE + comisionTotal + adicionalPorVentas;

            // Mostrar resultado
            Console.WriteLine($"\nEl salario total del vendedor es: ${salarioTotal}");

        }
    }
}
