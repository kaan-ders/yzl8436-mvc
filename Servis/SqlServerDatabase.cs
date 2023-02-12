using MvcApp.Models;

namespace MvcApp.Servis
{
    public class SqlServerDatabase : IDatabase
    {
        private int _connection;

        public void OpenConnection(string connectionstring)
        {
            //sql server'a bağlantı aç
            _connection = 1;
        }

        public void CloseConnection()
        {
            //sql server'a bağlantı kapat
            _connection = 0;
        }

        public bool Ekle(ModelBase model)
        {
            //sql server'a kaydet
            return true;
        }

        public bool Sil(int id)
        {
            //sql serverdan sil
            return true;
        }

        public bool Guncelle(ModelBase model)
        {
            //sql serverdan güncelle
            return true;
        }

        public List<ModelBase> Listele(string sorgu)
        {
            //sorguyu sql servera gönder sonucu modelbase'e çevir ve dön
            return new List<ModelBase>();
        }

        public ModelBase Getir(int id)
        {
            //ilgili idli kaydı sql serverdan sorgula ve dön
            return null;
        }

        public void Ac()
        {

        }
    }
}
