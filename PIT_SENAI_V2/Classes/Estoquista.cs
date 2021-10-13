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
	p.idProduto as 'id',
	p.nomeProduto as 'produto',
	p.preco,
	p.estoqueMinimo,
	coalesce(ct.emEstoque,0) as 'emEstoque',
	c.categoria,
	f.fornecedor	
from 
	produtos as p
left join 
	estoque as e on p.idProduto = e.idProduto
left join 
	categorias as c on p.idCategoria = c.idCategoria
left join
  (
select 
	p.idProduto, Count(*) as 'emEstoque'
from 
	produtos as p
inner join 
	estoque as e 
	on p.idProduto = e.idProduto
inner join 
	categorias as c 
    on p.idCategoria = c.idCategoria
where 
	if(@pesquisa = null, null,
			p.nomeProduto like concat('%',@pesquisa,'%') or
			p.idProduto like @pesquisa)     
	and e.saida is null 
	and (e.vendido is null or e.vendido = 0)
group by p.idProduto
order by p.idProduto asc
) ct
	on p.idProduto = ct.idProduto    
left join
	fornecedores as f 
    on  p.idFornecedor = f.idFornecedor
where
	if(@pesquisa = null, null,
			p.nomeProduto like concat('%',@pesquisa,'%') or
			p.idProduto like @pesquisa)	and
	p.ativo = 1
group by p.idProduto
order by p.idProduto asc
";
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
select 
	idFornecedor as 'id',
    fornecedor,
    responsavel,
    descricao,
    telefone,
    contato,
    email
from 
	fornecedores as f
where 
	if(@pesquisa = null, null,
	f.fornecedor like concat('%',@pesquisa,'%')
	or   
	f.idFornecedor like @pesquisa) and
    ativo = 1;
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
		when vendido = 0 then 'não'
		when vendido = 1 then 'sim'
	end as 'vendido',
	e.entrada,
	e.saida,
	p.idProduto,
	p.nomeProduto as 'produto',
	p.preco as 'preço',
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
	p.nomeProduto like concat('%',@pesquisa,'%') or   
	e.idEstoque like @pesquisa or   
	p.idProduto like @pesquisa or
    e.entrada like concat('%',@pesquisa,'%') or
    e.saida like concat('%',@pesquisa,'%'))
order by e.idestoque asc;
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

        public string registrarEntrada(string idProduto,string qtde)
        {
            string mensagem = "";
            cmd = new MySqlCommand();

            cmd.CommandText = @"
call registrarEntrada(@idProduto,@qtde);
";
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

            using (cmd = new MySqlCommand())
            {
                cmd.CommandText = @"
update
	estoque
set
	saida = curdate()
where idEstoque = @id;
";
                cmd.Parameters.AddWithValue("@id", idEstoque);
            }
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                mensagem = "Saída(s) registrada(s)";
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
