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
    public partial class CadastroCliente : ContentPage
    {
        DataContext objContext;
        public CadastroCliente()
        {
            InitializeComponent();
            objContext = new DataContext();
            BindingContext = new Cliente();
        }

        private async void SalvarCliente(object sender, EventArgs e)
        {
            var cliente = (Cliente)BindingContext;

            await objContext.SalvarCliente(cliente);
        }
    }
}