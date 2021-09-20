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
    public partial class frm1_1AddFuncionarios : Form
    {
        DataTable dt,dt2;
        Gerencia ge = new Gerencia();
        bool atualizar;
        string idFuncionario;
        public frm1_1AddFuncionarios(bool atualizar,params string[] idFuncionario)
        {
            InitializeComponent();
            this.atualizar = atualizar;
            cmbAtivo.Items.Add("Desligado");
            cmbAtivo.Items.Add("Ativo");

            dt2 = ge.getAcessos();
            foreach(DataRow dr in dt2.Rows)
            {
                cmbAcessos.Items.Add(dr[0]);
            }
            cmbAcessos.SelectedIndex = 4;
            if (atualizar)
            {
                this.Text = "Atualizar funcionario: "+idFuncionario[0];
                btnConfirmar.Text = "Atualizar";
                this.idFuncionario = idFuncionario[0];
                dt = ge.getFuncionario(this.idFuncionario);
                if (dt.Rows.Count > 0)
                {
                    txbNome.Text = dt.Rows[0]["nome"].ToString();
                    txbDocumento.Text = dt.Rows[0]["documento"].ToString();
                    txbEndereco.Text = dt.Rows[0]["endereco"].ToString();
                    txbCep.Text = dt.Rows[0]["cep"].ToString();
                    txbTelefone.Text = dt.Rows[0]["telefone"].ToString();
                    txbContato.Text = dt.Rows[0]["contato"].ToString();
                    txbEmail.Text = dt.Rows[0]["email"].ToString();
                    cmbAcessos.Text = dt.Rows[0]["acesso"].ToString();
                    cmbAtivo.SelectedIndex = int.Parse(dt.Rows[0]["ativo"].ToString());
                }
                else
                {
                    MessageBox.Show("Não foi possivel carregar os dados");
                }
            }
            else
            {
                this.Text = "Cadastrar funcionario";
                btnConfirmar.Text = "Cadastrar";
                cmbAtivo.SelectedIndex = 1;
                cmbAtivo.Enabled = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool ok;
            string mensagem;
            if(txbNome.Text.Trim().Length > 0)
            {
                if (txbDocumento.Text.Trim().Length > 0)
                { 
                    if (txbSenha.Text.Trim().Length > 0 && txbConfirmacao.Text.Equals(txbSenha.Text))
                    {
                        if (atualizar)
                        {
                            var i = ge.atualizarFuncinario(txbNome.Text, txbSenha.Text, txbDocumento.Text, txbEndereco.Text,
                                txbCep.Text, txbTelefone.Text, txbContato.Text, txbEmail.Text,
                                (cmbAcessos.SelectedIndex + 1).ToString(),cmbAtivo.SelectedIndex, idFuncionario);
                            ok = i.ok;
                            mensagem = i.mensagem;
                        }
                        else
                        {
                            var i = ge.adicionarFuncinario(txbNome.Text, txbSenha.Text, txbDocumento.Text, txbEndereco.Text,
                                txbCep.Text, txbTelefone.Text, txbContato.Text, txbEmail.Text,
                                (cmbAcessos.SelectedIndex + 1).ToString());
                            ok = i.ok;
                            mensagem = i.mensagem;
                        }
                        if (ok)
                        {
                            limparCampos();
                        }
                        MessageBox.Show(mensagem);
                    }
                    else
                    {
                        MessageBox.Show("As senhas não conferem", "Verifique as senhas");
                    }
                }
                else
                {
                    MessageBox.Show("Favor informar o documento do funcionário", "Documento é necessário");
                }
            }
            else
            {
                MessageBox.Show("Favor informar o nome do funcionário", "Nome necessário");
            }
        }
        private void limparCampos()
        {
            txbNome.Text = txbSenha.Text = txbConfirmacao.Text = txbDocumento.Text =
                txbEndereco.Text = txbCep.Text = txbTelefone.Text = txbContato.Text = txbEmail.Text = "";
        }
    }
}
