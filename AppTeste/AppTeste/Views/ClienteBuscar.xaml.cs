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
    public partial class ClienteBuscar : ContentPage
    {
        private DataContext objContext;
        public ClienteBuscar()
        {
            InitializeComponent();
            objContext = new DataContext();
            BindingContext = new Cliente();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var Clientes = await objContext.TodosClientes();
            BindingContext = Clientes;
            collectionCliente.ItemsSource = Clientes;
        }
        private async void CadastrarCliente(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ClienteCadastro));
        }

        private async void ItemSelecionado(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                var cliente = (Cliente)e.CurrentSelection[0];
                await Shell.Current.GoToAsync($"{nameof(ClienteCadastro)}?{nameof(ClienteCadastro.ClienteId)}={cliente.Id}");
            }
        }
    }
}