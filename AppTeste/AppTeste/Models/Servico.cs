using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace AppTeste.Models
{
    public class Servico
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
    }
}
