using ProjetoMobile.Model;
using ProjetoMobile.Model.DAO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ProjetoMobile.ViewModel
{
    public class CardapioViewModel : BaseViewModel
    {
        public List<Item> Itens { get; set; }
        public CumprimentoUsuarioDAO CumprimentoUsuarioDAO { get; set; }
        public CardapioViewModel()
        {
            this.Itens = new List<Item>();
            this.CumprimentoUsuarioDAO = new CumprimentoUsuarioDAO();
        }

        public bool aguarde;
        public bool Aguarde
        {
            get
            {
                return aguarde;
            }
            set
            {
                aguarde = value;
                OnPropertyChanged();
            }
        }

        private Item itemSelecionado;

        public Item ItemSelecionado
        {
            get
            {
                return itemSelecionado;
            }
            set
            {
                itemSelecionado = value;
                if (itemSelecionado != null)
                {
                    MessagingCenter.Send<Item>(itemSelecionado, "ItemSelecionado");
                }
            }
        }

        public void GetItens()
        {
            Aguarde = true;
            //AddItem("smoothiesdemorango.jpg", "Smoothies de morango", 11);
            AddItem("crepiocatradional.jpg", "Crepioca tradicional", 15);
            AddItem("tapioca.jpg", "Tapioca tradicional", 5);
            //AddItem("milkshakepacoca.jpg", "Milk Shake de Paçoca", 11.60);
            AddItem("tapiocadoce.jpg", "Tapioca Doce", 7);
            AddItem("nuggets.jpg", "Nuggets", 10);
            AddItem("batatafrita.jpg", "Batata Frita", 10, "Batata frita com bacon e cheddar");
            AddItem("Massangana.jpg", "Privilege Massangana", 17.99);
            Aguarde = false;
        }

        public string MensagemBoasVindas
        {
            get
            {
                return CumprimentoUsuarioDAO.AvaliaHoraDeCumprimentoUsuario();
            }
        }

        private void AddItem(string directoryImage, string titulo, double preco, string ingrediente = null)
        {
            Itens.Add(new Item()
            {
                DirectoryImage = directoryImage,
                Titulo = titulo,
                Ingrediente = ingrediente,
                Preco = preco
            });
        }
    }
}
