using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    class Fornecedor
    {
        private ulong cnpj;
        private string endereco;
        private string nome;
        private string tel;
        private string email;

        public Fornecedor()
        { }

        public Fornecedor(string nome)
        {
            Nome = nome;
        }

        public Fornecedor(ulong cnpj, string nome, string endereco, string tel, string email)
        {
            Cnpj = cnpj;
            Nome = nome;
            Endereco = endereco;
            Tel = tel;
            Email = email;
        }

        public Fornecedor(ulong cnpj)
        {
            Cnpj = cnpj;
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }



        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public ulong Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public override string ToString()
        {
            return nome;
        }



    }
}