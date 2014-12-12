using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimFramework
{
    class Game
    {
        int[] heaps;
        IAgent alice;
        IAgent bob;

        public Game(int[] h, IAgent a, IAgent b)
        {
            heaps = h;
            alice = a;
            bob = b;
        }

        public IAgent run()
        {
            while (true)
            {
                dump();
                Choice aliceChoice = alice.step(Array.AsReadOnly(heaps));
                heaps[aliceChoice.Heap] -= aliceChoice.Stones;
                if (allHeapsEmpty())
                {
                    return alice;
                }

                dump();
                Choice bobChoice = bob.step(Array.AsReadOnly(heaps));
                heaps[bobChoice.Heap] -= bobChoice.Stones;
                if (allHeapsEmpty())
                {
                    return bob;
                }
            }
        }

        bool allHeapsEmpty()
        {
            return heaps.All(h => h <= 0);
        }

        void dump()
        {
            foreach (int i in heaps)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
