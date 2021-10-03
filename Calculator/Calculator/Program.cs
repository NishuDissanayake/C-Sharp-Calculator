using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaatada bn me boru krnne? \n\n");
            Console.Write("Enter first value: ");
            int no1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second value: ");
            int no2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1 for addition");
            Console.WriteLine("Enter 2 for subtraction");
            Console.WriteLine("Enter 3 for multiplication");
            Console.WriteLine("Enter 4 for division");

            Console.Write("Enter an operation to perform: ");
            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                int sum = no1 + no2;
                Console.WriteLine("Value = " + sum);
            }
            else if (op == 2)
            {
                int sub = no1 - no2;
                Console.WriteLine("Value = " + sub);
            }
            else if (op == 3)
            {
                int mul = no1 * no2;
                Console.WriteLine("Value = " + mul);
            }
            else if (op == 4)
            {
                int div = no1 / no2;
                Console.WriteLine("Value = " + div);
            }
            else
            {
                Console.WriteLine("Invalid operation!");
            }

            Console.WriteLine("Operation completed!");

            Console.ReadLine();
        }
    }
}
