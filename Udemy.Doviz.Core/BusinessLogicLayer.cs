﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
                    ID          = reader.IsDBNull(0) ? Guid.Empty   : reader.GetGuid(0),
                    Code        = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    Tanim       = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    UyariLimit  = reader.IsDBNull(3) ? 0            : reader.GetDecimal(3)
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
                    ID              = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    ParaBirimiID    = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                    Satis           = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                    Alis            = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    Degisim         = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    d_oran          = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5),
                    d_yon           = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                    OlusturmaTarihi = reader.IsDBNull(7) ? DateTime.MinValue : reader.GetDateTime(7)
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
                    Degisim = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    d_oran = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5),
                    d_yon = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                    OlusturmaTarihi = reader.IsDBNull(7) ? DateTime.MinValue : reader.GetDateTime(7)
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
        public void KurKayitEkle(Guid ID, Guid ParaBirimiID, string Satis, string Alis, string Degisim, string d_oran, string d_yon, DateTime OlusturmaTarihi)
        {
       
            if (ID != Guid.Empty 
                && ParaBirimiID != Guid.Empty
                && Satis != string.Empty
                && Alis != string.Empty
                && Degisim != string.Empty
                && d_oran != string.Empty   
                && d_yon != string.Empty
                && OlusturmaTarihi > DateTime.MinValue)
            {
                DLL.KurKayitEkle(new Kur()
                {
                    ID = ID,
                    ParaBirimiID = ParaBirimiID,
                    Satis = decimal.Parse(Satis, CultureInfo.InvariantCulture),
                    Alis = decimal.Parse(Alis,CultureInfo.InvariantCulture),
                    Degisim = decimal.Parse(Degisim, CultureInfo.InvariantCulture),
                    d_oran = decimal.Parse(d_oran, CultureInfo.InvariantCulture),
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
            // Videoda anlatılan API'dan gelen veriler array şeklinde olduğu için ve o api artık olmadığı için biz burada daha farklı bir yoldan devam edeceğiz..
            // Aşağıdaki kullanımı incelemenizi ve debug atıp verilerin nasıl geldiğini görmenizi tavsiye ederim.
            List<KeyValuePair<string, JsonDataType>> DovizKurBilgileri = JsonConvert.DeserializeObject<Dictionary<string, JsonDataType>>(JsonDataTxt).ToList();

            List<ParaBirimi> ParaBirimiListe = ParaBirimiListesi();

            for (int i = 0; i < ParaBirimiListe.Count; i++)
            {
                JsonDataType BulunanKur = DovizKurBilgileri.FirstOrDefault(I => I.Key == ParaBirimiListe[i].Code).Value;
                KurKayitEkle(Guid.NewGuid(),
                            ParaBirimiListe[i].ID,
                            BulunanKur.satis,
                            BulunanKur.alis,
                            BulunanKur.degisim,
                            BulunanKur.d_oran,
                            BulunanKur.d_yon,
                            DateTime.Now
                            );
                if(decimal.Parse(BulunanKur.satis) <= ParaBirimiListe[i].UyariLimit && ParaBirimiListe[i].UyariLimit != 0)
                {
                    // Buradaki if şartı true olduğu zaman email göndereceğiz...
                    ControlException(() =>
                    {
                        EmailGonder(BulunanKur, ParaBirimiListe[i]);
                    });
                }

            }

            //foreach (var item in ParaBirimiListe)
            //{
            //    JsonDataType foundData = dovizKurlari.FirstOrDefault(I => I.Key == item.Code).Value;
            //}
            //JsonDataType DovizKurBilgileri = JsonConvert.DeserializeObject<JsonDataType>(JsonDataTxt);

        }

        public DataTable KurGecmisGoruntule()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Doviz Tanım",        typeof(string));
            dataTable.Columns.Add("Doviz Kod",          typeof(string));
            dataTable.Columns.Add("Satış",              typeof(string));
            dataTable.Columns.Add("Alış",               typeof(string));
            dataTable.Columns.Add("Oluşturma Tarihi",   typeof(string));

            List<KurGecmis> KurGecmisList = KurGecmisListe();
            List<ParaBirimi> ParaBirimList = ParaBirimiListesi();

            for (int i = 0; i < KurGecmisList.Count; i++)
            {
                dataTable.Rows.Add(
                    ParaBirimList.FirstOrDefault(I => I.ID == KurGecmisList[i].ParaBirimiID).Tanim,
                    ParaBirimList.FirstOrDefault(I => I.ID == KurGecmisList[i].ParaBirimiID).Code,
                    KurGecmisList[i].Satis,
                    KurGecmisList[i].Alis,
                    KurGecmisList[i].OlusturmaTarihi.ToString("dd.MM.yyyy hh:mm")
                    );
            }

            return dataTable;
        }
        private void EmailGonder(JsonDataType dataType, ParaBirimi ParaBirimi)
        {
            // Buraya yazacağımız kodlar ile alakalı bilgileri github adresimdeki repolar içerisinden bulabilirsiniz. 
            // Kolay ulaşım için link : https://github.com/ApieceoFsoftWare/ObservingEmailOperations

            // Gmail Hesap Bilgileri
            string username = "ozcanozanberkay@gmail.com";
            string password = "..."; // Google App Şifresi 

            // SMTP İstemci Oluşturma ve Ayarlama
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(username, password)
            };

            // Gönderici ve alıcı e-posta adresleri
            string fromEmail    = "ozcanozanberkay@gmail.com";
            string toEmail      = "ozanberkay34@gmail.com";
            
            // E-posta ileti oluşturma
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(fromEmail);
            mail.To.Add(toEmail);
            mail.Subject = $"{ParaBirimi.Tanim} - ${ParaBirimi.UyariLimit} Değerinize ulaştı!";
            mail.Body = $"{ParaBirimi.Tanim} - {ParaBirimi.UyariLimit} değerine {DateTime.Now.ToString()} tarihinde ulaştı! Alım yapabilirsiniz.";
            mail.IsBodyHtml = true;

            // Attachment ile mail gönderme, bunun için file name girmeniz gerekir. Ben bunu yorum satırı olarak bırakacağım gerisi size kalmış...
            //mail.Attachments.Add(new Attachment(@"PutYourFileLocation"));

            // E-posta iletilerini gönderme
            smtp.Send(mail);
        }
    }
}
