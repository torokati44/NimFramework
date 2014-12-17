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
            this.listGames = new System.Windows.Forms.ListView();
            this.headID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headAlice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headAliceDepth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headAliceWin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headBob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headBobDepth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headBobWin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headHeaps = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headStones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headRuns = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numStonesPlusMinus = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProg = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numStones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRuns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAliceDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBobDepth)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStonesPlusMinus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeapNum
            // 
            this.lblHeapNum.AutoSize = true;
            this.lblHeapNum.Location = new System.Drawing.Point(12, 9);
            this.lblHeapNum.Name = "lblHeapNum";
            this.lblHeapNum.Size = new System.Drawing.Size(86, 13);
            this.lblHeapNum.TabIndex = 2;
            this.lblHeapNum.Text = "Kupacok száma:";
            // 
            // lblStones
            // 
            this.lblStones.AutoSize = true;
            this.lblStones.Location = new System.Drawing.Point(100, 9);
            this.lblStones.Name = "lblStones";
            this.lblStones.Size = new System.Drawing.Size(145, 13);
            this.lblStones.TabIndex = 3;
            this.lblStones.Text = "Kövek száma egy kupacban:";
            // 
            // numStones
            // 
            this.numStones.Location = new System.Drawing.Point(103, 25);
            this.numStones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStones.Name = "numStones";
            this.numStones.Size = new System.Drawing.Size(49, 20);
            this.numStones.TabIndex = 5;
            this.numStones.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numHeaps
            // 
            this.numHeaps.Location = new System.Drawing.Point(15, 25);
            this.numHeaps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeaps.Name = "numHeaps";
            this.numHeaps.Size = new System.Drawing.Size(72, 20);
            this.numHeaps.TabIndex = 6;
            this.numHeaps.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numRuns
            // 
            this.numRuns.Location = new System.Drawing.Point(250, 25);
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
            this.numRuns.Size = new System.Drawing.Size(90, 20);
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
            this.lblRuns.Location = new System.Drawing.Point(247, 9);
            this.lblRuns.Name = "lblRuns";
            this.lblRuns.Size = new System.Drawing.Size(93, 13);
            this.lblRuns.TabIndex = 8;
            this.lblRuns.Text = "Futtatások száma:";
            // 
            // comboAlice
            // 
            this.comboAlice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlice.FormattingEnabled = true;
            this.comboAlice.Location = new System.Drawing.Point(346, 25);
            this.comboAlice.Name = "comboAlice";
            this.comboAlice.Size = new System.Drawing.Size(150, 21);
            this.comboAlice.TabIndex = 9;
            // 
            // comboBob
            // 
            this.comboBob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBob.FormattingEnabled = true;
            this.comboBob.Location = new System.Drawing.Point(548, 24);
            this.comboBob.Name = "comboBob";
            this.comboBob.Size = new System.Drawing.Size(150, 21);
            this.comboBob.TabIndex = 10;
            // 
            // lblAlice
            // 
            this.lblAlice.AutoSize = true;
            this.lblAlice.Location = new System.Drawing.Point(343, 9);
            this.lblAlice.Name = "lblAlice";
            this.lblAlice.Size = new System.Drawing.Size(33, 13);
            this.lblAlice.TabIndex = 11;
            this.lblAlice.Text = "Alice:";
            // 
            // lblBob
            // 
            this.lblBob.AutoSize = true;
            this.lblBob.Location = new System.Drawing.Point(545, 9);
            this.lblBob.Name = "lblBob";
            this.lblBob.Size = new System.Drawing.Size(29, 13);
            this.lblBob.TabIndex = 12;
            this.lblBob.Text = "Bob:";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 51);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 13;
            this.btnRun.Text = "Futtatás";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // numAliceDepth
            // 
            this.numAliceDepth.Location = new System.Drawing.Point(502, 26);
            this.numAliceDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numAliceDepth.Name = "numAliceDepth";
            this.numAliceDepth.Size = new System.Drawing.Size(40, 20);
            this.numAliceDepth.TabIndex = 14;
            this.numAliceDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // numBobDepth
            // 
            this.numBobDepth.Location = new System.Drawing.Point(704, 25);
            this.numBobDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numBobDepth.Name = "numBobDepth";
            this.numBobDepth.Size = new System.Drawing.Size(40, 20);
            this.numBobDepth.TabIndex = 15;
            this.numBobDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Location = new System.Drawing.Point(471, 10);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(71, 13);
            this.lblDepth.TabIndex = 16;
            this.lblDepth.Text = "Max mélység:";
            // 
            // listGames
            // 
            this.listGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headID,
            this.headAlice,
            this.headAliceDepth,
            this.headAliceWin,
            this.headBob,
            this.headBobDepth,
            this.headBobWin,
            this.headHeaps,
            this.headStones,
            this.headRuns,
            this.headTime});
            this.listGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listGames.Location = new System.Drawing.Point(0, 78);
            this.listGames.Name = "listGames";
            this.listGames.Size = new System.Drawing.Size(784, 283);
            this.listGames.TabIndex = 17;
            this.listGames.UseCompatibleStateImageBehavior = false;
            this.listGames.View = System.Windows.Forms.View.Details;
            // 
            // headID
            // 
            this.headID.Text = "ID";
            this.headID.Width = 25;
            // 
            // headAlice
            // 
            this.headAlice.Text = "Alice";
            this.headAlice.Width = 100;
            // 
            // headAliceDepth
            // 
            this.headAliceDepth.Text = "Alice mélység";
            this.headAliceDepth.Width = 85;
            // 
            // headAliceWin
            // 
            this.headAliceWin.Text = "Alice nyert";
            this.headAliceWin.Width = 70;
            // 
            // headBob
            // 
            this.headBob.Text = "Bob";
            this.headBob.Width = 100;
            // 
            // headBobDepth
            // 
            this.headBobDepth.Text = "Bob mélység";
            this.headBobDepth.Width = 85;
            // 
            // headBobWin
            // 
            this.headBobWin.Text = "Bob nyert";
            this.headBobWin.Width = 70;
            // 
            // headHeaps
            // 
            this.headHeaps.Text = "Kupacok";
            // 
            // headStones
            // 
            this.headStones.Text = "Kövek";
            this.headStones.Width = 50;
            // 
            // headRuns
            // 
            this.headRuns.Text = "Futtatások";
            this.headRuns.Width = 65;
            // 
            // headTime
            // 
            this.headTime.Text = "Idő [s]";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numStonesPlusMinus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblProg);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.lblHeapNum);
            this.panel1.Controls.Add(this.lblStones);
            this.panel1.Controls.Add(this.lblDepth);
            this.panel1.Controls.Add(this.numStones);
            this.panel1.Controls.Add(this.numBobDepth);
            this.panel1.Controls.Add(this.numHeaps);
            this.panel1.Controls.Add(this.numAliceDepth);
            this.panel1.Controls.Add(this.numRuns);
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Controls.Add(this.lblRuns);
            this.panel1.Controls.Add(this.lblBob);
            this.panel1.Controls.Add(this.comboAlice);
            this.panel1.Controls.Add(this.lblAlice);
            this.panel1.Controls.Add(this.comboBob);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 78);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "+/-";
            // 
            // numStonesPlusMinus
            // 
            this.numStonesPlusMinus.Location = new System.Drawing.Point(192, 24);
            this.numStonesPlusMinus.Name = "numStonesPlusMinus";
            this.numStonesPlusMinus.Size = new System.Drawing.Size(49, 20);
            this.numStonesPlusMinus.TabIndex = 20;
            this.numStonesPlusMinus.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Max mélység:";
            // 
            // lblProg
            // 
            this.lblProg.AutoSize = true;
            this.lblProg.Location = new System.Drawing.Point(229, 56);
            this.lblProg.Name = "lblProg";
            this.lblProg.Size = new System.Drawing.Size(24, 13);
            this.lblProg.TabIndex = 18;
            this.lblProg.Text = "0/0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(103, 51);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(120, 23);
            this.progressBar.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.listGames);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Nim Framework";
            ((System.ComponentModel.ISupportInitialize)(this.numStones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRuns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAliceDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBobDepth)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStonesPlusMinus)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ListView listGames;
        private System.Windows.Forms.ColumnHeader headID;
        private System.Windows.Forms.ColumnHeader headAlice;
        private System.Windows.Forms.ColumnHeader headAliceWin;
        private System.Windows.Forms.ColumnHeader headAliceDepth;
        private System.Windows.Forms.ColumnHeader headBob;
        private System.Windows.Forms.ColumnHeader headBobWin;
        private System.Windows.Forms.ColumnHeader headBobDepth;
        private System.Windows.Forms.ColumnHeader headHeaps;
        private System.Windows.Forms.ColumnHeader headStones;
        private System.Windows.Forms.ColumnHeader headRuns;
        private System.Windows.Forms.ColumnHeader headTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblProg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numStonesPlusMinus;
    }
}