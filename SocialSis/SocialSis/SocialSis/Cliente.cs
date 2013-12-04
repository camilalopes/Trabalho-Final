using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    class Cliente
    {
        private ulong cpf;
        private string nome;
        private string rg;
        private string email;
        private ulong tel;
        private string endereco;
        private DateTime prevPagamento;
        private DateTime dataNasc;

        public Cliente() { }

        public Cliente(string nome, ulong cpf, string rg, string email,
            ulong tel, string endereco, DateTime prevPagamento, DateTime dataNasc)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Email = email;
            Tel = tel;
            Endereco = endereco;
            PrevPagamento = prevPagamento;
            DataNasc = dataNasc;
        }

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public ulong Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public ulong Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public DateTime PrevPagamento
        {
            get { return prevPagamento; }
            set { prevPagamento = value; }
        }

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

        public override string ToString()
        {
            return nome;
        }









    }
}
