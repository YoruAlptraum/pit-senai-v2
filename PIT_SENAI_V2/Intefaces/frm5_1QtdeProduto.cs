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
    public partial class frm5_1QtdeProduto : Form
    {
        string id;
        bool adicionar;
        int max;
        Vendedor ven;
        public frm5_1QtdeProduto(string id,int max,bool adicionar,Vendedor ven)
        {
            InitializeComponent();
            this.id = id;
            this.adicionar = adicionar;
            this.ven = ven;
            nudQtde.DecimalPlaces = 0;
            nudQtde.Minimum = 0;
            if (adicionar)
            {
                this.Text = "Quantidade a adicionar";
            }
            else
            {
                this.Text = "Quantidade a remover";
            }
            nudQtde.Maximum = max;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (adicionar)
            {
                if(ven.adicionarItemAOrdem(id, (int)nudQtde.Value))
                {
                    this.Close();
                    MessageBox.Show("Itens adicionados");
                }
                else
                {
                    MessageBox.Show("Erro com o banco de dados");
                }
                
            }
            else
            {
                if(ven.removerItemDaOrdem(id, (int)nudQtde.Value))
                {
                    this.Close();
                    MessageBox.Show("Itens removidos");
                }
                else
                {
                    MessageBox.Show("Erro com o banco de dados");
                }
            }
        }
    }
}
