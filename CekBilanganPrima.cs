using System;

namespace CekBilanganPrima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Mengecek Bilangan Prima");

            // Input bilangan
            Console.Write("Masukkan bilangan: ");
            int bilangan = Convert.ToInt32(Console.ReadLine());

            // Panggil fungsi untuk mengecek bilangan prima
            bool isPrima = CekPrima(bilangan);

            // Output hasil
            if (isPrima)
            {
                Console.WriteLine($"{bilangan} adalah bilangan prima.");
            }
            else
            {
                Console.WriteLine($"{bilangan} bukan bilangan prima.");
            }
        }

        // Fungsi untuk mengecek bilangan prima
        static bool CekPrima(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
