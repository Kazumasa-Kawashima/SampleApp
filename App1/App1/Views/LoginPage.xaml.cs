using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginViewModel viewModel;

        public LoginPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new LoginViewModel();
        }

        private void Password_Entry(object sender, EventArgs e)
        {
            viewModel.CanLogin = !string.IsNullOrEmpty((sender as Entry).Text);
            LoginButton.IsEnabled = viewModel.CanLogin;
        }
    }
}