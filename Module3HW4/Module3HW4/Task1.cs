using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW4
{
    public class Task1
    {
        private EventHandler _eventHandler;
        private List<int> _results;
        public Task1()
        {
            _results = new List<int>();
            _eventHandler = Sum;
            _eventHandler += Sum;
        }

        public void Wrapper()
        {
            try
            {
                _eventHandler.Invoke(this, new EventArgs());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            int allResults = 0;
            foreach (var item in _results)
            {
                allResults += item;
            }

            Console.WriteLine("Sum of results: " + allResults);
        }

        private void Sum(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("\nEnter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            int y = int.Parse(Console.ReadLine());
            int sum = x + y;
            _results.Add(sum);
            Console.WriteLine("Sum = " + sum);
        }
    }
}
