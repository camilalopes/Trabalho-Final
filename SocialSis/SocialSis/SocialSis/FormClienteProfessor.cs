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

      

        private void FormClienteProfessor_Load(object sender, EventArgs e)
        {
        

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


            ProfessorDao.salvarProfessor(new Professor(txtNome.Text, ulong.Parse(txtCpf.Text),txtRg.Text, txtEmail.Text, 
                ulong.Parse(txtTel.Text), txtEndereco.Text /*DateTime.Parse( txtDataNasc.Text)*/,

                /*DateTime.Parse(txtDataNasc.Text), */ checkContratado.Checked));

        }
    }
}
