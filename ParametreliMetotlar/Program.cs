using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametreliMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kısa kenarı giriniz:");
            int kisaKenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun kenarı giriniz:");
            int uzunKenar = Convert.ToInt32(Console.ReadLine());

            CevreHesapla(kisaKenar, uzunKenar);
            int cevap = AlanHesapla(kisaKenar, uzunKenar);
            Console.WriteLine("Alanı:{0}", cevap);

            Console.ReadKey();
        }
       
        static void CevreHesapla(int kisaKenar, int uzunKenar)
        {
            int cevre = 2 * (kisaKenar + uzunKenar);
            Console.WriteLine("Çevresi:{0}", cevre);
        }

        static int AlanHesapla(int a, int b)
        {
            int alan = a * b;
            return alan;
        }
    }
}
