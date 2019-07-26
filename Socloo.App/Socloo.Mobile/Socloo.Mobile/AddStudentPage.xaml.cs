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
    public partial class AddStudentPage
    {
        public AddStudentPage()
        {
            InitializeComponent();

        }

        private void Button_OnClicked(object sender, EventArgs e)
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
            
            var resultPost = new StudentsController().Post(student);
            if (resultPost)
            {
                DisplayAlert("result", "Studente aggiunto","Okay cool");
                email.Text = "";
                name.Text = "";
                phone.Text = "";

            }
            else
            {
                result.Text = "Errore";
            }
            
        }
        
    }
}