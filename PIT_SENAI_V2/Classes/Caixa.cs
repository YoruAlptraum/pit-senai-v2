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

        public bool cadastrarCliente(string nome, string documento, 
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
                    return true;
                }
            }
            catch(MySqlException e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
            finally
            {
                con.Desconectar();
            }
        }
        public bool atualizarCliente(string nome, string documento,
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
                    return true;
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
                return false;
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
        public bool abrirCaixa(int saldoInicial)
        {
            bool retorno;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
                insert into fechamentocaixa
	                (horaAbertura,idFuncionarioAbertura,saldoInicial)
                values
	                (time(now()),@idFuncionario,@saldoInicial)";
            cmd.Parameters.AddWithValue("@idFuncionario",DadosGlobais.id);
            cmd.Parameters.AddWithValue("@saldoInicial", saldoInicial);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch(MySqlException e)
            {
                Debug.WriteLine(e.Message);
                retorno = false;
            }
            finally
            {
                con.Desconectar();
            }
            return DadosGlobais.caixaAberto = retorno;
        }
        public bool fecharCaixa(int valorContado,string obs)
        {
            bool retorno;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
            update fechamentocaixa
            set
	            horaFechamento = time(now()),
                idFuncionarioFechamento = @idFuncionarioFechamento,
                valorFechamento = @valorFechamento,
                valorContado = @valorContado,
                observacao = @observacao
            where dataFechamento = curdate();";
            cmd.Parameters.AddWithValue("@idFuncionarioFechamento", DadosGlobais.id);
            //cmd.Parameters.AddWithValue("@valorFechamento",);
            cmd.Parameters.AddWithValue("@valorContado", valorContado);
            cmd.Parameters.AddWithValue("@observacao", obs);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                retorno = false;
            }
            catch(MySqlException e)
            {
                Debug.WriteLine(e.Message);
                retorno = true;
            }
            finally
            {
                con.Desconectar();
            }
            return DadosGlobais.caixaAberto = retorno;
        }
        public DataTable getFormaDePagamento()
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"select formadepagamento from formasdepagamento";
            try
            {
                cmd.Connection = con.Conectar();
                da.Fill(dt);
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                con.Desconectar();
            }
            return dt;
        }
        public (bool valido,string mensagem, string obs, int valor) validarOrdem(string idOrdem)
        {
            bool valido;
            string mensagem, obs;
            int valor;
            try
            {
                using(TransactionScope scope = new TransactionScope())
                {
                    using (MySqlCommand cmd = new MySqlCommand(@"
                        select observacao 
                        from ordens 
                       where idOrdem = @idOrdem", 
                       con.Conectar()))
                    {
                        cmd.Parameters.AddWithValue("@idOrdem", idOrdem);
                        obs = (string)cmd.ExecuteScalar();
                        if (obs != null)
                        {
                            mensagem = "Ordem encontrada";
                            valido = true;
                        }
                        else
                        {
                            mensagem = "Ordem não encontrada";
                            valido = false;
                        }
                    }

                    cmd = new MySqlCommand();
                    cmd.CommandText = @"
                        select 
                         ifnull(sum(p.preco),0) 
                        from 
                         itensdasordens as i
                        inner join
                         estoque as e on e.idEstoque = i.idEstoque
                        inner join
                         produtos as p on p.idProduto = e.idProduto
                        where i.idOrdem = @idOrdem;";
                    cmd.Parameters.AddWithValue("@idOrdem", idOrdem);
                    cmd.Connection = con.Conectar();
                    valor = Convert.ToInt32(cmd.ExecuteScalar());
                    scope.Complete();
                    return (valido,mensagem,obs,valor);
                }
            }
            catch(MySqlException e)
            {
                Debug.WriteLine(e.Message);
                valido = false;
                mensagem = "Erro com o banco de dados";
                obs = "";
                valor = 0;
                return (valido, mensagem, obs, valor);
            }
            finally
            {
                con.Desconectar();
            }
        }
        public (bool valido,string mensagem, int valor) validarNota(string idNota)
        {
            bool valido;
            string mensagem;
            int valor;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
                select 
	                sum(preco)
                from 
                    itemsdasnotas as i 
                inner join
	                estoque as e on e.idEstoque = i.idEstoque
                inner join
	                produtos as p on p.idProduto = e.idProduto
                where i.idNota = @idNota;
            ";
            cmd.Parameters.AddWithValue("@idNota", idNota);
            try
            {
                cmd.Connection = con.Conectar();
                valor = (int)cmd.ExecuteScalar();
                if (valor != 0)
                {
                    valido = true;
                    mensagem = "Nota encontrada";
                }
                else 
                { 
                    valido = false;
                    mensagem = "Nota não encontrada";
                }
                return (valido, mensagem, valor);
            }
            catch(MySqlException e)
            {
                valido = false;
                mensagem = "Erro com o banco de dados";
                valor = 0;
                Debug.WriteLine(e.Message);
                return (valido, mensagem, valor);
            }
            finally
            {
                con.Desconectar();
            }
        }
        public bool notaRecebimento(string FormaDePagamento, string idOrdem, string tipoDeMovimento,
            string observacao, string valor)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cmd = new MySqlCommand();
                    cmd.CommandText = @"
    insert into notas
	    (idFormaDePagamento,idOrdem)
    values
	    ((select 
		    idFormaDePagamento 
        from 
		    formasdepagamento 
        where 
		    FormaDePagamento = @FormaDePagamento),
	    @idOrdem);

    set @idNota = (select idNota from notas order by idNota desc limit 1);

    insert into movimentoDoCaixa
	    (dataMovimento, horaMovimento,tipoDeMovimento,observacao,valor,idNota,idFuncionario)
    value
	    (curdate(), time(now()),@tipoDeMovimento, @observacao,@valor,@idNota,@idFuncionario);
    insert into 
        itensdasnotas (select i.idEstoque, @idNota from itensdasordens as i where i.idOrdem = @idOrdem);
    ";
                    cmd.Parameters.AddWithValue("@FormaDePagamento", FormaDePagamento);
                    cmd.Parameters.AddWithValue("@idOrdem", idOrdem);
                    cmd.Parameters.AddWithValue("@tipoDeMovimento", tipoDeMovimento);
                    cmd.Parameters.AddWithValue("@observacao", observacao);
                    cmd.Parameters.AddWithValue("@valor", valor);
                    cmd.Parameters.AddWithValue("@idFuncionario", DadosGlobais.id);
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    scope.Complete();
                    return true;
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
            finally
            {
                con.Desconectar();
            }
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
        public void abrirAbrirCaixa(frm4Caixa f)
        {
            frm4_6AbrirCaixa fa = new frm4_6AbrirCaixa(f);
            fa.ShowDialog();
        }
        //Fechar Caixa
        public void abrirFecharCaixa(frm4Caixa f)
        {
            frm4_7FecharCaixa fc = new frm4_7FecharCaixa(f);
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
