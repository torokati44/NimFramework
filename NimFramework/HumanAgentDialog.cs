using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimFramework
{
    public partial class HumanAgentDialog : Form
    {
        int[] heaps;

        public HumanAgentDialog(int[] heaps)
        {
            InitializeComponent();
            this.heaps = heaps;
            String text = "";
            foreach (int h in heaps) {
                text = text + h + ", ";
            }
            text = text.Substring(0, text.Length - 2);
            heapsLbl.Text = text;
        }

        public Choice getChoice()
        {
            return new Choice((int)heap.Value - 1, (int)stones.Value);
        }

        private void HumanAgentDialog_Load(object sender, EventArgs e)
        {
            heap.Maximum = heaps.Count();
            stones.Maximum = heaps[(int)heap.Value - 1];
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void heap_ValueChanged(object sender, EventArgs e)
        {
            stones.Minimum = 1;
            stones.Maximum = heaps[(int)heap.Value - 1];
            okBtn.Enabled = heaps[(int)heap.Value - 1] > 0;
        }
    }
}
