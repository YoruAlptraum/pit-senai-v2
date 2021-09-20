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
    public partial class frm1_4AddProdutos : Form
    {
        DataTable dt;
        Gerencia ge = new Gerencia();
        bool atualizar;
        string id;
        public frm1_4AddProdutos(bool atualizar,params string[] id)
        {
            InitializeComponent();
            nudEstoqueMin.Maximum = nudPreco.Maximum = 999999;
            nudEstoqueMin.Minimum = nudPreco.Minimum = 0;
            nudPreco.DecimalPlaces = 2;

            //

            this.atualizar = atualizar;
            cmbAtivo.Items.Add("Desligado");
            cmbAtivo.Items.Add("Ativo");
            if (atualizar)
            {
                this.Text = "Atualizar Produto: "+id[0];
                btnConfirmar.Text = "Atualizar";
                this.id = id[0];
                dt = ge.getProduto(this.id);
                if (dt.Rows.Count > 0)
                {

                    cmbAtivo.SelectedIndex = int.Parse(dt.Rows[0]["ativo"].ToString());
                }
                else
                {
                    MessageBox.Show("Não foi possivel carregar os dados");
                }
            }
            else
            {
                this.Text = "Cadastrar Produto";
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
                //var i = ge.atualizar ();
                //ok = i.ok;
                //mensagem = i.mensagem;
            }
            else
            {
                //var i = ge.adicionar ();
                //ok = i.ok;
                //mensagem = i.mensagem;
            }
            if (ok)
            {
                limparCampos();
            }
            MessageBox.Show(mensagem);
        }
        private void limparCampos()
        {
            //limpar campos
            txbProduto.Text = "";
        }
    }
}
