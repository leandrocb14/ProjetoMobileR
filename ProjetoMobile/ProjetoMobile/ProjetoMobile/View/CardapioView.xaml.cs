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
    public partial class CardapioView : ContentPage
    {
        public CardapioViewModel CardapioViewModel = new CardapioViewModel();
        public CardapioView()
        {
            this.BindingContext = CardapioViewModel;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Item>(this, "ItemSelecionado", (msg) =>
            {
                Navigation.PushAsync(new DetalheItemView(msg));
                listItensView.SelectedItem = null;
            });
            MessagingCenter.Subscribe<string>(this, "MeuCarrinho", (msg) =>
            {                
                Navigation.PushAsync(new CarrinhoView());                
            });
            MessagingCenter.Subscribe<string>(this, "MeusPedidos", (msg) =>
            {
                Navigation.PushAsync(new PedidoView());                
            });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Item>(this, "ItemSelecionado");
            MessagingCenter.Unsubscribe<string>(this, "MeuCarrinho");
            MessagingCenter.Unsubscribe<string>(this, "MeusPedidos");
        }      
    }
}