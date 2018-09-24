using ProjetoMobile.DAO;
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
        public MasterDAO MasterDAO { get; set; }
        public ICommand CommandSair { get; set; }
        public ICommand CommandMeuCarrinho { get; set; }
        public ICommand CommandMeusPedidos { get; set; }

        public MasterViewModel()
        {
            this.MasterDAO = new MasterDAO();            
            this.CommandSair = new Command(() =>
            {
                MessagingCenter.Send<string>("", "UsuarioDeslogado");
            });

            this.CommandMeuCarrinho = new Command(() =>
            {
                MessagingCenter.Send<string>("", "MeuCarrinho");
            });

            this.CommandMeusPedidos = new Command(() =>
            {
                MessagingCenter.Send<string>("", "MeusPedidos");
            });            
        }
    }
}
