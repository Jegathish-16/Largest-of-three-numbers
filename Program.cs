using System;
namespace Sharp
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three Number: ");
            int n1, n2, n3;
            Console.WriteLine("Enter 1st Number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2st Number: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3st Number: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("n1 is greater");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("n2 is greater");
            }
            else
            {
                Console.WriteLine("n3 is greater");
            }
        }
    }
}
