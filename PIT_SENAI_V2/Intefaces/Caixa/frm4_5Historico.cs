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
            ToolTip tip = new ToolTip();
            tip.SetToolTip(btnPesquisarMovCaixa, "Pesquisar pela observação, id ou data do movimento.");
            ToolTip tip1 = new ToolTip();
            tip1.SetToolTip(btnPesquisarNotas, "Pesquisar pela data de emissão da nota.");
            ToolTip tip2 = new ToolTip();
            tip2.SetToolTip(btnPesquisarFechamentos, "Pesquisar pela data ou observação do fechamento ou pelo nome do funcionário de abertura ou fechamento do caixa.");
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
    }
}
