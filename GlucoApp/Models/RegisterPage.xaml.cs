using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using GlucoApp.ViewModels;
using Xamarin.Forms;

namespace GlucoApp.Models
{
    public partial class RegisterPage : ContentPage
    {
        public bool tipoD, tipoA, tipoC, tipoPre1, tipoPost1;
        static SQLiteHelper db;
        public RegistroDia regis;
        public RegisterPage()
        {
            tipoD = true;
            tipoA = false;
            tipoC = false;
            tipoPre1 = false;
            tipoPost1 = false;
            InitializeComponent();
           
            

            this.BindingContext = regis;

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

        private async void BtnGuardar_Clicked(object sender, EventArgs e)
        {

            if (ValidarDatosParte1())
            {
                if (ValidarDatosParte2())
                {
                    regis = new RegistroDia()
                    {
                        tipoDesayuno = DesayunoRadioButton.IsChecked,
                        tipoAlmuerzo = AlmuerzoRadioButton.IsChecked,
                        tipoCena = CenaRadioButton.IsChecked,
                        tipoPre = PreRadioButton.IsChecked,
                        tipoPost = PostRadioButton.IsChecked,
                        fecha = DateTime.Now,
                        nivelglucosa = EtiquetaGlucosaSlider.Text
                    };

                    await SQLiteDB.GuardarRegistroAsync(regis);
                    await DisplayAlert("Guardado!!", "Se han guardado los datos", "Cerrar");
                }
            else
            {
                await DisplayAlert("Advertencia!!", "Seleccionar todos los datos", "Cerrar");
            }
            }
            else
            {
                await DisplayAlert("Advertencia!!", "Seleccionar todos los datos", "Cerrar");
            }
        }

        public bool ValidarDatosParte1()
        {
            bool parte1;

            if(DesayunoRadioButton.IsChecked)
            {
                parte1 = true;
                tipoD = true;
            }
            else if(AlmuerzoRadioButton.IsChecked)
            {
                parte1 = true;
                tipoA = true;

            }
            else if(CenaRadioButton.IsChecked)
            {
                parte1 = true;
                tipoC = true;
            }
            else
            {
                parte1 = false;

            }

            return parte1;
        }
        public bool ValidarDatosParte2()
        {
            bool parte2;

            if (PreRadioButton.IsChecked)
            {
                parte2 = true;
                tipoPre1 = true;
                tipoPost1 = false;

            }
            else if (PostRadioButton.IsChecked)
            {
                parte2 = true;
                tipoPost1 = true;
                tipoPre1 = false;
            }
            else
            {
                parte2 = false;
                tipoPost1 = false;

            }

            return parte2;
        }
    }
}
