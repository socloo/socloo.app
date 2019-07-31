using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Socloo.Mobile.Controls;
using Socloo.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Socloo.Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddUserPage : ContentPage
    {
        
        public AddUserPage()
        {
            InitializeComponent();
            PickerRole.Items.Add("Studente");
            PickerRole.Items.Add("Docente");

          
        }
        private async void Button_OnClicked(object sender, EventArgs e)
        {
            bool resultPost = false;
            LoadingText.IsVisible = true;
            activityIndicator.IsVisible = true;
            activityIndicator.IsRunning = true;


            if (name.Text == null || email.Text == null || phone.Text == null)
            {
                await DisplayAlert("Errore", "Nessun campo può essere vuoto", "Ok");
            }
            else
            {
                

                if (PickerRole.SelectedIndex == 0)
                {
                    StudentViewModel student = new StudentViewModel
                    {
                        FullName = name.Text,
                        Email = email.Text,
                        PhoneNumber = phone.Text,
                        CoursesId = new List<string>(),
                        Deleted = false,
                        GroupsId = new List<string>(),
                    };
                    resultPost = await new StudentsService().Post(student);
                }
                else
                {
                    if (PickerRole.SelectedIndex == 1)
                    {
                        TeacherViewModel teacher = new TeacherViewModel
                        {
                            FullName = name.Text,
                            Email = email.Text,
                            PhoneNumber = phone.Text,
                            CoursesId = new List<string>(),
                            Deleted = false,
                            GroupsId = new List<string>(),
                            Subject = new List<string>(),
                        };
                        resultPost = new TeachersService().Post(teacher).Result;
                    }
                }
               
                if (resultPost)
                {
                    await DisplayAlert("Result", "Utente aggiunto", "Ok");
                    email.Text = "";
                    name.Text = "";
                    phone.Text = "";
                   

                }
                else
                {
                    await DisplayAlert("Errore", "Errore Generico", "Ok");
                }
               
            }
            activityIndicator.IsRunning = false;
            activityIndicator.IsVisible = false;
            LoadingText.IsVisible = false;
        }

       
    }
}