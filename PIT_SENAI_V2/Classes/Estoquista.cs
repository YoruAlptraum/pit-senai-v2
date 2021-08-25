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
    select
		p.idProduto,
        p.nomeProduto,
        p.preco,
        p.estoqueMinimo,
        Count(*) as 'emEstoque',
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
    order by idProduto asc;";
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
	select * from fornecedores as f
    where 
		if(@pesquisa = null, null,
		f.fornecedor like concat('%',@pesquisa,'%')
		or   
		f.idFornecedor like @pesquisa);
";
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
	select
		e.idEstoque,
        case 
			when vendido = 0 then 'não vendido'
            when vendido = 1 then 'vendido'
		end as 'status',
        e.entrada,
        e.saida,
		p.idProduto,
        p.nomeProduto,
        p.preco,
        p.estoqueMinimo,
        c.categoria,
        f.fornecedor
    from 
		estoque as e
    inner join 
		produtos as p on e.idProduto = p.idProduto
	inner join 
		categorias as c on c.idCategoria = p.idCategoria
    inner join
		fornecedores as f on f.idFornecedor = p.idFornecedor    
    where 
		if(@pesquisa = null, null,
		p.nomeProduto like concat('%',@pesquisa,'%')        
		or   
		e.idEstoque like @pesquisa
		or   
		p.idProduto like @pesquisa);";
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
