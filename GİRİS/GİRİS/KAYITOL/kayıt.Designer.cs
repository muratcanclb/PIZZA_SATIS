namespace GİRİS.KAYITOL
{
    partial class kayıt
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
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kyt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADINIZ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ŞİFRE:";
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(141, 9);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 20);
            this.t1.TabIndex = 4;
            this.t1.TextChanged += new System.EventHandler(this.t1_TextChanged);
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(141, 50);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(100, 20);
            this.t2.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(227, 109);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ŞİRKET KAYIDI YAPMAK İSTİYORUM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kyt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.t2);
            this.panel1.Controls.Add(this.t1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 187);
            this.panel1.TabIndex = 8;
            // 
            // kyt
            // 
            this.kyt.BackColor = System.Drawing.Color.Black;
            this.kyt.ForeColor = System.Drawing.Color.White;
            this.kyt.Location = new System.Drawing.Point(118, 144);
            this.kyt.Name = "kyt";
            this.kyt.Size = new System.Drawing.Size(123, 28);
            this.kyt.TabIndex = 49;
            this.kyt.Text = "KAYIT OL";
            this.kyt.UseVisualStyleBackColor = false;
            this.kyt.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(322, 213);
            this.Controls.Add(this.panel1);
            this.Name = "kayıt";
            this.Text = "T";
            this.Load += new System.EventHandler(this.kayıt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kyt;
    }
}