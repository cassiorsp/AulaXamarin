using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTeste.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServicoBuscar : ContentPage
    {
        public ServicoBuscar()
        {
            InitializeComponent();
        }

        private async void CadastrarServico(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ServicoCadastro));
        }

        private void ItemSelecionado(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}