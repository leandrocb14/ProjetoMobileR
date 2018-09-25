using ProjetoMobile.DAO;
using ProjetoMobile.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMobile.ViewModel
{
    public class CarrinhoViewModel
    {
        public CarrinhoDAO CarrinhoDAO { get; set; }

        #region Construtor
        public CarrinhoViewModel(List<Item> itens = null)
        {
            if (itens != null)
            {
                this.CarrinhoDAO = new CarrinhoDAO(itens);
            }
            else
            {
                this.CarrinhoDAO = new CarrinhoDAO();
            }

        }
        #endregion

        #region Binding
        public bool CarrinhoTemItem
        {
            get
            {
                return CarrinhoPossuiItens();
            }
        }
        public bool CarrinhoNaoTemItem
        {
            get
            {
                return !CarrinhoPossuiItens();
            }
        }

        public string TextoQuantidadeDeItens
        {
            get
            {
                return $"Quantidade de itens: {this.ListarItens().Count}";
            }
        }

        public string TextoPrecoTotal
        {
            get
            {
                return $"Preço total: R$ {CalculaPrecoDeTodosItens().ToString("0.00")}";
            }
        }
        
        public List<Item> ListarItensDoCarrinho
        {
            get
            {
                return ListarItens();
            }
        }
        #endregion

        #region Metodos
        private List<Item> ListarItens()
        {
            return CarrinhoDAO.Itens;
        }
        private bool CarrinhoPossuiItens()
        {
            return CarrinhoDAO.Itens.Count > 0;
        }

        private double CalculaPrecoDeTodosItens()
        {
            double total = 0;
            foreach (var q in ListarItens())
            {
                total += q.Preco;
            }            
            return total;
        }
        #endregion
    }
}
