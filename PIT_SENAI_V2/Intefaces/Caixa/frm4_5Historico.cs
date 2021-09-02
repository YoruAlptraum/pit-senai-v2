using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PIT_SENAI_V2.Classes;

namespace PIT_SENAI_V2.Dados
{
    public partial class frm4_5Historico : Form
    {
        Caixa caixa = new Caixa();
        Thread t1;
        public frm4_5Historico()
        {
            InitializeComponent();
            tsmiNota.Enabled = DadosGlobais.caixaAberto;
        }

        #region ToolStripMenu
        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosGlobais.sair(this);
        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caixa.abrirMenu(this);
        }

        private void tsmiNota_Click(object sender, EventArgs e)
        {
            caixa.abrirNota(this);
        }

        private void tsmiCadastrar_Click(object sender, EventArgs e)
        {
            caixa.abrirCadastrarCliente(this);
        }

        private void tsmiAtualizarCadastro_Click(object sender, EventArgs e)
        {
            caixa.abrirAtualizarCliente(this);
        }

        private void tsmiPesquisarID_Click(object sender, EventArgs e)
        {
            caixa.abrirPesquisarID(this);
        }

        private void tsmiHistorico_Click(object sender, EventArgs e)
        {
            caixa.abrirHistorico(this);
        }
        #endregion

    }
}
