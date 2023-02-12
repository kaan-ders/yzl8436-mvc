using MvcApp.Models;

namespace MvcApp.Servis
{
    public class OracleDatabase : IDatabase
    {
        private int _connection;

        public void OpenConnection(string connectionstring)
        {
            //oracle'a bağlan
            _connection = 1;
        }

        public void CloseConnection()
        {
            //oracle'a bağlantıyı kes
            _connection = 0;
        }

        public bool Ekle(ModelBase model)
        {
            //oracle'a kaydet
            return true;
        }

        public bool Sil(int id)
        {
            //oracle'dan sil
            return true;
        }

        public bool Guncelle(ModelBase model)
        {
            //oracle'dan güncelle
            return true;
        }

        public List<ModelBase> Listele(string sorgu)
        {
            //sorguyu oracle'a gönder sonucu modelbase'e çevir ve dön
            return new List<ModelBase>();
        }

        public ModelBase Getir(int id)
        {
            //ilgili idli kaydı oracle'dan sorgula ve dön
            return null;
        }
    }
}
