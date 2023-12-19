using System.Data.SqlClient;
using DataAL;
using KullanıcıAppModel;
namespace KullaniciİslemBL
{
    public class KullaniciIslemleri
    {
        public bool KullaniciEkle(Kullanıcı k)
        {
            SqlParameter[] p =
           {
           new SqlParameter("@Ad",k.ad),
           new SqlParameter("@Soyad",k.soyad),
           new SqlParameter("@Email",k.email),
           new SqlParameter("@Sifre",k.sifre)
           };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Insert into Uyeler2 Values (@Ad, @Soyad, @Email, @Sifre)", p) > 0;
        }
    }
    public class Adminİşlemleri
    {
        public bool KullaniciEkle(Admin A)
        {
            SqlParameter[] p =
           {
           new SqlParameter("@TC",A.TC),
           new SqlParameter("@AD",A.AD),

           };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Insert into AdminT Values (@TC, @AD)", p) > 0;
        }
    }
}
//ADMİN İÇİN GİRİŞ KATMANLI MİMARİ YAP TC AD SOYADI 