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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IO_H02
{
    public partial class FormRehberEkleGuncelle2 : Form
    {
        public FormRehberEkleGuncelle2()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormRehberEkleGuncelle2_Load(object sender, EventArgs e)
        {
            txtAdSoyad.Text = Form1.rehber.AdSoyad;
            txtTelefon.Text = Form1.rehber.Telefon;

            Text = Form1.rehber.KisiID == 0 ? "Yeni Kişi Ekle" : Form1.rehber.AdSoyad;
            btnKayitEkleGuncelle.Text = Form1.rehber.KisiID == 0 ? "Ekle" : "Güncelle";
        }

        private void btnKayitEkleGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "" && txtTelefon.Text != "")
            {
                if (txtAdSoyad.Text.Length < 51 && txtTelefon.Text.Length < 11)
                {
                    if (MessageBox.Show(txtAdSoyad.Text + " isimli kayıt "
                        + (Form1.rehber.KisiID == 0 ? "eklenecek" : "güncellenecek") + ", onaylıyor musunuz?",
                        "Kayıt Onayı",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Form1.rehber.AdSoyad = txtAdSoyad.Text;
                        Form1.rehber.Telefon = txtTelefon.Text;

                        if (Form1.rehber.KisiID == 0)
                            Genel.db.Rehber.Add(Form1.rehber);

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
