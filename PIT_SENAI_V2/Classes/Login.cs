using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIT_SENAI_V2.Dados;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

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
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();

            cmd.CommandText = @"
            select 
                idFuncionario,idAcesso,nome 
            from 
                funcionarios
            where 
                idFuncionario = @id and senha = md5(@senha)";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.Conectar();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    //preencher os dados globais
                    DadosGlobais.id = Convert.ToInt32(dr["idFuncionario"]);
                    DadosGlobais.privilegio = Convert.ToInt32(dr["idAcesso"]);
                    DadosGlobais.usuario = dr["nome"].ToString();
                    //retornar o acesso
                    return true;
                }
                else return false;
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
