
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Splash : ContentPage
    {
        public Splash()
        {
            AbsoluteLayout splashLayout = new AbsoluteLayout
            {
                HeightRequest = 600
            };

            var image = new Image()
            {
                Source = "Army.jpg",
                Aspect = Aspect.AspectFill,
            };

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
            await Task.Delay(6000);

            // Instantiate a NavigationPage with the MainPage
            var navPage = new NavigationPage(new HomePage()
            );
            Application.Current.MainPage = navPage;
        }
    }
    
}