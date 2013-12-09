using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocialSis;
using Dao;
using System.Collections;

namespace GUI
{
    /// <summary>
    /// Classe responsável por representar graficamente uma compra nos sistema
    /// </summary>
    public partial class FormCompra : Form
    {
        CompraAux compraClicada;

        //cria uma propriedade que permite pegar uma string
        //e guardar o login do usuario
        private string loginAux;

        public string LoginAux
        {
            get { return loginAux; }
            set { loginAux = value; }
        }


        public FormCompra(string loginUser)
        {
            loginAux = loginUser;
        }


        //Atributo responsavel por registrar a data de compra
        DateTime dataCompra = DateTime.Now;

        //Atributo responsavel por registrar a data de pagamento
        //Pode-se unir os dois atributos acima, e manipulalo de acordo com a situação.
        DateTime dataPagamento;

        //Atributo responsavel por resgistrar a compra.
        Compra compra;

        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        public FormCompra()
        {
            InitializeComponent();
        }

        public void Restaurar()
        {
            txtCliente.Text = "";
            txtProduto.Text = "";
            txtQuantidade.Text = "";
            btSalvar.Enabled = true;
            btCancelar.Enabled = false;

        }

        /// <summary>
        /// Evento responsável por controlar o que acontecerar enquanto a janela está carregando
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCompra_Load(object sender, EventArgs e)
        {
            dgvCompra.DataSource = CompraDao.buscarTodos(new CompraAux());

        }

        /// <summary>
        /// Evento responsável por controlar a ação de salvar compras com o butão
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSalvar_Click(object sender, EventArgs e)
        {


            string nomeUsuario;

            nomeUsuario = loginAux;

            Usuario user = new Usuario();
            user = UsuarioDao.BuscarPorLogin(new Usuario(nomeUsuario));

            //Verificação de pagamento
            if (chkPago.Checked == true)
            {
                dataPagamento = DateTime.Now;
            }


            double total = int.Parse(txtQuantidade.Text) *
                ProdutoDao.buscarPorDescricao(new Produto(txtProduto.Text)).PrecoUnitario;

            //Instanciação de objeto para salva-lo no Banco de Dados
            compra = new Compra(0, dataPagamento, dataCompra, total, ClienteDao.buscarPorNome(new Cliente(txtCliente.Text)), user);

            int idUltimaCompra;

            CompraDao.salvar(compra);

            idUltimaCompra = CompraDao.buscarTodos(new Compra()).Count;
            // dgvCompra.DataSource = CompraDao.buscarTodos(new Compra());
            compra.SetId(idUltimaCompra);

            ItemProdutoDao.salvar(new ItemProduto(0, int.Parse(txtQuantidade.Text),
               compra,
                ProdutoDao.buscarPorDescricao(new Produto(txtProduto.Text))));

            dgvCompra.DataSource = CompraDao.buscarTodos(new CompraAux());

        }

        /// <summary>
        /// Evento responsável por exibir a lista de clientes, assim que algumas teclas forem precionadas e o campo de Nome de cliente tiver mais de 2 caracteres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCliente_KeyUp(object sender, KeyEventArgs e)
        {
            //Verificação de campo nulo, ou com poucos valores
            if (txtCliente.Text != "" && txtCliente.Text.Length > 2)
            {

                listaCliente.Visible = true;
                listaCliente.DataSource = ClienteDao.buscarListaPorNome(new Cliente(txtCliente.Text));

                btPesquisaPorCliente.Visible = true;
                btPesquisarPorProduto.Visible = false;

            }
            //Contraresposta
            else
                listaCliente.Visible = false;
        }

        /// <summary>
        /// Evento responsável por exibir a lista de produtos, assim que algumas teclas forem precionadas e o campo de Nome de produto tiver mais de 2 caracteres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProduto_KeyUp(object sender, KeyEventArgs e)
        {
            //Verificação de campo nulo, ou com poucos valores
            if (txtProduto.Text != "" && txtProduto.Text.Length > 2)
            {

                btPesquisaPorCliente.Visible = false;
                btPesquisarPorProduto.Visible = true; ;
                listaProduto.Visible = true;
                listaProduto.DataSource = ProdutoDao.buscarListaPorDescricao(new Produto(txtProduto.Text));
            }
            //Contraresposta
            else
                listaProduto.Visible = false;
        }

        /// <summary>
        /// Evento responsável por verificar qual cliente foi selecionado, e ocultar a lista de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listaCliente_Click(object sender, EventArgs e)
        {
            Cliente clienteAux = ClienteDao.buscarPorNome(new Cliente(listaCliente.SelectedItem.ToString()));
            txtCliente.Text = listaCliente.SelectedItem.ToString();
            listaCliente.Visible = false;
        }

        /// <summary>
        /// Evento responsável por verificar qual produto foi selecionado, e ocultar a lista de produtos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listaProduto_Click(object sender, EventArgs e)
        {
            Produto produtoAux = ProdutoDao.buscarPorDescricao(new Produto(listaProduto.SelectedItem.ToString()));
            txtProduto.Text = listaProduto.SelectedItem.ToString();
            listaProduto.Visible = false;
        }

        private void btPesquisaPorCliente_Click(object sender, EventArgs e)
        {



            string nomeCliente;
            nomeCliente = txtCliente.Text.Trim();

            Cliente auxCliente = new Cliente();
            auxCliente = ClienteDao.buscarPorNome(new Cliente(nomeCliente));

            dgvCompra.DataSource = CompraDao.buscarPorCliente(auxCliente);



        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Restaurar();

            dgvCompra.DataSource = CompraDao.buscarTodos(new CompraAux());

            btPesquisaPorCliente.Visible = false;
            btPesquisarPorProduto.Visible = false;
        }

        private void dgvCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Habilida e desabilita os seguintes botões
            chkPago.Enabled = true;
            btSalvar.Enabled = false;
            btCancelar.Enabled = true;
            btAlterar.Enabled = true;

            //Verifica se a celula clicada é válida
            if (e.RowIndex != -1)
            {
                // Recupera a fonte de dados como (as) ArrayList.
                ArrayList comprasAux
                         = dgvCompra.DataSource as ArrayList;

                // Recupera o destinatario clicado no DataGridView.
                compraClicada = (CompraAux)comprasAux[e.RowIndex];

                txtCliente.Text = compraClicada.Cliente;
                txtProduto.Text = compraClicada.Produto;
                txtQuantidade.Text = compraClicada.Quantidade.ToString();


            }

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            CompraDao.salvar(new Compra(compraClicada.GetId(), 
                chkPago.Checked ? DateTime.Now : compraClicada.DataPagamento));

            dgvCompra.DataSource = CompraDao.buscarTodos(new CompraAux());

            Restaurar();

        }
    }
}