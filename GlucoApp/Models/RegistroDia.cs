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
      public Boolean tipo1 { get; set; }
      //Pre y post
      public Boolean tipo2 { get; set; }
      //fecha de registro
      [MaxLength(50)]
      public DateTime fecha { get; set; }
      //Nivel de glucosa
      public int nivelglucosa { get; set; }

    }
}
