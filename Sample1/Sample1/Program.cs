using System;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, sum = 0;
            Console.WriteLine("Enter First Number : "); n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Number : "); n2 = Int32.Parse(Console.ReadLine());
            sum = n1 + n2;
            Console.WriteLine("The sum is : "+sum);

        }
    }
}
