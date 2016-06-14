using System;

namespace UniqueCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            var counter = new Counter();

            while ((line = Console.ReadLine()) != null)
            {
                counter.UpdateMap(line.Trim());
            }

            counter.PrintMap();
        }
    }
}
