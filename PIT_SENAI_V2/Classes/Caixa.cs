using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using PIT_SENAI_V2.Classes;
using PIT_SENAI_V2.Dados;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using System.Transactions;
using System.Windows.Forms;

namespace PIT_SENAI_V2.Classes
{
    public class Caixa
    {
        public MySqlDataAdapter da;
        public MySqlCommand cmd;
        public DataTable dt;
        private Conexao con = new Conexao();

        public void cadastrarCliente(string nome, string documento, 
            string endereco, string cep, string banco,DataTable contatos)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    string idCliente;
                    //criar o cliente
                    cmd = new MySqlCommand();
                    cmd.CommandText = @"
                        insert into 
	                        clientes (nome,documento,endereco,cep,idVendedor,
                                        banco) 
                        values(
	                        @nome,
                            @documento,
                            @endereco,
                            @cep,
                            @idVendedor,
                            @banco);
                        select 
                            idCliente 
                        from 
                            clientes 
                        order by idCliente desc 
                        limit 1;
                        ";
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@documento", documento);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@cep", cep);
                    cmd.Parameters.AddWithValue("@idVendedor", DadosGlobais.id);
                    cmd.Parameters.AddWithValue("@banco", banco);
                    cmd.Connection = con.Conectar();
                    idCliente = cmd.ExecuteScalar().ToString();
                    //inserir os contatos do cliente
                    for (int i = 0; i< contatos.Rows.Count;i++)
                    {
                        cmd = new MySqlCommand();
                        cmd.CommandText = @"
                            insert into
                                contatosdosclientes
                            values(
                                @idCliente,
                                @tipoContato,
                                @Contato
                                );
                            ";
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);
                        cmd.Parameters.AddWithValue("@tipoContato", contatos.Rows[i][0]);
                        cmd.Parameters.AddWithValue("@Contato", contatos.Rows[i][1]);
                        cmd.Connection = con.Conectar();
                        cmd.ExecuteNonQuery();                        
                    }
                    scope.Complete();
                }
            }
            catch(MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                con.Desconectar();
            }
        }
        public void atualizarCliente(string nome, string documento,
            string endereco, string cep, string banco, 
            DataTable contatos, string idCliente)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    //atualizar o cliente
                    cmd = new MySqlCommand();
                    cmd.CommandText = @"          
                        update clientes
							set nome = @nome, 
							documento = @documento,
							endereco = @endereco,
							cep = @cep,
							idVendedor = @idVendedor,
							banco = @banco
                        where idCliente = @idCliente;
                        delete from 
                            contatosdosclientes 
                        where 
                            idCliente = @idCliente;
                    ";
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@documento", documento);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@cep", cep);
                    cmd.Parameters.AddWithValue("@idVendedor", DadosGlobais.id);
                    cmd.Parameters.AddWithValue("@banco", banco);
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    //inserir os contatos do cliente
                    for (int i = 0; i < contatos.Rows.Count; i++)
                    {
                        cmd = new MySqlCommand();
                        cmd.CommandText = @"
                            insert into
                                contatosdosclientes
                            values(
                                @idCliente,
                                @tipoContato,
                                @Contato
                                );
                            ";
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);
                        cmd.Parameters.AddWithValue("@tipoContato", contatos.Rows[i][0]);
                        cmd.Parameters.AddWithValue("@Contato", contatos.Rows[i][1]);
                        cmd.Connection = con.Conectar();
                        cmd.ExecuteNonQuery();
                    }
                    scope.Complete();
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                con.Desconectar();
            }

        }
        public DataTable contatos(string idCliente)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
                select 
	                tipoContato as 'Tipo',
                    contato as 'Contato'
                from contatosdosclientes 
                where idCliente = @idCliente;
            ";
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            try
            {
                cmd.Connection = con.Conectar();
                da.Fill(dt);
            }
            catch(MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                con.Desconectar();
            }
            return dt;
        }
        public (string mensagem, bool valido) pesquisarCliente(string idCliente)
        {
            string mensagem;
            bool valido = false;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
                select
	                nome
                from 
	                clientes 
                where 
	                idCliente = @idCliente;
            ";
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            try
            {
                cmd.Connection = con.Conectar();
                string nome = (string)cmd.ExecuteScalar();
                if (nome != null && nome.Length > 0)
                {
                    mensagem = "Cliente: " + nome;
                    valido = true;
                }
                else mensagem = "Cliente não encontrado";
            }
            catch(MySqlException e)
            {
                Debug.WriteLine(e.Message);
                mensagem = "Erro ao se conectar ao banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return (mensagem,valido);
        }
        public DataTable dadosCliente(string idCliente)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
                select
	                nome, documento, endereco,cep,banco
                from 
	                clientes
                where
	                idCliente = @idCliente;
            ";
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            try
            {
                cmd.Connection = con.Conectar();
                da.Fill(dt);
            }
            catch(MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                con.Desconectar();
            }
            return dt;
        }

        public string pesquisarID(string doc)
        {
            string mensagem;
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
                select
	                nome, idCliente
                from
	                clientes
                where
	                documento = @documento;
            ";
            cmd.Parameters.AddWithValue("@documento", doc);
            try
            {
                cmd.Connection = con.Conectar();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //mensagem = $"Cliente:\t {(string)dt.Rows[0]["nome"]} \n" +
                    //    $"ID:\t {dt.Rows[0]["idCliente"]}";
                    mensagem = string.Format("{0,-8} {1}\n{2,-8} {3}",
                        "Cliente:",(string)dt.Rows[0]["nome"],
                        "ID:",dt.Rows[0]["idCliente"]);
                }
                else
                {
                    mensagem = "Documento não registrado";
                }
            }
            catch(MySqlException e)
            {
                Debug.WriteLine(e.Message);
                mensagem = "Erro com o banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return mensagem;
        }

        #region Menus
        Thread t1;
        //Menu
        public void abrirMenu(Form f)
        {
            f.Close();
            t1 = new Thread(abrirfrm4Caixa);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        //Nota
        public void abrirNota(Form f)
        {
            frm4_1Nota fn = new frm4_1Nota();
            fn.ShowDialog();
        }
        //Cadastrar
        public void  abrirCadastrarCliente(Form f)
        {
            f.Close();
            t1 = new Thread(abrirfrmCadastrarCliente);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        //Atualizar Cliente
        public void abrirAtualizarCliente(Form f)
        {
            frm4_3SelecionarID si = new frm4_3SelecionarID(f);
            si.ShowDialog();
        }
        //Pesquisar ID
        public void abrirPesquisarID(Form f)
        {
            frm4_4PesquisarID pi = new frm4_4PesquisarID();
            pi.ShowDialog();
        }
        //Historico
        public void abrirHistorico(Form f)
        {
            f.Close();
            t1 = new Thread(abrirfrmHistorico);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        public void abrirAbrirCaixa(Form f)
        {
            frm4_6AbrirCaixa fa = new frm4_6AbrirCaixa();
            fa.ShowDialog();
        }
        //Fechar Caixa
        public void abrirFecharCaixa(Form f)
        {
            frm4_7FecharCaixa fc = new frm4_7FecharCaixa();
            fc.ShowDialog();
        }


        private void abrirfrm4Caixa()
        {
            Application.Run(new frm4Caixa());
        }
        private void abrirfrmCadastrarCliente()
        {
            Application.Run(new frm4_2CadastrarCliente(true));
        }
        private void abrirfrmHistorico()
        {
            Application.Run(new frm4_5Historico());
        }

        #endregion
    }
}
