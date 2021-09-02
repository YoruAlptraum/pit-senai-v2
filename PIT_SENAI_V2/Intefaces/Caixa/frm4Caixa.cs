using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using PIT_SENAI_V2.Classes;

namespace PIT_SENAI_V2.Dados
{
    public partial class frm4Caixa : Form
    {
        Caixa caixa = new Caixa();
        public frm4Caixa()
        {
            InitializeComponent();
            atualizar();
        }
        public void atualizar()
        {
            this.Text = "Caixa: " + DadosGlobais.usuario;
            menuToolStripMenuItem.Enabled = false;
            btnFecharCaixa.Enabled = btnNota.Enabled =
                tsmiFecharCaixa.Enabled = tsmiNota.Enabled = DadosGlobais.caixaAberto;
            btnAbrirCaixa.Enabled = 
                tsmiAbrirCaixa.Enabled = !DadosGlobais.caixaAberto;
        }
        private void btnNota_Click(object sender, EventArgs e)
        {
            //gerar nota
            caixa.abrirNota(this);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            caixa.abrirCadastrarCliente(this);
        }

        private void btnAtualizarCadastro_Click(object sender, EventArgs e)
        {
            caixa.abrirAtualizarCliente(this);
        }
        private void btnPesquisarID_Click(object sender, EventArgs e)
        {
            caixa.abrirPesquisarID(this);
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            caixa.abrirHistorico(this);
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            caixa.abrirAbrirCaixa(this);
        }
        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            caixa.abrirFecharCaixa(this);
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

        private void tsmiAbrirCaixa_Click(object sender, EventArgs e)
        {
            caixa.abrirAbrirCaixa(this);
        }

        private void tsmiFecharCaixa_Click(object sender, EventArgs e)
        {
            caixa.abrirFecharCaixa(this);
        }
        #endregion

    }
}