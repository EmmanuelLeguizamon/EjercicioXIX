using System;

namespace EjercicioXIX
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isString;

            do
            {
                Console.WriteLine("Ingrese un número decimal: ");
                string n = Console.ReadLine();
                isString = decimal.TryParse(n, out decimal m);

                if (isString == false)
                {
                    Console.WriteLine("Ingresaste un valor no válido. Intenta otra vez.");
                }
                else
                {
                    m = Math.Truncate(m);
                    Console.WriteLine("La parte entera del número decimal que ingresaste es: " + m);
                }

            } while (isString == false);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
