using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListConsoleApp
{
    class ShoppingList
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Shopping List Manager");
            Console.WriteLine("You have 0 items in your list. ");
        }
        public static void printLine()
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("*", 120)));
        }
    }
}
//public static void printLine()
//{
//    Console.WriteLine(string.Concat(Enumerable.Repeat("*", 120)));
//}
