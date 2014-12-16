using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimFramework
{
    /// <summary>
    /// Az ágensek közös interfésze.
    /// </summary>
    interface IAgent
    {
        /// <summary>
        /// Ez a metódus végzi a döntést, hogy egy adott állapotban melyik kupacból hány követ vesz el az ágens.
        /// </summary>
        /// <param name="heaps">Egy jelenlegi játékállapot, amelyben döntést kell hozni.</param>
        /// <returns>Az ágens által megtenni kívánt lépés.</returns>
        Choice step(ReadOnlyCollection<int> heaps);

        /// <summary>
        /// Az ágens beazonosítására szolgáló név.
        /// </summary>
        String Name { get; }
    }
}
