using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimFramework
{
    /// <summary>
    /// A Minimax algoritmust felhasználó ágens megvalósítások közös őse, opcionálisan korlátozható mélységű fabejárással.
    /// A mélységi korlát után lévő kimeneteleket döntetlennek kell feltételezni.
    /// </summary>
    abstract class AbstractMinimaxAgent : IAgent
    {
        protected int maxDepth;

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="maxDepth">A fa bejárásakor alkalmazott mélységi korlát.</param>
        protected AbstractMinimaxAgent(int maxDepth = -1)
        {
            this.maxDepth = maxDepth;
        }

        /// <summary>
        /// Előállítja az egy játékállásból az egy lépéssel megkapható összes lehetséges játékállást.
        /// </summary>
        /// <param name="heaps">A kezdeti állapot.</param>
        /// <returns>A lehetségtes következő állapotok listája.</returns>
        protected List<int[]> generateChildren(int[] heaps)
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

        abstract public Choice step(ReadOnlyCollection<int> heaps);
        abstract public String Name { get; }
    }
}
