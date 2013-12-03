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
using System.Globalization;

namespace GUI
{
    public partial class FormClienteProfessor : Form
    {
        public FormClienteProfessor()
        {
            InitializeComponent();
        }

        public void Restaurar()
        {
            txtNome.Text = "";
            txtRg.Text = "";
            txtCpf.Text = "";
            txtDataNasc.Text = "";
            txtPrevPag.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";

        }
      

        private void FormClienteProfessor_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = ClienteDao.buscarTodos(new Cliente());
        }

        private void lbSairSistema_Click(object sender, EventArgs e)
        {
            // Logado = False
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            ClienteDao.salvar(new Cliente(txtNome.Text, ulong.Parse(txtCpf.Text), txtRg.Text, txtEmail.Text,
                ulong.Parse(txtTel.Text), txtEndereco.Text, DateTime.Parse(txtPrevPag.Text), DateTime.Parse(txtDataNasc.Text)));

            dgvCliente.DataSource = ClienteDao.buscarTodos(new Cliente());

            Restaurar();
           
        }
    }
}
