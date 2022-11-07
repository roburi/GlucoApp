using System;
using System.Collections.Generic;
using GlucoApp.ViewModels;
using Xamarin.Forms;
using System.IO;

namespace GlucoApp
{
    public partial class CarouselPagqUno : CarouselPage
    {

        public CarouselPagqUno()
        {
            InitializeComponent();
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
