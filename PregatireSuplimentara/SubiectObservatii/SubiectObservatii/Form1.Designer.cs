namespace SubiectObservatii
{
    partial class Form1
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
            this.tbObservatie = new System.Windows.Forms.TextBox();
            this.lbObservatie = new System.Windows.Forms.Label();
            this.btnAdaugaObs = new System.Windows.Forms.Button();
            this.lvObservatii = new System.Windows.Forms.ListView();
            this.obs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdaugaColect = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lbIdObs = new System.Windows.Forms.Label();
            this.tbIdOBS = new System.Windows.Forms.TextBox();
            this.tbIdCol = new System.Windows.Forms.TextBox();
            this.lvIDCOL = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbObservatie
            // 
            this.tbObservatie.Location = new System.Drawing.Point(88, 33);
            this.tbObservatie.Name = "tbObservatie";
            this.tbObservatie.Size = new System.Drawing.Size(100, 20);
            this.tbObservatie.TabIndex = 0;
            // 
            // lbObservatie
            // 
            this.lbObservatie.AutoSize = true;
            this.lbObservatie.Location = new System.Drawing.Point(27, 36);
            this.lbObservatie.Name = "lbObservatie";
            this.lbObservatie.Size = new System.Drawing.Size(58, 13);
            this.lbObservatie.TabIndex = 1;
            this.lbObservatie.Text = "Observatie";
            // 
            // btnAdaugaObs
            // 
            this.btnAdaugaObs.Location = new System.Drawing.Point(33, 131);
            this.btnAdaugaObs.Name = "btnAdaugaObs";
            this.btnAdaugaObs.Size = new System.Drawing.Size(158, 23);
            this.btnAdaugaObs.TabIndex = 2;
            this.btnAdaugaObs.Text = "AdaugaOBS";
            this.btnAdaugaObs.UseVisualStyleBackColor = true;
            this.btnAdaugaObs.Click += new System.EventHandler(this.btnAdaugaObs_Click);
            // 
            // lvObservatii
            // 
            this.lvObservatii.CausesValidation = false;
            this.lvObservatii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.obs,
            this.columnHeader1});
            this.lvObservatii.HideSelection = false;
            this.lvObservatii.HoverSelection = true;
            this.lvObservatii.Location = new System.Drawing.Point(222, 33);
            this.lvObservatii.Name = "lvObservatii";
            this.lvObservatii.Size = new System.Drawing.Size(140, 150);
            this.lvObservatii.TabIndex = 3;
            this.lvObservatii.UseCompatibleStateImageBehavior = false;
            this.lvObservatii.View = System.Windows.Forms.View.Details;
            // 
            // obs
            // 
            this.obs.Text = "ID";
            // 
            // btnAdaugaColect
            // 
            this.btnAdaugaColect.Location = new System.Drawing.Point(33, 160);
            this.btnAdaugaColect.Name = "btnAdaugaColect";
            this.btnAdaugaColect.Size = new System.Drawing.Size(158, 23);
            this.btnAdaugaColect.TabIndex = 4;
            this.btnAdaugaColect.Text = "Adauga Colectivitate";
            this.btnAdaugaColect.UseVisualStyleBackColor = true;
            this.btnAdaugaColect.Click += new System.EventHandler(this.btnAdaugaColect_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(402, 33);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(361, 150);
            this.dgv.TabIndex = 5;
            // 
            // lbIdObs
            // 
            this.lbIdObs.AutoSize = true;
            this.lbIdObs.Location = new System.Drawing.Point(30, 63);
            this.lbIdObs.Name = "lbIdObs";
            this.lbIdObs.Size = new System.Drawing.Size(38, 13);
            this.lbIdObs.TabIndex = 6;
            this.lbIdObs.Text = "IdOBS";
            // 
            // tbIdOBS
            // 
            this.tbIdOBS.Location = new System.Drawing.Point(88, 59);
            this.tbIdOBS.Name = "tbIdOBS";
            this.tbIdOBS.Size = new System.Drawing.Size(100, 20);
            this.tbIdOBS.TabIndex = 0;
            // 
            // tbIdCol
            // 
            this.tbIdCol.Location = new System.Drawing.Point(88, 85);
            this.tbIdCol.Name = "tbIdCol";
            this.tbIdCol.Size = new System.Drawing.Size(100, 20);
            this.tbIdCol.TabIndex = 0;
            // 
            // lvIDCOL
            // 
            this.lvIDCOL.AutoSize = true;
            this.lvIDCOL.Location = new System.Drawing.Point(30, 85);
            this.lvIDCOL.Name = "lvIDCOL";
            this.lvIDCOL.Size = new System.Drawing.Size(39, 13);
            this.lvIDCOL.TabIndex = 6;
            this.lvIDCOL.Text = "IDCOL";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "VAL";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "menu";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvIDCOL);
            this.Controls.Add(this.lbIdObs);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnAdaugaColect);
            this.Controls.Add(this.lvObservatii);
            this.Controls.Add(this.btnAdaugaObs);
            this.Controls.Add(this.lbObservatie);
            this.Controls.Add(this.tbIdCol);
            this.Controls.Add(this.tbIdOBS);
            this.Controls.Add(this.tbObservatie);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbObservatie;
        private System.Windows.Forms.Label lbObservatie;
        private System.Windows.Forms.Button btnAdaugaObs;
        private System.Windows.Forms.ListView lvObservatii;
        private System.Windows.Forms.ColumnHeader obs;
        private System.Windows.Forms.Button btnAdaugaColect;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lbIdObs;
        private System.Windows.Forms.TextBox tbIdOBS;
        private System.Windows.Forms.TextBox tbIdCol;
        private System.Windows.Forms.Label lvIDCOL;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

