using ProjetoMobile.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjetoMobile.ViewModel
{
    public class MasterViewModel
    {
        
        public ICommand commandSair { get; set; }

        public MasterViewModel()
        {            
            this.commandSair = new Command(() =>
            {
                MessagingCenter.Send<string>("", "UsuarioDeslogado");
            });
        }
    }
}
