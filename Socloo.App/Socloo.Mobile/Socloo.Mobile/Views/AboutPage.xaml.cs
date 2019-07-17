using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using SoclooAPI.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Web.Helpers;

namespace Socloo.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

                Content = new Label {Text = "" };

        }

    }
}