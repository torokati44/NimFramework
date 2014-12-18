using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimFramework
{
    /// <summary>
    /// A felhasználó által vezérelt ágens megvalósítása.
    /// Minden lépésnél egy kis felbukkanó párbeszédablakban kijelzi
    /// a jelenlegi állást, és bekéri, hogy melyik kupacból hány követ
    /// szeretnénk elvenni.
    /// </summary>
    class HumanAgent : IAgent
    {
        public Choice step(ReadOnlyCollection<int> heaps)
        {
            HumanAgentDialog dialog = new HumanAgentDialog(heaps.ToArray());
            dialog.ShowDialog();
            return dialog.getChoice();
        }

        public override string ToString()
        {
            return "Felhasználó ágens";
        }
    }
}
