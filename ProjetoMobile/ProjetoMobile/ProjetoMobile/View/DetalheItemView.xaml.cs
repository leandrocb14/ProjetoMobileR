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
    public partial class DetalheItemView : ContentPage
    {
        public DetalheItemViewModel DetalheItemViewModel { get; set; }        
        public DetalheItemView(Item item)
        {
            InitializeComponent();
            DetalheItemViewModel = new DetalheItemViewModel(item);
            this.BindingContext = DetalheItemViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<Item>(this, "AdicionaItem", async (msgItem) =>
            {
                var confirma = await DisplayAlert("Adicionar item", "Você tem certeza que deseja adicionar ao seu carrinho?", "Sim", "Não");
                if (confirma)
                {
                    MessagingCenter.Send<Item>(msgItem, "AdicionaItemCarrinho");
                    await Navigation.PopAsync();
                }
            });

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Item>(this, "AdicionaItem");            
        }


    }
}