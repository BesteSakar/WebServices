using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcKimlikDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {




            /*
             
            Web Servisler HTTP protokolunu kullanarak hizmet sağlarlar.
            İstemci yani client istek atar ve bir geri dönüş gerçekleşir.
            Bu geri dönüşte kullanılan servise göre XML,JSON VB yapılar kullanılır.
            Bilgi lisverisi sağlanmış olur.
            Burada textboxlar üzerinden girilen veriler alınıp sorgulama yapılır ve geri dous tip olarak true ya da
            false olan bool bir deger dondurduk.. */














            long kimlikNo = long.Parse(txt_tc.Text);
            int yil = int.Parse(txt_yil.Text);
            bool durum;

            try
            {
                using (TcDogrula.KPSPublicSoapClient service = new TcDogrula.KPSPublicSoapClient { })
                {
                    durum = service.TCKimlikNoDogrula(kimlikNo, txt_isim.Text, txt_soyisim.Text, yil);
                }
            }

            catch (Exception)
            {
                throw;
            }

            MessageBox.Show(durum.ToString());





        }
    }
}
