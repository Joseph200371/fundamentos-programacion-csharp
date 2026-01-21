namespace Ejercicio22_AnioBisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 22
            // Objetivo:
            // Ingresar un año y determinar si es bisiesto.
            //
            // Regla:
            // Un año es bisiesto si:
            // - Es divisible por 400, O
            // - Es divisible por 4 y NO es divisible por 100
            // | Año  | Resultado        | Motivo                             
            // | ---- | ---------------- | ------------------------------------- 
            // | 2024 | ✔️ Bisiesto      | divisible por 4 y no por 100          
            // | 1900 | ❌ No bisiesto   | divisible por 100 pero no por 400     
            // | 2000 | ✔️ Bisiesto      | divisible por 400
            // | 2023 | ❌ No bisiesto  | no divisible por 4
            // ----------------------------------------------------------------- 

            Console.WriteLine(
                "Ejercicio 22:\n" +
                "Determinar si un año es bisiesto.\n"
            );

            // Declaración de variable
            int anio;

            // Entrada de datos
            Console.Write("Ingrese el año: ");
            anio = int.Parse(Console.ReadLine());

            // Evaluación de año bisiesto
            if (anio % 400 == 0 || (anio % 4 == 0 && anio % 100 != 0))
            {
                Console.WriteLine($"El año {anio} es bisiesto");
            }
            else
            {
                Console.WriteLine($"El año {anio} no es bisiesto");
            }

            Console.ReadKey();

        }
    }
}
