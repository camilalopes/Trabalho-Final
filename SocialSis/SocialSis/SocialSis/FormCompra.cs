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

namespace GUI
{
    /// <summary>
    /// Classe responsável por representar graficamente uma compra nos sistema
    /// </summary>
    public partial class FormCompra : Form
    {
     
        DateTime dataCompra = DateTime.Now;
        //Atributo responsavel por registrar a data de compra

        DateTime dataPagamento;
        //Atributo responsavel por registrar a data de pagamento
        //Pode-se unir os dois atributos acima, e manipulalo de acordo com a situação.
 
        Compra compra;
        //Atributo responsavel por resgistrar a compra para em seguida salva-la no banco de dados

        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        public FormCompra()
        {
            InitializeComponent();
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
            //Verificação de pagamento
            if(chkPago.Checked == true)
            {
                dataPagamento = DateTime.Now;
            }

            //double total = compra.calcularTotal(ProdutoDao.buscarPorDescricao(new Produto(txtProduto.Text)), int.Parse(txtQuantidade.Text));

            //Instanciação de objeto para salva-lo no Banco de Dados
            compra = new Compra(0, dataPagamento, dataCompra, ProdutoDao.buscarPorDescricao(new Produto(txtProduto.Text)).PrecoUnitario * int.Parse(txtQuantidade.Text),
                ClienteDao.buscarPorNome(new Cliente(txtCliente.Text)));
            
            //Invocação do metodos para salvar o objeto acima
            CompraDao.salvar(compra);

            ///Não sei para que serve <<
            ItemProdutoDao.salvar(new ItemProduto(0, int.Parse(txtQuantidade.Text), compra, ProdutoDao.buscarPorDescricao(new Produto(txtProduto.Text))));
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
    }
}
