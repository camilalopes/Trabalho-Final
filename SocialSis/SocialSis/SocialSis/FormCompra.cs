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
    public partial class FormCompra : Form
    {
        DateTime dataCompra = DateTime.Now;

        DateTime dataPagamento;

        Compra compra;

        public FormCompra()
        {
            InitializeComponent();
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            dgvCompra.DataSource = CompraDao.buscarTodos(new CompraAux());

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {


            //verifica se a compra foi paga, se sim passa a data de pagamento
            if(chkPago.Checked == true)
            {
                dataPagamento = DateTime.Now;
            }

            //double total = compra.calcularTotal(ProdutoDao.buscarPorDescricao(new Produto(txtProduto.Text)), int.Parse(txtQuantidade.Text));

            //cria o objeto compra para ser salvo
            compra = new Compra(0, dataPagamento, dataCompra, ProdutoDao.buscarPorDescricao(new Produto(txtProduto.Text)).PrecoUnitario * int.Parse(txtQuantidade.Text),
                ClienteDao.buscarPorNome(new Cliente(txtCliente.Text)));
            
            CompraDao.salvar(compra);

            ItemProdutoDao.salvar(new ItemProduto(0, int.Parse(txtQuantidade.Text), compra, ProdutoDao.buscarPorDescricao(new Produto(txtProduto.Text))));
        }

        //evento do teclado, quando o usuario digitar algo a lista de clientes sera carregada
        private void txtCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCliente.Text != "")
            {

                listaCliente.Visible = true;
                listaCliente.DataSource = ClienteDao.buscarListaPorNome(new Cliente(txtCliente.Text));

            }
            else
                listaCliente.Visible = false;
        }

        //evento do teclado, quando o usuario digitar algo a lista de clientes sera carregada
        private void txtProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtProduto.Text != "")
            {
                listaProduto.Visible = true;
                listaProduto.DataSource = ProdutoDao.buscarListaPorDescricao(new Produto(txtProduto.Text));
            }
            else
                listaProduto.Visible = false;
        }

        private void listaCliente_Click(object sender, EventArgs e)
        {
            Cliente clienteAux = ClienteDao.buscarPorNome(new Cliente(listaCliente.SelectedItem.ToString()));
            txtCliente.Text = listaCliente.SelectedItem.ToString();
            listaCliente.Visible = false;
        }

        private void listaProduto_Click(object sender, EventArgs e)
        {
            Produto produtoAux = ProdutoDao.buscarPorDescricao(new Produto(listaProduto.SelectedItem.ToString()));
            txtProduto.Text = listaProduto.SelectedItem.ToString();
            listaProduto.Visible = false;
        }
    }
}
