using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dao;
using SocialSis;

namespace GUI
{
    /// <summary>
    /// Classe responsável por representar graficamente um produto no sistema
    /// </summary>
    public partial class FormProduto : Form
    {
        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        public FormProduto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo responsável por restaurar os componentes graficos para seu estado inicial
        /// </summary>
        public void Restaurar()
        {
            txtDescricao.Text = "";
            txtPreco.Text = "";
        }

        /// <summary>
        /// Evento responsável por controlar a ação de salvar produtos com o butão
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSalvar_Click(object sender, EventArgs e)
        {
            ProdutoDao.salvar(new Produto(0, txtDescricao.Text, double.Parse(txtPreco.Text)));

            dgvProduto.DataSource = ProdutoDao.buscarTodos(new Produto());

            Restaurar();

        }

        /// <summary>
        /// Evento responsável por controlar o que acontecerar enquanto a janela está carregando
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormProduto_Load(object sender, EventArgs e)
        {
            dgvProduto.DataSource = ProdutoDao.buscarTodos(new Produto());
        }
    }
}
