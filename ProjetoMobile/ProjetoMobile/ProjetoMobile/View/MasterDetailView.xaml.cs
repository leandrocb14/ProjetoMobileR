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
    public partial class MasterDetailView : MasterDetailPage
    {
        public MasterDetailViewModel MasterDetailViewModel { get; set; }
        public MasterDetailView()
        {
            InitializeComponent();
            this.MasterDetailViewModel = new MasterDetailViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<string>(this, "MeuCarrinho", (msg) =>
            {
                IsPresented = false;                
            });
            MessagingCenter.Subscribe<string>(this, "MeusPedidos", (msg) =>
            {
                IsPresented = false;                
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Login>(this, "SucessoLogin");
            MessagingCenter.Unsubscribe<Login>(this, "UsuarioDeslogado");
            MessagingCenter.Unsubscribe<string>(this, "MeuCarrinho");
            MessagingCenter.Unsubscribe<string>(this, "MeusPedidos");
            MessagingCenter.Unsubscribe<MasterDetailView>(this, "AdicionaCarrinho");
        }
    }
}