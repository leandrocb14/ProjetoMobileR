using ProjetoMobile.BLL;
using ProjetoMobile.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMobile.DAO
{
    public class LoginDAO
    {
        public Login Login;
        private LoginBLL LoginBLL { get; set; }
        public LoginDAO(Login login)
        {
            this.Login = login;
        }

        public bool EhValido(string usuario, string senha)
        {            
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                return false;
            }
            else
            {
                return true;
            }            
        }

    }
}
