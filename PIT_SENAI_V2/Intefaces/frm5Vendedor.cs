using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIT_SENAI_V2.Classes;

namespace PIT_SENAI_V2.Dados
{
    public partial class frm5Vendedor : Form
    {
        private Estoquista est = new Estoquista();
        private Vendedor ven = new Vendedor();
        private bool ordem;

        public frm5Vendedor()
        {
            InitializeComponent();
            btnImprimir.Enabled = btnDescartar.Enabled = 
                btnAdicionar.Enabled = grpOrdem.Enabled = false;
            pesquisarCatalogo();
        }
        private void pesquisarCatalogo()
        {
            dgvCatalogo.DataSource = ven.procurarProdutos(txbPesquisarCatalogo.Text);
        }
        private void btnNovaOrdem_Click(object sender, EventArgs e)
        {
            grpOrdem.Enabled = ordem = ven.gerarOrdem(txbDescricao.Text,txbPesquisarCliente.Text);
        }
        private void btnPesquisarCatalogo_Click(object sender, EventArgs e)
        {
            pesquisarCatalogo();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //adicionar o produto selecionado a lista de items da ordem
            ven.adicionarItemAOrdem(
                dgvCatalogo.SelectedRows[0].Cells["codigo"].Value.ToString());
            //atualizar a dgvItemsDaOrdem
            dgvItemsDaOrdem.DataSource = ven.ItensDaOrdem();
            lblTotal.Text = ven.totalOrdem();
        }
        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            lblCliente.Text = ven.procurarCliente(txbPesquisarCliente.Text);
        }
        private void dgvCatalogo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(ordem)btnAdicionar.Enabled = true;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Atualizar a ordem
            ven.atualizarOrdem(txbDescricao.Text, txbPesquisarCliente.Text);
            //Imprimir a ordem
            //idOrdem, valorOrdem

        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            //Descartar a ordem e os items dessa ordem
            ven.descartarOrdem();
        }
    }
}
