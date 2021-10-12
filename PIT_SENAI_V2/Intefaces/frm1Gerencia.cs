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
using PIT_SENAI_V2;

namespace PIT_SENAI_V2.Dados
{
    public partial class frm1Gerencia : Form
    {
        Form subForm = null;
        public frm1Gerencia()
        {
            InitializeComponent();
            this.Text = "Gerência: " + DadosGlobais.usuario;
            btnMenus.Image = (Image)(new Bitmap(
                Properties.Resources.Menus, new Size(30, 30)));
            btnClientes.Image = (Image)(new Bitmap(
                Properties.Resources.Clientes, new Size(30, 30)));
            btnDevolucao.Image = (Image)(new Bitmap(
                Properties.Resources.Devoluções, new Size(30, 30)));
            btnCategorias.Image = (Image)(new Bitmap(
                Properties.Resources.Categorias,new Size(30,30)));
            btnFormasDePagamento.Image = (Image)(new Bitmap(
                Properties.Resources.Pagamento, new Size(30, 30)));
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosGlobais.sair(this);
        }
        private void abrirSubFrm(Form f,string t)
        {
            if(lblTitulo.Text != t)
            {
                if(subForm != null)
                {
                    subForm.Close();
                }
                subForm = f;
                subForm.TopLevel = false;
                subForm.AutoScroll = true;
                subForm.Dock = DockStyle.Fill;
                this.pnlConteudo.Controls.Add(subForm);
                subForm.Show();
                lblTitulo.Text = t;
                lblTitulo.Left = (pnlTitulo.Width - lblTitulo.Width) / 2;
            }
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            abrirSubFrm(new frm1_1Funcionarios(),"Funcionários");
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            abrirSubFrm(new frm1_2Fornecedores(), "Fornecedores");
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirSubFrm(new frm1_3Clientes(), "Clientes");
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            abrirSubFrm(new frm1_4Produtos(), "Produtos");
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            abrirSubFrm(new frm1_6Categorias(), "Categorias");
        }

        private void btnFormasDePagamento_Click(object sender, EventArgs e)
        {
            abrirSubFrm(new frm1_7FormasDePagamento(), "Formas de Pagamento");
        }

        private void btnMenus_Click(object sender, EventArgs e)
        {
            if(subForm != null)
            {
                lblTitulo.Text = "Menus";
                lblTitulo.Left = (pnlTitulo.Width - lblTitulo.Width) / 2;
                subForm.Close();
                subForm = null;
            }
        }
        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            abrirSubFrm(new frm1_5Devolucoes(), "Devoluções");
        }
    }
}
