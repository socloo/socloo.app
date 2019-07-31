using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FFImageLoading.Forms;
using Socloo.Mobile.Controls;
using Socloo.Mobile.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Socloo.Mobile.Pages.AdminPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileAdminPage : ContentPage
    {
        public ProfileAdminPage()
        {
            InitializeComponent();
            List<UserModel> users = new UsersService().GetAll();
            UserModel user = new UserModel();
            foreach (var u in users)
            {
                if (u.Email.Equals(Application.Current.Properties["Email"]))
                {
                    user = u;
                    break;
                }
            }

            FullName.Text = "Nome Completo: \n" + user.FullName;
            Email.Text = "Email: \n" + user.Email;
            PhoneNumber.Text = "Numero di Telefono: \n" + user.PhoneNumber;
            Bio.Text = "Bio: \n"+user.Bio;

            FullName.HorizontalTextAlignment = TextAlignment.Center;
            Email.HorizontalTextAlignment = TextAlignment.Center;
            PhoneNumber.HorizontalTextAlignment = TextAlignment.Center;
            Bio.HorizontalTextAlignment = TextAlignment.Center;
            //if (user.ProfilePictureId.Equals("5d286be132b90e35642c96db"))
            //{
            //    ProfileImage= new Image{Source = "defaultProfilePic.png" };
            //}
        }

    }
}