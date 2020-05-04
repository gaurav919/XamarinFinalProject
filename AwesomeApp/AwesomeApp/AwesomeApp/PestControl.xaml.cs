using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Xamarin.Forms.Maps;
using Map = Xamarin.Forms.Maps.Map;

namespace AwesomeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PestControl : ContentPage
    {
        public PestControl()
        {
            InitializeComponent();
           

        }
        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
    
}