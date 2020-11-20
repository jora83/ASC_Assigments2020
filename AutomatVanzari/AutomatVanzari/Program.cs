using System;
namespace AutomatVanzari
{
    class Program
    {

        static void Main(string[] args)
        {

            while (true)
            {
                Automat();
            }
        }

        static void Automat()
        {
            int monede = 0, rest = 0, suma = 0;

            Console.WriteLine("Introduceti monede de 5 10 sau 25 de centi in aparat");

            while (suma < 20)
            {

                monede = int.Parse(Console.ReadLine());
                if (monede == 5 || monede == 10 || monede == 25)
                {
                    suma += monede;
                }
                else
                {
                    Console.WriteLine("Moneda introdusa nu este corecta");
                }
                Console.WriteLine($"Aveti {suma} centi in aparat");

            }


            Console.WriteLine("Produsul a fost servit");
            if (suma > 20)
            {
                rest = suma - 20;
            }
            Console.WriteLine($"rest: {rest} centi");
            Console.WriteLine(" ");

        }
    }
}