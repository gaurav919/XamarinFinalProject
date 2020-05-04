using System;
using System.IO;
using Xamarin.Forms;
using AwesomeApp.ViewModel;
using System.Collections.Generic;

namespace AwesomeApp
{
    public partial class NoteEntryPage : ContentPage
    {
        

        public NoteEntryPage()
        {
            InitializeComponent();   
        }


        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (BugListViewModel)BindingContext;
            var notes = new List<BugListViewModel>();

            var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                

            File.WriteAllText(filename, note.Name);

            var contact = new BugListViewModel
            {
                Image = "https://i.imgur.com/wrGW7Dz.jpg"

            };
            var secondPage = new MainPage();
            secondPage.BindingContext = contact;


            await Navigation.PushAsync(new MainPage());
        }

       
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {

            var note = (BugListViewModel)BindingContext;

            if (File.Exists(note.Filename))
            {
                File.Delete(note.Filename);
            }

            await Navigation.PushAsync(new MainPage());
        }
        async void OnPestControlledClicked(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new PestControl());
        }
    }
}