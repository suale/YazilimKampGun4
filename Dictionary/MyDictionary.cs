using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDictionary<Anahtar, Deger>
    {
        Anahtar[] anahtar;
        Deger[] deger;

        public MyDictionary()
        {
            anahtar = new Anahtar[0];
            deger = new Deger[0];
        }

        public void Add(Anahtar anahtarGelen, Deger degerGelen)
        {
            bool varMi = false;

            for (int i = 0; i < anahtar.Length; i++)
            {
                if (!EqualityComparer<Anahtar>.Default.Equals(anahtar[i], anahtarGelen))
                {
                    varMi = true;
                }
            }

            if (varMi == false)
            {
                Anahtar[] anahtarGecici = anahtar;
                Deger[] degerGecici = deger;

                anahtar = new Anahtar[anahtar.Length + 1];
                deger = new Deger[deger.Length + 1];

                for (int i = 0; i < anahtar.Length - 1; i++)
                {
                    anahtar[i] = anahtarGecici[i];
                }

                for (int i = 0; i < deger.Length - 1; i++)
                {
                    deger[i] = degerGecici[i];
                }

                anahtar[anahtar.Length - 1] = anahtarGelen;
                deger[deger.Length - 1] = degerGelen;


            }
            else
            {
                Console.WriteLine("Bu anahtar mevcut");
            }


        }

        public void Dict(Anahtar gelenAnahtar)
        {
            for (int i = 0; i < anahtar.Length; i++)
            {
                if (EqualityComparer<Anahtar>.Default.Equals(anahtar[i], gelenAnahtar))
                {
                    Console.WriteLine(deger[i]);
                }
                else
                {
                    Console.WriteLine("Bu anahtara sahip değer yok");
                }
            }
        }
    

    }
}
