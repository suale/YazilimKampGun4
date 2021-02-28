using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Customer
    {
        public Customer()
        {

        }
        public Customer(string firstName,string lastName, string city)
        {
            Console.WriteLine("Customer created!");
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
