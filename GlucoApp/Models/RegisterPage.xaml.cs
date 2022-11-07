using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GlucoApp.Models
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();

        }

        private async void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            if(false)
            {

            }
            else
            {
                await DisplayAlert("Advertencia!!", "Seleccionar todos los datos", "Cerrar");
            }
        }
    }
}
