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
        DataTable dt,dtC,dtF;
        Gerencia ge = new Gerencia();
        bool atualizar;
        string id;
        frm1_4Produtos main;
        public frm1_4AddProdutos(frm1_4Produtos main,bool atualizar,params string[] id)
        {
            InitializeComponent();
            this.atualizar = atualizar;
            this.main = main;
            nudEstoqueMin.Maximum = nudPreco.Maximum = 999999;
            nudEstoqueMin.Minimum = nudPreco.Minimum = 0;
            nudPreco.DecimalPlaces = 2;

            dtC = ge.getCategorias(); 
            foreach (DataRow dr in dtC.Rows)
            {
                cmbCategoria.Items.Add(dr[0]);
            }
            dtF = ge.getFornecedores();
            foreach (DataRow dr in dtF.Rows)
            {
                cmbFornecedor.Items.Add(dr[0]);
            }
            if (cmbCategoria.Items.Count > 0 && cmbFornecedor.Items.Count > 0)
            {
                cmbCategoria.SelectedIndex = cmbFornecedor.SelectedIndex = 0;
            }

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
                    txbProduto.Text = dt.Rows[0]["nomeProduto"].ToString();
                    nudPreco.Value = (decimal)dt.Rows[0]["preco"];
                    nudEstoqueMin.Value = (int)dt.Rows[0]["estoqueMinimo"];
                    cmbCategoria.Text = dt.Rows[0]["categoria"].ToString();
                    cmbFornecedor.Text = dt.Rows[0]["fornecedor"].ToString();
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
                var i = ge.atualizarProduto(txbProduto.Text,nudPreco.Value,(int)nudEstoqueMin.Value,
                    cmbCategoria.Text,cmbFornecedor.Text,cmbAtivo.SelectedIndex,this.id);
                ok = i.ok;
                mensagem = i.mensagem;
            }
            else
            {
                var i = ge.adicionarProduto(txbProduto.Text,nudPreco.Value,(int)nudEstoqueMin.Value,
                    cmbCategoria.Text,cmbFornecedor.Text);
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
            txbProduto.Text = "";
            nudPreco.Value = nudEstoqueMin.Value = 0;
        }
    }
}
