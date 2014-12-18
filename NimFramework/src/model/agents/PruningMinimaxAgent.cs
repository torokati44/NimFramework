using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimFramework
{
    /// <summary>
    /// Az alfa-béta nyesést alkalmazó Minimax algoritmusú ágens megvalósítás.
    /// </summary>
    class PruningMinimaxAgent : AbstractMinimaxAgent
    {
        public PruningMinimaxAgent() : this(-1) { }
        public PruningMinimaxAgent(int maxDepth = -1) : base(maxDepth) { }

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
                    int fitness = min(child, Int32.MinValue, Int32.MaxValue);
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
        /// Ezen felül kihagyja azon gyerekek feltárását a fában, amelyek már biztosan nem
        /// jöhetnek szóba a pillanatnyi alfa és béta paraméterek mellett.
        /// </summary>
        /// <param name="heaps">A kiindulási játékállás.</param>
        /// <param name="depth">A jelenlegi mélység a fában.</param>
        /// <returns>Az elérhető maximális pontszám.</returns>
        int max(int[] heaps, int alpha, int beta, int depth = 0)
        {
            if (maxDepth >= 0 && depth >= maxDepth) { return 0; }

            var children = generateChildren(heaps);
            if (children.Count() == 0) { return -1; }

            int maxFitness = Int32.MinValue;
            foreach (int[] h in children)
            {
                int fitness = min(h, alpha, beta, depth + 1);
                if (fitness > maxFitness) { maxFitness = fitness; }
                if (fitness > alpha) { alpha = fitness; }

                // Itt történik meg a nyesés, ha az alfa már nagyobb itt, mint a kapott
                // béta, akkor a többi gyerek bejárása az alfát csak tovább növelhetné,
                // de a kisebb béta miatt ez már semmiképp nem javíthatna a döntésen,
                // az egyik feljebb lévő minimalizáló úgyis eldobná ezt az értéket.
                if (alpha >= beta) { break; }
            }
            return maxFitness;
        }

        /// <summary>
        /// A minimalizáló funkciót megvalósító metódus. Megadja az egy adott
        /// játékállásból kiindulva a legrosszabb elérhető pontszámot.
        /// Ezen felül kihagyja azon gyerekek feltárását a fában, amelyek már biztosan nem
        /// jöhetnek szóba a pillanatnyi alfa és béta paraméterek mellett.
        /// </summary>
        /// <param name="heaps">A kiindulási játékállás.</param>
        /// <param name="depth">A jelenlegi mélység a fában.</param>
        /// <returns>Az elérhető legrosszabb pontszám.</returns>
        int min(int[] heaps, int alpha, int beta, int depth = 0)
        {
            if (maxDepth >= 0 && depth >= maxDepth) { return 0; }

            var children = generateChildren(heaps);
            if (children.Count() == 0) { return 1; }

            int minFitness = Int32.MaxValue;
            foreach (int[] h in children)
            {
                int fitness = max(h, alpha, beta, depth + 1);
                if (fitness < minFitness) { minFitness = fitness; }
                if (fitness < beta) { beta = fitness; }

                // Itt történik meg a nyesés, ha az béta már kisebb itt, mint a kapott
                // alfa, akkor a többi gyerek bejárása a bétát csak tovább csökkenthetné,
                // de a nagyobb alfa miatt ez már semmiképp nem javíthatna a döntésen,
                // az egyik feljebb lévő maximalizáló úgyis eldobná ezt az értéket.
                if (beta <= alpha) { break; }
            }
            return minFitness;
        }

        public override string ToString() {
            return "Nyeséses minimax ágens";
        }
    }
}
