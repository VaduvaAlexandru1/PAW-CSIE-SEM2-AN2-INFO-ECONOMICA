namespace SubiectTranzactie
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
            this.components = new System.ComponentModel.Container();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.cbTranzactii = new System.Windows.Forms.ComboBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranzactiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvTranzactii = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(21, 24);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(306, 20);
            this.tbNume.TabIndex = 0;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(21, 63);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(306, 20);
            this.tbAdresa.TabIndex = 1;
            // 
            // cbTranzactii
            // 
            this.cbTranzactii.FormattingEnabled = true;
            this.cbTranzactii.Location = new System.Drawing.Point(21, 118);
            this.cbTranzactii.Name = "cbTranzactii";
            this.cbTranzactii.Size = new System.Drawing.Size(306, 21);
            this.cbTranzactii.TabIndex = 2;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(26, 166);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(301, 42);
            this.btnAdauga.TabIndex = 3;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tranzactiiToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // tranzactiiToolStripMenuItem
            // 
            this.tranzactiiToolStripMenuItem.Name = "tranzactiiToolStripMenuItem";
            this.tranzactiiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tranzactiiToolStripMenuItem.Text = "Tranzactii";
            this.tranzactiiToolStripMenuItem.Click += new System.EventHandler(this.tranzactiiToolStripMenuItem_Click);
            // 
            // lvTranzactii
            // 
            this.lvTranzactii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.columnHeader2,
            this.columnHeader3});
            this.lvTranzactii.ContextMenuStrip = this.contextMenuStrip1;
            this.lvTranzactii.FullRowSelect = true;
            this.lvTranzactii.GridLines = true;
            this.lvTranzactii.HideSelection = false;
            this.lvTranzactii.Location = new System.Drawing.Point(369, 36);
            this.lvTranzactii.Name = "lvTranzactii";
            this.lvTranzactii.Size = new System.Drawing.Size(582, 226);
            this.lvTranzactii.TabIndex = 5;
            this.lvTranzactii.UseCompatibleStateImageBehavior = false;
            this.lvTranzactii.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adresa";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tranzactie";
            this.columnHeader3.Width = 292;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(369, 281);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(582, 37);
            this.btnAfiseaza.TabIndex = 6;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.saveToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem1.Text = "Delete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.lvTranzactii);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.cbTranzactii);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.ComboBox cbTranzactii;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tranzactiiToolStripMenuItem;
        private System.Windows.Forms.ListView lvTranzactii;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
    }
}

