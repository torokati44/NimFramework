using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimFramework
{
    /// <summary>
    /// Az ágensek egy megtenni kívánt lépését reprezentálja.
    /// </summary>
    struct Choice
    {
        int heap;
        int stones;

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="h">A kupac sorszáma, amelyikből az ágens el szeretne venni köveket.</param>
        /// <param name="s">Az elvenni kívánt kövek száma.</param>
        public Choice(int h, int s)
        {
            heap = h;
            stones = s;
        }

        /// <summary>
        /// A kupac sorszáma, amelyikből az ágens el szeretne venni köveket.
        /// </summary>
        public int Heap { get { return heap; } }

        /// <summary>
        /// Az elvenni kívánt kövek száma.
        /// </summary>
        public int Stones { get { return stones; } }
    }
}
