using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PIT_SENAI_V2.Dados;

namespace PIT_SENAI_V2.Classes
{
    public static class DadosGlobais
    {
        public static Thread t1;
        //dados do login atual
        public static int id,privilegio;
        public static string usuario;
        public static bool caixaAberto;
        static public void flush()
        {
            id = privilegio = 0;
            usuario = null;
        }
        static public void sair(Form f)
        {
            id = privilegio = 0;
            usuario = null;

            f.Close();
            t1 = new Thread(AbrirLogin);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        static private void AbrirLogin()
        {
            Application.Run(new frm0Login());
        }
    }
}
