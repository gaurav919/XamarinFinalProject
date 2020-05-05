using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.IO;
using AwesomeApp.ViewModel;

namespace AwesomeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        // public static string FolderPath { get; private set; }
        public ObservableCollection<AwesomeApp.ViewModel.BugListViewModel> notes { get; set; }
        public MainPage()
        {
            InitializeComponent();


            notes = new ObservableCollection<ViewModel.BugListViewModel>();
            
            //lstView.ItemsSource = spottedBugs;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //var notes = new List<BugListViewModel>();
            notes.Add(new ViewModel.BugListViewModel { Name = "Paper Wasp", Location = "front porch", Image = "paperwasp.jpg" });
            notes.Add(new ViewModel.BugListViewModel { Name = "Deer Tick", Location = "back yard", Image = "deertick.jpg" });
            notes.Add(new ViewModel.BugListViewModel { Name = "Pavement Ant", Location = "driveway", Image = "pavementant.jpg" });
            notes.Add(new ViewModel.BugListViewModel { Name = "Wolf Spider", Location = "LIVING ROOM!!", Image = "wolfspider.jpg" });
            notes.Add(new ViewModel.BugListViewModel { Name = "Yellow Jacket", Location = "garage", Image = "yellowjacket.jpg" });
            notes.Add(new ViewModel.BugListViewModel { Name = "Japanese Beetle", Location = "walking trail", Image = "japbeetles.jpg" });
            notes.Add(new ViewModel.BugListViewModel { Name = "Fisher Spider", Location = "walking trail pond", Image = "fishspider.jpg" });
            var files = Directory.EnumerateFiles(App.FolderPath, "*.notes.txt");
           
           
                    
            foreach (var filename in files)
            {
                notes.Add(new BugListViewModel
                {
                    Filename = filename,
                    Name = File.ReadAllText(filename),
                    spottedDate = File.GetCreationTime(filename),
                    Image = "https://i.imgur.com/wrGW7Dz.jpg",
                  
                });
            }
            


            lstView.ItemsSource = notes.OrderBy(d => d.spottedDate).ToList();
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new NoteEntryPage
                {
                    BindingContext = e.SelectedItem
                    as BugListViewModel
                });
            }
        }
        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            
            await Navigation.PopToRootAsync();
        }
    }
}
