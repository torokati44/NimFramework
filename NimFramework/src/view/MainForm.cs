using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private Game game;

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

        private void btnRun_Click(object sender, EventArgs e) {
            NamedType als = (NamedType)comboAlice.SelectedItem;
            NamedType bos = (NamedType)comboBob.SelectedItem;

            IAgent Alice = getSelectedAgent(als.type, (int)numAliceDepth.Value);
            IAgent Bob = getSelectedAgent(bos.type, (int)numBobDepth.Value);

            Game g = new Game((int)numHeaps.Value, (int)numStones.Value, Alice, Bob);
            int aliceWin = 0;
            int bobWin = 0;
            int runs = (int)numRuns.Value;

            for (int i = 0; i < runs; ++i) {
                IAgent winner = g.run();
                aliceWin += winner == Alice ? 1 : 0;
                bobWin += winner == Bob ? 1 : 0;
            }

            MessageBox.Show("Alice: " + aliceWin + "\nBob: " + bobWin);
        }
    }
}
