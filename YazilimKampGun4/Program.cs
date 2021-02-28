using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimKampGun4
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi = 98;
            int sayi2;
            sayi2 = 99;
            Metod.Artir(sayi,sayi2);
           
            Console.WriteLine(sayi);
            Console.WriteLine(sayi2);

            int[] dizi = new int[] { 1, 2, 3, 4 };
            int[] dizi2 = new int[5];
            dizi[0] = 22;
            dizi2[2] = 1;
            
            foreach (var item in dizi2)
            {
                Console.WriteLine(item);
            }


            foreach (var x in dizi)
            {
                Console.WriteLine(x);
            }
            dizi = new int[4];
            Metod.Degistir(dizi);
            foreach (var x in dizi)
            {
                Console.WriteLine(x);
            }

            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };//jenerik yapı
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
                
            }
           
            
            Console.ReadLine();



        }
    }
}
