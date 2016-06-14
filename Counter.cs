using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueCount
{
    class Counter
    {
        private readonly Dictionary<string, int> _map = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        public void UpdateMap(string token)
        {
            int count;
            _map.TryGetValue(token, out count);
            _map[token] = count + 1;
        }

        public void PrintMap()
        {
            var entries = _map.OrderByDescending(kvp => kvp.Value);
            foreach (var entry in entries)
            {
                Console.WriteLine("{0} -> {1}", entry.Value, entry.Key);
            }
        }
    }
}
