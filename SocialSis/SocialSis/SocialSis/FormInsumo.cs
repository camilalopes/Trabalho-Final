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
    public partial class FormInsumo : Form
    {
        public FormInsumo()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            InsumoDao.Salvar(new Insumo(0 , txtDescricao.Text, double.Parse(txtPreco.Text)));
            dgvInsumo.DataSource = InsumoDao.BuscarTodos(new Insumo());

        }

        private void FormInsumo_Load(object sender, EventArgs e)
        {
            dgvInsumo.DataSource = InsumoDao.BuscarTodos(new Insumo());

        }
    }
}
