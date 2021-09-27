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
using PIT_SENAI_V2.Properties;

namespace PIT_SENAI_V2.Dados
{
    public partial class frm4Caixa : Form
    {
        Form subForm = null;
        Caixa caixa = new Caixa();
        public frm4Caixa()
        {
            InitializeComponent();
            atualizar();

            //inserir imagens
            btnMenus.Image = (Image)(new Bitmap(
                Properties.Resources.Menus, new Size(30, 30)));
            btnNota.Image = (Image)(new Bitmap(
                Properties.Resources.notas, new Size(30, 30)));
            btnCadastrar.Image = (Image)(new Bitmap(
                Properties.Resources.Cadastrar, new Size(30, 30)));
            btnAtualizarCadastro.Image = (Image)(new Bitmap(
                Properties.Resources.Atualizar_Cadastro, new Size(30, 30)));
            btnPesquisarID.Image = (Image)(new Bitmap(
                Properties.Resources.Pesquisar_ID, new Size(30, 30)));
            btnHistorico.Image = (Image)(new Bitmap(
                Properties.Resources.Historico, new Size(30, 30)));
            btnAbrirCaixa.Image = (Image)(new Bitmap(
                Properties.Resources.Abrir_Caixa, new Size(30, 30)));
            btnFecharCaixa.Image = (Image)(new Bitmap(
                Properties.Resources.Fechar_Caixa, new Size(30, 30)));
        }
        public void atualizar()
        {
            this.Text = "Caixa: " + DadosGlobais.usuario;
            btnAbrirCaixa.Enabled = !DadosGlobais.caixaAberto;
            btnNota.Enabled = btnFecharCaixa.Enabled = DadosGlobais.caixaAberto;
            fecharMenus();
        }
        public void abrirSubFrm(Form f, string t)
        {
            if (lblTitulo.Text != t)
            {
                if (subForm != null)
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
            }
        }

        private void btnMenus_Click(object sender, EventArgs e)
        {
            fecharMenus();
        }
        public void fecharMenus()
        {
            if (subForm != null)
            {
                lblTitulo.Text = "Menus";
                subForm.Close();
                subForm = null;
            }
        }
        private void btnNota_Click(object sender, EventArgs e)
        {
            frm4_1Nota fn = new frm4_1Nota();
            fn.ShowDialog();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            abrirSubFrm(new frm4_2CadastrarCliente(this,true), "Cadastrar");
        }
        private void btnAtualizarCadastro_Click(object sender, EventArgs e)
        {
            abrirAtualizarCadastro();
        }
        public void abrirAtualizarCadastro()
        {
            frm4_3SelecionarID si = new frm4_3SelecionarID(this);
            si.ShowDialog();
        }
        private void btnPesquisarID_Click(object sender, EventArgs e)
        {
            frm4_4PesquisarID pi = new frm4_4PesquisarID();
            pi.ShowDialog();
        }
        private void btnHistorico_Click(object sender, EventArgs e)
        {
            abrirSubFrm(new frm4_5Historico(), "Histórico");
        }
        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            frm4_6AbrirCaixa fa = new frm4_6AbrirCaixa(this);
            fa.ShowDialog();
        }
        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            abrirSubFrm(new frm4_7FecharCaixa(this),"Fechar Caixa");
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosGlobais.sair(this);
        }
    }
}