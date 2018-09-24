using ProjetoMobile.DAO;
using ProjetoMobile.Model;
using ProjetoMobile.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjetoMobile.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private LoginDAO LoginDAO;

        #region Binding
        public ICommand ComandoEntrar { get; set; }

        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                OnPropertyChanged();
            }
        }


        private string senha;

        public string Senha
        {
            get { return senha; }
            set
            {
                senha = value;
                OnPropertyChanged();
            }
        }

        #endregion
        public LoginViewModel()
        {

            this.LoginDAO = new LoginDAO(new Login(Usuario, Senha));
            this.ComandoEntrar = new Command(() =>
            {
                if (LoginDAO.EhValido(Usuario, Senha))
                {
                    MessagingCenter.Send<Login>(new Login(Usuario, Senha), "SucessoLogin");
                }
                else
                {
                    MessagingCenter.Send<ArgumentException>(new ArgumentException("Usuário ou senha estão inválidos!"), "FalhaLogin");
                }
            });
        }
    }
}
