using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sum(5,6));
            display();
            Console.WriteLine(text("ali"));
        }

        static int sum(int x, int y)
        {
            return x + y;
        }

        static void display()
        {
           for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("*");
            }
        }

        static string text(string word)
        {
            if(word == "Mohammed")
            {
                return "Good job";
            }else if(word == "Yarub")
            {
                return "Free palastine";
            }
            else
            {
                return "Hello";
            }

        }
    }
}
