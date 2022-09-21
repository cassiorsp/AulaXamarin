using System;
using SQLite;

namespace AppTeste.Models
{
   public class Notas
    {
        //public string Filename { get; set; }
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [MaxLength(500), NotNull]
        public string Texto { get; set; }
        [NotNull]
        public DateTime Data { get; set; }
    }
}
