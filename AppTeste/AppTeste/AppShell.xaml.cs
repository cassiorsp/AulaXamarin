using AppTeste.Views;
using Xamarin.Forms;

namespace AppTeste
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CadastroNota), typeof(CadastroNota));
            Routing.RegisterRoute(nameof(ClienteCadastro), typeof(ClienteCadastro));
            Routing.RegisterRoute(nameof(ServicoCadastro), typeof(ServicoCadastro));
        }
    }
}
