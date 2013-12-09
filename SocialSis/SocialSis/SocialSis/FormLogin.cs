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
    /// <summary>
    /// Classe responsável por realizar o acesso ao sistema
    /// </summary>
    public partial class FormLogin : Form
    {
        private FormPrincipal fp;
        //Atributo para auxiliar no jogo de telas
        private static FormLogin janelaLogin;

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

            //Busca o usuario no BD de acordo com a senha e o login informados
            Usuario resposta = UsuarioDao.BuscarPorLoginESenha(new Usuario(txtLogin.Text, txtSenha.Text));

            // se houver uma resposta a form principal é chamada
            if (resposta != null)
            {
                // Abre a janela principal
                FormPrincipal fp = new FormPrincipal();
                FormCompra fc;


                // "Fecha" janela de login
                fecharJanelaLogin();

                //passa a propiedade de adm do usuario para a FormPrincipal
                fp = new FormPrincipal();
                fp.AdmAux = resposta.Adm;
                fp.LoginAux = resposta.Login;
                fp.Show();


            }
            else
                //caso contrario a mensagem abaixo é ixibida
                MessageBox.Show("Este usuario e/ou senha, não existem !!");



        }
        public string DescobreUsuario()
        {

            return txtLogin.Text;
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
        public static void FecharTudo()
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

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Usuario resposta = UsuarioDao.BuscarPorLoginESenha(new Usuario(txtLogin.Text, txtSenha.Text));


                if (resposta != null)
                {

                    //passa a propiedade de adm do usuario para a FormPrincipal
                    fp = new FormPrincipal();
                    fp.AdmAux = resposta.Adm;
                    fp.LoginAux = resposta.Login;
                    fp.Show();

                }
                else
                    MessageBox.Show("Este usuario e/ou senha, não existem !!");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        public string nomeUser()
        {
            return txtLogin.Text;
        }
    }
}


