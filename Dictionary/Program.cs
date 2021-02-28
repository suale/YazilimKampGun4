using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Samed");
            dictionary.Add(22, "Veli");
            dictionary.Add(15, "Ali");
            
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(dictionary[15]);

            MyDictionary<int, string> benimDictionary = new MyDictionary<int, string>();

            benimDictionary.Add(33, "Ayşe");

            benimDictionary.Dict(33);
            benimDictionary.Dict(44);

            



            Console.ReadLine();
        }
    }
}
