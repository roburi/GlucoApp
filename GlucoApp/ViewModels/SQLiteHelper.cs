﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GlucoApp.Models;
using SQLite;

namespace GlucoApp.ViewModels
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;

        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<RegistroDia>().Wait();

        }

        public Task <int> GuardarRegistroAsync(RegistroDia registro1)
        {
            if(registro1.id_registro==0)
            {
                return db.InsertAsync(registro1);
            }
            else
            {
                return null;
            }
        }

        public Task<List<RegistroDia>> getDatosAsync()
        {
            return db.Table<RegistroDia>().ToListAsync();
        }
        public Task<RegistroDia> GetRegistroPorDia(DateTime fecha)
        {
            return db.Table<RegistroDia>().Where(a => a.fecha == fecha).FirstOrDefaultAsync();
        }

    }
}