using ProjetoMobile.DAO;
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
    public partial class MasterView : ContentPage
    {
        public MasterViewModel MasterViewModel { get; set; }
        public MasterView()
        {
            InitializeComponent();
            this.MasterViewModel = new MasterViewModel();
            this.BindingContext = MasterViewModel;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();            
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();            
        }
    }
}