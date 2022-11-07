using GlucoApp.Models;
using SQLite;

namespace GlucoApp.ViewModels
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;

        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<RegistroDia>().Wait();

        }
    }
}
