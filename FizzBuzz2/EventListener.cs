using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    class EventListener
    {
        private ListWithChangedEvent List;

        public EventListener(ListWithChangedEvent list)
        {
            List = list;
            List.Changed += new ChangeEventHandler(OnListChanged);
            List.fizz += new FizzBuzzEventHandler(OnFizzFound);
            List.fizz += new FizzBuzzEventHandler(Print);
            List.buzz += new FizzBuzzEventHandler(OnBuzzFound);
            List.buzz += new FizzBuzzEventHandler(Print);
            List.fizzBuzz += new FizzBuzzEventHandler(OnFizzBuzzFound);
            List.fizzBuzz += new FizzBuzzEventHandler(Print);
        }

        private void OnListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("list changed event received");
        }
        private void OnFizzFound(object sender, EventArgs e)
        {
            Console.WriteLine("Fizz");
        }
        private void Print(object sender, EventArgs e)
        {
            List.PrintList();
        }
        private void OnBuzzFound(object sender, EventArgs e)
        {
            Console.WriteLine("Buzz");
        }
        private void OnFizzBuzzFound(object sender, EventArgs e)
        {
            Console.WriteLine("FizzBuzz");
        }
        public void Detatch()
        {
            List.Changed -= new ChangeEventHandler(OnListChanged);
            List = null;
        }
    }
}
