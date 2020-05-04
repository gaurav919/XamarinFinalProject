using AwesomeApp.ViewModel;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
      
        public DetailPage()
        {
            InitializeComponent();
            BindingContext = new BugListViewModel
            {
                Image= "https://i.imgur.com/wrGW7Dz.jpg",
                insectMatch= "Match: Beetle",
                isPest = "Pest: Yes"
            };
          

        }
        async void moreInfoBtn_Clicked(object sender, EventArgs e)
        {
            var contact = new BugListViewModel
            {
                Image = "https://i.imgur.com/wrGW7Dz.jpg"

            };
            var secondPage = new NoteEntryPage();
            secondPage.BindingContext = contact;
            await Navigation.PushAsync(secondPage);
        }


       
    }

}