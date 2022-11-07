using System;
using SQLite;
namespace GlucoApp.Models
{
    public class RegistroDia
    { 
      [PrimaryKey,AutoIncrement]
      //Llave primaria
      public int id_registro { get; set; }

      //Desayuno, comida y cena
        public Boolean tipoDesayuno { get; set; }
        public Boolean tipoAlmuerzo { get; set; }
        public Boolean tipoCena { get; set; }

      //Pre y post
        public Boolean tipoPre { get; set; }
        public Boolean tipoPost { get; set; }

      //fecha de registro
        public DateTime fecha { get; set; }

      //Nivel de glucosa
        public string nivelglucosa { get; set; }
    }
}
