using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    /// <summary>
    /// Classe responsável por representar um cliente no sistema
    /// </summary>
    class Cliente
    {
        private ulong cpf;
        //Atributo responsável por registrar o cpf do cliente

        private string nome;
        //Atributo responsável por registrar no nome do cliente

        private string rg;
        //Atributo responsável por registrar  rg do cliente

        private string email;
        //Atributo responsável por registrar o email do cliente

        private ulong tel;
        //Atributo responsável por registrar o telefone do cliente

        private string endereco;
        //Atributo responsavel por registrar o endereço do cliente

        private DateTime prevPagamento;
        //Atributo responsável por registrar a previsão de pagamento do cliente

        private DateTime dataNasc;
        //Atributo responsável por registrar a data de nascimento do cliente

        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        public Cliente() { }

        /// <summary>
        /// Construtor sobrecarregado da classe, todos atributos como parametro
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="rg"></param>
        /// <param name="email"></param>
        /// <param name="tel"></param>
        /// <param name="endereco"></param>
        /// <param name="prevPagamento"></param>
        /// <param name="dataNasc"></param>
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

        /// <summary>
        /// Construtor sobrecarregado da classe, atributo nome como paramentro
        /// </summary>
        /// <param name="nome"></param>
        public Cliente(string nome)
        {
            Nome = nome;
        }

        public Cliente(ulong cpf)
        {
            Cpf = cpf;
        }

        /// <summary>
        /// Propriedade responsável por guardar e retornar valores do atributo nome do cliente
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Propriedade responsável por guardar e retornar valores do atributo cpf do cliente
        /// </summary>
        public ulong Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        /// <summary>
        /// Propriedade responsável por guardar e retornar valores do atributo rg do cliente
        /// </summary>
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        /// <summary>
        /// Propriedade responsável por guardar e retornar valores do atributo email do cliente
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Propriedade responsável por guardar e retornar valores do atributo teleone do cliente
        /// </summary>
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

        /// <summary>
        /// Propriedade responsável por guardar e retornar valores do atributo de data da previsão de pagamento do cliente
        /// </summary>
        public DateTime PrevPagamento
        {
            get { return prevPagamento; }
            set { prevPagamento = value; }
        }

        /// <summary>
        /// Propriedade responsável por guardar e retornar valores do atributo de data de nascimento do cliente
        /// </summary>
        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

        /// <summary>
        /// Sobrescrita do ToString() da classe, retorna o nome do cliente
        /// </summary>
        public override string ToString()
        {
            return nome;
        }









    }
}
