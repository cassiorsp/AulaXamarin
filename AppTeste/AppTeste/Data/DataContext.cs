using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;
using AppTeste.Models;
using System.Threading.Tasks;

namespace AppTeste.Data
{
    public class DataContext
    {
        readonly SQLiteAsyncConnection sqliteConn;
        public DataContext()
        {
            var caminho = Path.Combine(App.FolderPath, "DbNotas");
            sqliteConn = new SQLiteAsyncConnection(caminho);
            sqliteConn.CreateTableAsync<Notas>().Wait();
            //CRIA A TABELA CASO NÃO EXISTA...
            sqliteConn.CreateTableAsync<Cliente>().Wait();
        }
        #region ---------------------Notas---------------------
        public Task<List<Notas>> TodasNotas()
        {
            return sqliteConn.Table<Notas>().ToListAsync();
        }

        public Task<int> SalvarNota(Notas nota)
        {
            return sqliteConn.InsertAsync(nota);
        }
        #endregion
        #region ---------------------Clientes---------------------
        public Task<List<Cliente>> TodosClientes()
        {
            return sqliteConn.Table<Cliente>().ToListAsync();
        }
        public Task<int> SalvarCliente(Cliente cliente)
        {
            if (cliente.Id == 0)
            {
                return sqliteConn.InsertAsync(cliente);
            }
            else
            {
                return sqliteConn.UpdateAsync(cliente);
            }

        }

        public Task<int> DeletarCliente(Cliente cliente)
        {

            return sqliteConn.DeleteAsync(cliente);

        }

        #endregion
    }
}

