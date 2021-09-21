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
    public partial class frm1_6AddCategorias : Form
    {
        DataTable dt;
        Gerencia ge = new Gerencia();
        bool atualizar;
        string id;
        frm1_6Categorias main;
        public frm1_6AddCategorias(frm1_6Categorias main,bool atualizar,params string[] id)
        {
            InitializeComponent();
            this.atualizar = atualizar;
            this.main = main;
            cmbAtivo.Items.Add("Desligado");
            cmbAtivo.Items.Add("Ativo");
            if (atualizar)
            {
                this.Text = "Atualizar Categoria: "+id[0];
                btnConfirmar.Text = "Atualizar";
                this.id = id[0];
                dt = ge.getCategoria(this.id);
                if (dt.Rows.Count > 0)
                {
                    txbCategoria.Text = dt.Rows[0]["categoria"].ToString();
                    cmbAtivo.SelectedIndex = int.Parse(dt.Rows[0]["ativo"].ToString());
                }
                else
                {
                    MessageBox.Show("Não foi possivel carregar os dados");
                }
            }
            else
            {
                this.Text = "Cadastrar Categoria";
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
                var i = ge.atualizarCategoria(txbCategoria.Text,cmbAtivo.SelectedIndex,this.id);
                ok = i.ok;
                mensagem = i.mensagem;
            }
            else
            {
                var i = ge.adicionarCategoria(txbCategoria.Text);
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
            txbCategoria.Text = "";
        }
    }
}
