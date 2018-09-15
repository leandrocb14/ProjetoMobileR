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
    public partial class MenuView : ContentPage
    {
        public MenuViewModel menuViewModel { get; set; }
        public MenuView()
        {
            InitializeComponent();
            this.menuViewModel = new MenuViewModel();
            this.BindingContext = menuViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.menuViewModel.GetItens();            
            MessagingCenter.Subscribe<Item>(this, "ItemSelecionado", (msg) =>
            {
                Navigation.PushAsync(new DetalheItemView(msg));
            });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Item>(this, "ItemSelecionado");
        }


    }
}