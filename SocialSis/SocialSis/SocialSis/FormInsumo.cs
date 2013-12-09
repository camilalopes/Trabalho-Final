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
    public partial class FormInsumo : Form
    {
        Insumo insumoClicado;

        public FormInsumo()
        {
            InitializeComponent();
        }

        public void Restaurar()
        {
            txtDescricao.Text = "";
            txtPreco.Text = "";
            btCancelar.Enabled = false;
            btExcluir.Enabled = false;
            btSalvar.Enabled = true;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            InsumoDao.Salvar(new Insumo(0 , txtDescricao.Text, double.Parse(txtPreco.Text)));

            dgvInsumo.DataSource = InsumoDao.BuscarTodos(new Insumo());

            Restaurar();

        }

        private void FormInsumo_Load(object sender, EventArgs e)
        {
            dgvInsumo.DataSource = InsumoDao.BuscarTodos(new Insumo());

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Restaurar();

            dgvInsumo.DataSource = InsumoDao.BuscarTodos(new Insumo());

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            InsumoDao.Salvar(new Insumo(insumoClicado.GetId(), txtDescricao.Text,
                double.Parse(txtPreco.Text)));

            dgvInsumo.DataSource = InsumoDao.BuscarTodos(new Insumo());

            Restaurar();


        }

        private void dgvInsumo_CellClick(object sender, DataGridViewCellEventArgs e)
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
                ArrayList insumos
                     = dgvInsumo.DataSource as ArrayList;

                // Recupera o insumo clicado no DataGridView.
                insumoClicado = (Insumo)insumos[e.RowIndex];

                // Adiciona as propriedades do insumo clicado no
                // respectivo campo
                txtDescricao.Text = insumoClicado.Descricao;
                txtPreco.Text = insumoClicado.PrecoUnitario.ToString();

            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            InsumoDao.Excluir(new Insumo(insumoClicado.GetId()));

            dgvInsumo.DataSource = InsumoDao.BuscarTodos(new Insumo());

            Restaurar();

        }
    }
}
