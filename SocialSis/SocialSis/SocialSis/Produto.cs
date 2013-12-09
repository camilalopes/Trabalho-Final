using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    class Produto
    {
        private int id;
        //Atributo responsável por guardar o id do produto

        private string descricao;
        //Atributo responsável por guardar a descrição do produto

        private double precoUnitario;
        //Atributo reponsável por guarda o preço unitario de cada produto

        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        public Produto() { }

        /// <summary>
        /// Construtor sobrecarregado da classe, todos os atributos como parametro
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descricao"></param>
        /// <param name="precoUnitario"></param>
        public Produto(int id, string descricao, double precoUnitario)
        {
            SetId(id);
            Descricao = descricao;
            PrecoUnitario = precoUnitario;
        }

        /// <summary>
        /// Construtor sobregarregado da classe, com o atributo descrição como parametro
        /// </summary>
        /// <param name="descricao"></param>
        public Produto(string descricao)
        {
            Descricao = descricao;
        }

        public Produto(int id)
        {
            SetId(id);
        }

        /// <summary>
        /// Propriedade responsável por guardar e retornar valores do atributo descrição do produto
        /// </summary>
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }


        /// <summary>
        /// Metodo responsável por setar valor para o id do produto
        /// </summary>
        /// <param name="id"></param>
        public void SetId(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Metodo responsável por retornar valor do id do produto
        /// </summary>
        /// <param name="id"></param>
        public int GetId()
        {
            return id;
        }

        /// <summary>
        /// Propriedade responsável por guardar e retornar valores do atributo preço unitario de cada produto
        /// </summary>
        public double PrecoUnitario
        {
            get { return precoUnitario; }
            set { precoUnitario = value; }
        }

        /// <summary>
        /// Sobrescrita do ToString() da classe, retorna a descrição do produto
        /// </summary>
        public override string ToString()
        {
            return descricao;
        }


    }
}
