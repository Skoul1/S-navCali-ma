using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SınavCalişma
{
    public partial class Form1 : Form
    {
        int score;
        int sonuc = 0;
        int sure = 60;
        public Form1()
        {
            InitializeComponent();
        }
        public void tanımla(string ad, string tc)
        {
            lbladgelir.Text = ad;
            lbltcgelir.Text = tc;
        }
        public void tanımla(string ad, string soyad, string email)
        {
            lbl_Ad.Text = ad;
            lbl_soyad.Text = soyad;
            lbl_Email.Text = email;
        }
        private void btn_click(object sender, EventArgs e)
        {
            //Toplama işlemi yaptırdık 
            Button btn = (Button)sender;
            //Butonun içindeki texti inte çevirip sayi değişkenine atadık
            int sayi = int.Parse(btn.Text);
            //her tıkladığında sonuç değişkine atadık
            sonuc += sayi;
        }
        private void topla_click(object sender, EventArgs e)
        {
            //Topla butonuna bastığımızda sonuc değişkenini ekrana yazdırdı
            MessageBox.Show($"İşlem sonucu: {sonuc}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Btn_kac(object sender, MouseEventArgs e)
        {
            //timer
            if (!timer.Enabled)
            {
                timer.Start();
            }
            //butonu kaçırmak için
            var btn2 = (Button)sender;
            //random sayı oluşturduk
            var rnd = new Random();
            //butonun lokasyonunu ayarlamak için Ekran genişliğinden ve blg_paneli ,redbtn ve buttonun genişliğini cıkardık //burda da yüksekliğinden butonun ve redbtn yuksekliğini cıkardık
            btn2.Location = new Point(rnd.Next(this.ClientSize.Width - Blg_panel.Width - btn2.Width  /*redbtn.Width*/), rnd.Next(this.ClientSize.Height - btn2.Height  /*redbtn.Height*/));
            //Mayın oluşturma
            if (score % 10 == 0)
            {
                Button redbtn = new Button();
                var rnd2 = new Random();
                redbtn.Size = new Size(25, 25);
                redbtn.Name = "redbtn";
                redbtn.BackColor = Color.Red;
                redbtn.MouseClick += Redbtn_MouseClick;
                redbtn.Location = new Point(rnd2.Next(this.ClientSize.Width - Blg_panel.Width - redbtn.Width), rnd2.Next(this.ClientSize.Height - redbtn.Height));
                this.Controls.Add(redbtn);
            }
            //skor hesaplatma
            if (btn2.Name == "btn_rose")
            {
                score++;
            }
            lbl_puan.Text = score.ToString();
        }
        private void Redbtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (score > 5)
            {
                score -= 5;

            }
            else
            {
                score = 0;
            }
            lbl_puan.Text = score.ToString();
        }
        //SURE
        private void timer_Tick(object sender, EventArgs e)
        {
            sure--;
            lbl_sure.Text = sure.ToString();
            if (sure == 0)
            {
                timer.Stop();
                btn_rose.Enabled = false;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            /* using (SqlConnection connection = new SqlConnection(frm2.SQLConnecitonString))
             {
                 try
                 {
                     decimal urunFiyati = txtÜrünFiyat.Value;
                     connection.Open();
                     SqlCommand cmd = new SqlCommand("INSERT INTO Urunler (UrunAdi, Fiyat) VALUES (@UrunAdi, @Fiyat)", connection);
                     cmd.Parameters.AddWithValue("@UrunAdi", txtÜrünADI.Text.Trim());
                     cmd.Parameters.AddWithValue("@Fiyat", txtÜrünFiyat.Text.Trim());
                     int sonuc = cmd.ExecuteNonQuery();
                     if (sonuc > 0) { MessageBox.Show("KAYIT BAŞARILI"); }
                     else { MessageBox.Show("KAYIT BAŞARISIZ"); }

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
                 }
                 catch (Exception ex)
                 {
                     // Handle exceptions
                     Console.WriteLine("Error: " + ex.Message);
                 }
                 finally
                 {
                     if (connection != null && connection.State != ConnectionState.Closed)
                     {
                         connection.Close();
                     }
                 }
             }
            */
        }
    }
}
