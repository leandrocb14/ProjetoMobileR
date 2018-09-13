using ProjetoMobile.Model;
using ProjetoMobile.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoMobile.View
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<ArgumentException>(this, "FalhaLogin", (msg) =>
            {
                DisplayAlert("Login", msg.Message, "OK");
            });            
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<ArgumentException>(this, "FalhaLogin");
            MessagingCenter.Unsubscribe<Login>(this, "SucessoLogin");
        }
    }
}