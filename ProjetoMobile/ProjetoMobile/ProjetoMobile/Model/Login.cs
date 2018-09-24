using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMobile.Model
{
    public class Login
    {
        public string Usuario;
        public string Senha;

        public Login(string usuario, string senha)
        {
            this.Usuario = usuario;
            this.Senha = senha;
        }
    }
}
