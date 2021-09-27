using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PIT_SENAI_V2.Classes;

namespace PIT_SENAI_V2.Dados
{
    public partial class frm4_3SelecionarID : Form
    {
        Thread t1;
        Caixa caixa = new Caixa();
        string idCliente;
        frm4Caixa main;
        public frm4_3SelecionarID(frm4Caixa main)
        {
            InitializeComponent();
            this.main = main;
            btnSelecionar.Enabled = false;
            btnPesquisar.BackgroundImage = Properties.Resources.Search;
            btnPesquisar.BackgroundImageLayout = ImageLayout.Stretch;
            txbIDCliente.Focus();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.Close();
            main.abrirSubFrm(new frm4_2CadastrarCliente(main,false, idCliente),"Atualizar Cliente");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //pesquisar se o cliente é valido e mostrar o nome do cliente pesquisado
            var cliente = caixa.pesquisarCliente(txbIDCliente.Text);
            lblCliente.Text = cliente.mensagem;
            idCliente = txbIDCliente.Text;
            //alterar o estado do btnSelecionar para ser igual a validação
            btnSelecionar.Enabled = cliente.valido;
        }
    }
}
