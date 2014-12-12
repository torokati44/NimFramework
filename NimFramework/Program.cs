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
            Game game = new Game(new int[] {4, 5}, new RandomAgent(), new RandomAgent());

            Stopwatch watch = new Stopwatch();
            watch.Start();
            IAgent winner = game.run();
            watch.Stop();
            Console.WriteLine("Game took {0} ms, {1} won.", watch.ElapsedMilliseconds, winner.Name);
            Console.ReadKey();
        }
    }
}
