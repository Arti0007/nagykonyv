
namespace nagykonyv
{
    partial class FrmLista
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.szerzőkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újKönyvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kereso = new System.Windows.Forms.TextBox();
            this.tabla1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.konyvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helyezes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerzőkToolStripMenuItem,
            this.újKönyvToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // szerzőkToolStripMenuItem
            // 
            this.szerzőkToolStripMenuItem.Name = "szerzőkToolStripMenuItem";
            this.szerzőkToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.szerzőkToolStripMenuItem.Text = "Szerzők";
            // 
            // újKönyvToolStripMenuItem
            // 
            this.újKönyvToolStripMenuItem.Name = "újKönyvToolStripMenuItem";
            this.újKönyvToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.újKönyvToolStripMenuItem.Text = "Új könyv";
            this.újKönyvToolStripMenuItem.Click += new System.EventHandler(this.újKönyvToolStripMenuItem_Click);
            // 
            // kereso
            // 
            this.kereso.Location = new System.Drawing.Point(15, 40);
            this.kereso.Name = "kereso";
            this.kereso.Size = new System.Drawing.Size(390, 20);
            this.kereso.TabIndex = 1;
            this.kereso.TextChanged += new System.EventHandler(this.kereso_TextChanged);
            // 
            // tabla1
            // 
            this.tabla1.AllowUserToAddRows = false;
            this.tabla1.AllowUserToDeleteRows = false;
            this.tabla1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.konyvID,
            this.helyezes,
            this.nev,
            this.cim});
            this.tabla1.Location = new System.Drawing.Point(15, 66);
            this.tabla1.Name = "tabla1";
            this.tabla1.ReadOnly = true;
            this.tabla1.Size = new System.Drawing.Size(773, 372);
            this.tabla1.TabIndex = 2;
            this.tabla1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tabla1_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Keresés szerző vagy cím alapján:";
            // 
            // konyvID
            // 
            this.konyvID.HeaderText = "konyvID";
            this.konyvID.Name = "konyvID";
            this.konyvID.ReadOnly = true;
            this.konyvID.Visible = false;
            // 
            // helyezes
            // 
            this.helyezes.FillWeight = 25F;
            this.helyezes.HeaderText = "Helyezés";
            this.helyezes.Name = "helyezes";
            this.helyezes.ReadOnly = true;
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // cim
            // 
            this.cim.HeaderText = "Cím";
            this.cim.Name = "cim";
            this.cim.ReadOnly = true;
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabla1);
            this.Controls.Add(this.kereso);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nagykönyv";
            this.Load += new System.EventHandler(this.FrmLista_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szerzőkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újKönyvToolStripMenuItem;
        private System.Windows.Forms.TextBox kereso;
        private System.Windows.Forms.DataGridView tabla1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn konyvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn helyezes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn cim;
    }
}

