using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingPage : ContentPage
    {
        public LoadingPage()
        {
            AbsoluteLayout splashLayout = new AbsoluteLayout
            {
                HeightRequest = 600
            };

            var image = new Image()
            {
                Source = "Loading.gif",
                Aspect = Aspect.AspectFill,
            };
            image.Opacity = 0;
             image.FadeTo(1,6000);

            AbsoluteLayout.SetLayoutFlags(image, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(image, new Rectangle(0f, 0f,
             1f, 1f));

            splashLayout.Children.Add(image);

            Content = new StackLayout()
            {
                Children = { splashLayout }
            };
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Delay for a few seconds on the splash screen
            await Task.Delay(8000);

            // Instantiate a NavigationPage with the MainPage
            await Navigation.PushAsync(new DetailPage());
        }

    }
}