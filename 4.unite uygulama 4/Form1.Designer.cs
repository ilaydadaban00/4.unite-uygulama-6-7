namespace _4.unite_uygulama_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSozlu1 = new System.Windows.Forms.TextBox();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.txtSozlu2 = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.listeleNotlar = new System.Windows.Forms.ListBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ad soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "not 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "not 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "sözlü 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "sözlü 2";
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(12, 164);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(46, 20);
            this.txtNot1.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(416, 164);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(58, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSozlu1
            // 
            this.txtSozlu1.Location = new System.Drawing.Point(206, 164);
            this.txtSozlu1.Name = "txtSozlu1";
            this.txtSozlu1.Size = new System.Drawing.Size(46, 20);
            this.txtSozlu1.TabIndex = 11;
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(105, 164);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(46, 20);
            this.txtNot2.TabIndex = 12;
            // 
            // txtSozlu2
            // 
            this.txtSozlu2.Location = new System.Drawing.Point(309, 164);
            this.txtSozlu2.Name = "txtSozlu2";
            this.txtSozlu2.Size = new System.Drawing.Size(46, 20);
            this.txtSozlu2.TabIndex = 13;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(211, 57);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(107, 20);
            this.txtAdSoyad.TabIndex = 14;
            // 
            // listeleNotlar
            // 
            this.listeleNotlar.FormattingEnabled = true;
            this.listeleNotlar.Location = new System.Drawing.Point(499, 101);
            this.listeleNotlar.Name = "listeleNotlar";
            this.listeleNotlar.Size = new System.Drawing.Size(120, 95);
            this.listeleNotlar.TabIndex = 15;
            this.listeleNotlar.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(625, 161);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(58, 23);
            this.btnListele.TabIndex = 16;
            this.btnListele.Text = "listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.listeleNotlar);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtSozlu2);
            this.Controls.Add(this.txtNot2);
            this.Controls.Add(this.txtSozlu1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtNot1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtSozlu1;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.TextBox txtSozlu2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ListBox listeleNotlar;
        private System.Windows.Forms.Button btnListele;
    }
}

