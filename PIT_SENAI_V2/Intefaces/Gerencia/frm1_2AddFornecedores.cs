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
    public partial class frm1_2AddFornecedores : Form
    {
        DataTable dt;
        Gerencia ge = new Gerencia();
        bool atualizar;
        string id;
        frm1_2Fornecedores main;
        public frm1_2AddFornecedores(frm1_2Fornecedores main,bool atualizar,params string[] id)
        {
            InitializeComponent();
            this.atualizar = atualizar;
            this.main = main;
            cmbAtivo.Items.Add("Desligado");
            cmbAtivo.Items.Add("Ativo");
            if (atualizar)
            {
                this.Text = "Atualizar Fornecedor: "+id[0];
                btnConfirmar.Text = "Atualizar";
                this.id = id[0];
                dt = ge.getFornecedor(this.id);
                if (dt.Rows.Count > 0)
                {
                    txbFornecedor.Text = dt.Rows[0]["fornecedor"].ToString();
                    txbResponsavel.Text = dt.Rows[0]["responsavel"].ToString();
                    txbDescricao.Text = dt.Rows[0]["descricao"].ToString();
                    txbTelefone.Text = dt.Rows[0]["telefone"].ToString();
                    txbContato.Text = dt.Rows[0]["contato"].ToString();
                    txbEmail.Text = dt.Rows[0]["email"].ToString();
                    cmbAtivo.SelectedIndex = int.Parse(dt.Rows[0]["ativo"].ToString());
                }
                else
                {
                    MessageBox.Show("Não foi possivel carregar os dados");
                }
            }
            else
            {
                this.Text = "Cadastrar Fornecedor";
                btnConfirmar.Text = "Cadastrar";
                cmbAtivo.SelectedIndex = 1;
                cmbAtivo.Enabled = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool ok = false;
            string mensagem = "";
            if (atualizar)
            {
                var i = ge.atualizarFornecedor(txbFornecedor.Text,txbResponsavel.Text,
                    txbDescricao.Text,txbTelefone.Text,txbContato.Text,txbEmail.Text,
                    cmbAtivo.SelectedIndex,this.id);
                ok = i.ok;
                mensagem = i.mensagem;
            }
            else
            {
                var i = ge.adicionarFornecedor(txbFornecedor.Text,txbResponsavel.Text,
                    txbDescricao.Text,txbTelefone.Text,txbContato.Text,txbEmail.Text);
                ok = i.ok;
                mensagem = i.mensagem;
            }
            if (ok)
            {
                limparCampos();
                main.pesquisar();
            }
            MessageBox.Show(mensagem);
        }
        private void limparCampos()
        {
            //limpar campos
            txbFornecedor.Text = txbResponsavel.Text = txbDescricao.Text =
                txbTelefone.Text = txbContato.Text = txbEmail.Text = "";

        }
    }
}
