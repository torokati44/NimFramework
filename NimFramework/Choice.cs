using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimFramework
{
    struct Choice
    {
        int heap;
        int stones;

        public Choice(int h, int s)
        {
            heap = h;
            stones = s;
        }

        public int Heap { get { return heap; } }
        public int Stones { get { return stones; } }
    }
}
