using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIT_SENAI_V2.Dados;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using System.Transactions;

namespace PIT_SENAI_V2.Classes
{
    class Login
    {
        Conexao con = new Conexao();
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        public bool VerificarLogin(int id, string senha)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cmd = new MySqlCommand();
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();

                    cmd.CommandText = @"
select 
    idFuncionario,idAcesso,nome 
from 
    funcionarios
where 
    idFuncionario = @id and senha = md5(@senha) and
ativo = 1";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Connection = con.Conectar();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        //preencher os dados globais
                        DadosGlobais.id = Convert.ToInt32(dr["idFuncionario"]);
                        DadosGlobais.privilegio = Convert.ToInt32(dr["idAcesso"]);
                        DadosGlobais.usuario = dr["nome"].ToString();
                        cmd = new MySqlCommand();
                        da = new MySqlDataAdapter(cmd);
                        dt = new DataTable();
                        cmd.CommandText = @"
select 
	horaAbertura,
	horaFechamento
from 
	fechamentocaixa 
where 
	dataFechamento = curdate();
";
                        cmd.Connection = con.Conectar();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0 &&
                            dt.Rows[0]["horaFechamento"].ToString() == "")
                        {
                            Debug.WriteLine("caixa Aberto");
                            DadosGlobais.caixaAberto = true;
                        }
                        else
                        {
                            Debug.WriteLine("caixa Fechado: "+dt.Rows.Count+" "+dt.Rows[0]["horaFechamento"].ToString());
                            DadosGlobais.caixaAberto = false;
                        }
                        //retornar o acesso
                        return true;
                    }
                    else return false;
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e);
                return false;
            }
            finally
            {
                con.Desconectar();
            }
        }
    }
}
