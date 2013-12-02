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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

    
        
        private void btLogin_Click(object sender, EventArgs e)
        {
            FormPrincipal fp = new FormPrincipal();
    
            fp.Show();
            this.Visible = false;
        }

        private void lbSairSistema_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
