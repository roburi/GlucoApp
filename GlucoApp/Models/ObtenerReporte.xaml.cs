using System;
using System.IO;
using GlucoApp.ViewModels;
using Xamarin.Forms;

namespace GlucoApp
{
    public partial class ObtenerReporte : ContentPage
    {
        static SQLiteHelper db;

        public ObtenerReporte()
        {
            InitializeComponent();
        }
        
        public static SQLiteHelper SQLiteDB
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "registros.db3"));
                }
                return db;
            }
        }

        private async void ButtonObtener_Clicked(object sender, EventArgs e)
        {
            var regisList = await SQLiteDB.GetDatosAsync();
            if(regisList != null)
            {
                listaRegi.ItemsSource = regisList;
            }

            await DisplayAlert("qweqwe","ewqewqe","cerrar");
        }
        
    }
}
