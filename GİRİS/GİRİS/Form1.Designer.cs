namespace GİRİS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.giris = new System.Windows.Forms.Button();
            this.kayıt = new System.Windows.Forms.Button();
            this.adl = new System.Windows.Forms.Label();
            this.adt = new System.Windows.Forms.TextBox();
            this.sifrel = new System.Windows.Forms.Label();
            this.sifret = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.Color.Black;
            this.giris.ForeColor = System.Drawing.Color.White;
            this.giris.Location = new System.Drawing.Point(401, 270);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(101, 32);
            this.giris.TabIndex = 1;
            this.giris.Text = "GİRİŞ YAP";
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // kayıt
            // 
            this.kayıt.BackColor = System.Drawing.Color.Black;
            this.kayıt.ForeColor = System.Drawing.Color.White;
            this.kayıt.Location = new System.Drawing.Point(593, 270);
            this.kayıt.Name = "kayıt";
            this.kayıt.Size = new System.Drawing.Size(101, 32);
            this.kayıt.TabIndex = 2;
            this.kayıt.Text = "KAYIT OL";
            this.kayıt.UseVisualStyleBackColor = false;
            this.kayıt.Click += new System.EventHandler(this.kayıt_Click);
            // 
            // adl
            // 
            this.adl.AutoSize = true;
            this.adl.BackColor = System.Drawing.Color.Maroon;
            this.adl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adl.ForeColor = System.Drawing.Color.White;
            this.adl.Location = new System.Drawing.Point(387, 69);
            this.adl.Name = "adl";
            this.adl.Size = new System.Drawing.Size(56, 17);
            this.adl.TabIndex = 3;
            this.adl.Text = "ADINIZ:";
            this.adl.Click += new System.EventHandler(this.ad_Click);
            // 
            // adt
            // 
            this.adt.Location = new System.Drawing.Point(558, 68);
            this.adt.Multiline = true;
            this.adt.Name = "adt";
            this.adt.Size = new System.Drawing.Size(136, 18);
            this.adt.TabIndex = 4;
            this.adt.TextChanged += new System.EventHandler(this.adt_TextChanged);
            // 
            // sifrel
            // 
            this.sifrel.AutoSize = true;
            this.sifrel.BackColor = System.Drawing.Color.Maroon;
            this.sifrel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrel.ForeColor = System.Drawing.Color.White;
            this.sifrel.Location = new System.Drawing.Point(387, 157);
            this.sifrel.Name = "sifrel";
            this.sifrel.Size = new System.Drawing.Size(73, 17);
            this.sifrel.TabIndex = 5;
            this.sifrel.Text = "ŞİFRENİZ:";
            // 
            // sifret
            // 
            this.sifret.Location = new System.Drawing.Point(558, 157);
            this.sifret.Multiline = true;
            this.sifret.Name = "sifret";
            this.sifret.PasswordChar = '*';
            this.sifret.Size = new System.Drawing.Size(136, 18);
            this.sifret.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(68, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "HAKKIMIZDA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(761, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sifret);
            this.Controls.Add(this.sifrel);
            this.Controls.Add(this.adt);
            this.Controls.Add(this.adl);
            this.Controls.Add(this.kayıt);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Button kayıt;
        private System.Windows.Forms.Label adl;
        private System.Windows.Forms.TextBox adt;
        private System.Windows.Forms.Label sifrel;
        private System.Windows.Forms.TextBox sifret;
        private System.Windows.Forms.Button button1;
    }
}

