using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            FullName.Text = "Nome Completo: " + user.FullName;
            Email.Text = "Email: " + user.Email;
            PhoneNumber.Text = "Numero di Telefono: " + user.PhoneNumber;
            Bio.Text = "Bio: "+user.Bio;
            if (user.ProfilePictureId.Equals("5d286be132b90e35642c96db"))
            {
                ProfileImage= new Image{Source = "defaultProfilePic.png" };
            }
        }

    }
}