﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Socloo.Mobile.Pages.AdminPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            LoadingText.IsVisible = true;
            activityIndicator.IsVisible = true;
            activityIndicator.IsRunning = true;
             Application.Current.Properties["Email"] = EntryEmail.Text;
            await Navigation.PushModalAsync(new MainAdminPage());
            await Application.Current.SavePropertiesAsync();

        }
    }
}