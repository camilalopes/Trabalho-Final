using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    class Usuario
    {
        private string login, senha, nome, email;
        private bool adm;
        private ulong telefone;

        public Usuario()
        { }

        public Usuario(string login, string senha, string nome, ulong telefone, string email, bool adm)
        {
            Login = login;
            SetSenha(senha);
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Adm = adm;
        }

        public Usuario(string login, string senha, bool adm)
        {
            Login = login;
            SetSenha(senha);
            Adm = adm;
        }

        public Usuario(string login, string senha)
        {
            Login = login;
            SetSenha(senha);
        }

        public Usuario(string login)
        {
            Login = login;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public ulong Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public bool Adm
        {
            get { return adm; }
            set { adm = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public void SetSenha(string senha)
        {
            this.senha = senha;
        }

        public string GetSenha()
        {
            return this.senha;
        }
    }
}
