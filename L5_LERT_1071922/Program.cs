using System;

namespace L5_LERT_1071922
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEntero;

            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Ingrese un numero entero");

            numeroEntero = Convert.ToInt32(Console.ReadLine());

            if (numeroEntero > 0)
            {
                Console.WriteLine("Resultado : positivo");
            }
            else if (numeroEntero < 0)
            {
                Console.WriteLine("Resultado : negativo");
            }
            else if (numeroEntero == 0)
            {
                Console.WriteLine("Resultado : el valor ingresado es cero");

            }
            Console.ReadKey();

        }
    }
}
