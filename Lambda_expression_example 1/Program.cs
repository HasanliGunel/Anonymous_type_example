using System;
using System.Collections.Generic;
using System.Linq;
namespace Lambda_expression_example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>() {
            new Dog { Name = "Rex", Age = 4 },
            new Dog { Name = "Sean", Age = 0 },
            new Dog { Name = "Stacy", Age = 3 }
         };
            var names = dogs.Select(x => x.Name);
            foreach (var name in names)
            {
                Console.WriteLine(name);

            }
            //var ages = dogs.Select(x => x.Age);
            //foreach (var age in ages)
            //    Console.WriteLine(age);
            Console.Read();
        }
    }
}
