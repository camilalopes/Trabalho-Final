using System;
using System.Collections.Generic;
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
        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {
            dgvFornecedor.DataSource = FornecedorDao.buscarTodos(new Fornecedor());
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            FornecedorDao.salvar(new Fornecedor(ulong.Parse(txtCnpj.Text), txtNome.Text,
                txtEndereco.Text, txtTelefone.Text, txtEmail.Text));

            dgvFornecedor.DataSource = FornecedorDao.buscarTodos(new Fornecedor());

            Restaurar();


        }
    }
}
