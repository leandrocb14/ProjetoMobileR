using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMobile.Model
{
    public class Carrinho
    {

        public List<Item> Itens { get; set; }

        public Carrinho()
        {
            Itens = new List<Item>();
        }        
    }
}
