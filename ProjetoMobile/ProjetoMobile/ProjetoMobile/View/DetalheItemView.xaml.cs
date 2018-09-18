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
    public partial class DetalheItemView : ContentPage
    {
        public DetalheItemView(Item item)
        {
            InitializeComponent();
            DetalheItemViewModel detalheItemViewModel = new DetalheItemViewModel(item);
            this.BindingContext = detalheItemViewModel;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();            
        }
    }
}