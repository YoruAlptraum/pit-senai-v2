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
    public partial class frm1_1Funcionarios : Form
    {
        Gerencia ge = new Gerencia();
        bool historico = false;
        public frm1_1Funcionarios()
        {
            InitializeComponent();
            KeyPreview = true;
            pesquisar();
            btnAtualizar.Enabled = btnRemover.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }
        private void pesquisar()
        {
            dgvFuncionarios.DataSource = ge.getFuncionarios(historico, txbPesquisa.Text);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                ge.removerFuncionario(dgvFuncionarios.SelectedRows[0].Cells[0].Value.ToString()));
            pesquisar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frm1_1AddFuncionarios af = new frm1_1AddFuncionarios(false);
            af.ShowDialog();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frm1_1AddFuncionarios af = new frm1_1AddFuncionarios(true,
                dgvFuncionarios.SelectedRows[0].Cells[0].Value.ToString());
            af.ShowDialog();
        }

        private void frm1_1Funcionarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                historico = !historico;
                pesquisar();
            }
        }

        private void dgvFuncionarios_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvFuncionarios.SelectedRows.Count > 0)
            {
                btnAtualizar.Enabled = btnRemover.Enabled = true;
            }
            else
            {
                btnAtualizar.Enabled = btnRemover.Enabled = false;
            }
        }

        private void txbPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
