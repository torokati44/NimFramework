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
    /// még nem üres kupacból vesz el véletlenszerű számú, de legalább egy követ.
    /// </summary>
    class RandomHeapAgent : IAgent
    {
        static Random rand = new Random();

        public Choice step(ReadOnlyCollection<int> heaps)
        {
            int heap;
            do
            {
                heap = rand.Next(heaps.Count);
            } while (heaps[heap] <= 0);

            return new Choice(heap, 1);
        }

        public override string ToString() {
            return "Random 1 ágens";
        }
    }
}
