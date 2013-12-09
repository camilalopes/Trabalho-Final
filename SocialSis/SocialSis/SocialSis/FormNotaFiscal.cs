using System;
using System.Collections;
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
    public partial class FormNotaFiscal : Form
    {
        DateTime dataPagamento;

        public FormNotaFiscal()
        {
            InitializeComponent();
        }

        private void FormNotaFiscal_Load(object sender, EventArgs e)
        {
             dgvNota.DataSource = NotaFiscalDao.BuscarTodos(new NotaFiscalAux());
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            DateTime dataCompra = DateTime.Now;



            if(chkPago.Checked == true)
            {
                dataPagamento = DateTime.Now;
            }

            double precoTotal;      

            precoTotal = int.Parse(txtQuantidade.Text) * InsumoDao.BuscarPorDescricao(new Insumo(txtInsumo.Text)).PrecoUnitario;
               

            NotaFiscalDao.Salvar(new NotaFiscal(0, ulong.Parse(txtNBoleto.Text), dataPagamento, dataCompra, 
                DateTime.Parse(txtDataPrevPag.Text), precoTotal,
                FornecedorDao.BuscarPorNome(new Fornecedor(txtFornecedor.Text))));

            NotaFiscal notafiscal = new NotaFiscal();

            int idUltimaNotaFiscal;

            idUltimaNotaFiscal = NotaFiscalDao.BuscarTodos(new NotaFiscal()).Count;

            notafiscal.SetId(idUltimaNotaFiscal);

            ItemInsumoDao.Salvar(new ItemInsumo(0, int.Parse(txtQuantidade.Text),notafiscal,
                InsumoDao.BuscarPorDescricao(new Insumo(txtInsumo.Text))));

            //dgvNota.DataSource = NotaFiscalDao.BuscarTodos(new NotaFiscalAux());



        }

        private void txtFornecedor_KeyUp(object sender, KeyEventArgs e)
        {
            //Verificação de campo nulo, ou com poucos valores
            if (txtFornecedor.Text != "" && txtFornecedor.Text.Length > 2)
            {

                listaFornecedor.Visible = true;
                listaFornecedor.DataSource = FornecedorDao.BuscarListaPorNome(new Fornecedor(txtFornecedor.Text));

            }
            //Contraresposta
            else
                listaFornecedor.Visible = false;

        }

        private void txtInsumo_KeyUp(object sender, KeyEventArgs e)
        {
            //Verificação de campo nulo, ou com poucos valores
            if (txtInsumo.Text != "" && txtInsumo.Text.Length > 2)
            {

                listaInsumo.Visible = true;
                listaInsumo.DataSource = InsumoDao.BuscarListaPorDescricao(new Insumo(txtInsumo.Text));

            }
            //Contraresposta
            else
                listaInsumo.Visible = false;
        }

        private void listaFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedorAux = FornecedorDao.BuscarPorNome(new Fornecedor(listaFornecedor.SelectedItem.ToString()));
            txtFornecedor.Text = listaFornecedor.SelectedItem.ToString();
            listaFornecedor.Visible = false;

        }

        private void listaInsumo_Click(object sender, EventArgs e)
        {
            Insumo insumoAux = InsumoDao.BuscarPorDescricao(new Insumo(listaInsumo.SelectedItem.ToString()));
            txtInsumo.Text = listaInsumo.SelectedItem.ToString();
            listaInsumo.Visible = false;
        }
    }
}
