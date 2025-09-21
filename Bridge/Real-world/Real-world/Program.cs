using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_world
{

    
        class Program
        {
            static void Main(string[] args)
            {
                // Create RefinedAbstraction
                var customers = new Customers();

                // Set ConcreteImplementor
                customers.Data = new CustomersData("Chicago");

                // Exercise the bridge
                customers.Show();
                customers.Next();
                customers.Show();
                customers.Next();
                customers.Show();

                customers.Add("Henry Velasquez");
                customers.ShowAll();

                Console.ReadKey();
            }
        }
    }

