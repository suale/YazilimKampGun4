using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Samed", "Musabasoglu", "Ordu");
            Console.WriteLine(customer1.FirstName);

            Customer customer2 = new Customer();
            customer2.FirstName = "İsim";
            customer2.LastName = "Soyisim";
            customer2.City = "Şehir";
            Console.WriteLine(customer2.FirstName);

            Customer customer3 = new Customer { FirstName = "Müşteri", LastName="Velinimettir", City="İstanbul" };
            Console.WriteLine(customer3.FirstName);
            Console.ReadLine();
        }
    }
}
