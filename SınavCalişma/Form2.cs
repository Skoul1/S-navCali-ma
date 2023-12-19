using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using KullanıcıAppModel;
using KullaniciİslemBL;

namespace SınavCalişma
{
    public partial class Form2 : Form
    {
        public string ad;
        public string soyad;
        public string email;
        public Form2()
        {
            InitializeComponent();
            txt_Admin.Visible = false;
            adminlbl.Visible = false;
            lbltc.Visible = false;
            Txt_TC.Visible = false;
        }
        private void lbl_kapa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void giris_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new Form1();
                 if (!string.IsNullOrEmpty(txtad.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtsoyad.Text))
                {
                    frm.tanımla(ad: txtad.Text.Trim(), soyad: txtsoyad.Text.Trim(), email: txtEmail.Text.Trim());
                }
                else if (!string.IsNullOrEmpty(Txt_TC.Text) && !string.IsNullOrEmpty(txt_Admin.Text))
                {
                    frm.tanımla(ad: txt_Admin.Text.Trim(), tc: Txt_TC.Text.Trim());
                }
                frm.ShowDialog();
                var islemkul = new KullaniciIslemleri();
                var islemadmin = new Adminİşlemleri();

                bool sonuc = islemkul.KullaniciEkle(new Kullanıcı { ad = txtad.Text.Trim(), soyad = txtsoyad.Text.Trim(), email = txtEmail.Text.Trim(), sifre = txtsifre.Text.Trim() });
                bool sonuc2 = islemadmin.KullaniciEkle(new Admin { TC = Txt_TC.Text.Trim(), AD = txt_Admin.Text.Trim() });
                MessageBox.Show(sonuc||sonuc2 ? "KULLANICI EKLENDİ" : "KULLANICI EKLENEMEDİ");

            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("BU KAYIT DAHA ÖNCE BULUNMAKTA");
                        break;
                    default:
                        MessageBox.Show("VERİ TABANI HATASI" + ex.Message);
                        break;
                }
                throw;
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
        }
        private void adminbtn_Click(object sender, EventArgs e)
        {
            txt_Admin.Visible = true;
            adminlbl.Visible = true;
            lbltc.Visible = true;
            Txt_TC.Visible = true;
            txtad.Clear();
            txtsoyad.Clear();
            txtEmail.Clear();
            txtsifre.Clear();
            lblad.Visible = false;
            lblsoyad.Visible = false;
            lblemail.Visible = false;
            lblsifre.Visible = false;
            txtad.Visible = false;
            txtsoyad.Visible = false;
            txtEmail.Visible = false;
            txtsifre.Visible = false;
        }
        private void UserBtn_Click(object sender, EventArgs e)
        {
            txt_Admin.Visible = false;
            adminlbl.Visible = false;
            lbltc.Visible = false;
            Txt_TC.Visible = false;
            txt_Admin.Clear();
            Txt_TC.Clear();
            lblad.Visible = true;
            lblsoyad.Visible = true;
            lblemail.Visible = true;
            lblsifre.Visible = true;
            txtad.Visible = true;
            txtsoyad.Visible = true;
            txtEmail.Visible = true;
            txtsifre.Visible = true;
        }
    }
}

