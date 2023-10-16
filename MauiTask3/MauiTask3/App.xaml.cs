using MauiTask3.Pages;
namespace MauiTask3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navigationPage = new NavigationPage (new StackLayoutDemo());
            MainPage = navigationPage;
        }
    }
}