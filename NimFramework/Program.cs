using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace NimFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heaps = new int[3];

            for (int i = 0; i < heaps.Count(); ++i)
            {
                heaps[i] = 4;
            }

            Game game = new Game(heaps, new RandomAgent(), new MinimaxAgent());

            Stopwatch watch = new Stopwatch();
            watch.Start();
            IAgent winner = game.run();
            watch.Stop();
            Console.WriteLine("Game took {0} ms, {1} won.", watch.ElapsedMilliseconds, winner.Name);
            Console.ReadKey();
        }
    }
}
