using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GlucoApp
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BtnGuardar.Clicked += BtnGuardar_Clicked;
        }

        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            
            throw new NotImplementedException();
        }
    }
}
