using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer;
            int i;
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Please input an integer");
                integer = int.Parse(Console.ReadLine());

                Console.WriteLine("Number      Squared      Cubed");
                Console.WriteLine("======      =======      =======");
                for (i = 1; i <= integer; i++)// whatever integer you put in the for loop loops that many times
                {
                    Console.WriteLine(String.Format("{0,-10}  {1,-10}   {2,-10}", i, i * i, i * i * i));
                }
                while (true)
                {
                    Console.WriteLine("Do you want to run the program again? (yes/no)");
                    String str = Console.ReadLine().ToLower();
                    if (str == "yes")
                    {
                        repeat = true;
                        break;
                    }
                    else if (str == "no")
                    {
                        Console.WriteLine("Bye!");
                        repeat = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }
        }
    }
}
