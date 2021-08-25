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
        private Vendedor ven = new Vendedor();
        private bool ordem;

        public frm5Vendedor()
        {
            InitializeComponent();
            btnImprimir.Enabled = btnDescartar.Enabled = 
                btnAdicionar.Enabled = grpOrdem.Enabled = ordem = false;
            this.Text = "Vendedor: " + DadosGlobais.usuario;
            pesquisarCatalogo();
        }
        private void pesquisarCatalogo()
        {
            dgvCatalogo.DataSource = ven.procurarProdutos(txbPesquisarCatalogo.Text);
        }
        private void btnNovaOrdem_Click(object sender, EventArgs e)
        {
            grpOrdem.Enabled = btnAdicionar.Enabled = 
                btnImprimir.Enabled = btnDescartar.Enabled = ordem =
                ven.gerarOrdem(txbDescricao.Text,txbPesquisarCliente.Text);
            btnNovaOrdem.Enabled = !ordem;
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
            lblTotal.Text = "Total: " + ven.totalOrdem();
            pesquisarCatalogo();
        }
        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            lblCliente.Text = ven.procurarCliente(txbPesquisarCliente.Text);
        }
        private void dgvCatalogo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(ordem)btnAdicionar.Enabled = true;
        }
        private void resetOrdem()
        {
            btnImprimir.Enabled = btnDescartar.Enabled =
                btnAdicionar.Enabled = grpOrdem.Enabled = ordem = false;
            txbPesquisarCliente.Text = txbDescricao.Text = lblCliente.Text = "";
            lblTotal.Text = "Total:";
            pesquisarCatalogo();
            dgvItemsDaOrdem.DataSource = null;
            dgvItemsDaOrdem.Rows.Clear();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Atualizar a ordem
            ven.atualizarOrdem(txbDescricao.Text, txbPesquisarCliente.Text);
            //Imprimir a ordem caso o resultado do dialogo for OK
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                PrintDocument.Print();
            }
            //resetar
            resetOrdem();
        }
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //idOrdem, valorOrdem
            string txt = 
                $"ID da ordem: \t{ven.idOrdem}\n" +
                $"Total a pagar:\t {ven.totalOrdem()}";
            e.Graphics.DrawString(txt, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }
        private void btnDescartar_Click(object sender, EventArgs e)
        {
            //Descartar a ordem e os items dessa ordem
            ven.descartarOrdem();
            //resetar
            resetOrdem();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosGlobais.sair(this);
        }
    }
}
