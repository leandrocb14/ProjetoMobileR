using ProjetoMobile.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMobile.DAO
{
    public class CarrinhoDAO
    {

        public Carrinho Carrinho { get; set; }        

        #region construtor
        public CarrinhoDAO()
        {
            Carrinho = new Carrinho();
        }
        public CarrinhoDAO(List<Item> itens)
        {
            this.Carrinho = new Carrinho();            
            if (itens != null)
            {
                AdicionaItensNoCarrinho(itens);
            }
        }
        #endregion

        public void AddItem(Item item)
        {
           Carrinho.Itens.Add(item);
        }

        public List<Item> ListarItens()
        {
            return Carrinho.Itens;
        }

        public void LimparTodosItens()
        {
            this.Carrinho.Itens.Clear();
        }

        private void AdicionaItensNoCarrinho(List<Item> itens)
        {
            foreach(var item in itens)
            {
                AddItem(item);
            }
        }
    }
}
