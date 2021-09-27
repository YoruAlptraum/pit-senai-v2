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
    public partial class frm1_3AddClientes : Form
    {
        DataTable dt,contatos,dtV;
        Gerencia ge = new Gerencia();
        bool atualizar;
        string id;
        frm1_3Clientes main;
        public frm1_3AddClientes(frm1_3Clientes main,bool atualizar,params string[] id)
        {
            InitializeComponent();
            btnRemoverContato.Enabled = false;
            this.atualizar = atualizar;
            this.main = main;
            cmbAtivo.Items.Add("Desligado");
            cmbAtivo.Items.Add("Ativo");

            dtV = ge.getVendedores();
            foreach (DataRow dr in dtV.Rows)
            {
                cmbVendedor.Items.Add(dr[0]);
            }
            if(cmbVendedor.Items.Count > 0)
            {
                cmbVendedor.SelectedIndex = 0;
            }
            if (atualizar)
            {
                this.Text = "Atualizar Cliente: "+id[0];
                btnConfirmar.Text = "Atualizar";
                this.id = id[0];
                dt = ge.getCliente(this.id);
                if (dt.Rows.Count > 0)
                {
                    txbNome.Text = dt.Rows[0]["nome"].ToString();
                    txbDocumento.Text = dt.Rows[0]["documento"].ToString();
                    txbEndereco.Text = dt.Rows[0]["endereco"].ToString();
                    txbCep.Text = dt.Rows[0]["cep"].ToString();
                    cmbVendedor.Text = dt.Rows[0]["vendedor"].ToString();
                    txbBanco.Text = dt.Rows[0]["banco"].ToString();
                    cmbAtivo.SelectedIndex = int.Parse(dt.Rows[0]["ativo"].ToString());
                }
                else
                {
                    MessageBox.Show("Não foi possivel carregar os dados");
                }
                contatos = ge.getContatos(id[0]);
                dgvContatos.DataSource = contatos;
            }
            else
            {
                this.Text = "Cadastrar Cliente";
                btnConfirmar.Text = "Cadastrar";
                cmbAtivo.SelectedIndex = 1;
                cmbAtivo.Enabled = false;
                resetarForm();
            }
        }
        private void resetarForm()
        {
            txbNome.Text = txbDocumento.Text = txbEndereco.Text =
                txbCep.Text = txbBanco.Text = txbTipoContato.Text =
                txbContato.Text = "";

            contatos = new DataTable();
            contatos.Columns.Add("Tipo");
            contatos.Columns.Add("Contato");
            dgvContatos.DataSource = contatos;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DataTable contatos1 = new DataTable();
            foreach (DataGridViewColumn col in dgvContatos.Columns)
            {
                contatos1.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgvContatos.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dRow = contatos1.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    contatos1.Rows.Add(dRow);
                }
            }
            bool ok = false;
            string mensagem = "";
            if (atualizar)
            {
                var i = ge.atualizarCliente(txbNome.Text,txbDocumento.Text,txbEndereco.Text,
                    txbCep.Text,cmbVendedor.Text,txbBanco.Text,cmbAtivo.SelectedIndex,this.id,
                    contatos1);
                ok = i.ok;
                mensagem = i.mensagem;
            }
            else
            {
                var i = ge.adicionarCliente(txbNome.Text, txbDocumento.Text, txbEndereco.Text,
                    txbCep.Text, cmbVendedor.Text, txbBanco.Text, contatos1);
                ok = i.ok;
                mensagem = i.mensagem;
            }
            if (ok)
            {
                resetarForm();
                main.pesquisar();
            }
            MessageBox.Show(mensagem);
        }

        private void dgvContatos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvContatos.SelectedRows.Count > 0)
            {
                btnRemoverContato.Enabled = true;
            }
            else
            {
                btnRemoverContato.Enabled = false;
            }
        }

        private void btnAdicionarContato_Click(object sender, EventArgs e)
        {
            string[] strArray = { txbTipoContato.Text, txbContato.Text };
            contatos.Rows.Add(strArray);
            txbContato.Text = "";
        }

        private void btnRemoverContato_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvContatos.SelectedRows[0];
            if (!row.IsNewRow)
            {
                dgvContatos.Rows.RemoveAt(row.Index);
            }
        }
    }
}
