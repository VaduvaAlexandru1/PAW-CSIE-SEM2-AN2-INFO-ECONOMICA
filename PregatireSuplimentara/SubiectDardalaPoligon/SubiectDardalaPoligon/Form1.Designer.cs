namespace SubiectDardalaPoligon
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
            this.tbPunctX = new System.Windows.Forms.TextBox();
            this.tbPunctY = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lvPuncte = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbCuloare = new System.Windows.Forms.TextBox();
            this.tbEticheta = new System.Windows.Forms.TextBox();
            this.tbGrosime = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lvPoligon = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NrPuncte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPunctX
            // 
            this.tbPunctX.Location = new System.Drawing.Point(150, 18);
            this.tbPunctX.Name = "tbPunctX";
            this.tbPunctX.Size = new System.Drawing.Size(167, 20);
            this.tbPunctX.TabIndex = 0;
            // 
            // tbPunctY
            // 
            this.tbPunctY.Location = new System.Drawing.Point(150, 44);
            this.tbPunctY.Name = "tbPunctY";
            this.tbPunctY.Size = new System.Drawing.Size(167, 20);
            this.tbPunctY.TabIndex = 0;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(150, 70);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(167, 39);
            this.btnAdauga.TabIndex = 1;
            this.btnAdauga.Text = "Adauga Punct";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lvPuncte
            // 
            this.lvPuncte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvPuncte.GridLines = true;
            this.lvPuncte.HideSelection = false;
            this.lvPuncte.Location = new System.Drawing.Point(374, 21);
            this.lvPuncte.Name = "lvPuncte";
            this.lvPuncte.Size = new System.Drawing.Size(124, 139);
            this.lvPuncte.TabIndex = 2;
            this.lvPuncte.UseCompatibleStateImageBehavior = false;
            this.lvPuncte.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Punct X";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Punct Y";
            // 
            // tbCuloare
            // 
            this.tbCuloare.Location = new System.Drawing.Point(150, 140);
            this.tbCuloare.Name = "tbCuloare";
            this.tbCuloare.Size = new System.Drawing.Size(167, 20);
            this.tbCuloare.TabIndex = 0;
            this.tbCuloare.Text = "\r\n";
            // 
            // tbEticheta
            // 
            this.tbEticheta.Location = new System.Drawing.Point(150, 166);
            this.tbEticheta.Name = "tbEticheta";
            this.tbEticheta.Size = new System.Drawing.Size(167, 20);
            this.tbEticheta.TabIndex = 0;
            // 
            // tbGrosime
            // 
            this.tbGrosime.Location = new System.Drawing.Point(150, 192);
            this.tbGrosime.Name = "tbGrosime";
            this.tbGrosime.Size = new System.Drawing.Size(167, 20);
            this.tbGrosime.TabIndex = 0;
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(150, 218);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(167, 20);
            this.tbCod.TabIndex = 0;
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(31, 25);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(42, 13);
            this.lbX.TabIndex = 3;
            this.lbX.Text = "PunctX";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(31, 44);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(42, 13);
            this.lbY.TabIndex = 3;
            this.lbY.Text = "PunctY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Culoare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Eticheta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Grosime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cod";
            // 
            // lvPoligon
            // 
            this.lvPoligon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.NrPuncte});
            this.lvPoligon.GridLines = true;
            this.lvPoligon.HideSelection = false;
            this.lvPoligon.Location = new System.Drawing.Point(504, 21);
            this.lvPoligon.Name = "lvPoligon";
            this.lvPoligon.Size = new System.Drawing.Size(310, 139);
            this.lvPoligon.TabIndex = 4;
            this.lvPoligon.UseCompatibleStateImageBehavior = false;
            this.lvPoligon.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adauga Poligon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Culoare";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Eticheta";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Grosime";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cod";
            // 
            // NrPuncte
            // 
            this.NrPuncte.Text = "Nr Puncte";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.lvPoligon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.lvPuncte);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.tbGrosime);
            this.Controls.Add(this.tbEticheta);
            this.Controls.Add(this.tbCuloare);
            this.Controls.Add(this.tbPunctY);
            this.Controls.Add(this.tbPunctX);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "v";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPunctX;
        private System.Windows.Forms.TextBox tbPunctY;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.ListView lvPuncte;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox tbCuloare;
        private System.Windows.Forms.TextBox tbEticheta;
        private System.Windows.Forms.TextBox tbGrosime;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvPoligon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader NrPuncte;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
    }
}

