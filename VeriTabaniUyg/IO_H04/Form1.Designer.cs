
namespace IO_H03
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVerileriGetir = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKayitEkleGuncelle = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeniKisi = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSil = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDuzenle = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDuzenle2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSil,
            this.btnDuzenle,
            this.btnDuzenle2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 216);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnVerileriGetir
            // 
            this.btnVerileriGetir.Location = new System.Drawing.Point(12, 8);
            this.btnVerileriGetir.Name = "btnVerileriGetir";
            this.btnVerileriGetir.Size = new System.Drawing.Size(104, 23);
            this.btnVerileriGetir.TabIndex = 1;
            this.btnVerileriGetir.Text = "Verileri Getir";
            this.btnVerileriGetir.UseVisualStyleBackColor = true;
            this.btnVerileriGetir.Click += new System.EventHandler(this.btnVerileriGetir_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(461, 10);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(117, 20);
            this.txtArama.TabIndex = 2;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKayitEkleGuncelle);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kişi Ekle";
            // 
            // btnKayitEkleGuncelle
            // 
            this.btnKayitEkleGuncelle.Location = new System.Drawing.Point(449, 25);
            this.btnKayitEkleGuncelle.Name = "btnKayitEkleGuncelle";
            this.btnKayitEkleGuncelle.Size = new System.Drawing.Size(111, 23);
            this.btnKayitEkleGuncelle.TabIndex = 4;
            this.btnKayitEkleGuncelle.Text = "Yeni Kişi Ekle";
            this.btnKayitEkleGuncelle.UseVisualStyleBackColor = true;
            this.btnKayitEkleGuncelle.Click += new System.EventHandler(this.btnKayitEkleGuncelle_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(289, 27);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(142, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefon";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(75, 27);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(142, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // btnYeniKisi
            // 
            this.btnYeniKisi.Location = new System.Drawing.Point(351, 8);
            this.btnYeniKisi.Name = "btnYeniKisi";
            this.btnYeniKisi.Size = new System.Drawing.Size(104, 23);
            this.btnYeniKisi.TabIndex = 4;
            this.btnYeniKisi.Text = "Yeni Kişi";
            this.btnYeniKisi.UseVisualStyleBackColor = true;
            this.btnYeniKisi.Click += new System.EventHandler(this.btnYeniKisi_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::IO_H02.Properties.Resources.delete;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::IO_H02.Properties.Resources.edit;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // btnSil
            // 
            this.btnSil.HeaderText = "";
            this.btnSil.Image = global::IO_H02.Properties.Resources.delete;
            this.btnSil.Name = "btnSil";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.HeaderText = "";
            this.btnDuzenle.Image = global::IO_H02.Properties.Resources.edit;
            this.btnDuzenle.Name = "btnDuzenle";
            // 
            // btnDuzenle2
            // 
            this.btnDuzenle2.HeaderText = "";
            this.btnDuzenle2.Image = global::IO_H02.Properties.Resources.edit;
            this.btnDuzenle2.Name = "btnDuzenle2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 363);
            this.Controls.Add(this.btnYeniKisi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnVerileriGetir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVerileriGetir;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKayitEkleGuncelle;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnYeniKisi;
        private System.Windows.Forms.DataGridViewImageColumn btnSil;
        private System.Windows.Forms.DataGridViewImageColumn btnDuzenle;
        private System.Windows.Forms.DataGridViewImageColumn btnDuzenle2;
    }
}

