namespace Rhinozelfant
{
    partial class Rhinozelefant
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_bild = new System.Windows.Forms.PictureBox();
            this.bu_file = new System.Windows.Forms.Button();
            this.prb_working = new System.Windows.Forms.ProgressBar();
            this.la_time = new System.Windows.Forms.Label();
            this.tb_time = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bild)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_bild
            // 
            this.pb_bild.Location = new System.Drawing.Point(12, 46);
            this.pb_bild.Name = "pb_bild";
            this.pb_bild.Size = new System.Drawing.Size(953, 470);
            this.pb_bild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_bild.TabIndex = 0;
            this.pb_bild.TabStop = false;
            // 
            // bu_file
            // 
            this.bu_file.Location = new System.Drawing.Point(12, 12);
            this.bu_file.Name = "bu_file";
            this.bu_file.Size = new System.Drawing.Size(116, 28);
            this.bu_file.TabIndex = 1;
            this.bu_file.Text = "Bild auswählen";
            this.bu_file.UseVisualStyleBackColor = true;
            this.bu_file.Click += new System.EventHandler(this.bu_file_Click);
            // 
            // prb_working
            // 
            this.prb_working.Location = new System.Drawing.Point(134, 12);
            this.prb_working.Maximum = 200;
            this.prb_working.Name = "prb_working";
            this.prb_working.Size = new System.Drawing.Size(350, 28);
            this.prb_working.TabIndex = 2;
            // 
            // la_time
            // 
            this.la_time.AutoSize = true;
            this.la_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_time.Location = new System.Drawing.Point(490, 22);
            this.la_time.Name = "la_time";
            this.la_time.Size = new System.Drawing.Size(217, 18);
            this.la_time.TabIndex = 3;
            this.la_time.Text = "Benötigte Zeit (in Milisekunden):";
            // 
            // tb_time
            // 
            this.tb_time.Location = new System.Drawing.Point(672, 21);
            this.tb_time.Name = "tb_time";
            this.tb_time.ReadOnly = true;
            this.tb_time.Size = new System.Drawing.Size(100, 22);
            this.tb_time.TabIndex = 4;
            // 
            // Rhinozelefant
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(977, 528);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.la_time);
            this.Controls.Add(this.prb_working);
            this.Controls.Add(this.bu_file);
            this.Controls.Add(this.pb_bild);
            this.DoubleBuffered = true;
            this.Name = "Rhinozelefant";
            this.Text = "Rhinozelefant";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_bild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_bild;
        private System.Windows.Forms.Button bu_file;
        private System.Windows.Forms.ProgressBar prb_working;
        private System.Windows.Forms.Label la_time;
        private System.Windows.Forms.TextBox tb_time;
    }
}

