using ProjetoMobile.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjetoMobile.ViewModel
{
    public class LoginViewModel
    {
        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
            }
        }

        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }


        public ICommand ComandoEntrar { get; set; }

        public LoginViewModel()
        {
            this.ComandoEntrar = new Command(() =>
            {
                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
                {
                    MessagingCenter.Send<ArgumentException>(new ArgumentException("Usuário ou senha estão inválidos!"), "FalhaLogin");
                }
                else
                {
                    MessagingCenter.Send<Login>(new Login(usuario, senha), "SucessoLogin");
                }
                
            });
        }
    }
}
