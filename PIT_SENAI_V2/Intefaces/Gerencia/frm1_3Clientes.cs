﻿using System;
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
    public partial class frm1_3Clientes : Form
    {
        Gerencia ge = new Gerencia();
        bool historico = false;
        public frm1_3Clientes()
        {
            InitializeComponent();
            pesquisar();
            ToolTip tip = new ToolTip();
            tip.SetToolTip(btnPesquisar, "Pesquisar pelo nome do cliente");
            btnAtualizar.Enabled = btnRemover.Enabled = false;
            KeyPreview = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }
        public void pesquisar()
        {
            dgv.DataSource = ge.getClientes(historico,txbPesquisa.Text);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ge.removerCliente(dgv.SelectedRows[0].Cells[0].Value.ToString()));
            pesquisar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frm1_3AddClientes add = new frm1_3AddClientes(this,false);
            add.ShowDialog();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frm1_3AddClientes add = new frm1_3AddClientes(this,true,dgv.SelectedRows[0].Cells[0].Value.ToString());
            add.ShowDialog();
        }

        private void txbPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void frm1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                historico = !historico;
                pesquisar();
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                btnAtualizar.Enabled = btnRemover.Enabled = true;
            }
            else
            {
                btnAtualizar.Enabled = btnRemover.Enabled = false;
            }
        }
    }
}
