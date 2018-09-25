using ProjetoMobile.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMobile.DAO
{
    public class CarrinhoDAO
    {

        public static List<Item> Itens { get; set; }

        #region construtor
        public CarrinhoDAO()
        {
            Itens = new List<Item>();
        }
        public CarrinhoDAO(List<Item> itens)
        {
            //Itens = new List<Item>();
            if (itens == null)
            {
                Itens = itens;
            }
        }
        #endregion

        public void AddItem(Item item)
        {
            Itens.Add(item);
        }

        public List<Item> ListarItens()
        {
            return Itens;
        }
    }
}
