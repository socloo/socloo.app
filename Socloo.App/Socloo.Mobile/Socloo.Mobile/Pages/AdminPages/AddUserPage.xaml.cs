using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
        private void Button_OnClicked(object sender, EventArgs e)
        {
            bool resultPost = false;
            if (name.Text == null || email.Text == null || phone.Text == null)
            {
                DisplayAlert("Errore", "Nessun campo può essere vuoto", "Ok");
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
                    resultPost = new StudentsController().Post(student);
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
                        resultPost = new TeachersController().Post(teacher);
                    }
                }
               
                if (resultPost)
                {
                    DisplayAlert("Result", "Utente aggiunto", "Ok");
                    email.Text = "";
                    name.Text = "";
                    phone.Text = "";

                }
                else
                {
                    DisplayAlert("Errore", "Errore Generico", "Ok");
                }

            }

        }
    }
}