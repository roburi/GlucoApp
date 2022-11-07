using System;
using System.Collections.Generic;
using GlucoApp.ViewModels;
using Xamarin.Forms;

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
                    db = new SQLiteHelper(P)
                }
            }
        }

        private async void navigationToregister(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
        private async void navigationTogetReporte(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ObtenerReporte());
        }

    }
}
