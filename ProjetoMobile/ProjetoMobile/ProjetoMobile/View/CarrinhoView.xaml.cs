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
	public partial class CarrinhoView : ContentPage
	{
        public CarrinhoViewModel CarrinhoViewModel { get; set; }
		public CarrinhoView (List<Item> itens)
		{
            this.CarrinhoViewModel = new CarrinhoViewModel(itens);
            this.BindingContext = this.CarrinhoViewModel;
            InitializeComponent();            
		}
        protected override void OnAppearing()
        {
            
            base.OnAppearing();            
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        private void listItensView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
    }
}