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
    class Estoquista
    {
        Conexao conexao = new Conexao();
        MySqlDataAdapter da;
        MySqlCommand cmd;
        DataTable dt;
        public DataTable selectProdutos(string pesquisa)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();

            cmd.CommandText = @"
            call procurarProdutos(@pesquisa);";
            cmd.Parameters.AddWithValue("@pesquisa",pesquisa);

            try
            {
                cmd.Connection = conexao.Conectar();
                da.Fill(dt);
            }
            catch(MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
            return dt;
        }
        public DataTable selectFornecedores(string pesquisa)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();

            cmd.CommandText = @"
            call procurarFornecedores(@pesquisa);";
            cmd.Parameters.AddWithValue("@pesquisa", pesquisa);

            try
            {
                cmd.Connection = conexao.Conectar();
                da.Fill(dt);
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
            return dt;
        }
        public DataTable selectEstoque(string pesquisa)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();

            cmd.CommandText = @"
            call procurarestoque(@pesquisa)";
            cmd.Parameters.AddWithValue("@pesquisa", pesquisa);

            try
            {
                cmd.Connection = conexao.Conectar();
                da.Fill(dt);
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
            return dt;

        }

        public string registrarEntrada(string idProduto,string qtde)
        {
            string mensagem = "";
            cmd = new MySqlCommand();

            cmd.CommandText = @"call registrarEntrada(@idProduto,@qtde);";
            cmd.Parameters.AddWithValue("@idProduto", idProduto);
            cmd.Parameters.AddWithValue("@qtde", qtde);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                mensagem = "Entrada(s) registrada(s)";
            }
            catch (MySqlException e)
            {
                mensagem = e.Message;
                Debug.WriteLine(mensagem);
            }
            finally
            {
                conexao.Desconectar();
            }
            return mensagem;
        }
        public string registrarSaida(string idEstoque)
        {
            string mensagem = "";
            cmd = new MySqlCommand();

            cmd.CommandText = @"call registrarSaida(@idEstoque)";
            cmd.Parameters.AddWithValue("@idEstoque", idEstoque);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                mensagem = "Saída registrada";
            }
            catch (MySqlException e)
            {
                mensagem = e.Message;
                Debug.WriteLine(mensagem);
            }
            finally
            {
                conexao.Desconectar();
            }
            return mensagem;
        }
    }
}
