namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TekSayılar = new System.Windows.Forms.TabControl();
            this.tekSayı = new System.Windows.Forms.TabPage();
            this.txtTekSayıToplam = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTekSayıCarpım = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listTekSayı = new System.Windows.Forms.ListView();
            this.ciftSayılar = new System.Windows.Forms.TabPage();
            this.listCiftSayı = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCiftSayıCarpım = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCiftSayıToplam = new System.Windows.Forms.MaskedTextBox();
            this.asalSayılar = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAsalSayıCarpım = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAsalSayıToplam = new System.Windows.Forms.MaskedTextBox();
            this.listAsalSayı = new System.Windows.Forms.ListView();
            this.mukemmelSayılar = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMukemmelSayıCarpım = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMukemmelSayıToplam = new System.Windows.Forms.MaskedTextBox();
            this.listMukemmelSayı = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBitis = new System.Windows.Forms.MaskedTextBox();
            this.txtBaslangıc = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calistir = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TekSayılar.SuspendLayout();
            this.tekSayı.SuspendLayout();
            this.ciftSayılar.SuspendLayout();
            this.asalSayılar.SuspendLayout();
            this.mukemmelSayılar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TekSayılar
            // 
            this.TekSayılar.Controls.Add(this.tekSayı);
            this.TekSayılar.Controls.Add(this.ciftSayılar);
            this.TekSayılar.Controls.Add(this.asalSayılar);
            this.TekSayılar.Controls.Add(this.mukemmelSayılar);
            this.TekSayılar.Location = new System.Drawing.Point(12, 104);
            this.TekSayılar.Name = "TekSayılar";
            this.TekSayılar.SelectedIndex = 0;
            this.TekSayılar.Size = new System.Drawing.Size(776, 334);
            this.TekSayılar.TabIndex = 3;
            // 
            // tekSayı
            // 
            this.tekSayı.Controls.Add(this.txtTekSayıToplam);
            this.tekSayı.Controls.Add(this.label3);
            this.tekSayı.Controls.Add(this.txtTekSayıCarpım);
            this.tekSayı.Controls.Add(this.label1);
            this.tekSayı.Controls.Add(this.listTekSayı);
            this.tekSayı.Location = new System.Drawing.Point(4, 22);
            this.tekSayı.Name = "tekSayı";
            this.tekSayı.Padding = new System.Windows.Forms.Padding(3);
            this.tekSayı.Size = new System.Drawing.Size(768, 308);
            this.tekSayı.TabIndex = 0;
            this.tekSayı.Text = "Tek Sayılar";
            this.tekSayı.UseVisualStyleBackColor = true;
            // 
            // txtTekSayıToplam
            // 
            this.txtTekSayıToplam.Enabled = false;
            this.txtTekSayıToplam.Location = new System.Drawing.Point(557, 6);
            this.txtTekSayıToplam.Name = "txtTekSayıToplam";
            this.txtTekSayıToplam.Size = new System.Drawing.Size(156, 20);
            this.txtTekSayıToplam.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Çarpım";
            // 
            // txtTekSayıCarpım
            // 
            this.txtTekSayıCarpım.Enabled = false;
            this.txtTekSayıCarpım.Location = new System.Drawing.Point(557, 32);
            this.txtTekSayıCarpım.Name = "txtTekSayıCarpım";
            this.txtTekSayıCarpım.Size = new System.Drawing.Size(156, 20);
            this.txtTekSayıCarpım.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toplam";
            // 
            // listTekSayı
            // 
            this.listTekSayı.HideSelection = false;
            this.listTekSayı.Location = new System.Drawing.Point(3, 3);
            this.listTekSayı.Name = "listTekSayı";
            this.listTekSayı.Size = new System.Drawing.Size(490, 312);
            this.listTekSayı.TabIndex = 0;
            this.listTekSayı.UseCompatibleStateImageBehavior = false;
            // 
            // ciftSayılar
            // 
            this.ciftSayılar.Controls.Add(this.listCiftSayı);
            this.ciftSayılar.Controls.Add(this.label4);
            this.ciftSayılar.Controls.Add(this.txtCiftSayıCarpım);
            this.ciftSayılar.Controls.Add(this.label5);
            this.ciftSayılar.Controls.Add(this.txtCiftSayıToplam);
            this.ciftSayılar.Location = new System.Drawing.Point(4, 22);
            this.ciftSayılar.Name = "ciftSayılar";
            this.ciftSayılar.Padding = new System.Windows.Forms.Padding(3);
            this.ciftSayılar.Size = new System.Drawing.Size(768, 308);
            this.ciftSayılar.TabIndex = 1;
            this.ciftSayılar.Text = "Çift Sayılar";
            this.ciftSayılar.UseVisualStyleBackColor = true;
            // 
            // listCiftSayı
            // 
            this.listCiftSayı.HideSelection = false;
            this.listCiftSayı.Location = new System.Drawing.Point(3, 3);
            this.listCiftSayı.Name = "listCiftSayı";
            this.listCiftSayı.Size = new System.Drawing.Size(490, 312);
            this.listCiftSayı.TabIndex = 10;
            this.listCiftSayı.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Çarpım";
            // 
            // txtCiftSayıCarpım
            // 
            this.txtCiftSayıCarpım.Enabled = false;
            this.txtCiftSayıCarpım.Location = new System.Drawing.Point(558, 35);
            this.txtCiftSayıCarpım.Name = "txtCiftSayıCarpım";
            this.txtCiftSayıCarpım.Size = new System.Drawing.Size(156, 20);
            this.txtCiftSayıCarpım.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Toplam";
            // 
            // txtCiftSayıToplam
            // 
            this.txtCiftSayıToplam.Enabled = false;
            this.txtCiftSayıToplam.Location = new System.Drawing.Point(558, 9);
            this.txtCiftSayıToplam.Name = "txtCiftSayıToplam";
            this.txtCiftSayıToplam.Size = new System.Drawing.Size(156, 20);
            this.txtCiftSayıToplam.TabIndex = 6;
            // 
            // asalSayılar
            // 
            this.asalSayılar.Controls.Add(this.label6);
            this.asalSayılar.Controls.Add(this.txtAsalSayıCarpım);
            this.asalSayılar.Controls.Add(this.label7);
            this.asalSayılar.Controls.Add(this.txtAsalSayıToplam);
            this.asalSayılar.Controls.Add(this.listAsalSayı);
            this.asalSayılar.Location = new System.Drawing.Point(4, 22);
            this.asalSayılar.Name = "asalSayılar";
            this.asalSayılar.Padding = new System.Windows.Forms.Padding(3);
            this.asalSayılar.Size = new System.Drawing.Size(768, 308);
            this.asalSayılar.TabIndex = 2;
            this.asalSayılar.Text = "Asal Sayılar";
            this.asalSayılar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Çarpım";
            // 
            // txtAsalSayıCarpım
            // 
            this.txtAsalSayıCarpım.Enabled = false;
            this.txtAsalSayıCarpım.Location = new System.Drawing.Point(557, 32);
            this.txtAsalSayıCarpım.Name = "txtAsalSayıCarpım";
            this.txtAsalSayıCarpım.Size = new System.Drawing.Size(156, 20);
            this.txtAsalSayıCarpım.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Toplam";
            // 
            // txtAsalSayıToplam
            // 
            this.txtAsalSayıToplam.Enabled = false;
            this.txtAsalSayıToplam.Location = new System.Drawing.Point(557, 6);
            this.txtAsalSayıToplam.Name = "txtAsalSayıToplam";
            this.txtAsalSayıToplam.Size = new System.Drawing.Size(156, 20);
            this.txtAsalSayıToplam.TabIndex = 7;
            // 
            // listAsalSayı
            // 
            this.listAsalSayı.HideSelection = false;
            this.listAsalSayı.Location = new System.Drawing.Point(3, 3);
            this.listAsalSayı.Name = "listAsalSayı";
            this.listAsalSayı.Size = new System.Drawing.Size(490, 312);
            this.listAsalSayı.TabIndex = 6;
            this.listAsalSayı.UseCompatibleStateImageBehavior = false;
            // 
            // mukemmelSayılar
            // 
            this.mukemmelSayılar.Controls.Add(this.label8);
            this.mukemmelSayılar.Controls.Add(this.txtMukemmelSayıCarpım);
            this.mukemmelSayılar.Controls.Add(this.label9);
            this.mukemmelSayılar.Controls.Add(this.txtMukemmelSayıToplam);
            this.mukemmelSayılar.Controls.Add(this.listMukemmelSayı);
            this.mukemmelSayılar.Location = new System.Drawing.Point(4, 22);
            this.mukemmelSayılar.Name = "mukemmelSayılar";
            this.mukemmelSayılar.Padding = new System.Windows.Forms.Padding(3);
            this.mukemmelSayılar.Size = new System.Drawing.Size(768, 308);
            this.mukemmelSayılar.TabIndex = 3;
            this.mukemmelSayılar.Text = "Mukemmel Sayılar";
            this.mukemmelSayılar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(498, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Çarpım";
            // 
            // txtMukemmelSayıCarpım
            // 
            this.txtMukemmelSayıCarpım.Enabled = false;
            this.txtMukemmelSayıCarpım.Location = new System.Drawing.Point(557, 32);
            this.txtMukemmelSayıCarpım.Name = "txtMukemmelSayıCarpım";
            this.txtMukemmelSayıCarpım.Size = new System.Drawing.Size(156, 20);
            this.txtMukemmelSayıCarpım.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(498, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Toplam";
            // 
            // txtMukemmelSayıToplam
            // 
            this.txtMukemmelSayıToplam.Enabled = false;
            this.txtMukemmelSayıToplam.Location = new System.Drawing.Point(557, 6);
            this.txtMukemmelSayıToplam.Name = "txtMukemmelSayıToplam";
            this.txtMukemmelSayıToplam.Size = new System.Drawing.Size(156, 20);
            this.txtMukemmelSayıToplam.TabIndex = 7;
            // 
            // listMukemmelSayı
            // 
            this.listMukemmelSayı.HideSelection = false;
            this.listMukemmelSayı.Location = new System.Drawing.Point(3, 3);
            this.listMukemmelSayı.Name = "listMukemmelSayı";
            this.listMukemmelSayı.Size = new System.Drawing.Size(490, 312);
            this.listMukemmelSayı.TabIndex = 6;
            this.listMukemmelSayı.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBitis);
            this.groupBox1.Controls.Add(this.txtBaslangıc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.calistir);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş bilgisi";
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(214, 26);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(100, 20);
            this.txtBitis.TabIndex = 6;
            this.txtBitis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBitis_KeyPress);
            // 
            // txtBaslangıc
            // 
            this.txtBaslangıc.Location = new System.Drawing.Point(76, 25);
            this.txtBaslangıc.Name = "txtBaslangıc";
            this.txtBaslangıc.Size = new System.Drawing.Size(100, 20);
            this.txtBaslangıc.TabIndex = 5;
            this.txtBaslangıc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBaslangıc_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Başlangıç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitiş";
            // 
            // calistir
            // 
            this.calistir.Location = new System.Drawing.Point(361, 23);
            this.calistir.Name = "calistir";
            this.calistir.Size = new System.Drawing.Size(75, 23);
            this.calistir.TabIndex = 2;
            this.calistir.Text = "Çalıştır";
            this.calistir.UseVisualStyleBackColor = true;
            this.calistir.Click += new System.EventHandler(this.calistir_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TekSayılar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TekSayılar.ResumeLayout(false);
            this.tekSayı.ResumeLayout(false);
            this.tekSayı.PerformLayout();
            this.ciftSayılar.ResumeLayout(false);
            this.ciftSayılar.PerformLayout();
            this.asalSayılar.ResumeLayout(false);
            this.asalSayılar.PerformLayout();
            this.mukemmelSayılar.ResumeLayout(false);
            this.mukemmelSayılar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TekSayılar;
        private System.Windows.Forms.TabPage tekSayı;
        private System.Windows.Forms.MaskedTextBox txtTekSayıToplam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtTekSayıCarpım;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listTekSayı;
        private System.Windows.Forms.TabPage ciftSayılar;
        private System.Windows.Forms.ListView listCiftSayı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCiftSayıCarpım;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCiftSayıToplam;
        private System.Windows.Forms.TabPage asalSayılar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtAsalSayıCarpım;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtAsalSayıToplam;
        private System.Windows.Forms.ListView listAsalSayı;
        private System.Windows.Forms.TabPage mukemmelSayılar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtMukemmelSayıCarpım;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtMukemmelSayıToplam;
        private System.Windows.Forms.ListView listMukemmelSayı;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtBitis;
        private System.Windows.Forms.MaskedTextBox txtBaslangıc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calistir;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

