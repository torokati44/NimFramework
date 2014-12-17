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
    class HumanAgent : IAgent
    {
        public Choice step(ReadOnlyCollection<int> heaps)
        {
            HumanAgentDialog dialog = new HumanAgentDialog(heaps.ToArray());
            dialog.ShowDialog();
            return dialog.getChoice();
        }

        public String Name { get { return "HumanAgent"; } }

        public override string ToString()
        {
            return "Felhasználó ágens";
        }
    }
}
