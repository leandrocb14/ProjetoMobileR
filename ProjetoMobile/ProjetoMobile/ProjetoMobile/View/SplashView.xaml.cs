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
	public partial class SplashView : ContentPage
	{
		public SplashView ()
		{
            var absolutLayout = new AbsoluteLayout();
			InitializeComponent ();
            this.BackgroundColor = Color.FromRgb(144, 30, 120);
            this.Content = absolutLayout;
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Application.Current.MainPage = new LoginView();
        }
    }
}