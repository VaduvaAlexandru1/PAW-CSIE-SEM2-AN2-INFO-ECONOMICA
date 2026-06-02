namespace SubiectNr2
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
            this.tbValoareObs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.lvObservatii = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvIndici = new System.Windows.Forms.DataGridView();
            this.btnAfiseazaIndici = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndici)).BeginInit();
            this.SuspendLayout();
            // 
            // tbValoareObs
            // 
            this.tbValoareObs.Location = new System.Drawing.Point(129, 36);
            this.tbValoareObs.Name = "tbValoareObs";
            this.tbValoareObs.Size = new System.Drawing.Size(100, 20);
            this.tbValoareObs.TabIndex = 0;
            this.tbValoareObs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbValoareObs_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valoare Observatie";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(30, 78);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(199, 26);
            this.btnAdauga.TabIndex = 3;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(30, 127);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(199, 26);
            this.btnModifica.TabIndex = 3;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(29, 171);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(199, 26);
            this.btnSterge.TabIndex = 3;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // lvObservatii
            // 
            this.lvObservatii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvObservatii.FullRowSelect = true;
            this.lvObservatii.HideSelection = false;
            this.lvObservatii.Location = new System.Drawing.Point(338, 36);
            this.lvObservatii.Name = "lvObservatii";
            this.lvObservatii.Size = new System.Drawing.Size(123, 161);
            this.lvObservatii.TabIndex = 4;
            this.lvObservatii.UseCompatibleStateImageBehavior = false;
            this.lvObservatii.View = System.Windows.Forms.View.Details;
            this.lvObservatii.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvObservatii_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valoare";
            // 
            // dgvIndici
            // 
            this.dgvIndici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvIndici.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvIndici.Location = new System.Drawing.Point(29, 227);
            this.dgvIndici.Name = "dgvIndici";
            this.dgvIndici.Size = new System.Drawing.Size(432, 150);
            this.dgvIndici.TabIndex = 5;
            // 
            // btnAfiseazaIndici
            // 
            this.btnAfiseazaIndici.Location = new System.Drawing.Point(29, 395);
            this.btnAfiseazaIndici.Name = "btnAfiseazaIndici";
            this.btnAfiseazaIndici.Size = new System.Drawing.Size(200, 23);
            this.btnAfiseazaIndici.TabIndex = 6;
            this.btnAfiseazaIndici.Text = "Creaza Colectie";
            this.btnAfiseazaIndici.UseVisualStyleBackColor = true;
            this.btnAfiseazaIndici.Click += new System.EventHandler(this.btnAfiseazaIndici_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(243, 394);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(218, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAfiseazaIndici);
            this.Controls.Add(this.dgvIndici);
            this.Controls.Add(this.lvObservatii);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbValoareObs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValoareObs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.ListView lvObservatii;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataGridView dgvIndici;
        private System.Windows.Forms.Button btnAfiseazaIndici;
        private System.Windows.Forms.Button btnClear;
    }
}

