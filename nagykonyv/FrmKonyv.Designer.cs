
namespace nagykonyv
{
    partial class FrmKonyv
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rogzit = new System.Windows.Forms.Button();
            this.modosit = new System.Windows.Forms.Button();
            this.torles = new System.Windows.Forms.Button();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.szerzo_cb = new System.Windows.Forms.ComboBox();
            this.cim_tb = new System.Windows.Forms.TextBox();
            this.helyezes_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szerző:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cím";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Helyezés:";
            // 
            // rogzit
            // 
            this.rogzit.Enabled = false;
            this.rogzit.Location = new System.Drawing.Point(12, 117);
            this.rogzit.Name = "rogzit";
            this.rogzit.Size = new System.Drawing.Size(75, 23);
            this.rogzit.TabIndex = 4;
            this.rogzit.Text = "Rögzítés";
            this.rogzit.UseVisualStyleBackColor = true;
            this.rogzit.Click += new System.EventHandler(this.rogzit_Click);
            // 
            // modosit
            // 
            this.modosit.Enabled = false;
            this.modosit.Location = new System.Drawing.Point(93, 117);
            this.modosit.Name = "modosit";
            this.modosit.Size = new System.Drawing.Size(75, 23);
            this.modosit.TabIndex = 5;
            this.modosit.Text = "Módosítás";
            this.modosit.UseVisualStyleBackColor = true;
            this.modosit.Click += new System.EventHandler(this.modosit_Click);
            // 
            // torles
            // 
            this.torles.Enabled = false;
            this.torles.Location = new System.Drawing.Point(174, 117);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(75, 23);
            this.torles.TabIndex = 6;
            this.torles.Text = "Törlés";
            this.torles.UseVisualStyleBackColor = true;
            this.torles.Click += new System.EventHandler(this.torles_Click);
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(68, 12);
            this.id_tb.Name = "id_tb";
            this.id_tb.ReadOnly = true;
            this.id_tb.Size = new System.Drawing.Size(100, 20);
            this.id_tb.TabIndex = 7;
            // 
            // szerzo_cb
            // 
            this.szerzo_cb.FormattingEnabled = true;
            this.szerzo_cb.Location = new System.Drawing.Point(68, 38);
            this.szerzo_cb.Name = "szerzo_cb";
            this.szerzo_cb.Size = new System.Drawing.Size(121, 21);
            this.szerzo_cb.TabIndex = 8;
            this.szerzo_cb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.szerzo_cb_KeyPress);
            // 
            // cim_tb
            // 
            this.cim_tb.Location = new System.Drawing.Point(68, 65);
            this.cim_tb.Name = "cim_tb";
            this.cim_tb.Size = new System.Drawing.Size(100, 20);
            this.cim_tb.TabIndex = 9;
            // 
            // helyezes_tb
            // 
            this.helyezes_tb.Location = new System.Drawing.Point(68, 91);
            this.helyezes_tb.Name = "helyezes_tb";
            this.helyezes_tb.Size = new System.Drawing.Size(100, 20);
            this.helyezes_tb.TabIndex = 10;
            // 
            // FrmKonyv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 151);
            this.Controls.Add(this.helyezes_tb);
            this.Controls.Add(this.cim_tb);
            this.Controls.Add(this.szerzo_cb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.torles);
            this.Controls.Add(this.modosit);
            this.Controls.Add(this.rogzit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmKonyv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Könyv";
            this.Load += new System.EventHandler(this.FrmKonyv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rogzit;
        private System.Windows.Forms.Button modosit;
        private System.Windows.Forms.Button torles;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.ComboBox szerzo_cb;
        private System.Windows.Forms.TextBox cim_tb;
        private System.Windows.Forms.TextBox helyezes_tb;
    }
}