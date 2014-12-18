using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimFramework
{
    /// <summary>
    /// Egy nagyon egyszerű ágens megvalósítás, mindig egy véletlenszerű,
    /// még nem üres kupacból vesz el potnosan egy követ.
    /// </summary>
    class RandomAgent : IAgent
    {
        static Random rand = new Random();

        public Choice step(ReadOnlyCollection<int> heaps)
        {
            int heap;
            do
            {
                heap = rand.Next(heaps.Count);
            } while (heaps[heap] <= 0);

            int stones = rand.Next(heaps[heap]) + 1;
            return new Choice(heap, stones);
        }

        public override string ToString() {
            return "Random ágens";
        }
    }
}
