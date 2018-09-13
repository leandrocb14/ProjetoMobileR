using ProjetoMobile.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMobile.ViewModel
{
    public class DetalheItemViewModel 
    {

        public Item Item { get; set; }
        public DetalheItemViewModel(Item item)
        {
            this.Item = item;
            
        }


    }
}
