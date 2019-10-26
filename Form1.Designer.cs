namespace WindowsApp
{
    partial class frmGiris
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
            this.colorDilagBiskletRengi = new System.Windows.Forms.ColorDialog();
            this.txtRenkAdi = new System.Windows.Forms.TextBox();
            this.btnRenkSec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTekerlekSayisi = new System.Windows.Forms.TextBox();
            this.btnCalsitir = new System.Windows.Forms.Button();
            this.txtBisikletInfo = new System.Windows.Forms.TextBox();
            this.BisikletHizi = new System.Windows.Forms.Label();
            this.txtBisikletHizi = new System.Windows.Forms.TextBox();
            this.Tavsiye = new System.Windows.Forms.Label();
            this.txtTavsiyeEdermisin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bisiklet Renk";
            // 
            // txtRenkAdi
            // 
            this.txtRenkAdi.Location = new System.Drawing.Point(192, 25);
            this.txtRenkAdi.Name = "txtRenkAdi";
            this.txtRenkAdi.ReadOnly = true;
            this.txtRenkAdi.Size = new System.Drawing.Size(151, 22);
            this.txtRenkAdi.TabIndex = 1;
            // 
            // btnRenkSec
            // 
            this.btnRenkSec.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRenkSec.Location = new System.Drawing.Point(362, 22);
            this.btnRenkSec.Name = "btnRenkSec";
            this.btnRenkSec.Size = new System.Drawing.Size(118, 28);
            this.btnRenkSec.TabIndex = 2;
            this.btnRenkSec.Text = "Renk Seciniz";
            this.btnRenkSec.UseVisualStyleBackColor = true;
            this.btnRenkSec.Click += new System.EventHandler(this.btnRenkSec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tekerlerk Sayisi";
            // 
            // txtTekerlekSayisi
            // 
            this.txtTekerlekSayisi.Location = new System.Drawing.Point(192, 56);
            this.txtTekerlekSayisi.Name = "txtTekerlekSayisi";
            this.txtTekerlekSayisi.Size = new System.Drawing.Size(151, 22);
            this.txtTekerlekSayisi.TabIndex = 4;
            // 
            // btnCalsitir
            // 
            this.btnCalsitir.Location = new System.Drawing.Point(694, 24);
            this.btnCalsitir.Name = "btnCalsitir";
            this.btnCalsitir.Size = new System.Drawing.Size(120, 23);
            this.btnCalsitir.TabIndex = 5;
            this.btnCalsitir.Text = "Calistir";
            this.btnCalsitir.UseVisualStyleBackColor = true;
            this.btnCalsitir.Click += new System.EventHandler(this.btnCalsitir_Click);
            // 
            // txtBisikletInfo
            // 
            this.txtBisikletInfo.Location = new System.Drawing.Point(33, 188);
            this.txtBisikletInfo.Multiline = true;
            this.txtBisikletInfo.Name = "txtBisikletInfo";
            this.txtBisikletInfo.Size = new System.Drawing.Size(781, 241);
            this.txtBisikletInfo.TabIndex = 6;
            // 
            // BisikletHizi
            // 
            this.BisikletHizi.AutoSize = true;
            this.BisikletHizi.Location = new System.Drawing.Point(29, 89);
            this.BisikletHizi.Name = "BisikletHizi";
            this.BisikletHizi.Size = new System.Drawing.Size(79, 17);
            this.BisikletHizi.TabIndex = 7;
            this.BisikletHizi.Text = "Bisiklet Hizi";
            this.BisikletHizi.Click += new System.EventHandler(this.BisikletTipi_Click);
            // 
            // txtBisikletHizi
            // 
            this.txtBisikletHizi.Location = new System.Drawing.Point(192, 89);
            this.txtBisikletHizi.Name = "txtBisikletHizi";
            this.txtBisikletHizi.Size = new System.Drawing.Size(151, 22);
            this.txtBisikletHizi.TabIndex = 8;
            this.txtBisikletHizi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Tavsiye
            // 
            this.Tavsiye.AutoSize = true;
            this.Tavsiye.Location = new System.Drawing.Point(29, 122);
            this.Tavsiye.Name = "Tavsiye";
            this.Tavsiye.Size = new System.Drawing.Size(123, 17);
            this.Tavsiye.TabIndex = 9;
            this.Tavsiye.Text = "Tavsiye Edermisin";
            // 
            // txtTavsiyeEdermisin
            // 
            this.txtTavsiyeEdermisin.Location = new System.Drawing.Point(192, 122);
            this.txtTavsiyeEdermisin.Name = "txtTavsiyeEdermisin";
            this.txtTavsiyeEdermisin.Size = new System.Drawing.Size(151, 22);
            this.txtTavsiyeEdermisin.TabIndex = 10;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 523);
            this.Controls.Add(this.txtTavsiyeEdermisin);
            this.Controls.Add(this.Tavsiye);
            this.Controls.Add(this.txtBisikletHizi);
            this.Controls.Add(this.BisikletHizi);
            this.Controls.Add(this.txtBisikletInfo);
            this.Controls.Add(this.btnCalsitir);
            this.Controls.Add(this.txtTekerlekSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRenkSec);
            this.Controls.Add(this.txtRenkAdi);
            this.Controls.Add(this.label1);
            this.Name = "frmGiris";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDilagBiskletRengi;
        private System.Windows.Forms.TextBox txtRenkAdi;
        private System.Windows.Forms.Button btnRenkSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTekerlekSayisi;
        private System.Windows.Forms.Button btnCalsitir;
        private System.Windows.Forms.TextBox txtBisikletInfo;
        private System.Windows.Forms.Label BisikletHizi;
        private System.Windows.Forms.TextBox txtBisikletHizi;
        private System.Windows.Forms.Label Tavsiye;
        private System.Windows.Forms.TextBox txtTavsiyeEdermisin;
    }
}

