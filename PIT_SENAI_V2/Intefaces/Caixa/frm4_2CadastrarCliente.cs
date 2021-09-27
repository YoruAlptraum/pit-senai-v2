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
        Gerencia ge = new Gerencia();
        bool cadastrar;
        DataTable contatos;
        string idCliente;
        frm4Caixa main;
        public frm4_2CadastrarCliente(frm4Caixa main,bool cadastrar,
            params string[] idCliente)
        {
            this.main = main;
            InitializeComponent();
            this.cadastrar = cadastrar;
            if (cadastrar)
            {
                this.Text = "Cadastrar Cliente";
                btnCadastrar.Text = "Cadastrar";
                resetarForm();
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
            btnRemoverContato.Enabled = false;
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
                var r = ge.adicionarCliente(txbNome.Text, txbDocumento.Text, txbEndereco.Text,
                    txbCep.Text, DadosGlobais.id.ToString(), txbBanco.Text, contatos1);
                MessageBox.Show(r.mensagem);
                if (r.ok)
                {
                    resetarForm();
                }
            }
            else
            {
                var r = ge.atualizarCliente(txbNome.Text, txbDocumento.Text, txbEndereco.Text,
                    txbCep.Text, DadosGlobais.id.ToString(), txbBanco.Text, 1, this.idCliente,
                    contatos1);
                MessageBox.Show(r.mensagem);
                if (r.ok)
                {
                    main.abrirAtualizarCadastro();
                    this.Close();
                }
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

        private void dgvContatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContatos.SelectedRows.Count > 0) 
                btnRemoverContato.Enabled = true;
            else btnRemoverContato.Enabled = false;
        }
    }
}