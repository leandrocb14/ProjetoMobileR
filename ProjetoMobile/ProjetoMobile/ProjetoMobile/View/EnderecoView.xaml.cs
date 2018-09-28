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
    public partial class EnderecoView : ContentPage
    {
        public EnderecoViewModel EnderecoViewModel { get; set; }
        public EnderecoView()
        {
            this.EnderecoViewModel = new EnderecoViewModel();
            this.BindingContext = this.EnderecoViewModel;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<string>(this, "ConfirmaPedido", async (msg) =>
            {
                var confirmacao = await DisplayAlert("Confirmação", "Você confirma realmente o seu pedido?", "Sim", "Não");
                if (confirmacao)
                {
                    MessagingCenter.Send<string>("", "RemoveItensCarrinho");
                    await DisplayAlert("Pedido", "Seu pedido foi realizado com sucesso!", "OK");
                    await Navigation.PopToRootAsync();
                }
            });
        }
    }
}