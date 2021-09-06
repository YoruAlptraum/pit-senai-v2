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
    public partial class frm1Gerencia : Form
    {
        public frm1Gerencia()
        {
            InitializeComponent();
            this.Text = "Gerência: " + DadosGlobais.usuario;
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosGlobais.sair(this);
        }
    }
}
