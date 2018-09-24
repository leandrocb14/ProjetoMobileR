using ProjetoMobile.BLL;
using ProjetoMobile.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMobile.DAO
{
    public class DetalheItemDAO
    {
        public Item Item { get; set; }
        private DetalheItemBLL DetalheItemBLL { get; set; }
        public DetalheItemDAO()
        {
            this.Item = new Item();
            this.DetalheItemBLL = new DetalheItemBLL();
        }
    }
}
