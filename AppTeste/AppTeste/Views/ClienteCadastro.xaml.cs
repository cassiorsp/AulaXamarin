using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppTeste.Data;
using AppTeste.Models;
namespace AppTeste.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(ClienteId), nameof(ClienteId))]
    public partial class ClienteCadastro : ContentPage
    {
        //PROPRIEDADE QUE ESTÁ RECEBENDO VALOR DA TELA TODOS CLIENTES
        public int ClienteId {set => CarregaCliente(value);}
        async void CarregaCliente(int id)
        {
            if (id != 0)
            {
                var cliente = (await objContext.TodosClientes()).Where(x => x.Id == id).First();
                BindingContext = cliente;
            }
        }
        DataContext objContext;
        public ClienteCadastro()
        {
            InitializeComponent();
            objContext = new DataContext();
            BindingContext = new Cliente();
        }
        
        private async void SalvarCliente(object sender, EventArgs e)
        {
            var cliente = (Cliente)BindingContext;

            await objContext.SalvarCliente(cliente);
            await Shell.Current.GoToAsync("..");
        }

        private void PegarData(object sender, DateChangedEventArgs e)
        {
            var cliente = (Cliente)BindingContext;

            cliente.DataNascimento = DnCliente.Date;

            BindingContext = cliente;
        }

        private async void DeletarCliente(object sender, EventArgs e)
        {
            var cliente = (Cliente)BindingContext;

            await objContext.DeletarCliente(cliente);
            await Shell.Current.GoToAsync("..");
        }
    }
}