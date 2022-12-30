using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, sum ;

            Console.Write("Enter First number: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second number: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            for (int i = n1; i <= n2; i++)
            {
                int j = 1;
                sum = 0;
                while (j < i)
                {
                    if (i % j == 0) sum += j;
                    j++;
                }
                if (sum == i) Console.Write("{0} , ", i);
            }

            Console.ReadKey();
        }
    }
}
