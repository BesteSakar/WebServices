namespace tcKimlikDogrulama
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
            this.lbl_tc = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.txt_yil = new System.Windows.Forms.TextBox();
            this.lbl_yil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(58, 56);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(52, 25);
            this.lbl_tc.TabIndex = 0;
            this.lbl_tc.Text = "TC :";
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(223, 53);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(253, 31);
            this.txt_tc.TabIndex = 1;
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(223, 158);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(253, 31);
            this.txt_isim.TabIndex = 3;
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(58, 158);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(66, 25);
            this.lbl_isim.TabIndex = 2;
            this.lbl_isim.Text = "İSİM :";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(223, 264);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(253, 31);
            this.txt_soyisim.TabIndex = 5;
            this.txt_soyisim.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Location = new System.Drawing.Point(58, 264);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(111, 25);
            this.lbl_soyisim.TabIndex = 4;
            this.lbl_soyisim.Text = "SOYİSİM :";
            // 
            // btn_gonder
            // 
            this.btn_gonder.Location = new System.Drawing.Point(223, 462);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(253, 61);
            this.btn_gonder.TabIndex = 6;
            this.btn_gonder.Text = "GÖNDER";
            this.btn_gonder.UseVisualStyleBackColor = true;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // txt_yil
            // 
            this.txt_yil.Location = new System.Drawing.Point(223, 357);
            this.txt_yil.Name = "txt_yil";
            this.txt_yil.Size = new System.Drawing.Size(253, 31);
            this.txt_yil.TabIndex = 8;
            // 
            // lbl_yil
            // 
            this.lbl_yil.AutoSize = true;
            this.lbl_yil.Location = new System.Drawing.Point(58, 357);
            this.lbl_yil.Name = "lbl_yil";
            this.lbl_yil.Size = new System.Drawing.Size(56, 25);
            this.lbl_yil.TabIndex = 7;
            this.lbl_yil.Text = "YIL :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(586, 551);
            this.Controls.Add(this.txt_yil);
            this.Controls.Add(this.lbl_yil);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.lbl_soyisim);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.lbl_tc);
            this.Name = "Form1";
            this.Text = "T.C KİMLİK DOĞRULAMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.TextBox txt_yil;
        private System.Windows.Forms.Label lbl_yil;
    }
}

