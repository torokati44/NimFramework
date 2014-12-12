using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimFramework
{
    class RandomAgent : IAgent
    {
        String name;

        public RandomAgent(String n)
        {
            name = n;
        }
        
        public Choice step(ReadOnlyCollection<int> heaps)
        {
            Random rand = new Random();
            int heap;
            do
            {
                heap = rand.Next(heaps.Count);
            } while (heaps[heap] <= 0);

            int stones = rand.Next(heaps[heap]) + 1;
            return new Choice(heap, stones);
        }

        public String Name { get { return name; } }
    }
}
