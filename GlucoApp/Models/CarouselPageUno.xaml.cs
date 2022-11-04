using System;
using System.Collections.Generic;

using Xamarin.Forms;

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
            await Navigation.PushAsync(new RegisterPage());
        }
        private async void navigationTogetReporte(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ObtenerReporte());
        }

    }
}
