using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimKampGun4
{
    class Metod
    {

        public static void Artir(int sayi, int sayi2)
        {
            _ = sayi + 1;
            _ = sayi2 + 1;
        }
        public static void Degistir(int[] dizi)
        {
            dizi[1] = 33;

        }
        public static void Azalt(List<int> liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                liste[i] = liste[i] - 5;
            }
        }

    }
}
