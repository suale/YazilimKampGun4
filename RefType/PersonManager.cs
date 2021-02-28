using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefType
{
    class PersonManager
    {

        public void Add(Person person)
        {
            Console.WriteLine("{0} added.",person.FirstName);
        }

    }
}
