using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas5
{
    internal class Numbers
    {
        public void CariNilaiMin(int a, int b, int c)
        {
            Console.WriteLine("Tersedia angka sebagai berikut {0}, {1}, {2}", a, b, c);

            if (a <= b && a <= c)
            {
                
                Console.WriteLine("Nilai terkecil dari ketiga angka adalah: {0}", a);
            }
            else if (b <= a && b <= c)
            {
               
                Console.WriteLine("Nilai terkecil dari ketiga angka adalah: {0}", b);
            }
            else if (c <= a && c <= b)
            {
                
                Console.WriteLine("Nilai terkecil dari ketiga angka adalah: {0}", c);

            }
        }

        
        public int CariNilaiMax(int a, int b, int c)
        {
            Console.WriteLine("Tersedia angka sebagai berikut {0}, {1}, {2}", a, b, c);
           
            if (a >= b && a >= c)
            {
                
                Console.WriteLine("Nilai terbesar dari ketiga angka adalah : {0}", a);
            }
            else if (b >= a && b >= c)
            {
                
                Console.WriteLine("Nilai terbesar dari ketiga angka adalah: {0}", b);
            }
            else if (c >= a && c <= b)
            {
               
                Console.WriteLine("Nilai terbesar dari ketiga angka adalah: {0}", c);
            }
            return 0;
        }
    }
}
