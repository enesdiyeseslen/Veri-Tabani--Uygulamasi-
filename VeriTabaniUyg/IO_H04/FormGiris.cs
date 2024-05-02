using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO_H03
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var kullanilar = Genel.db.Kullanici
                    .Where(x => x.KullaniciAdi == txtKAdi.Text && x.Sifre == txtSifre.Text)
                    .ToList();

            if (kullanilar.Count() == 1)
            {
                Genel.kullanici = kullanilar.First();

                Form1 frm = new Form1();
                frm.Show();

                Hide();
            }
            else
                lblMesaj.Text = "Kullanıcı Adı/Şifresi Hatalı";
        }
    }
}
