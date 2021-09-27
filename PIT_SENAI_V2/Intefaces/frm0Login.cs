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
using System.Threading;

namespace PIT_SENAI_V2.Dados
{
    public partial class frm0Login : Form
    {
        Login login = new Login();
        Thread t1;
        public frm0Login()
        {
            InitializeComponent();
            btnConfirmar.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            confirmar();
        }
        private void confirmar()
        {
            //Se o login estiver correto permitir entrada
            int.TryParse(txbUsuario.Text, out int idUsuario);
            if (login.VerificarLogin(idUsuario, txbSenha.Text))
            {
                //Abrir formulario de acordo com o tipo de acesso
                Acessar(DadosGlobais.privilegio);
            }
            else
            {
                MessageBox.Show("Favor conferir credenciais", "Login não encontrado");
            }
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {
            if(txbSenha.Text.Length >0 && txbUsuario.Text.Length > 0)
            {
                btnConfirmar.Enabled = true;
            }
        }

        private void Acessar(int priv)
        {
            this.Close();
            switch (priv)
            {
                case 1:
                    t1 = new Thread(AbrirGerencia);
                    break;
                case 2:
                    t1 = new Thread(AbrirFinanceiro);
                    break;
                case 3:
                    t1 = new Thread(AbrirEstoquista);
                    break;
                case 4:
                    t1 = new Thread(AbrirCaixa);
                    break;
                default:
                    t1 = new Thread(AbrirVendedor);
                    break;
            }
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirGerencia()
        {
            Application.Run(new frm1Gerencia());
        }
        private void AbrirFinanceiro()
        {
            Application.Run(new frm2Financeiro());
        }
        private void AbrirEstoquista()
        {
            Application.Run(new frm3Estoquista());
        }
        private void AbrirCaixa()
        {
            Application.Run(new frm4Caixa());
        }
        private void AbrirVendedor()
        {
            Application.Run(new frm5Vendedor());
        }

        private void txbSenha_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnConfirmar.Enabled)
            {
                confirmar();
            }
        }
    }
}
