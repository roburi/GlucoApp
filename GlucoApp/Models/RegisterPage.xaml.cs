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
        public bool tipo1Asignada, tipo2Asignada;
        static SQLiteHelper db;
        public RegistroDia regis;
        public RegisterPage()
        {
            InitializeComponent();
            tipo1Asignada = false;
            tipo2Asignada = false;
            regis = new RegistroDia()
            {
                tipo1 = tipo1Asignada,
                tipo2 = tipo2Asignada,
                fecha = DateTime.Now
            };

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
            
            if(ValidarDatosParte1())
            {
                if (ValidarDatosParte2())
                {
                   // await SQLiteHelper.GuardarRegistroAsync(regis);
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
                tipo1Asignada = true;
            }else if(AlmuerzoRadioButton.IsChecked)
            {
                parte1 = true;
                tipo1Asignada = true;
            }
            else if(CenaRadioButton.IsChecked)
            {
                parte1 = true;
                tipo1Asignada = true;
            }
            else
            {
                parte1 = false;
                tipo1Asignada = false;
            }

            return parte1;
        }
        public bool ValidarDatosParte2()
        {
            bool parte2;

            if (PreRadioButton.IsChecked)
            {
                parte2 = true;
                tipo2Asignada = true;

            }
            else if (PostRadioButton.IsChecked)
            {
                parte2 = true;
                tipo2Asignada = true;
            }
            else
            {
                parte2 = false;
                tipo2Asignada = false;
            }

            return parte2;
        }
    }
}
