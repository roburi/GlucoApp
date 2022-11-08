using System;
using System.Collections.Generic;
using System.IO;
using GlucoApp.ViewModels;
using Microcharts.Forms;
using Xamarin.Forms;

namespace GlucoApp
{
    public partial class ObtenerReporte : ContentPage
    {
        static SQLiteHelper db;
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
        public ObtenerReporte()
        {
            InitializeComponent();
        }
    }
}
