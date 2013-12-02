using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormClienteAluno : Form
    {
       
        public FormClienteAluno()
        {
            InitializeComponent();
        }

       
        private void FormClienteAluno_Load(object sender, EventArgs e)
        {

        }

        private void lbSairSistema_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txtNomeFiliacao_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeFiliacao.Text != "")
            {
                listFiliacoes.Visible = true;
            }
            if (txtNomeFiliacao.Text == "")
            {
                listFiliacoes.Visible = true;
            }
            
        }
    }
}
