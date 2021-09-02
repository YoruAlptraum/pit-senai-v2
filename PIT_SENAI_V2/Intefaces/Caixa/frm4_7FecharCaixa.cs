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
    public partial class frm4_7FecharCaixa : Form
    {
        Caixa caixa = new Caixa();
        frm4Caixa main;
        public frm4_7FecharCaixa(frm4Caixa f)
        {
            InitializeComponent();
            this.main = f;
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosGlobais.sair(this);
        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            if (caixa.fecharCaixa((int)nudTotalContado.Value,txbObs.Text))
            {
                MessageBox.Show("Caixa Fechado");
                this.Close();
                main.atualizar();
            }
            else MessageBox.Show("Algum erro ocorreu");
        }
    }
}
