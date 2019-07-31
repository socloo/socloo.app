using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Socloo.Mobile.Controls;
using Socloo.Mobile.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Socloo.Mobile.Pages.AdminPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewSchoolPage : ContentPage
    {
        public ViewSchoolPage()
        {
            InitializeComponent();
            GridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });
            GridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });
            SchoolAdminModel schoolAdmin= new SchoolAdminModel();
            List<SchoolAdminModel> admins = new SchoolAdminsService().GetAll();
            List<TeacherModel> teachers = new List<TeacherModel>();
            string email = "" + Application.Current.Properties["Email"];
            foreach (var admin in admins)
            {

                UserModel user = new UsersService().GetById(admin.UserId);
                if (user.Email.Equals(email))
                {
                    schoolAdmin = admin;
                    break;
                }
            }
            Parallel.ForEach(schoolAdmin.TeachersId, (teacher) =>
            {
                teachers.Add(new TeachersService().GetById(teacher));
            });
            Parallel.For(0, teachers.Count, (i) =>
            {
                UserModel user = new UsersService().GetById(teachers[i].UserId);
                Label fullNameLabel = new Label { Text = user.FullName };
                Label emaiLabel = new Label { Text = "" + user.Email };
                //  GridLayout.RowDefinitions.Add(new RowDefinition{Height = new GridLength(1,GridUnitType.Auto)});
                GridLayout.Children.Add(fullNameLabel, 0, i);
                GridLayout.Children.Add(emaiLabel, 1, i);
            });

            /*  foreach (var teacher in schoolAdmin.TeachersId)
              {
                  teachers.Add(new TeachersService().GetById(teacher));

              }

            for (int i = 0; i < teachers.Count; i++)
            {
                UserModel user = new UsersService().GetById(teachers[i].UserId);
                Label fullNameLabel = new Label { Text = user.FullName };
                Label emaiLabel = new Label { Text = "" + user.Email };
                //  GridLayout.RowDefinitions.Add(new RowDefinition{Height = new GridLength(1,GridUnitType.Auto)});
                GridLayout.Children.Add(fullNameLabel,0,i);
                GridLayout.Children.Add(emaiLabel,1,i);
            }
          */
            //Application.Current.Properties["Email"];

        }
    }
}