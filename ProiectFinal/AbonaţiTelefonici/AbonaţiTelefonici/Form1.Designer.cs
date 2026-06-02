namespace AbonaţiTelefonici
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvClienti = new System.Windows.Forms.DataGridView();
            this.lbDateClienti = new System.Windows.Forms.Label();
            this.lbNume = new System.Windows.Forms.Label();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.lbAbonament = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.cbAbonamente = new System.Windows.Forms.ComboBox();
            this.lbExtraoptiuni = new System.Windows.Forms.Label();
            this.clbExtraOptiuni = new System.Windows.Forms.CheckedListBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.lbDetaliiClient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNume2 = new System.Windows.Forms.Label();
            this.lbTelefon2 = new System.Windows.Forms.Label();
            this.lbAbonament2 = new System.Windows.Forms.Label();
            this.lbExtraCost = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbNume2 = new System.Windows.Forms.TextBox();
            this.tbTelefon2 = new System.Windows.Forms.TextBox();
            this.tbExtraCost = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbAbonament2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.binToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientCurentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClienti
            // 
            this.dgvClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienti.Location = new System.Drawing.Point(30, 430);
            this.dgvClienti.Name = "dgvClienti";
            this.dgvClienti.Size = new System.Drawing.Size(439, 262);
            this.dgvClienti.TabIndex = 0;
            this.dgvClienti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienti_CellClick);
            // 
            // lbDateClienti
            // 
            this.lbDateClienti.AutoSize = true;
            this.lbDateClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateClienti.Location = new System.Drawing.Point(98, 68);
            this.lbDateClienti.Name = "lbDateClienti";
            this.lbDateClienti.Size = new System.Drawing.Size(249, 39);
            this.lbDateClienti.TabIndex = 1;
            this.lbDateClienti.Text = "DATE CLIENTI";
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNume.Location = new System.Drawing.Point(27, 143);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(43, 16);
            this.lbNume.TabIndex = 2;
            this.lbNume.Text = "Nume";
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefon.Location = new System.Drawing.Point(27, 175);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(53, 16);
            this.lbTelefon.TabIndex = 2;
            this.lbTelefon.Text = "Telefon";
            // 
            // lbAbonament
            // 
            this.lbAbonament.AutoSize = true;
            this.lbAbonament.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAbonament.Location = new System.Drawing.Point(27, 209);
            this.lbAbonament.Name = "lbAbonament";
            this.lbAbonament.Size = new System.Drawing.Size(76, 16);
            this.lbAbonament.TabIndex = 2;
            this.lbAbonament.Text = "Abonament";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(282, 139);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(187, 20);
            this.tbNume.TabIndex = 3;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(282, 171);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(187, 20);
            this.tbTelefon.TabIndex = 3;
            // 
            // cbAbonamente
            // 
            this.cbAbonamente.FormattingEnabled = true;
            this.cbAbonamente.Location = new System.Drawing.Point(282, 204);
            this.cbAbonamente.Name = "cbAbonamente";
            this.cbAbonamente.Size = new System.Drawing.Size(187, 21);
            this.cbAbonamente.TabIndex = 4;
            // 
            // lbExtraoptiuni
            // 
            this.lbExtraoptiuni.AutoSize = true;
            this.lbExtraoptiuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExtraoptiuni.Location = new System.Drawing.Point(27, 278);
            this.lbExtraoptiuni.Name = "lbExtraoptiuni";
            this.lbExtraoptiuni.Size = new System.Drawing.Size(76, 16);
            this.lbExtraoptiuni.TabIndex = 2;
            this.lbExtraoptiuni.Text = "Extraoptiuni";
            // 
            // clbExtraOptiuni
            // 
            this.clbExtraOptiuni.FormattingEnabled = true;
            this.clbExtraOptiuni.Items.AddRange(new object[] {
            ""});
            this.clbExtraOptiuni.Location = new System.Drawing.Point(282, 246);
            this.clbExtraOptiuni.Name = "clbExtraOptiuni";
            this.clbExtraOptiuni.Size = new System.Drawing.Size(186, 94);
            this.clbExtraOptiuni.TabIndex = 5;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(30, 380);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(124, 23);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(173, 380);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(142, 23);
            this.btnSterge.TabIndex = 6;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(338, 380);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(131, 23);
            this.btnModifica.TabIndex = 6;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // lbDetaliiClient
            // 
            this.lbDetaliiClient.AutoSize = true;
            this.lbDetaliiClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetaliiClient.Location = new System.Drawing.Point(678, 68);
            this.lbDetaliiClient.Name = "lbDetaliiClient";
            this.lbDetaliiClient.Size = new System.Drawing.Size(277, 39);
            this.lbDetaliiClient.TabIndex = 1;
            this.lbDetaliiClient.Text = "DETALII CLIENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1089, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "z";
            // 
            // lbNume2
            // 
            this.lbNume2.AutoSize = true;
            this.lbNume2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNume2.Location = new System.Drawing.Point(656, 169);
            this.lbNume2.Name = "lbNume2";
            this.lbNume2.Size = new System.Drawing.Size(43, 16);
            this.lbNume2.TabIndex = 2;
            this.lbNume2.Text = "Nume";
            // 
            // lbTelefon2
            // 
            this.lbTelefon2.AutoSize = true;
            this.lbTelefon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefon2.Location = new System.Drawing.Point(656, 204);
            this.lbTelefon2.Name = "lbTelefon2";
            this.lbTelefon2.Size = new System.Drawing.Size(53, 16);
            this.lbTelefon2.TabIndex = 2;
            this.lbTelefon2.Text = "Telefon";
            // 
            // lbAbonament2
            // 
            this.lbAbonament2.AutoSize = true;
            this.lbAbonament2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAbonament2.Location = new System.Drawing.Point(656, 238);
            this.lbAbonament2.Name = "lbAbonament2";
            this.lbAbonament2.Size = new System.Drawing.Size(76, 16);
            this.lbAbonament2.TabIndex = 2;
            this.lbAbonament2.Text = "Abonament";
            // 
            // lbExtraCost
            // 
            this.lbExtraCost.AutoSize = true;
            this.lbExtraCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExtraCost.Location = new System.Drawing.Point(656, 275);
            this.lbExtraCost.Name = "lbExtraCost";
            this.lbExtraCost.Size = new System.Drawing.Size(67, 16);
            this.lbExtraCost.TabIndex = 2;
            this.lbExtraCost.Text = "Extra Cost";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(656, 307);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(38, 16);
            this.lbTotal.TabIndex = 2;
            this.lbTotal.Text = "Total";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbNume2
            // 
            this.tbNume2.Location = new System.Drawing.Point(842, 171);
            this.tbNume2.Name = "tbNume2";
            this.tbNume2.ReadOnly = true;
            this.tbNume2.Size = new System.Drawing.Size(113, 20);
            this.tbNume2.TabIndex = 8;
            // 
            // tbTelefon2
            // 
            this.tbTelefon2.Location = new System.Drawing.Point(842, 203);
            this.tbTelefon2.Name = "tbTelefon2";
            this.tbTelefon2.ReadOnly = true;
            this.tbTelefon2.Size = new System.Drawing.Size(113, 20);
            this.tbTelefon2.TabIndex = 9;
            // 
            // tbExtraCost
            // 
            this.tbExtraCost.Location = new System.Drawing.Point(842, 271);
            this.tbExtraCost.Name = "tbExtraCost";
            this.tbExtraCost.ReadOnly = true;
            this.tbExtraCost.Size = new System.Drawing.Size(113, 20);
            this.tbExtraCost.TabIndex = 10;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(842, 307);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(113, 20);
            this.tbTotal.TabIndex = 11;
            // 
            // tbAbonament2
            // 
            this.tbAbonament2.Location = new System.Drawing.Point(842, 233);
            this.tbAbonament2.Name = "tbAbonament2";
            this.tbAbonament2.ReadOnly = true;
            this.tbAbonament2.Size = new System.Drawing.Size(113, 20);
            this.tbAbonament2.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1090, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1090, 24);
            this.menuStrip2.TabIndex = 14;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.importToolStripMenuItem,
            this.printToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "menu";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStripMenuItem,
            this.binToolStripMenuItem,
            this.xmlToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.saveToolStripMenuItem.Text = "save";
            // 
            // txtToolStripMenuItem
            // 
            this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            this.txtToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.txtToolStripMenuItem.Text = "txt";
            this.txtToolStripMenuItem.Click += new System.EventHandler(this.txtToolStripMenuItem_Click);
            // 
            // binToolStripMenuItem
            // 
            this.binToolStripMenuItem.Name = "binToolStripMenuItem";
            this.binToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.binToolStripMenuItem.Text = "bin";
            this.binToolStripMenuItem.Click += new System.EventHandler(this.binToolStripMenuItem_Click);
            // 
            // xmlToolStripMenuItem
            // 
            this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            this.xmlToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.xmlToolStripMenuItem.Text = "xml";
            this.xmlToolStripMenuItem.Click += new System.EventHandler(this.xmlToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStripMenuItem1,
            this.binToolStripMenuItem1,
            this.xmlToolStripMenuItem1});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "import";
            // 
            // txtToolStripMenuItem1
            // 
            this.txtToolStripMenuItem1.Name = "txtToolStripMenuItem1";
            this.txtToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.txtToolStripMenuItem1.Text = "txt";
            this.txtToolStripMenuItem1.Click += new System.EventHandler(this.txtToolStripMenuItem1_Click);
            // 
            // binToolStripMenuItem1
            // 
            this.binToolStripMenuItem1.Name = "binToolStripMenuItem1";
            this.binToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.binToolStripMenuItem1.Text = "bin";
            this.binToolStripMenuItem1.Click += new System.EventHandler(this.binToolStripMenuItem1_Click);
            // 
            // xmlToolStripMenuItem1
            // 
            this.xmlToolStripMenuItem1.Name = "xmlToolStripMenuItem1";
            this.xmlToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.xmlToolStripMenuItem1.Text = "xml";
            this.xmlToolStripMenuItem1.Click += new System.EventHandler(this.xmlToolStripMenuItem1_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientCurentToolStripMenuItem});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.printToolStripMenuItem.Text = "print";
            // 
            // clientCurentToolStripMenuItem
            // 
            this.clientCurentToolStripMenuItem.Name = "clientCurentToolStripMenuItem";
            this.clientCurentToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.clientCurentToolStripMenuItem.Text = "client curent";
            this.clientCurentToolStripMenuItem.Click += new System.EventHandler(this.clientCurentToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(605, 430);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(413, 262);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "Venituri pe tip abonament";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 745);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.tbAbonament2);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbExtraCost);
            this.Controls.Add(this.tbTelefon2);
            this.Controls.Add(this.tbNume2);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.clbExtraOptiuni);
            this.Controls.Add(this.cbAbonamente);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.lbExtraoptiuni);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbExtraCost);
            this.Controls.Add(this.lbAbonament2);
            this.Controls.Add(this.lbAbonament);
            this.Controls.Add(this.lbTelefon2);
            this.Controls.Add(this.lbTelefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNume2);
            this.Controls.Add(this.lbNume);
            this.Controls.Add(this.lbDetaliiClient);
            this.Controls.Add(this.lbDateClienti);
            this.Controls.Add(this.dgvClienti);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClienti;
        private System.Windows.Forms.Label lbDateClienti;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.Label lbAbonament;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.ComboBox cbAbonamente;
        private System.Windows.Forms.Label lbExtraoptiuni;
        private System.Windows.Forms.CheckedListBox clbExtraOptiuni;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Label lbDetaliiClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNume2;
        private System.Windows.Forms.Label lbTelefon2;
        private System.Windows.Forms.Label lbAbonament2;
        private System.Windows.Forms.Label lbExtraCost;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbNume2;
        private System.Windows.Forms.TextBox tbTelefon2;
        private System.Windows.Forms.TextBox tbExtraCost;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbAbonament2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem binToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientCurentToolStripMenuItem;
    }
}

