using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Doviz.Entities;

namespace Udemy.Doviz.Core
{
    public class DatabaseLogicLayer : BaseClass
    {
        SqlConnection   _connection;
        SqlCommand      _command;
        SqlDataReader   _reader;
        string MachineName = Environment.MachineName;

        public DatabaseLogicLayer()
        {   // Bu Bağlantı metodu local veritabanı için geçerlidir. Değiştirmek istersen değiştirebilirsin :D
            _connection = new SqlConnection($"Server={MachineName}\\SQLEXPRESS; Initial Catalog = UdemyDoviz; Integrated Security = True");
        }
        public void ConnectionOperation()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
            else
            {
                _connection.Open();
            }
        }
        public SqlDataReader ParaBirimiListesi()
        {
            ControlException(() =>
            {
                _command = new SqlCommand("SELECT * FROM ParaBirimi", _connection);
                ConnectionOperation();
                _reader = _command.ExecuteReader();
            });
            return _reader;
        }
        public SqlDataReader KurListe()
        {
            ControlException(() =>
            {
                _command = new SqlCommand("SELECT * FROM Kur", _connection);
                ConnectionOperation();
                _reader = _command.ExecuteReader();
            });
            return _reader;
        }
        public SqlDataReader KurListe(Guid ParaBirimiID)
        {
            ControlException(() =>
            {
                _command = new SqlCommand("SELECT * FROM Kur WHERE ParaBirimiID = @ParaBirimiID", _connection);
                _command.Parameters.Add("@ParaBirimiID", SqlDbType.UniqueIdentifier).Value = ParaBirimiID;
                ConnectionOperation();
                _reader = _command.ExecuteReader();
            });
            return _reader;
        }
        public SqlDataReader KurGecmisListe()
        {
            ControlException(() =>
            {
                _command = new SqlCommand("SELECT * FROM KurGecmis");
                ConnectionOperation();
                _reader = _command.ExecuteReader();
            });
            return _reader;
        }
        public SqlDataReader KurGecmisListe(Guid ParaBirimiID)
        {
            ControlException(() =>
            {
                _command = new SqlCommand("SELECT * FROM KurGecmis WHERE ParaBirimiID = @ParaBirimiID", _connection);
                _command.Parameters.Add("@ParaBirimiID", SqlDbType.UniqueIdentifier).Value = ParaBirimiID;
                ConnectionOperation();
                _reader = _command.ExecuteReader();
            });
            return _reader;
        }
        public void KurKayitEkle(Kur kur)
        {
            ControlException(() =>
            {
                _command = new SqlCommand("KurKayitEkle", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@ID",              SqlDbType.UniqueIdentifier).Value = kur.ID;
                _command.Parameters.Add("@KurID",           SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
                _command.Parameters.Add("@ParaBirimiID",    SqlDbType.UniqueIdentifier).Value = kur.ParaBirimiID;
                _command.Parameters.Add("@Satis",           SqlDbType.Decimal).Value = kur.Satis;
                _command.Parameters.Add("@Alis",            SqlDbType.Decimal).Value = kur.Alis;
                _command.Parameters.Add("@Degisim",         SqlDbType.Decimal).Value = kur.d_oran;
                _command.Parameters.Add("@d_oran",          SqlDbType.Decimal).Value = kur.d_oran;
                _command.Parameters.Add("@d_yon",           SqlDbType.NVarChar).Value = kur.d_yon;
                _command.Parameters.Add("@OlusturmaTarihi", SqlDbType.DateTime).Value = kur.OlusturmaTarihi;

                ConnectionOperation();
                _command.ExecuteNonQuery();
            });
                ConnectionOperation();
        }
    }
}
