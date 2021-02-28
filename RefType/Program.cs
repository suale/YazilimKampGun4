using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefType
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person { FirstName = "Samed", LastName = "Muasabasoglu", Id = 1 };
            Employee employee1 = new Employee { FirstName = "Ali", LastName = "Soyad", EmployeeId = 165, Id = 2 };
            Person person2 = employee1;

            Console.WriteLine(person2.FirstName);
            Console.WriteLine(employee1.FirstName);
            Console.WriteLine(employee1.EmployeeId);

            Console.WriteLine(((Employee)person2).EmployeeId);//boxing

            PersonManager personManager = new PersonManager();

            personManager.Add(employee1);


            Console.ReadLine();



        }
    }
}
