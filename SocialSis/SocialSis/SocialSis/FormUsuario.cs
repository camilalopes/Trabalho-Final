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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        public void Restaurar()
        {
            txtTelefone.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";
            txtLogin.Text = "";
            txtEmail.Text = "";
            btSalvar.Enabled = true;
            btCancelar.Enabled = false;
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
            txtNome.Focus();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //Verifica qual é o indice do ComboBox que está selecionado
            //caso seja 0 o usuario é salvo como padrão, se não é salvo 
            // como adm !
            if (cboTipo.SelectedIndex == 0)
            {
                //Salva um usuario padrão no BD
                UsuarioDao.Salvar(new Usuario(txtLogin.Text, txtSenha.Text, txtNome.Text,
                    ulong.Parse(txtTelefone.Text), txtEmail.Text, false));



                Restaurar();
            }
            else
            {
                //Salva um usuario administrador no BD
                UsuarioDao.Salvar(new Usuario(txtLogin.Text, txtSenha.Text, txtNome.Text,
                    ulong.Parse(txtTelefone.Text), txtTelefone.Text, true));

                Restaurar();
            }

            //Carrega o DGV com todos os usuarios do BD
            dgvUsuario.DataSource = UsuarioDao.BuscarTodos(new Usuario());

        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            //Inicializa o ComboBox com os respectivos tipos de Usuario
            cboTipo.Items.Add("Padrão");
            cboTipo.Items.Add("Administrador");

            //Seleciona o índice 0 do ComboBox
            cboTipo.SelectedIndex = 0;

            //Busca todos os usuarios existentes no BD
            dgvUsuario.DataSource = UsuarioDao.BuscarTodos(new Usuario());

            // Ajusta a largura das colunas do DataGridView,
            // caso haja usuario para serem exibidos.
            if (UsuarioDao.BuscarTodos(new Usuario()) != null)
            {
                dgvUsuario.Columns[2].Width = 138;
                dgvUsuario.Columns[3].Width = 61;
                dgvUsuario.Columns[0].Width = 160;
                dgvUsuario.Columns[1].Width = 80;
                dgvUsuario.Columns[4].Width = 95;

            }
        }
    }
}
