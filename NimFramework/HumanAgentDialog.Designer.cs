namespace NimFramework
{
    partial class HumanAgentDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okBtn = new System.Windows.Forms.Button();
            this.heap = new System.Windows.Forms.NumericUpDown();
            this.stones = new System.Windows.Forms.NumericUpDown();
            this.heapLbl = new System.Windows.Forms.Label();
            this.stonesLbl = new System.Windows.Forms.Label();
            this.heapsLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stones)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(200, 65);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "Mehet";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // heap
            // 
            this.heap.Location = new System.Drawing.Point(59, 68);
            this.heap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heap.Name = "heap";
            this.heap.Size = new System.Drawing.Size(41, 20);
            this.heap.TabIndex = 1;
            this.heap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heap.ValueChanged += new System.EventHandler(this.heap_ValueChanged);
            // 
            // stones
            // 
            this.stones.Location = new System.Drawing.Point(153, 68);
            this.stones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stones.Name = "stones";
            this.stones.Size = new System.Drawing.Size(41, 20);
            this.stones.TabIndex = 2;
            this.stones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // heapLbl
            // 
            this.heapLbl.AutoSize = true;
            this.heapLbl.Location = new System.Drawing.Point(12, 70);
            this.heapLbl.Name = "heapLbl";
            this.heapLbl.Size = new System.Drawing.Size(41, 13);
            this.heapLbl.TabIndex = 3;
            this.heapLbl.Text = "Kupac:";
            // 
            // stonesLbl
            // 
            this.stonesLbl.AutoSize = true;
            this.stonesLbl.Location = new System.Drawing.Point(106, 70);
            this.stonesLbl.Name = "stonesLbl";
            this.stonesLbl.Size = new System.Drawing.Size(41, 13);
            this.stonesLbl.TabIndex = 4;
            this.stonesLbl.Text = "Kövek:";
            // 
            // heapsLbl
            // 
            this.heapsLbl.AutoSize = true;
            this.heapsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.heapsLbl.Location = new System.Drawing.Point(12, 35);
            this.heapsLbl.Name = "heapsLbl";
            this.heapsLbl.Size = new System.Drawing.Size(0, 20);
            this.heapsLbl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "A pillanatnyi állapot:";
            // 
            // HumanAgentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 95);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heapsLbl);
            this.Controls.Add(this.stonesLbl);
            this.Controls.Add(this.heapLbl);
            this.Controls.Add(this.stones);
            this.Controls.Add(this.heap);
            this.Controls.Add(this.okBtn);
            this.Name = "HumanAgentDialog";
            this.Text = "HumanAgentDialog";
            this.Load += new System.EventHandler(this.HumanAgentDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.heap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.NumericUpDown heap;
        private System.Windows.Forms.NumericUpDown stones;
        private System.Windows.Forms.Label heapLbl;
        private System.Windows.Forms.Label stonesLbl;
        private System.Windows.Forms.Label heapsLbl;
        private System.Windows.Forms.Label label2;
    }
}