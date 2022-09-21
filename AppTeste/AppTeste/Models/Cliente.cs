using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppTeste.Models
{
   public class Cliente
    {
        [PrimaryKey, AutoIncrement ]
        public int Id { get; set; }
        [MaxLength(100),NotNull]
        public string Nome { get; set; }
        [NotNull]
        public DateTime DataNascimento { get; set; }
        [NotNull]
        public string Uf { get; set; }
        [NotNull]
        public string Cidade { get; set; }
        [NotNull]
        public string Bairro { get; set; }
        [NotNull]
        public string Rua { get; set; }
        [NotNull]
        public string Numero { get; set; }
    }
}
