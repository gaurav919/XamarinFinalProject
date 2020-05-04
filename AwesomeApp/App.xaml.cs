
using System;
using System.IO;
using Xamarin.Forms;


namespace AwesomeApp
{
    public partial class App : Application
    {
        public static string FolderPath { get; private set; }

        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new HomePage());
            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
        }
        // ...
    }
}