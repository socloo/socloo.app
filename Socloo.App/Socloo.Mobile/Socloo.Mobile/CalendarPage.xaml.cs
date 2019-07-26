using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Socloo.Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarPage : ContentPage
    {
        public CalendarPage()
        {
            InitializeComponent();


        }
        public void showEvent(DateTime dat)
        {
            try
            {
                date.Text = dat.ToString();
            }
            catch (Exception e)
            {

            }
        }
    }
}