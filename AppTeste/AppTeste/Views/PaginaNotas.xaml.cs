using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppTeste.Models;
using System.IO;
using AppTeste.Data;

namespace AppTeste.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaNotas : ContentPage
    {
        DataContext objContext;
        public PaginaNotas()
        {
            InitializeComponent();
            objContext = new DataContext();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            
            var notes = await objContext.TodasNotas();
            
            collectionView.ItemsSource = notes.OrderBy(d => d.Data).ToList();
        }

        async void OnAddClicked(object sender, EventArgs e)
        {
            // Navigate to the NoteEntryPage, without passing any data.
            await Shell.Current.GoToAsync(nameof(CadastroNota));
        }

        //async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (e.CurrentSelection != null)
        //    {
        //        // Navigate to the NoteEntryPage, passing the filename as a query parameter.
        //        Notas note = (Notas)e.CurrentSelection.FirstOrDefault();
        //        await Shell.Current.GoToAsync($"{nameof(NoteEntryPage)}?{nameof(NoteEntryPage.ItemId)}={note.Filename}");
        //    }
        //}
    }
}

