using IO_H03;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO_H02
{
    public partial class FormRehberEkleGuncelle : Form
    {
        Rehber rehber;
        public FormRehberEkleGuncelle(Rehber rehber)
        {
            this.rehber = rehber;
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormRehberEkleGuncelle_Load(object sender, EventArgs e)
        {
            txtAdSoyad.Text = rehber.AdSoyad;
            txtTelefon.Text = rehber.Telefon;

            Text = rehber.KisiID == 0 ? "Yeni Kişi Ekle" : rehber.AdSoyad;
            btnKayitEkleGuncelle.Text = rehber.KisiID == 0 ? "Ekle" : "Güncelle";
        }

        private void btnKayitEkleGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "" && txtTelefon.Text != "")
            {
                if (txtAdSoyad.Text.Length < 51 && txtTelefon.Text.Length < 11)
                {
                    if (MessageBox.Show(txtAdSoyad.Text + " isimli kayıt "
                        + (rehber.KisiID == 0 ? "eklenecek" : "güncellenecek") + ", onaylıyor musunuz?",
                        "Kayıt Onayı",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        rehber.AdSoyad = txtAdSoyad.Text;
                        rehber.Telefon = txtTelefon.Text;

                        if (rehber.KisiID == 0)
                            Genel.db.Rehber.Add(rehber);

                        Genel.db.SaveChanges();

                        Close();
                    }
                }
                else
                    MessageBox.Show("Ad Soyad 50 karakterden ve telefon 10 karakterden fazla olamaz");
            }
            else
                MessageBox.Show("Ad Soyad ve Telefon alanlarını doldurunuz");
        }
    }
}
