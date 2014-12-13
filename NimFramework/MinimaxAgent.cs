using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimFramework
{
    class MinimaxAgent : IAgent
    {
        public Choice step(ReadOnlyCollection<int> heaps) {
            int max_fitness = Int32.MinValue;
            int max_heap = 0;
            int max_stones = 0;
            for (int heap = 0; heap < heaps.Count(); ++heap)
            {
                for (int stones = 1; stones <= heaps[heap]; ++stones)
                {
                    int[] child = heaps.ToArray();
                    child[heap] -= stones;
                    int fitness = max(child);
                    if (fitness > max_fitness)
                    {
                        max_fitness = fitness;
                        max_heap = heap;
                        max_stones = stones;
                    }
                }
            }

            return new Choice(max_heap, max_stones);
        }

        public String Name { get { return "MinimaxAgent"; } }

        List<int[]> generateChildren(int[] heaps)
        {
            var children = new List<int[]>();

            for (int heap = 0; heap < heaps.Count(); ++heap)
            {
                for (int stones = 1; stones <= heaps[heap]; ++stones)
                {
                    int[] child = (int[])heaps.Clone();
                    child[heap] -= stones;
                    children.Add(child);
                }
            }

            return children;
        }

        int max(int[] heaps)
        {
            var children = generateChildren(heaps);
            return (children.Count() == 0) ? 0 : children.Max(h => min(h));
        }

        int min(int[] heaps)
        {
            var children = generateChildren(heaps);
            return (children.Count() == 0) ? 0 : children.Min(h => max(h));
        }
    }
}
