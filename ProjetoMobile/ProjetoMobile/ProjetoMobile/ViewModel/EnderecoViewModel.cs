using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjetoMobile.ViewModel
{
    public class EnderecoViewModel : BaseViewModel
    {
        public ICommand CommandConfirmarPedido { get; set; }

        private string textoLogradouro;
        public string TextoLogradouro
        {
            get { return textoLogradouro; }
            set
            {
                OnPropertyChanged();
                textoLogradouro = value;
            }
        }

        private string textoNumero;
        public string TextoNumero
        {
            get { return textoNumero; }
            set
            {
                OnPropertyChanged();
                textoNumero = value;
            }
        }

        private string textoComplemento;
        public string TextoComplemento
        {
            get { return textoComplemento; }
            set
            {
                OnPropertyChanged();
                textoComplemento = value;
            }
        }

        private string textoBairro;
        public string TextoBairro
        {
            get { return textoBairro; }
            set
            {
                OnPropertyChanged();
                textoBairro = value;
            }
        }

        private string pagamentoSelecionado;

        public string PagamentoSelecionado
        {
            get { return pagamentoSelecionado; }
            set
            {
                OnPropertyChanged();
                pagamentoSelecionado = value;
            }
        }

        public List<string> ListaFormasPagamento
        {
            get
            {
                List<string> listaFormasPagamento = new List<string>();
                listaFormasPagamento.Add("Crédito");
                listaFormasPagamento.Add("Débito");
                listaFormasPagamento.Add("Dinheiro");
                return listaFormasPagamento;
            }
        }


        public EnderecoViewModel()
        {
            this.CommandConfirmarPedido = new Command(() =>
            {
                if (string.IsNullOrEmpty(textoLogradouro) || string.IsNullOrEmpty(textoNumero) || string.IsNullOrEmpty(textoComplemento) || string.IsNullOrEmpty(textoBairro) || string.IsNullOrEmpty(pagamentoSelecionado))
                {
                    MessagingCenter.Send<string>("", "CamposInvalidos");
                }
                else
                {
                    MessagingCenter.Send<string>("", "ConfirmaPedido");
                }
            });
        }
    }
}
