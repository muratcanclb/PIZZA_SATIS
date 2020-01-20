namespace GİRİS.ULASIMBİLGİ
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adrest = new System.Windows.Forms.TextBox();
            this.telnol = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGönder = new System.Windows.Forms.Button();
            this.iptalb = new System.Windows.Forms.Button();
            this.btnGERİ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(290, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 207);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADRES:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adrest
            // 
            this.adrest.Location = new System.Drawing.Point(230, 251);
            this.adrest.Multiline = true;
            this.adrest.Name = "adrest";
            this.adrest.Size = new System.Drawing.Size(328, 151);
            this.adrest.TabIndex = 3;
            // 
            // telnol
            // 
            this.telnol.AutoSize = true;
            this.telnol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telnol.ForeColor = System.Drawing.Color.White;
            this.telnol.Location = new System.Drawing.Point(87, 433);
            this.telnol.Name = "telnol";
            this.telnol.Size = new System.Drawing.Size(113, 20);
            this.telnol.TabIndex = 4;
            this.telnol.Text = "TELEFON NO:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 435);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(155, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOT:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(230, 480);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(328, 92);
            this.textBox2.TabIndex = 7;
            // 
            // btnGönder
            // 
            this.btnGönder.BackColor = System.Drawing.Color.Black;
            this.btnGönder.ForeColor = System.Drawing.Color.White;
            this.btnGönder.Location = new System.Drawing.Point(457, 607);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(101, 32);
            this.btnGönder.TabIndex = 8;
            this.btnGönder.Text = "GÖNDER";
            this.btnGönder.UseVisualStyleBackColor = false;
            this.btnGönder.Click += new System.EventHandler(this.btnGönder_Click);
            // 
            // iptalb
            // 
            this.iptalb.BackColor = System.Drawing.Color.Black;
            this.iptalb.ForeColor = System.Drawing.Color.White;
            this.iptalb.Location = new System.Drawing.Point(324, 607);
            this.iptalb.Name = "iptalb";
            this.iptalb.Size = new System.Drawing.Size(101, 32);
            this.iptalb.TabIndex = 9;
            this.iptalb.Text = "İPTAL ET";
            this.iptalb.UseVisualStyleBackColor = false;
            this.iptalb.Click += new System.EventHandler(this.iptalb_Click);
            // 
            // btnGERİ
            // 
            this.btnGERİ.BackColor = System.Drawing.Color.Black;
            this.btnGERİ.ForeColor = System.Drawing.Color.White;
            this.btnGERİ.Location = new System.Drawing.Point(12, 607);
            this.btnGERİ.Name = "btnGERİ";
            this.btnGERİ.Size = new System.Drawing.Size(101, 32);
            this.btnGERİ.TabIndex = 10;
            this.btnGERİ.Text = "GERİ";
            this.btnGERİ.UseVisualStyleBackColor = false;
            this.btnGERİ.Click += new System.EventHandler(this.btnGERİ_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(803, 651);
            this.Controls.Add(this.btnGERİ);
            this.Controls.Add(this.iptalb);
            this.Controls.Add(this.btnGönder);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.telnol);
            this.Controls.Add(this.adrest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form2";
            this.Text = "ULAŞIMBİLGİLERİ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adrest;
        private System.Windows.Forms.Label telnol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnGönder;
        private System.Windows.Forms.Button iptalb;
        private System.Windows.Forms.Button btnGERİ;
    }
}