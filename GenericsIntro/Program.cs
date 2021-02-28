using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<int> sayilar = new MyList<int>();



            sayilar.Add(0);
            sayilar.Add(7);
            sayilar.Add(8);
            sayilar.Add(9);
            sayilar.Add(10);
            sayilar.Add(11);


            Console.WriteLine(sayilar.Length);
            foreach (var item in sayilar.Itemler)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
