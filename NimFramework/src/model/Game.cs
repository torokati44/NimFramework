﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimFramework
{
    class Game
    {
        static Random rand = new Random();

        private int[] heaps;
        private IAgent alice;
        private IAgent bob;

        public Game(int h, int stones, int plusminus, IAgent a, IAgent b) {
            reset(h, stones, plusminus);
            alice = a;
            bob = b;
        }

        public void reset(int h, int stones, int plusminus)
        {
            if (plusminus > stones)
            {
                plusminus = stones;
            }

            heaps = new int[h];
            for (int i = 0; i < h; ++i)
            {
                heaps[i] = stones + rand.Next(-plusminus, plusminus);
            }
        }

        public IAgent run()
        {
            while (true)
            {
                //dump();
                Choice aliceChoice = alice.step(Array.AsReadOnly(heaps));
                heaps[aliceChoice.Heap] -= aliceChoice.Stones;
                if (allHeapsEmpty())
                {
                    return alice;
                }

                //dump();
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
