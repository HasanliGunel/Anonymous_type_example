using System;

namespace Anonymous_type_example
{
    class Program
    {
        static void Main(string[] args)
        {
            //var student = new { Id = 1, FirstName = "James", LastName = "Bond" };

            var student = new
            {
                Id = 1,
                FirstName = "James",
                LastName = "Bond",
                Address = new { Id = 1, City = "London", Country = "UK" }
            };

            Console.WriteLine(student.Id); 
            Console.WriteLine(student.FirstName); 
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.Address);
            Console.WriteLine(student.Address.Id);
        }
    }
}
