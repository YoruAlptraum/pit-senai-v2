using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PIT_SENAI_V2.Classes;

namespace PIT_SENAI_V2.Dados
{
    public partial class frm4_5Historico : Form
    {
        Caixa caixa = new Caixa();
        Gerencia ge = new Gerencia();
        public frm4_5Historico()
        {
            InitializeComponent();
            //carregar dgvs
            pesquisarMovCaixa();
            pesquisarNotas();
            pesquisarFechamentos();
            pesquisarClientes();
            KeyPreview = true;
        }

        //pesquisar
        private void pesquisarMovCaixa()
        {
            dgvMovCaixa.DataSource = caixa.dtMovDoCaixa(txbPesquisarMovCaixa.Text);
        }
        private void pesquisarNotas()
        {
            dgvNotas.DataSource = caixa.dtNotas(txbPesquisarNotas.Text);
        }
        private void pesquisarFechamentos()
        {
            dgvFechamentos.DataSource = caixa.dtFechamentos(txbPesquisarFechamentos.Text);
        }
        private void pesquisarClientes()
        {
            dgvClientes.DataSource = ge.getClientes(false, txbPesquisarClientes.Text);
        }

        //txb
        private void txbPesquisarMovCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisarMovCaixa.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        private void txbPesquisarNotas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisarNotas.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        private void txbPesquisarFechamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisarFechamentos.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        private void txbPesquisarClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisarClientes.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        //botões
        private void btnPesquisarMovCaixa_Click(object sender, EventArgs e)
        {
            pesquisarMovCaixa();
        }
        private void btnPesquisarNotas_Click(object sender, EventArgs e)
        {
            pesquisarNotas();
        }
        private void btnPesquisarFechamentos_Click(object sender, EventArgs e)
        {
            pesquisarFechamentos();
        }
        private void btnPesquisarClientes_Click(object sender, EventArgs e)
        {
            pesquisarClientes();
        }     
    }
}
