using System;
using System.Collections.Generic;
using GlucoApp.ViewModels;
using Xamarin.Forms;
using System.IO;

namespace GlucoApp
{
    public partial class CarouselPagqUno : CarouselPage
    {
        static SQLiteHelper db;

        public CarouselPagqUno()
        {
            InitializeComponent();
        }

        public static SQLiteHelper SQLiteDB
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"registros.db3"));
                }
                return db;
            }
        }

        private async void navigationToregister(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Models.RegisterPage());
        }
        private async void navigationTogetReporte(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ObtenerReporte());
        }

    }
}
