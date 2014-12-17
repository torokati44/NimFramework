using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimFramework {
    struct NamedType {
        public Type type;
        public string p;

        public NamedType(Type type, string p) {
            this.type = type;
            this.p = p;
        }
        public override string ToString() {
            return p;
        }
    }

    public partial class MainForm : Form {
        private List<IAgent> alice = new List<IAgent>();
        private List<IAgent> bob = new List<IAgent>();
        private List<NamedType> alice_t = new List<NamedType>();
        private List<NamedType> bob_t = new List<NamedType>();
        public delegate void SimulationFinishedDelegate(int alice, int bob, long time);

        public MainForm() {
            InitializeComponent();

            alice_t.Add(new NamedType(typeof(MinimaxAgent), "Minimax ágens"));
            alice_t.Add(new NamedType(typeof(PruningMinimaxAgent), "Nyeséses minimax ágens"));
            alice_t.Add(new NamedType(typeof(RandomAgent), "Random ágens"));
            alice_t.Add(new NamedType(typeof(RandomHeapAgent), "Javított random ágens"));
            alice_t.Add(new NamedType(typeof(SummingMinimaxAgent), "Összegző minimax ágens"));

            bob_t.Add(new NamedType(typeof(MinimaxAgent), "Minimax ágens"));
            bob_t.Add(new NamedType(typeof(PruningMinimaxAgent), "Nyeséses minimax ágens"));
            bob_t.Add(new NamedType(typeof(RandomAgent), "Random ágens"));
            bob_t.Add(new NamedType(typeof(RandomHeapAgent), "Javított random ágens"));
            bob_t.Add(new NamedType(typeof(SummingMinimaxAgent), "Összegző minimax ágens"));
            
            comboAlice.DataSource = alice_t;
            comboBob.DataSource = bob_t;
        }

        private IAgent getSelectedAgent(Type t, int maxDepth) {
            if (t == typeof(MinimaxAgent)) {
                return new MinimaxAgent(maxDepth);
            }
            else if (t == typeof(PruningMinimaxAgent)) {
                return new PruningMinimaxAgent(maxDepth);
            }
            else if (t == typeof(RandomAgent)) {
                return new RandomAgent();
            }
            else if (t == typeof(RandomHeapAgent)) {
                return new RandomHeapAgent();
            }
            else if (t == typeof(SummingMinimaxAgent)) {
                return new SummingMinimaxAgent(maxDepth);
            }

            return null;
        }


        private int heaps, stones;
        private int aliceDepth, bobDepth;
        private int runs;
        private IAgent Alice, Bob;
        private void btnRun_Click(object sender, EventArgs e) {
            NamedType als = (NamedType)comboAlice.SelectedItem;
            NamedType bos = (NamedType)comboBob.SelectedItem;
            aliceDepth = (int)numAliceDepth.Value;
            bobDepth = (int)numBobDepth.Value;

            Alice = getSelectedAgent(als.type, aliceDepth);
            Bob = getSelectedAgent(bos.type, bobDepth);
            heaps = (int)numHeaps.Value;
            stones = (int)numStones.Value;
            Game g = new Game(heaps, stones, Alice, Bob);
            int aliceWin = 0;
            int bobWin = 0;
            runs = (int)numRuns.Value;
            
            btnRun.Enabled = false;
            btnRun.Text = "Futtatás...";
            new Thread(() => {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                for (int i = 0; i < runs; ++i) {
                    Invoke(new ProgressDelegate(updateProgress), new object[] { (i*100)/runs, i + "/" + runs });
                    g.reset(heaps, stones);
                    IAgent winner = g.run();
                    aliceWin += winner == Alice ? 1 : 0;
                    bobWin += winner == Bob ? 1 : 0;
                }
                sw.Stop();
                Invoke(new ProgressDelegate(updateProgress), new object[] { 100, runs + "/" + runs });
                Invoke(new SimulationFinishedDelegate(simulationEnded), new object[] { aliceWin, bobWin, sw.ElapsedMilliseconds });
            }) { IsBackground = true }.Start();
        }

        private void simulationEnded(int alice, int bob, long time) {
            btnRun.Enabled = true;
            btnRun.Text = "Futtatás";

            addToList(Alice.ToString(), alice, aliceDepth, Bob.ToString(), bob, bobDepth,
                      heaps, stones, runs, time);
        }

        public delegate void ProgressDelegate(int p, string s);
        private void updateProgress(int p, string s) {
            progressBar.Value = p;
            lblProg.Text = s;
        }

        private int id = 0;
        private void addToList(string alice, int aliceWin, int aliceDepth, 
                               string bob, int bobWin, int bobDepth,
                               int heaps, int stones, int runs, long time) {
            var l = new List<ListViewItem.ListViewSubItem>();
            ListViewItem lv = new ListViewItem("" + id++);

            l.Add(new ListViewItem.ListViewSubItem(lv, alice));//alice
            l.Add(new ListViewItem.ListViewSubItem(lv, aliceDepth + ""));//alicedepth
            l.Add(new ListViewItem.ListViewSubItem(lv, aliceWin + ""));//alicwin
            l.Add(new ListViewItem.ListViewSubItem(lv, bob));//bob
            l.Add(new ListViewItem.ListViewSubItem(lv, bobDepth + ""));//bobdepth
            l.Add(new ListViewItem.ListViewSubItem(lv, bobWin + ""));//bobwin
            l.Add(new ListViewItem.ListViewSubItem(lv, heaps + ""));//heaps
            l.Add(new ListViewItem.ListViewSubItem(lv, stones + ""));//stones
            l.Add(new ListViewItem.ListViewSubItem(lv, runs + ""));//runs
            l.Add(new ListViewItem.ListViewSubItem(lv, time + ""));//time

            foreach (var i in l) {
                lv.SubItems.Add(i);
            }

            listGames.Items.Add(lv);
        }
    }
}
