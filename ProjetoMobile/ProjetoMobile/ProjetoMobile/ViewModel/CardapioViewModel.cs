using ProjetoMobile.DAO;
using ProjetoMobile.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ProjetoMobile.ViewModel
{
    public class CardapioViewModel : BaseViewModel
    {
        public CardapioDAO CardapioDAO { get; set; }
        public CardapioViewModel()
        {
            this.CardapioDAO = new CardapioDAO();
        }

        #region Binding
        private bool aguarde;
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

        public List<Item> Itens
        {
            get
            {
                Aguarde = true;
                var itens = this.CardapioDAO.ListarItems();
                Aguarde = false;
                return itens;
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

        public string MensagemBoasVindas
        {
            get
            {
                return this.CardapioDAO.MensagemDeBoasVindas();
            }
        }
        #endregion        
    }
}
