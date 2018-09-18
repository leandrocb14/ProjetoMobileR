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
    public partial class CardapioView : ContentPage
    {
        public CardapioViewModel cardapioViewModel { get; set; }
        public CardapioView()
        {
            InitializeComponent();
            this.cardapioViewModel = new CardapioViewModel();
            this.BindingContext = cardapioViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.cardapioViewModel.GetItens();            
            MessagingCenter.Subscribe<Item>(this, "ItemSelecionado", (msg) =>
            {
                Navigation.PushAsync(new DetalheItemView(msg));
                listItensView.SelectedItem = null;
            });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Item>(this, "ItemSelecionado");            
        }


    }
}