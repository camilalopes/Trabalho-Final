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
    /// <summary>
    /// Classe responsável por representar graficamente um cliente no sistema
    /// </summary>
    public partial class FormClienteProfessor : Form
    {
        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        public FormClienteProfessor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo responsável por restaurar os componentes graficos para seu estado inicial
        /// </summary>
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

        /// <summary>
        /// Evento responsável por controlar o que acontecerar enquanto a janela está carregando
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormClienteProfessor_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = ClienteDao.buscarTodos(new Cliente());
        }

        /// <summary>
        /// Evento responsável por realizar o logout do usuario e fechar o sistema
        /// Não está funcionando porque o componente grafico sumiu, não apagar este evento caso contrario ocorrerá conflitos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbSairSistema_Click(object sender, EventArgs e)
        {
            // Logado = False
            Application.Exit();
        }

        /// <summary>
        /// Evento responsável por realizar oção com o clique do label que sumiu
        /// Não está funcionando porque o componente grafico sumiu, não apagar este evento caso contrario ocorrerá conflitos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento responsável por controlar a ação de salvar clientes com o butão
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSalvar_Click(object sender, EventArgs e)
        {
            ClienteDao.salvar(new Cliente(txtNome.Text, ulong.Parse(txtCpf.Text), txtRg.Text, txtEmail.Text,
                ulong.Parse(txtTel.Text), txtEndereco.Text, DateTime.Parse(txtPrevPag.Text), DateTime.Parse(txtDataNasc.Text)));

            dgvCliente.DataSource = ClienteDao.buscarTodos(new Cliente());

            Restaurar();
           
        }

    }
}
