using System;
using todo_list_app.Services;
using todo_list_app.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace todo_list_app
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
