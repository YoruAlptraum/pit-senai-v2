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
    public partial class frm4_6AbrirCaixa : Form
    {
        Caixa caixa = new Caixa();
        frm4Caixa main;
        public frm4_6AbrirCaixa(frm4Caixa f)
        {
            InitializeComponent();
            this.main = f;
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosGlobais.sair(this);
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            if (caixa.abrirCaixa((int)nudSaldoInicial.Value))
            {
                MessageBox.Show("Caixa aberto");
                this.Close();
                main.atualizar();
            }
            else MessageBox.Show("Algum erro ocorreu");
        }
    }
}
