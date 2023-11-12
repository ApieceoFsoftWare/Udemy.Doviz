using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udemy.Doviz.Entities;

namespace Udemy.Doviz.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Json_Kurgu_Click(object sender, EventArgs e)
        {
            //Core.BusinessLogicLayer BLL = new Core.BusinessLogicLayer();
            //BLL.KurBilgileriniGuncelle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Core.BusinessLogicLayer BLL = new Core.BusinessLogicLayer();
            BLL.KurBilgileriniGuncelle();
            // Parabirimlerini aldık...
            List<ParaBirimi> ParaBirimleri = BLL.ParaBirimiListesi();
            // Kur bilgilerinin olduğu listeyi aldık
            List<Kur> KurBilgileri = BLL.KurListe();
            // Burada istediğimiz para birimine ait verileri çekerek ilgili LABEL'a atama yapıyoruz...
            Kur Dolar = KurBilgileri.FirstOrDefault(I => I.ParaBirimiID == ParaBirimleri.FirstOrDefault(M => M.Code == "USD").ID);
            label_USD_alis.Text  = Dolar.Alis.ToString("N2");
            label_USD_satis.Text = Dolar.Satis.ToString("N2");
            // Burada istediğimiz para birimine ait verileri çekerek ilgili LABEL'a atama yapıyoruz...
            Kur EURO = KurBilgileri.FirstOrDefault(I => I.ParaBirimiID == ParaBirimleri.FirstOrDefault(M => M.Code == "EUR").ID);
            label_EUR_alis.Text  = EURO.Alis.ToString("N2");
            label_EUR_satis.Text = EURO.Satis.ToString("N2");
            // Burada istediğimiz para birimine ait verileri çekerek ilgili LABEL'a atama yapıyoruz...
            Kur STERLIN = KurBilgileri.FirstOrDefault(I => I.ParaBirimiID == ParaBirimleri.FirstOrDefault(M => M.Code == "GBP").ID);
            label_GBP_alis.Text  = STERLIN.Alis.ToString("N2");
            label_GBP_satis.Text = STERLIN.Satis.ToString("N2");


            // NOT olarak : iç içe sorgularda lambda yapısını kullanırken aynı değişken harfine veya ismina izin vermiyor ...
            // Örnek olarak ...FirstOrDefault("I" => "I".ParaBirimiID == ParaBirimleri.FirstOrDefault("M" => "M".Code == "EUR").ID);
            // Tırnak işareti ile belirttiğim gibi...


            grd_kurGecmis.DataSource = BLL.KurGecmisGoruntule();

        }
    }
}
