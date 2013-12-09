using System;
using System.Collections;
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
        Produto produtoClicado;
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
            btCancelar.Enabled = false;
            btExcluir.Enabled = false;
            btSalvar.Enabled = true;

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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Restaurar();
            dgvProduto.DataSource = ProdutoDao.buscarTodos(new Produto());

        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Habilida e desabilita os seguintes botões
            btAlterar.Enabled = true;
            btExcluir.Enabled = true;
            btSalvar.Enabled = false;
            btCancelar.Enabled = true;

            //Confere se a celula clicada é valida
            if (e.RowIndex != -1)
            {
                // Recupera a fonte de dados como (as) ArrayList.
                ArrayList produtos
                     = dgvProduto.DataSource as ArrayList;

                // Recupera o produto clicado no DataGridView.
                produtoClicado = (Produto)produtos[e.RowIndex];

                // Adiciona as propriedades do produto clicado no
                // respectivo campo
                txtDescricao.Text = produtoClicado.Descricao;
                txtPreco.Text = produtoClicado.PrecoUnitario.ToString();

            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            ProdutoDao.salvar(new Produto(produtoClicado.GetId(), txtDescricao.Text,
                double.Parse(txtPreco.Text)));

            dgvProduto.DataSource = ProdutoDao.buscarTodos(new Produto());

            Restaurar();

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            ProdutoDao.Excluir(new Produto(produtoClicado.GetId()));

            dgvProduto.DataSource = ProdutoDao.buscarTodos(new Produto());

            Restaurar();

        }


    }
}
