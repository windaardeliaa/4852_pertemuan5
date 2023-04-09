using System;
using tugas5;

namespace Pertemuan5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers method = new Numbers();
            method.CariNilaiMin(2, 8, 1);
            
            Console.WriteLine("--------------------------------------");
            method.CariNilaiMax(4, 5, 3);
           
            Console.ReadKey();
        }
    }
}