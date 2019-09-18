using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // create a new list 
            ListWithChangedEvent list = new ListWithChangedEvent();
            // create a class that litens for when the list is changed
            EventListener listener = new EventListener(list);

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(15);
            list.Add(30);

            Console.WriteLine();
            list.PrintList();
            list.FizzBuzz(); 
            list.Clear();
            listener.Detatch();

            Console.ReadKey();
        }
    }
}
