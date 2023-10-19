using MauiTask6.Pages;

namespace MauiTask6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EmployeeListPage());
        }
    }
}