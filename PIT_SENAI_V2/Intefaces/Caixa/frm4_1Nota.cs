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
using PIT_SENAI_V2.Properties;

namespace PIT_SENAI_V2.Dados
{
    public partial class frm4_1Nota : Form
    {
        DataTable dt;
        Caixa caixa = new Caixa();
        bool idValido = false;
        public frm4_1Nota()
        {
            InitializeComponent();
            popularCmbTiposDeMovimento();
            popularCmbFormasDePagamento();
            cmbTipoDeMovimento.SelectedIndex = 
                cmbFormaDePagamento.SelectedIndex = 0;
            btnEmitirNota.Enabled = btnValidarIdOrdem.Enabled = txbIdOrdem.Enabled = false;
            nudValor.Minimum = nudTroco.Minimum = 0;
            nudValor.Maximum = nudTroco.Maximum = 999999;
            nudValor.DecimalPlaces = nudTroco.DecimalPlaces = 2;
        }
        private void popularCmbTiposDeMovimento()
        {
            cmbTipoDeMovimento.Items.Clear();
            cmbTipoDeMovimento.Items.Add("Tipo de Movimento");
            dt = caixa.getTiposDeMovimento();
            for (int i= 0; i< dt.Rows.Count; i++)
            {
                cmbTipoDeMovimento.Items.Add(dt.Rows[i][0]);
            }
        }
        private void popularCmbFormasDePagamento()
        {
            cmbFormaDePagamento.Items.Clear();
            cmbFormaDePagamento.Items.Add("Forma de Pagamento");
            dt = caixa.getFormaDePagamento();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbFormaDePagamento.Items.Add(dt.Rows[i][0]);
            }
        }

        private void cmbTipoDeMovimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoDeMovimento.SelectedItem.ToString().Contains("Recebimento"))
            {
                lblIdOrdem.Text = "ID Ordem:";
                btnValidarIdOrdem.Enabled = txbIdOrdem.Enabled = lblValidacao.Enabled = true;
            }
            else if (cmbTipoDeMovimento.SelectedItem.ToString().Contains("Est."))
            {
                lblIdOrdem.Text = "ID Mov:";
                btnValidarIdOrdem.Enabled = txbIdOrdem.Enabled = lblValidacao.Enabled = true;
            }
            else
            {
                btnValidarIdOrdem.Enabled = txbIdOrdem.Enabled = lblValidacao.Enabled = false;
            }
        }

        private void cmbTipoDeMovimento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbTipoDeMovimento.SelectedIndex == 0 ||
                cmbFormaDePagamento.SelectedIndex == 0)
                btnEmitirNota.Enabled = false;
            else btnEmitirNota.Enabled = true;
        }

        private void btnValidarIdOrdem_Click(object sender, EventArgs e)
        {
            if (lblIdOrdem.Text.Contains("ID Ordem:"))
            {
                var v = caixa.validarOrdem(txbIdOrdem.Text);
                lblValidacao.Text = v.mensagem;
                idValido = v.valido;
                if (idValido)
                {
                    txbDescricao.Text = v.obs;
                    nudValor.Value = v.valor;
                }
            }
            else
            {
                var v = caixa.validarMovCaixa(txbIdOrdem.Text);
                lblValidacao.Text = v.mensagem;
                idValido = v.valido;
                if (idValido)
                {
                    nudValor.Value = v.valor;
                }
            }
        }

        private void btnEmitirNota_Click(object sender, EventArgs e)
        {
            string mensagem = "Erro com o banco de dados";
            switch (cmbTipoDeMovimento.SelectedItem.ToString())
            {
                case "Recebimento":
                    if (!idValido)
                    {
                        mensagem = "O ID precisa ser válido";
                    }
                    else if (caixa.notaRecebimento(cmbFormaDePagamento.Text, txbIdOrdem.Text,
                        cmbTipoDeMovimento.Text, txbDescricao.Text, nudValor.Value.ToString()))
                    {
                        mensagem = "Recebimento registrado";
                    }
                    break;
                case "Pagamento":
                    if (caixa.notaPagamento(cmbTipoDeMovimento.Text, txbDescricao.Text,
                        nudValor.Value.ToString()))
                    {
                        mensagem = "Pagamento registrado";
                    }
                    break;
                case "Est. Debt":
                    if(!idValido)
                    {
                        mensagem = "O ID precisa ser válido";
                    }
                    else if (caixa.notaEst(cmbTipoDeMovimento.Text, txbDescricao.Text,
                        nudValor.Value.ToString(), txbIdOrdem.Text))
                    {
                        mensagem = "Est. Debt registrado";
                    }
                    break;
                case "Est. Cred":
                    if (!idValido)
                    {
                        mensagem = "O ID precisa ser válido";
                    }
                    else if (caixa.notaEst(cmbTipoDeMovimento.Text, txbDescricao.Text,
                        nudValor.Value.ToString(), txbIdOrdem.Text))
                    {
                        mensagem = "Est. Cred registrado";
                    }
                    break;
                case "Sangria":
                    if (caixa.notaPagamento(cmbTipoDeMovimento.Text, txbDescricao.Text,
                        nudValor.Value.ToString()))
                    {
                        mensagem = "Sangria registrada";
                    }
                    break;
                default:
                    mensagem = "Falha ao procurar tipo de movimento selecionado";
                    break;
            }
            MessageBox.Show(mensagem);
        }

        private void txbIdOrdem_TextChanged(object sender, EventArgs e)
        {
            if (cmbTipoDeMovimento.Text.Equals("Recebimento") &&
                txbIdOrdem.Text.Trim().Length <= 0)
            {
                lblValidacao.Text = "É necessário informar o ID da ordem";
                lblValidacao.ForeColor = Color.Red;
                idValido = false;
            }
            else if (cmbTipoDeMovimento.Text.Contains("Est.") &&
                txbIdOrdem.Text.Trim().Length <= 0)
            {
                lblValidacao.Text = "É necessário informar o ID do movimento";
                lblValidacao.ForeColor = Color.Red;
                idValido = false;
            }
            else
            {
                lblValidacao.Text = "";
                lblValidacao.ForeColor = Color.Black;
            }
        }
        private void nudTroco_ValueChanged(object sender, EventArgs e)
        {
            lblTroco.Text = "Troco: "+(nudTroco.Value - nudValor.Value).ToString();
        }
    }
}
