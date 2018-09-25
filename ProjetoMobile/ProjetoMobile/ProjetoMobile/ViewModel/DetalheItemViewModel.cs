using ProjetoMobile.DAO;
using ProjetoMobile.Model;
using ProjetoMobile.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjetoMobile.ViewModel
{
    public class DetalheItemViewModel
    {        
        private DetalheItemDAO DetalheItemDAO { get; set; }        
        public ICommand CommandAdicionarCarrinho { get; set; }

        #region Construtores
        public DetalheItemViewModel(Item item)
        {     
            this.DetalheItemDAO = new DetalheItemDAO();
            this.DetalheItemDAO.Item = item;
            this.CommandAdicionarCarrinho = new Command(() =>
            {
                MessagingCenter.Send<Item>(DetalheItemDAO.Item, "AdicionaItem");
            });            
        }        
        #endregion

        #region Binding
        public Item Item
        {
            get
            {
                return this.DetalheItemDAO.Item;
            }
        }
        #endregion
    }
}
