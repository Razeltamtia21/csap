using System;

namespace KonversiSuhu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Konversi Suhu dari Celcius ke Fahrenheit dan Kelvin");

            // Input suhu dalam Celcius
            Console.Write("Masukkan suhu dalam Celcius: ");
            double celcius = Convert.ToDouble(Console.ReadLine());

            // Konversi ke Fahrenheit dan Kelvin
            double fahrenheit = (celcius * 9 / 5) + 32;
            double kelvin = celcius + 273.15;

            // Output hasil
            Console.WriteLine($"\nSuhu dalam Fahrenheit: {fahrenheit} °F");
            Console.WriteLine($"Suhu dalam Kelvin: {kelvin} K");
        }
    }
}
