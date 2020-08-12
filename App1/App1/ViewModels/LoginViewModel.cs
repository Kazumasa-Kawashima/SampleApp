using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        private bool canLogin;

        public bool CanLogin
        {
            get => canLogin;
            set => SetProperty(ref canLogin, value);
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(_ => LoginImpl(), _ => CanLogin);
        }

        void LoginImpl()
        {
            Application.Current.MainPage = new AppShell();
        }
    }
}
