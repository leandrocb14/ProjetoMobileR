using ProjetoMobile.DAO;
using ProjetoMobile.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProjetoMobile.ViewModel
{
    public class MasterDetailViewModel
    {

        public MasterDetailDAO MasterDetailDAO { get; set; }

        public MasterDetailViewModel()
        {
            this.MasterDetailDAO = new MasterDetailDAO();                        
        }        
    }
}
