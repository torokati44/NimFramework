using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimFramework
{
    /// <summary>
    /// Egy alternatív pontszámítási módot alkalmazó Minimax ágens megvalósítás.
    /// </summary>
    class SummingMinimaxAgent : AbstractMinimaxAgent
    {
        public SummingMinimaxAgent(int maxDepth) : base(maxDepth) { }

        public override Choice step(ReadOnlyCollection<int> heaps)
        {
            int max_fitness = Int32.MinValue;
            int max_heap = 0;
            int max_stones = 0;
            for (int heap = 0; heap < heaps.Count(); ++heap)
            {
                for (int stones = 1; stones <= heaps[heap]; ++stones)
                {
                    int[] child = heaps.ToArray();
                    child[heap] -= stones;
                    int fitness = min(child);
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

        /// <summary>
        /// A maximalizáló funkciót megvalósító metódus. Megadja az egy adott
        /// játékállásból kiindulva elérhető maximális pontszámot.
        /// Pontszámként azonban nem egyszerűen a gyerekekben lévő minimumok
        /// maximumát adja, hanem az összegüket.
        /// </summary>
        /// <param name="heaps">A kiindulási játékállás.</param>
        /// <param name="depth">A jelenlegi mélység a fában.</param>
        /// <returns>Az elérhető maximális pontszám.</returns>
        int max(int[] heaps, int depth = 0)
        {
            if (maxDepth >= 0 && depth >= maxDepth) { return 0; }

            var children = generateChildren(heaps);
            return (children.Count() == 0) ? -1 : children.Sum(h => min(h, depth + 1));
        }

        /// <summary>
        /// A minimalizáló funkciót megvalósító metódus. Megadja az egy adott
        /// játékállásból kiindulva a legrosszabb elérhető pontszámot.
        /// Pontszámként azonban nem egyszerűen a gyerekekben lévő maximumok
        /// minimumát adja, hanem az összegüket.
        /// </summary>
        /// <param name="heaps">A kiindulási játékállás.</param>
        /// <param name="depth">A jelenlegi mélység a fában.</param>
        /// <returns>Az elérhető legrosszabb pontszám.</returns>
        int min(int[] heaps, int depth = 0)
        {
            if (maxDepth >= 0 && depth >= maxDepth) { return 0; }

            var children = generateChildren(heaps);
            return (children.Count() == 0) ? 1 : children.Sum(h => max(h, depth + 1));
        }

        public override string ToString() {
            return "Összegző minimax ágens";
        }
    }
}
