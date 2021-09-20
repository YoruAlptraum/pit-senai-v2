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
    public partial class AddBase2 : Form
    {
        DataTable dt;
        Gerencia ge = new Gerencia();
        bool atualizar;
        string id;
        public AddBase2(bool atualizar,params string[] id)
        {
            InitializeComponent();
            this.atualizar = atualizar;
            cmbAtivo.Items.Add("Desligado");
            cmbAtivo.Items.Add("Ativo");
            if (atualizar)
            {
                this.Text = "Atualizar ...: "+id[0];
                btnConfirmar.Text = "Atualizar";
                this.id = id[0];
                //dt = ge.get (this.id);
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
                this.Text = "Cadastrar ...";
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

        }
    }
}
