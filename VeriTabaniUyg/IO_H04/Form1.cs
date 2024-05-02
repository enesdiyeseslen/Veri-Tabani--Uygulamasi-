using IO_H02;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IO_H03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerileriGetir_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Genel.db.Rehber.ToList();//SELECT * FROM Rehber

            dataGridView1.Columns["btnSil"].DisplayIndex = dataGridView1.Columns.Count - 1;
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            //SELECT * FROM Rehber WHERE AdSoyad=txtArama.text
            //SELECT * FROM Rehber WHERE AdSoyad LIKE '%txtArama.text%' OR Telefon LIKE '%txtArama.text%'
            dataGridView1.DataSource = Genel.db.Rehber.Where(x => x.AdSoyad.Contains(txtArama.Text) || x.Telefon.Contains(txtArama.Text)).ToList();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnKayitEkleGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "" && txtTelefon.Text != "")
            {
                if (txtAdSoyad.Text.Length < 51 && txtTelefon.Text.Length < 11)
                {
                    if (MessageBox.Show(txtAdSoyad.Text + " isimli kayıt "
                        + (guncelleID == 0 ? "eklenecek" : "güncellenecek") + ", onaylıyor musunuz?",
                        "Kayıt Onayı",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (guncelleID > 0) // Bu kısım güncelleme işlemi
                        {
                            var rehber = Genel.db.Rehber.Find(guncelleID);
                            if (rehber != null)
                            {
                                rehber.AdSoyad = txtAdSoyad.Text;
                                rehber.Telefon = txtTelefon.Text;
                                Genel.db.SaveChanges(); // Kayıt güncelleme işlemi
                                MessageBox.Show("Kayıt güncellendi.");
                            }
                            else
                            {
                                MessageBox.Show("Güncellenecek kayıt bulunamadı.");
                            }
                        }
                        else // Bu kısım ekleme işlemi  else if(guncelleID=0) ise yani
                        {
                            Rehber rehber = new Rehber()
                            {
                                AdSoyad = txtAdSoyad.Text,
                                Telefon = txtTelefon.Text
                            };

                            Genel.db.Rehber.Add(rehber);
                            Genel.db.SaveChanges(); // Yeni kayıt ekleme işlemi
                            MessageBox.Show("Yeni kayıt eklendi.");
                        }

                        txtAdSoyad.Clear();
                        txtTelefon.Clear();

                        guncelleID = 0;
                        btnKayitEkleGuncelle.Text = "Yeni Kişi Ekle";
                        groupBox1.Text = "Yeni Kişi Ekle";
                        groupBox1.Visible = Genel.kullanici.YetkiKayit;
                    }
                }
                else
                    MessageBox.Show("Ad Soyad 50 karakterden ve telefon 10 karakterden fazla olamaz");
            }
            else
                MessageBox.Show("Ad Soyad ve Telefon alanlarını doldurunuz");
        }

            private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = Genel.kullanici.YetkiKayit;
        }   

        int guncelleID = 0;

        public static Rehber rehber;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            //if (dataGridView1.Rows[e.RowIndex].Cells["btnSil"].Selected)
            if (dataGridView1.Columns["btnSil"].Index == e.ColumnIndex)
            {
                if (MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells["AdSoyad"].Value.ToString()
                    + " isimli kayıt silinecek, onaylıyor musunuz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["KisiID"].Value);
                    Rehber rehber = Genel.db.Rehber.Find(ID);

                    Genel.db.Rehber.Remove(rehber);
                    Genel.db.SaveChanges();
                }
            }
            else if (dataGridView1.Columns["btnDuzenle"].Index == e.ColumnIndex)
            {
                int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["KisiID"].Value);
                Rehber rehber = Genel.db.Rehber.Find(ID);

                FormRehberEkleGuncelle frm = new FormRehberEkleGuncelle(rehber);
                frm.ShowDialog();

                dataGridView1.DataSource = Genel.db.Rehber.ToList();
            }
            else if (dataGridView1.Columns["btnDuzenle2"].Index == e.ColumnIndex)
            {
                int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["KisiID"].Value);
                rehber = Genel.db.Rehber.Find(ID);

                FormRehberEkleGuncelle2 frm = new FormRehberEkleGuncelle2();
                frm.ShowDialog();

                dataGridView1.DataSource = Genel.db.Rehber.ToList();
            }
            else
            {
                if (!Genel.kullanici.YetkiGuncelle)
                    return;

                guncelleID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["KisiID"].Value);
                txtAdSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells["AdSoyad"].Value.ToString();
                txtTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells["Telefon"].Value.ToString();

                groupBox1.Text = txtAdSoyad.Text + " isimli kayıt günelleniyor...";
                btnKayitEkleGuncelle.Text = "Kaydı Güncelle";
                groupBox1.Visible = true;
            }
        }

        private void btnYeniKisi_Click(object sender, EventArgs e)
        {
            FormRehberEkleGuncelle frm = new FormRehberEkleGuncelle(new Rehber());
            frm.ShowDialog();

            dataGridView1.DataSource = Genel.db.Rehber.ToList();
        }
    }
}
