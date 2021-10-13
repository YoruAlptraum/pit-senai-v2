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
    public partial class frm3Estoquista : Form
    {
        Estoquista est = new Estoquista();
        public frm3Estoquista()
        {
            InitializeComponent();
            UpdateDGVs();
            KeyPreview = true;
            this.Text = "Controle de Estoque: " + DadosGlobais.usuario;
        }
        private void btnPesquisarEstoque_Click(object sender, EventArgs e)
        {
            PesquisarEstoque();
        }
        private void PesquisarEstoque()
        {
            dgvEstoque.DataSource = est.selectEstoque(txbPesquisarEstoque.Text);
            btnSaida.Enabled = false;
        }
        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            PesquisarProduto();
        }
        private void PesquisarProduto()
        {
            dgvProdutos.DataSource = est.selectProdutos(txbPesquisarProduto.Text);
        }
        private void btnPesquisarFornecedor_Click(object sender, EventArgs e)
        {
            PesquisarFornecedor();
        }
        private void PesquisarFornecedor()
        {
            dgvFornecedores.DataSource = est.selectFornecedores(txbPesquisarFornecedor.Text);
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            string ms = "um ou mais itens selecionados ja foram registrados como retirados.";
            bool f = true;
            for (int j = 0; j < dgvEstoque.SelectedRows.Count; j++)
            {
                if (dgvEstoque.SelectedRows[j].Cells["saida"].Value.ToString() != "")
                {
                    f = false;
                }
            }
            if (f)
            {
                for (int i = 0; i < dgvEstoque.SelectedRows.Count; i++)
                {
                    ms = est.registrarSaida(
                        dgvEstoque.SelectedRows[i].Cells[0].Value.ToString());
                }
            }
            MessageBox.Show(ms);
            UpdateDGVs();
        }
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            frmRegistrarEntrada re = new frmRegistrarEntrada(this);
            re.ShowDialog();
        }

        private void dgvEstoque_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEstoque.SelectedRows.Count > 0) btnSaida.Enabled = true;
            else btnSaida.Enabled = false;
        }
        public void UpdateDGVs()
        {
            dgvEstoque.DataSource = est.selectEstoque("");
            dgvFornecedores.DataSource =  est.selectFornecedores("");
            dgvProdutos.DataSource = est.selectProdutos("");
        }
        private void frm3Estoquista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txbPesquisarFornecedor.ContainsFocus) PesquisarFornecedor();
                else if (txbPesquisarProduto.ContainsFocus) PesquisarProduto();
                else PesquisarEstoque();
                e.SuppressKeyPress = true;
            }
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosGlobais.sair(this);
        }
    }
}
