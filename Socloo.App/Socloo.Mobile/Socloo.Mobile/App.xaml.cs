using System;
using Socloo.Mobile.Pages.AdminPages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Socloo.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainAdminPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
