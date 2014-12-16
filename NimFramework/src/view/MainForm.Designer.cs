namespace NimFramework {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblHeapNum = new System.Windows.Forms.Label();
            this.lblStones = new System.Windows.Forms.Label();
            this.numStones = new System.Windows.Forms.NumericUpDown();
            this.numHeaps = new System.Windows.Forms.NumericUpDown();
            this.numRuns = new System.Windows.Forms.NumericUpDown();
            this.lblRuns = new System.Windows.Forms.Label();
            this.comboAlice = new System.Windows.Forms.ComboBox();
            this.comboBob = new System.Windows.Forms.ComboBox();
            this.lblAlice = new System.Windows.Forms.Label();
            this.lblBob = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.numAliceDepth = new System.Windows.Forms.NumericUpDown();
            this.numBobDepth = new System.Windows.Forms.NumericUpDown();
            this.lblDepth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numStones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRuns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAliceDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBobDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeapNum
            // 
            this.lblHeapNum.AutoSize = true;
            this.lblHeapNum.Location = new System.Drawing.Point(12, 21);
            this.lblHeapNum.Name = "lblHeapNum";
            this.lblHeapNum.Size = new System.Drawing.Size(86, 13);
            this.lblHeapNum.TabIndex = 2;
            this.lblHeapNum.Text = "Kupacok száma:";
            // 
            // lblStones
            // 
            this.lblStones.AutoSize = true;
            this.lblStones.Location = new System.Drawing.Point(12, 60);
            this.lblStones.Name = "lblStones";
            this.lblStones.Size = new System.Drawing.Size(145, 13);
            this.lblStones.TabIndex = 3;
            this.lblStones.Text = "Kövek száma egy kupacban:";
            // 
            // numStones
            // 
            this.numStones.Location = new System.Drawing.Point(15, 76);
            this.numStones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStones.Name = "numStones";
            this.numStones.Size = new System.Drawing.Size(120, 20);
            this.numStones.TabIndex = 5;
            this.numStones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numHeaps
            // 
            this.numHeaps.Location = new System.Drawing.Point(15, 37);
            this.numHeaps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeaps.Name = "numHeaps";
            this.numHeaps.Size = new System.Drawing.Size(120, 20);
            this.numHeaps.TabIndex = 6;
            this.numHeaps.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numRuns
            // 
            this.numRuns.Location = new System.Drawing.Point(15, 115);
            this.numRuns.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numRuns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRuns.Name = "numRuns";
            this.numRuns.Size = new System.Drawing.Size(120, 20);
            this.numRuns.TabIndex = 7;
            this.numRuns.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblRuns
            // 
            this.lblRuns.AutoSize = true;
            this.lblRuns.Location = new System.Drawing.Point(12, 99);
            this.lblRuns.Name = "lblRuns";
            this.lblRuns.Size = new System.Drawing.Size(93, 13);
            this.lblRuns.TabIndex = 8;
            this.lblRuns.Text = "Futtatások száma:";
            // 
            // comboAlice
            // 
            this.comboAlice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlice.FormattingEnabled = true;
            this.comboAlice.Location = new System.Drawing.Point(15, 154);
            this.comboAlice.Name = "comboAlice";
            this.comboAlice.Size = new System.Drawing.Size(150, 21);
            this.comboAlice.TabIndex = 9;
            // 
            // comboBob
            // 
            this.comboBob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBob.FormattingEnabled = true;
            this.comboBob.Location = new System.Drawing.Point(15, 194);
            this.comboBob.Name = "comboBob";
            this.comboBob.Size = new System.Drawing.Size(150, 21);
            this.comboBob.TabIndex = 10;
            // 
            // lblAlice
            // 
            this.lblAlice.AutoSize = true;
            this.lblAlice.Location = new System.Drawing.Point(12, 138);
            this.lblAlice.Name = "lblAlice";
            this.lblAlice.Size = new System.Drawing.Size(33, 13);
            this.lblAlice.TabIndex = 11;
            this.lblAlice.Text = "Alice:";
            // 
            // lblBob
            // 
            this.lblBob.AutoSize = true;
            this.lblBob.Location = new System.Drawing.Point(12, 178);
            this.lblBob.Name = "lblBob";
            this.lblBob.Size = new System.Drawing.Size(29, 13);
            this.lblBob.TabIndex = 12;
            this.lblBob.Text = "Bob:";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(15, 243);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 13;
            this.btnRun.Text = "Futtatás";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // numAliceDepth
            // 
            this.numAliceDepth.Location = new System.Drawing.Point(171, 154);
            this.numAliceDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAliceDepth.Name = "numAliceDepth";
            this.numAliceDepth.Size = new System.Drawing.Size(40, 20);
            this.numAliceDepth.TabIndex = 14;
            this.numAliceDepth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numBobDepth
            // 
            this.numBobDepth.Location = new System.Drawing.Point(171, 194);
            this.numBobDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBobDepth.Name = "numBobDepth";
            this.numBobDepth.Size = new System.Drawing.Size(40, 20);
            this.numBobDepth.TabIndex = 15;
            this.numBobDepth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Location = new System.Drawing.Point(168, 138);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(71, 13);
            this.lblDepth.TabIndex = 16;
            this.lblDepth.Text = "Max mélység:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 327);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.numBobDepth);
            this.Controls.Add(this.numAliceDepth);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblBob);
            this.Controls.Add(this.lblAlice);
            this.Controls.Add(this.comboBob);
            this.Controls.Add(this.comboAlice);
            this.Controls.Add(this.lblRuns);
            this.Controls.Add(this.numRuns);
            this.Controls.Add(this.numHeaps);
            this.Controls.Add(this.numStones);
            this.Controls.Add(this.lblStones);
            this.Controls.Add(this.lblHeapNum);
            this.Name = "MainForm";
            this.Text = "Nim Framework";
            ((System.ComponentModel.ISupportInitialize)(this.numStones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRuns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAliceDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBobDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeapNum;
        private System.Windows.Forms.Label lblStones;
        private System.Windows.Forms.NumericUpDown numStones;
        private System.Windows.Forms.NumericUpDown numHeaps;
        private System.Windows.Forms.NumericUpDown numRuns;
        private System.Windows.Forms.Label lblRuns;
        private System.Windows.Forms.ComboBox comboAlice;
        private System.Windows.Forms.ComboBox comboBob;
        private System.Windows.Forms.Label lblAlice;
        private System.Windows.Forms.Label lblBob;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.NumericUpDown numAliceDepth;
        private System.Windows.Forms.NumericUpDown numBobDepth;
        private System.Windows.Forms.Label lblDepth;
    }
}