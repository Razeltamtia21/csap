using System;

namespace PersegiPanjang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Menghitung Luas dan Keliling Persegi Panjang");

            // Input panjang
            Console.Write("Masukkan panjang: ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            // Input lebar
            Console.Write("Masukkan lebar: ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            // Hitung luas
            double luas = panjang * lebar;

            // Hitung keliling
            double keliling = 2 * (panjang + lebar);

            // Output hasil
            Console.WriteLine("\nLuas Persegi Panjang: " + luas);
            Console.WriteLine("Keliling Persegi Panjang: " + keliling);
        }
    }
}
