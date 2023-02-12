using MvcApp.Models;

namespace MvcApp.Servis
{
    public interface IDatabase
    {
        void OpenConnection(string connectionstring);
        void CloseConnection();
        bool Ekle(ModelBase model);
        bool Sil(int id);
        bool Guncelle(ModelBase model);
        List<ModelBase> Listele(string sorgu);
        ModelBase Getir(int id);
    }
}