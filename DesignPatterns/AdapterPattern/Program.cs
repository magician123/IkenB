using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget adapter = new VendorAdapter();

            foreach (var product in adapter.GetProducts())
            {
                Console.WriteLine(product);
            }

            
            Console.ReadLine();
        }
    }
}
