using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class MyList<Tip>
    {
         Tip[] dizi;

        public MyList()
        {
            dizi = new Tip[0];
        }


        public void Add(Tip eleman)
        {
            Tip[] gecici = dizi;
            dizi = new Tip[gecici.Length + 1];
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                dizi[i] = gecici[i];
            }
            dizi[dizi.Length - 1] = eleman;
        }

        public int Length
        {
            get { return dizi.Length; }
        }
        public Tip[] Itemler
        {
            get {return dizi ; }
        }

    }
}
