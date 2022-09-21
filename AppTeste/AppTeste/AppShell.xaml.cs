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
            Routing.RegisterRoute(nameof(CadastroNota), typeof(CadastroNota));
        }

    }
}
