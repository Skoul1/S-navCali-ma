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
        }
        private void lbl_kapa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void giris_Click(object sender, EventArgs e)
        {
            try
            {
                var islemkul = new KullaniciIslemleri();
                var frm = new Form1(ad: txtad.Text.Trim(), soyad: txtsoyad.Text.Trim(), email: txtEmail.Text.Trim());
                bool sonuc =  islemkul.KullaniciEkle(new Kullanıcı { ad = txtad.Text.Trim(), soyad = txtsoyad.Text.Trim(), email = txtEmail.Text.Trim(), sifre = txtsifre.Text.Trim()});
                MessageBox.Show(sonuc ? "KULLANICI EKLENDİ" : "KULLANICI EKLENEMEDİ");
                frm.ShowDialog();
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
    }
}

