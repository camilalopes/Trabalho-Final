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
    /// <summary>
    /// Classe responsável pela orientação grafica básica do sistema
    /// </summary>
    public partial class FormPrincipal : Form
    {
        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
            logout();
                            
        }

        //cria uma propriedade que permite pegar um boleano
        //isso é usado para saber se o usuario logado é adm ou não
        private bool admAux;

        public bool AdmAux
        {
            get { return admAux; }
            set { admAux = value; }
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
        /// Evento responsável por controlar o que acontecerar enquanto a janela está carregando
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //Caso o usuario logado não seja um administrador
            //a parte de operações com usuario será desabilitada
            if (admAux == false)
            {
                USUARIOToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// Evento responsável por abrir a janela de gerenciamento de clientes professor
        /// Não está funcionando porque o componente grafico sumiu, não apagar este evento caso contrario ocorrerá conflitos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienteProfessor fc = new FormClienteProfessor();
            fc.Show();
        }

        /// <summary>
        /// Evento responsável por abrir a janela de gerenciamento de produtos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void visualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProduto fp = new FormProduto();
            fp.Show();
        }

        /// <summary>
        /// Evento responsável por abrir a janela de gerenciamento de compras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void visualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCompra foc = new FormCompra();
            foc.Show();
        }


        /// <summary>
        /// Evento responsável por realizar o logout do usuario e fechar o sistema
        /// Funciona Parcialmente, nesta versao não encerra corretamente o processo da janela de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtSairSistema_Click(object sender, EventArgs e)
        {
            //LogoUT
            FormLogin.FecharTudo();
        }

        /// <summary>
        /// Evento responsável por realizar o jogo de telas para logar o usuario
        /// Não funciona corretamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void logout()
        {
            // Oculta janela principal,...
            Hide();

            // ... toma outras ações...

            // ... e exibe a janela de login.
            FormLogin.abrirJanelaLogin();
        }

        private void visualizarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormUsuario fu = new FormUsuario();
            fu.Show();
        }

        private void visualizarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormFornecedor ff = new FormFornecedor();
            ff.Show();
        }

        private void visualizarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FormInsumo fi = new FormInsumo();
            fi.Show();
        }
    }
}
