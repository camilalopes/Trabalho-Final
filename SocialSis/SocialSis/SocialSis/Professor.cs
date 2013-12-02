using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    class Professor : Cliente
    {
        private bool contratado;


        public Professor() { }

        /*public Professor(string nome, ulong cpf, string rg, string email, ulong tel, string endereco, DateTime prevPagamento,
            DateTime dataNasc, bool contratado)
            : base(nome, cpf, rg, email, tel, endereco, prevPagamento, dataNasc)
        {
            Contratado = contratado;

        }*/

        public Professor(string nome, ulong cpf, string rg, string email, ulong tel, string endereco,
             bool contratado)
            : base(nome, cpf, rg, email, tel, endereco)
        {
            Contratado = contratado;

        }

        public bool Contratado
        {
            get { return contratado; }
            set { contratado = value; }
        }


    }
}
