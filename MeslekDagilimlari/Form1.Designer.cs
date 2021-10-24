
namespace MeslekDagilimlari
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
            this.gbx_dagilim = new System.Windows.Forms.GroupBox();
            this.lbx_dagilim = new System.Windows.Forms.ListBox();
            this.gbx_veriler = new System.Windows.Forms.GroupBox();
            this.btn_ogrenciEkle = new System.Windows.Forms.Button();
            this.btn_meslekEkle = new System.Windows.Forms.Button();
            this.tbx_ogrenciEkle = new System.Windows.Forms.TextBox();
            this.lbx_meslekler = new System.Windows.Forms.ListBox();
            this.tbx_meslekEkle = new System.Windows.Forms.TextBox();
            this.lbx_ogrenciler = new System.Windows.Forms.ListBox();
            this.btn_dagilim = new System.Windows.Forms.Button();
            this.gbx_dagilim.SuspendLayout();
            this.gbx_veriler.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_dagilim
            // 
            this.gbx_dagilim.Controls.Add(this.lbx_dagilim);
            this.gbx_dagilim.Location = new System.Drawing.Point(499, 12);
            this.gbx_dagilim.Name = "gbx_dagilim";
            this.gbx_dagilim.Size = new System.Drawing.Size(289, 426);
            this.gbx_dagilim.TabIndex = 0;
            this.gbx_dagilim.TabStop = false;
            this.gbx_dagilim.Text = "Dağılım";
            // 
            // lbx_dagilim
            // 
            this.lbx_dagilim.FormattingEnabled = true;
            this.lbx_dagilim.ItemHeight = 16;
            this.lbx_dagilim.Location = new System.Drawing.Point(6, 21);
            this.lbx_dagilim.Name = "lbx_dagilim";
            this.lbx_dagilim.Size = new System.Drawing.Size(277, 388);
            this.lbx_dagilim.TabIndex = 2;
            // 
            // gbx_veriler
            // 
            this.gbx_veriler.Controls.Add(this.btn_ogrenciEkle);
            this.gbx_veriler.Controls.Add(this.btn_meslekEkle);
            this.gbx_veriler.Controls.Add(this.tbx_ogrenciEkle);
            this.gbx_veriler.Controls.Add(this.lbx_meslekler);
            this.gbx_veriler.Controls.Add(this.tbx_meslekEkle);
            this.gbx_veriler.Controls.Add(this.lbx_ogrenciler);
            this.gbx_veriler.Location = new System.Drawing.Point(12, 12);
            this.gbx_veriler.Name = "gbx_veriler";
            this.gbx_veriler.Size = new System.Drawing.Size(481, 362);
            this.gbx_veriler.TabIndex = 2;
            this.gbx_veriler.TabStop = false;
            this.gbx_veriler.Text = "Veriler";
            // 
            // btn_ogrenciEkle
            // 
            this.btn_ogrenciEkle.Location = new System.Drawing.Point(21, 333);
            this.btn_ogrenciEkle.Name = "btn_ogrenciEkle";
            this.btn_ogrenciEkle.Size = new System.Drawing.Size(84, 23);
            this.btn_ogrenciEkle.TabIndex = 5;
            this.btn_ogrenciEkle.Text = "Ekle";
            this.btn_ogrenciEkle.UseVisualStyleBackColor = true;
            this.btn_ogrenciEkle.Click += new System.EventHandler(this.btn_ogrenciEkle_Click);
            // 
            // btn_meslekEkle
            // 
            this.btn_meslekEkle.Location = new System.Drawing.Point(245, 334);
            this.btn_meslekEkle.Name = "btn_meslekEkle";
            this.btn_meslekEkle.Size = new System.Drawing.Size(84, 23);
            this.btn_meslekEkle.TabIndex = 7;
            this.btn_meslekEkle.Text = "Ekle";
            this.btn_meslekEkle.UseVisualStyleBackColor = true;
            this.btn_meslekEkle.Click += new System.EventHandler(this.btn_meslekEkle_Click);
            // 
            // tbx_ogrenciEkle
            // 
            this.tbx_ogrenciEkle.Location = new System.Drawing.Point(111, 334);
            this.tbx_ogrenciEkle.Name = "tbx_ogrenciEkle";
            this.tbx_ogrenciEkle.Size = new System.Drawing.Size(128, 22);
            this.tbx_ogrenciEkle.TabIndex = 4;
            // 
            // lbx_meslekler
            // 
            this.lbx_meslekler.FormattingEnabled = true;
            this.lbx_meslekler.ItemHeight = 16;
            this.lbx_meslekler.Location = new System.Drawing.Point(245, 21);
            this.lbx_meslekler.Name = "lbx_meslekler";
            this.lbx_meslekler.Size = new System.Drawing.Size(218, 292);
            this.lbx_meslekler.TabIndex = 1;
            // 
            // tbx_meslekEkle
            // 
            this.tbx_meslekEkle.Location = new System.Drawing.Point(335, 334);
            this.tbx_meslekEkle.Name = "tbx_meslekEkle";
            this.tbx_meslekEkle.Size = new System.Drawing.Size(128, 22);
            this.tbx_meslekEkle.TabIndex = 6;
            // 
            // lbx_ogrenciler
            // 
            this.lbx_ogrenciler.FormattingEnabled = true;
            this.lbx_ogrenciler.ItemHeight = 16;
            this.lbx_ogrenciler.Location = new System.Drawing.Point(21, 21);
            this.lbx_ogrenciler.Name = "lbx_ogrenciler";
            this.lbx_ogrenciler.Size = new System.Drawing.Size(218, 292);
            this.lbx_ogrenciler.TabIndex = 0;
            // 
            // btn_dagilim
            // 
            this.btn_dagilim.Location = new System.Drawing.Point(12, 380);
            this.btn_dagilim.Name = "btn_dagilim";
            this.btn_dagilim.Size = new System.Drawing.Size(481, 41);
            this.btn_dagilim.TabIndex = 3;
            this.btn_dagilim.Text = "Dağılım Yap";
            this.btn_dagilim.UseVisualStyleBackColor = true;
            this.btn_dagilim.Click += new System.EventHandler(this.btn_dagilim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_dagilim);
            this.Controls.Add(this.gbx_veriler);
            this.Controls.Add(this.gbx_dagilim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbx_dagilim.ResumeLayout(false);
            this.gbx_veriler.ResumeLayout(false);
            this.gbx_veriler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_dagilim;
        private System.Windows.Forms.GroupBox gbx_veriler;
        private System.Windows.Forms.ListBox lbx_dagilim;
        private System.Windows.Forms.ListBox lbx_meslekler;
        private System.Windows.Forms.ListBox lbx_ogrenciler;
        private System.Windows.Forms.Button btn_meslekEkle;
        private System.Windows.Forms.TextBox tbx_meslekEkle;
        private System.Windows.Forms.Button btn_dagilim;
        private System.Windows.Forms.TextBox tbx_ogrenciEkle;
        private System.Windows.Forms.Button btn_ogrenciEkle;
    }
}

