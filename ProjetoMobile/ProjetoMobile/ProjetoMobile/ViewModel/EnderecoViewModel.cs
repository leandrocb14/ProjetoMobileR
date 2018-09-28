using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjetoMobile.ViewModel
{
    public class EnderecoViewModel
    {
        public ICommand CommandConfirmarPedido { get; set; }

        public EnderecoViewModel()
        {
            this.CommandConfirmarPedido = new Command(() =>
            {
                MessagingCenter.Send<string>("", "ConfirmaPedido");
            });
        }
    }
}
