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
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Show();
        }


        /// <summary>
        /// Passar nome de login de usuario para label de sair do sistema.
        /// </summary>
        /// <param name="login"></param>
     

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienteProfessor fcProfessor = new FormClienteProfessor();
          
            fcProfessor.Show();
        }

    


        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Logado = False
            FormLogin fl = new FormLogin();
            fl.Show();
            this.Visible = false;
       
        }

     

        private void lbSairSistema_Click(object sender, EventArgs e)
        {
            // Logado = False
            Application.Exit();
        }

        private void mainMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mainMenuStrip_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienteProfessor fc = new FormClienteProfessor();
            fc.Show();
        }

        private void visualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProduto fp = new FormProduto();
            fp.Show();
        }

        private void visualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCompra foc = new FormCompra();
            foc.Show();
        }
    }
}
