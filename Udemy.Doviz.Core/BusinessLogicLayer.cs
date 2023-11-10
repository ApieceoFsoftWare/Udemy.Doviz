using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Udemy.Doviz.Entities;

namespace Udemy.Doviz.Core
{
    public class BusinessLogicLayer : BaseClass
    {
        DatabaseLogicLayer DLL;

        public BusinessLogicLayer()
        {
            DLL = new DatabaseLogicLayer();
        }

        public List<ParaBirimi> ParaBirimiListesi()
        {
            List<ParaBirimi> ParaBirimleri = new List<ParaBirimi>();
            SqlDataReader reader = DLL.ParaBirimiListesi();
            while (reader.Read())
            {
                ParaBirimleri.Add(new ParaBirimi()
                {
                    ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    Code = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    Tanim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    UyariLimit = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3)
                });
            }
            reader.Close();
            DLL.ConnectionOperation();

            return ParaBirimleri;
        }

        public List<Kur> KurListe()
        {
            List<Kur> KurDegerleri = new List<Kur>();

            SqlDataReader reader = DLL.KurListe();
            while (reader.Read())
            {
                KurDegerleri.Add(new Kur()
                {
                    ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    ParaBirimiID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                    Satis = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                    Alis = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    d_oran = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    d_yon = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                    OlusturmaTarihi = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6)
                });
            }
            reader.Close();
            DLL.ConnectionOperation();

            return KurDegerleri;
        }
        public Kur KurListe(Guid ParaBirimiID)
        {
            Kur kur = new Kur();

            SqlDataReader reader = DLL.KurListe();
            while (reader.Read())
            {
                kur = new Kur()
                {
                    ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    ParaBirimiID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                    Satis = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                    Alis = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    d_oran = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    d_yon = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                    OlusturmaTarihi = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6)
                };
            }
            reader.Close();
            DLL.ConnectionOperation();

            return kur;
        }
        public List<KurGecmis> KurGecmisListe()
        {
            List<KurGecmis> KurGecmisListe = new List<KurGecmis>();
            SqlDataReader reader = DLL.KurGecmisListe();
            while (reader.Read())
            {
                KurGecmisListe.Add(new KurGecmis()
                {
                    ID              = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    KurID           = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                    ParaBirimiID    = reader.IsDBNull(2) ? Guid.Empty : reader.GetGuid(2),
                    Satis           = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    Alis            = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    Degisim         = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5),
                    d_oran          = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6),
                    d_yon           = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                    OlusturmaTarihi = reader.IsDBNull(8) ? DateTime.MinValue: reader.GetDateTime(8)
                });
            }
            reader.Close();
            DLL.ConnectionOperation();

            return KurGecmisListe;
        }
        public List<KurGecmis> KurGecmisListe(Guid ParaBirimiID)
        {
            List<KurGecmis> KurGecmisListe = new List<KurGecmis>();
            SqlDataReader reader = DLL.KurGecmisListe(ParaBirimiID);
            while (reader.Read())
            {
                KurGecmisListe.Add(new KurGecmis()
                {
                    ID              = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    KurID           = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                    ParaBirimiID    = reader.IsDBNull(2) ? Guid.Empty : reader.GetGuid(2),
                    Satis           = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    Alis            = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    Degisim         = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5),
                    d_oran          = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6),
                    d_yon           = reader.IsDBNull(7) ? string.Empty : reader.GetString(7), 
                    OlusturmaTarihi = reader.IsDBNull(8) ? DateTime.MinValue : reader.GetDateTime(8)
                });
            }   
            reader.Close();
            DLL.ConnectionOperation();
            return KurGecmisListe;
        }
        public void KurKayitEkle(Guid ID, Guid ParaBirimiID, decimal Satis, decimal Alis, decimal Degisim, decimal d_oran, string d_yon, DateTime OlusturmaTarihi)
        {
            if(ID != Guid.Empty 
                && ParaBirimiID != Guid.Empty 
                && Satis != 0
                && Alis != 0
                && Degisim != 0
                && d_oran != 0
                && d_yon != string.Empty
                && OlusturmaTarihi > DateTime.MinValue)
            {
                DLL.KurKayitEkle(new Kur()
                {
                    ID = ID,
                    ParaBirimiID = ParaBirimiID,
                    Satis = Satis,
                    Alis = Alis,
                    Degisim = Degisim,
                    d_oran = d_oran,
                    d_yon = d_yon,
                    OlusturmaTarihi = OlusturmaTarihi
                });
            }
            else
            {
                // Ekleme işlemini gerçekleştiremediğimiz case...
            }
        }

        public void KurBilgileriniGuncelle()
        {
            WebClient webClient = new WebClient();
            string JsonDataTxt = webClient.DownloadString("https://api.genelpara.com/embed/doviz.json");
            JsonDataType DovizKurBilgileri = JsonConvert.DeserializeObject<JsonDataType>(JsonDataTxt);
            Console.WriteLine(DovizKurBilgileri);
        }
    }
}
