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

namespace PIT_SENAI_V2.Dados
{
    public partial class frm4_2CadastrarCliente : Form
    {
        Caixa caixa = new Caixa();
        bool cadastrar;
        DataTable contatos;
        string idCliente;
        public frm4_2CadastrarCliente(bool cadastrar,
            params string[] idCliente)
        {
            InitializeComponent();
            this.cadastrar = cadastrar;
            if (cadastrar)
            {
                this.Text = "Cadastrar Cliente";
                btnCadastrar.Text = "Cadastrar";
                resetarForm();

                dgvContatos.ColumnCount = 2;
                dgvContatos.ColumnHeadersVisible = true;
                dgvContatos.Columns[0].Name = "Tipo";
                dgvContatos.Columns[1].Name = "Contato";
            }
            else if (idCliente.Length > 0)
            {
                var cliente = caixa.dadosCliente(idCliente[0]);
                string nomeCliente = (string)cliente.Rows[0]["nome"];
                this.idCliente = idCliente[0];
                this.Text = "Atualizar Cadastro - Cliente: " + nomeCliente;
                    
                btnCadastrar.Text = "Atualizar";
                contatos = caixa.contatos(idCliente[0]);
                dgvContatos.DataSource = contatos;


                txbNome.Text = nomeCliente;
                txbDocumento.Text = (string)cliente.Rows[0]["documento"];
                txbEndereco.Text = (string)cliente.Rows[0]["endereco"];
                txbCep.Text = (string)cliente.Rows[0]["cep"];
                txbBanco.Text = (string)cliente.Rows[0]["banco"];
            }
            tsmiCadastrar.Enabled = btnRemoverContato.Enabled = false;
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

        private void btnCadastrar_Click(object sender, EventArgs e)
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
            if (cadastrar)
            {
                caixa.cadastrarCliente(txbNome.Text,
                    txbDocumento.Text,
                    txbEndereco.Text, txbCep.Text, txbBanco.Text, contatos1);
                resetarForm();
            }
            else
            {
                caixa.atualizarCliente(txbNome.Text,txbDocumento.Text, 
                    txbEndereco.Text, txbCep.Text,txbBanco.Text, contatos1, 
                    idCliente);
                caixa.abrirAtualizarCliente(this);
                this.Close();
            }
        }
        private void resetarForm()
        {
            txbNome.Text = txbDocumento.Text = txbEndereco.Text =
                txbCep.Text = txbBanco.Text = txbTipoContato.Text =
                txbContato.Text = "";
            dgvContatos.DataSource = null;
            dgvContatos.Rows.Clear();
        }

        private void dgvContatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContatos.SelectedRows.Count > 0) 
                btnRemoverContato.Enabled = true;
            else btnRemoverContato.Enabled = false;
        }

        #region ToolStripMenu
        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosGlobais.sair(this);
        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caixa.abrirMenu(this);
        }

        private void tsmiNota_Click(object sender, EventArgs e)
        {
            caixa.abrirNota(this);
        }

        private void tsmiCadastrar_Click(object sender, EventArgs e)
        {
            caixa.abrirCadastrarCliente(this);
        }

        private void tsmiAtualizarCadastro_Click(object sender, EventArgs e)
        {
            caixa.abrirAtualizarCliente(this);
        }

        private void tsmiPesquisarID_Click(object sender, EventArgs e)
        {
            caixa.abrirPesquisarID(this);
        }

        private void tsmiHistorico_Click(object sender, EventArgs e)
        {
            caixa.abrirHistorico(this);
        }

        private void abrirCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caixa.abrirAbrirCaixa(this);
        }

        private void tsmiFecharCaixa_Click(object sender, EventArgs e)
        {
            caixa.abrirFecharCaixa(this);
        }
        #endregion
    }
}