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
    public partial class frm4_1Nota : Form
    {
        DataTable dt;
        Caixa caixa = new Caixa();
        public frm4_1Nota()
        {
            InitializeComponent();
            popularCmbTiposDeMovimento();
            popularCmbFormasDePagamento();
            cmbTipoDeMovimento.SelectedIndex = 
                cmbFormaDePagamento.SelectedIndex = 0;
            btnEmitirNota.Enabled = btnValidarIdOrdem.Enabled = txbIdOrdem.Enabled = false;
            nudValor.Minimum = 0;
            nudValor.Maximum = 999999;
        }
        private void popularCmbTiposDeMovimento()
        {
            cmbTipoDeMovimento.Items.Clear();
            cmbTipoDeMovimento.Items.Add("Tipo de Movimento");
            string[] tiposDeMovimento ={
                "Recebimento",
                "Pagamento",
                "Est. Debt",
                "Est. Cred"
            };
            for (int i= 0; i< tiposDeMovimento.Length; i++)
            {
                cmbTipoDeMovimento.Items.Add(tiposDeMovimento[i]);
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
                lblIdOrdem.Text = "ID Nota:";
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
                cmbFormaDePagamento.SelectedIndex == 0 ||
                nudValor.Value == 0) btnEmitirNota.Enabled = false;
            else btnEmitirNota.Enabled = true;
        }

        private void btnValidarIdOrdem_Click(object sender, EventArgs e)
        {
            if (lblIdOrdem.Text.Contains("ID Ordem:"))
            {
                var v = caixa.validarOrdem(txbIdOrdem.Text);
                lblValidacao.Text = v.mensagem;
                if (v.valido)
                {
                    txbDescricao.Text = v.obs;
                    nudValor.Value = v.valor;
                }
            }
            else
            {
                var v = caixa.validarNota(txbIdOrdem.Text);
                lblValidacao.Text = v.mensagem; 
                if (v.valido)
                {
                    nudValor.Value = v.valor;
                }
            }
        }

        private void btnEmitirNota_Click(object sender, EventArgs e)
        {
            string mensagem = "";
            switch (cmbTipoDeMovimento.SelectedItem.ToString())
            {
                case "Recebimento":
                    if (caixa.notaRecebimento(cmbFormaDePagamento.Text, txbIdOrdem.Text,
                        cmbTipoDeMovimento.Text, txbDescricao.Text, nudValor.Value.ToString()))
                    {
                        mensagem = "Recebimento registrado";
                    }
                    else mensagem = "Erro com o banco de dados";
                    break;
                case "Pagamento":
                    break;
                case "Est. Debt":
                    break;
                case "Est. Cred":
                    break;
                default:
                    mensagem = "Falha ao procurar tipo de movimento selecionado";
                    break;
            }
            MessageBox.Show(mensagem);
        }
    }
}
