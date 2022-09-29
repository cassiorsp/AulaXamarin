using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppTeste.Models;
using AppTeste.Data;

namespace AppTeste.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //[QueryProperty(nameof(ItemId), nameof(ItemId))]
    public partial class CadastroNota : ContentPage
    {
        DataContext objContext;
        //public string ItemId
        //{
        //    set => LoadNote(value);
        //}
        public CadastroNota()
        {
            InitializeComponent();
            objContext = new DataContext();
            // Set the BindingContext of the page to a new Note.
            BindingContext = new Notas();
        }
        //void LoadNote(string filename)
        //{
        //    try
        //    {
        //        // Retrieve the note and set it as the BindingContext of the page.
        //        Notas note = new Notas
        //        {
        //            Filename = filename,
        //            Texto = File.ReadAllText(filename),
        //            Data = File.GetCreationTime(filename)
        //        };
        //        BindingContext = note;
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Failed to load note.");
        //    }
        //}
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var nota = (Notas)BindingContext;

            nota.Data = DateTime.Now;
            await objContext.SalvarNota(nota);

            await Shell.Current.GoToAsync("..");
        }

        //async private void OnDeleteButtonClicked(object sender, EventArgs e)
        //{
        //    var note = (Notas)BindingContext;

        //    // Delete the file.
        //    if (File.Exists(note.Filename))
        //    {
        //        File.Delete(note.Filename);
        //    }

        //    // Navigate backwards
        //    await Shell.Current.GoToAsync("..");
        //}


    }
}