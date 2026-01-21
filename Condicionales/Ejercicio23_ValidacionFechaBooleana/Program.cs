namespace Ejercicio23_ValidacionFechaBooleana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Ejercicio 23
            // Objetivo:
            // Ingresar una fecha en formato DDMMAAAA y determinar,
            // mediante una variable booleana, si el día y el mes
            // corresponden a una fecha válida.
            //
            // Se debe informar:
            // true  -> fecha válida
            // false -> fecha inválida
            //
            // Ejemplos:
            // 31122013 -> válida
            // 12312013 -> inválida (mes incorrecto)
            // 29022015 -> inválida (febrero sin año bisiesto)
            // ------------------------------------------------------------

            Console.WriteLine(
                "Ejercicio 23:\n" +
                "Validar una fecha en formato DDMMAAAA usando una variable booleana.\n"
            );

            // Declaración de variables
            int fecha;
            int dia, mes, anio;
            bool fechaValida = true;

            // Entrada de datos
            Console.Write("Ingrese la fecha (DDMMAAAA): ");
            fecha = int.Parse(Console.ReadLine());

            // Descomposición de la fecha
            dia = fecha / 1000000;
            mes = (fecha % 1000000) / 10000;
            anio = fecha % 10000;

            // Validación del mes
            if (mes < 1 || mes > 12)
            {
                fechaValida = false;
            }
            // Validación del día según el mes
            else
            {
                if (mes == 2) // Febrero
                {
                    bool esBisiesto = (anio % 400 == 0 || (anio % 4 == 0 && anio % 100 != 0));

                    if (esBisiesto)
                    {
                        if (dia < 1 || dia > 29)
                            fechaValida = false;
                    }
                    else
                    {
                        if (dia < 1 || dia > 28)
                            fechaValida = false;
                    }
                }
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dia < 1 || dia > 30)
                        fechaValida = false;
                }
                else
                {
                    if (dia < 1 || dia > 31)
                        fechaValida = false;
                }
            }

            // Resultado final
            Console.WriteLine(fechaValida);

            Console.ReadKey();

        }
    }
}
