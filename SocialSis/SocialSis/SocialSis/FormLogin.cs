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
    /// Classe responsável por realizar o acesso ao sistema
    /// </summary>
    public partial class FormLogin : Form
    {
        private static FormLogin janelaLogin;
        //Atributo para auxiliar no jogo de telas

        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
        }
    
        /// <summary>
        /// Evento responsável por realizar o login do usuario no sistema
        /// Falta aplicar a validação do usuario com o clique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLogin_Click(object sender, EventArgs e)
        {
           
                // Abre a janela principal
                new FormPrincipal().Show();

                // "Fecha" janela de login
                fecharJanelaLogin();
            
        }

        /// <summary>
        /// Evento responsável por realizar fechar o sistema
        /// Funciona Parcialmente, nesta versao não encerra corretamente o processo da janela de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtSairSistema_Click(object sender, EventArgs e)
        {
            //Logout
            Application.Exit();
        }

        ///<summary>
        /// Metodo responsavel por encerrar tudo do sistema
        /// </summary>
        public static  void FecharTudo()
        {
            Application.Exit();
        }

        /// <summary>
        /// Metodo responsavel por abrir a janela login do sistema
        /// </summary>
        public static void abrirJanelaLogin()
        {
            if (janelaLogin == null)
            {
                janelaLogin = new FormLogin();
            }

            janelaLogin.Visible = true;
        }

        public static void fecharJanelaLogin()
        {
            if (janelaLogin != null)
            {
                janelaLogin.Visible = false;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

     
}

