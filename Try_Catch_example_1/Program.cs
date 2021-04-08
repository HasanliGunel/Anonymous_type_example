using System;

namespace Try_Catch_example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            static double DivideNumber(double num1, double num2)
            {
                if (num1 < num2)
                    num1 += 20;
                return num1 / num2;
            }
            try
            {
                int i = 20; int j = 0;
                //int i = Convert.ToInt32(Console.ReadLine());
                //int j  = Convert.ToInt32(Console.ReadLine());
                double result = DivideNumber(i, j);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempted divide by zero. {0}", ex.Message);
            }
        }
    }
}
