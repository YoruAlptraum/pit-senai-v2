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
    public partial class frmRegistrarEntrada : Form
    {
        Estoquista est = new Estoquista();
        frm3Estoquista main;
        public frmRegistrarEntrada(frm3Estoquista main)
        {
            InitializeComponent();
            this.main = main;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                est.registrarEntrada(txbIdProduto.Text,txbQtde.Text));
            main.UpdateDGVs();
        }
    }
}
