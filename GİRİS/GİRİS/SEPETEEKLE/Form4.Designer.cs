namespace GİRİS.SEPETEEKLE
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toplam = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(255, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 57);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toplam
            // 
            this.toplam.AutoSize = true;
            this.toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplam.ForeColor = System.Drawing.Color.White;
            this.toplam.Location = new System.Drawing.Point(631, 385);
            this.toplam.Name = "toplam";
            this.toplam.Size = new System.Drawing.Size(0, 17);
            this.toplam.TabIndex = 21;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(45, 119);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(527, 225);
            this.listBox1.TabIndex = 22;
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.Black;
            this.btnOnayla.ForeColor = System.Drawing.Color.White;
            this.btnOnayla.Location = new System.Drawing.Point(485, 400);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(110, 32);
            this.btnOnayla.TabIndex = 47;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnSepetekle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Black;
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(12, 400);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(110, 32);
            this.btnGeri.TabIndex = 48;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(617, 444);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.toplam);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label toplam;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnGeri;
        public System.Windows.Forms.ListBox listBox1;
    }
}