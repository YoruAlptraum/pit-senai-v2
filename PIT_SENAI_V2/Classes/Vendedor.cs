using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace PIT_SENAI_V2.Classes
{
    class Vendedor
    {
        private Conexao con = new Conexao();
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        private DataTable dt;
        public string idOrdem;

        public (bool conectado,bool retomar,DataTable dt) retomarOrdem()
        {
            bool conectado,retomar;
            cmd = new MySqlCommand();
            dt = new DataTable();
            da = new MySqlDataAdapter(cmd);
            cmd.CommandText = @"                
                select
                    ifnull(idCliente,'') as 'idCliente' ,
                    ifnull(observacao,'') as 'observacao',
                    ifnull(idOrdem,'') as 'idOrdem'
                from 
                    ordens 
                where completa = 0
                and idFuncionario = @idFuncionario
                order by idOrdem desc limit 1 ;
            ";
            cmd.Parameters.AddWithValue("@idFuncionario", DadosGlobais.id);
            try
            {
                cmd.Connection = con.Conectar();
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    idOrdem = (string)dt.Rows[0]["idOrdem"];
                    retomar = true;
                }
                else
                {
                    retomar = false;
                }
                conectado = true;
            }
            catch(MySqlException e)
            {
                conectado = retomar = false;
                Debug.WriteLine(e.Message);
            }
            finally
            {
                con.Desconectar();
            }
            return (conectado,retomar,dt);
        }
        public DataTable procurarProdutos(string pesquisa)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
                select
		            p.idProduto as 'codigo',
                    p.nomeProduto as 'produto',
                    p.preco as 'preço',
                    Count(*) as 'estoque',
                    c.categoria,
                    f.fornecedor
                from 
		            produtos as p
	            inner join 
		            estoque as e on e.idProduto = p.idProduto
	            inner join 
		            categorias as c on c.idCategoria = p.idCategoria
                inner join
		            fornecedores as f on f.idFornecedor = p.idFornecedor    
                where 
		            if(@pesquisa = null, null,
				            p.nomeProduto like concat('%',@pesquisa,'%') or
				            p.idProduto like @pesquisa)
		            and saida is null
                    and vendido = 0
	            group by p.idProduto
                order by p.idProduto asc;";
            cmd.Parameters.AddWithValue("@pesquisa", pesquisa);
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
        public bool gerarOrdem(string observacao,string documento)
        {
            cmd = new MySqlCommand();

            cmd.CommandText = @"
                insert into
                    ordens
                        (observacao,idCliente,idFuncionario)
                values
                    (@observacao,(
                select idCliente
                from clientes 
                where documento = @documento)
                ,@idFuncionario);
                select idOrdem 
                from ordens 
                where idFuncionario = @idFuncionario 
                order by idOrdem desc 
                limit 1;";
            cmd.Parameters.AddWithValue("@observacao", observacao);
            cmd.Parameters.AddWithValue("@documento",documento);
            cmd.Parameters.AddWithValue("@idFuncionario", DadosGlobais.id);

            try
            {
                cmd.Connection = con.Conectar();
                this.idOrdem = cmd.ExecuteScalar().ToString();
                return true;
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
        public void atualizarOrdem(string observacao,string documento)
        {
            cmd = new MySqlCommand();
            cmd.CommandText = @"
                update ordens 
                set 
	                observacao = @observacao,
	                idCliente = (
                        select idCliente
                        from clientes 
                        where documento = @documento),
	                dataEmissao = curdate(),
                    completa = 1
                where idOrdem = @idOrdem;
                ";
            cmd.Parameters.AddWithValue("@observacao", observacao);
            cmd.Parameters.AddWithValue("@documento", documento);
            cmd.Parameters.AddWithValue("@idOrdem", idOrdem);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
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
        public DataTable ItensDaOrdem()
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();

            cmd.CommandText = @"
                select
	                p.idProduto as 'ID',
                    p.nomeProduto as 'Produto',
                    p.preco as 'Preço',
                    Count(*) as 'Qtde'
                from produtos as p
                inner join estoque as e
	                on p.idProduto = e.idProduto
                inner join itensdasordens as i
	                on e.idEstoque = i.idEstoque 
                    where i.idOrdem = @idOrdem
                group by p.idProduto;";
            cmd.Parameters.AddWithValue("@idOrdem", idOrdem);
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
        public string totalOrdem()
        {
            cmd = new MySqlCommand();
            string soma;

            cmd.CommandText = @"
                select 
	                sum(p.preco)
                from produtos as p
                inner join estoque as e
	                on p.idProduto = e.idProduto
                inner join itensdasordens as i
	                on i.idEstoque = e.idEstoque
                where i.idOrdem = @idOrdem;";
            cmd.Parameters.AddWithValue("@idOrdem", idOrdem);

            try
            {
                cmd.Connection = con.Conectar();
                soma = cmd.ExecuteScalar().ToString();
            }
            catch(MySqlException e)
            {
                Debug.WriteLine(e.Message);
                soma = "Erro com a base de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return soma;
        }
        public string procurarCliente(string documento)
        {
            string mensagem;
            cmd = new MySqlCommand();
            
            cmd.CommandText = @"
                select nome 
                from clientes 
                where documento = @documento;";
            cmd.Parameters.AddWithValue("@documento",documento);

            try
            {
                cmd.Connection = con.Conectar();
                if (cmd.ExecuteScalar() != null)
                {
                    mensagem = "Cliente: " + cmd.ExecuteScalar().ToString();
                }
                else mensagem = "Cliente: não cadastrado";
            }
            catch(MySqlException e)
            {
                mensagem = "Erro com o banco de dados";
                Debug.WriteLine(e.Message);
            }
            finally
            {
                con.Desconectar();
            }
            return mensagem;
        }
        public void adicionarItemAOrdem(string idProduto)
        {
            cmd = new MySqlCommand();

            cmd.CommandText = @"
                call adicionarItemAOrdem(@idOrdem,@idProduto);";
            cmd.Parameters.AddWithValue("@idOrdem", idOrdem);
            cmd.Parameters.AddWithValue("@idProduto", idProduto);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
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
        public void descartarOrdem()
        {
            cmd = new MySqlCommand();
            cmd.CommandText = @"                
                update estoque 
                    set vendido = 0 
                where idEstoque in 
                    (select idEstoque 
                        from itensdasordens 
                            where idOrdem = @idOrdem);
                delete from itensdasordens
                    where idOrdem = @idOrdem;
                delete from ordens 
                    where idOrdem = @idOrdem;
            ";
            cmd.Parameters.AddWithValue("@idOrdem", idOrdem);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                idOrdem = "";
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
    }
}
