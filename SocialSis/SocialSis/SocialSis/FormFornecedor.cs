using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocialSis;
using Dao;

namespace GUI
{
    public partial class FormFornecedor : Form
    {
        Fornecedor fornecedorClicado;

        public FormFornecedor()
        {
            InitializeComponent();
        }

        public void Restaurar()
        {
            txtNome.Text = "";
            txtCnpj.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";

            btSalvar.Enabled = true;
            btCancelar.Enabled = false;
        }

        private void btSalvar_Click_1(object sender, EventArgs e)
        {
            FornecedorDao.salvar(new Fornecedor(ulong.Parse(txtCnpj.Text), txtNome.Text,
                txtEndereco.Text, txtTelefone.Text, txtEmail.Text));

            dgvFornecedor.DataSource = FornecedorDao.BuscarTodos();

            Restaurar();

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            dgvFornecedor.DataSource = FornecedorDao.BuscarTodos();

            Restaurar();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            FornecedorDao.Alterar(new Fornecedor(ulong.Parse(txtCnpj.Text), txtNome.Text,
                txtEndereco.Text, txtTelefone.Text, txtEmail.Text), fornecedorClicado.Cnpj);

            dgvFornecedor.DataSource = FornecedorDao.BuscarTodos();

            Restaurar();

        }

        private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
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
                ArrayList fornecedores
                     = dgvFornecedor.DataSource as ArrayList;

                // Recupera o fornecedor clicado no DataGridView.
                fornecedorClicado = (Fornecedor)fornecedores[e.RowIndex];

                // Adiciona as propriedades do fornecedor clicado no
                // respectivo campo
                txtNome.Text = fornecedorClicado.Nome;
                txtCnpj.Text = fornecedorClicado.Cnpj.ToString();
                txtTelefone.Text = fornecedorClicado.Tel;
                txtEmail.Text = fornecedorClicado.Email;
                txtEndereco.Text = fornecedorClicado.Endereco;

            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            FornecedorDao.Excluir(new Fornecedor(fornecedorClicado.Cnpj));

            dgvFornecedor.DataSource = FornecedorDao.BuscarTodos();

            Restaurar();
        }

        private void btProcurarPorNome_Click(object sender, EventArgs e)
        {
            FornecedorDao.BuscarListaPorNome(new Fornecedor(txtNome.Text));
        }

        private void FormFornecedor_Load_1(object sender, EventArgs e)
        {
            dgvFornecedor.DataSource = FornecedorDao.BuscarTodos();

        }
    }
}
