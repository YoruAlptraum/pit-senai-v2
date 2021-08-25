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
    public partial class frm4_4PesquisarID : Form
    {
        Caixa caixa = new Caixa();
        public frm4_4PesquisarID()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void btnPesquisarID_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void txbSelecionarID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                pesquisar();
            }
        }


        private void pesquisar()
        {
            lblMensagem.Text = caixa.pesquisarID(txbSelecionarID.Text);
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosGlobais.sair(this);
        }
    }
}
