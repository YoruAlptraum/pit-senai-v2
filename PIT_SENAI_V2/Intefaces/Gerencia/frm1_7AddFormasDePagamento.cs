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
    public partial class frm1_7AddFormasDePagamento : Form
    {
        DataTable dt;
        Gerencia ge = new Gerencia();
        bool atualizar;
        string id;
        frm1_7FormasDePagamento main;
        public frm1_7AddFormasDePagamento(frm1_7FormasDePagamento main,bool atualizar,params string[] id)
        {
            InitializeComponent();
            this.atualizar = atualizar;
            this.main = main;
            cmbAtivo.Items.Add("Desligado");
            cmbAtivo.Items.Add("Ativo");
            if (atualizar)
            {
                this.Text = "Atualizar Forma de Pagamento: "+id[0];
                btnConfirmar.Text = "Atualizar";
                this.id = id[0];
                dt = ge.getFormaDePagamento(this.id);
                if (dt.Rows.Count > 0)
                {
                    txbFormaDePagamento.Text = dt.Rows[0]["formaDePagamento"].ToString();
                    cmbAtivo.SelectedIndex = int.Parse(dt.Rows[0]["ativo"].ToString());
                }
                else
                {
                    MessageBox.Show("Não foi possivel carregar os dados");
                }
            }
            else
            {
                this.Text = "Cadastrar Forma de Pagamento";
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
                var i = ge.atualizarFormaDePagamento(txbFormaDePagamento.Text,cmbAtivo.SelectedIndex,
                    this.id);
                ok = i.ok;
                mensagem = i.mensagem;
            }
            else
            {
                var i = ge.adicionarFormaDePagamento(txbFormaDePagamento.Text);
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
            txbFormaDePagamento.Text = "";
        }
    }
}
