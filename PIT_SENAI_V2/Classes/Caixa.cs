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

        public DataTable contatos(string idCliente)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select 
	tipoContato as 'Tipo',
    contato as 'Contato'
from 
	contatosdosclientes 
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
	idCliente = @idCliente and
    ativo = 1;
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
	idCliente = @idCliente and
    ativo = 1;
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
	documento = @documento and
    ativo = 1;
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
        public (bool aberto, string mensagem) abrirCaixa(int saldoInicial)
        {
            bool retorno;
            string mensagem;
            using (cmd = new MySqlCommand(@"
select 
	horafechamento
from 
	fechamentocaixa
where 
	dataFechamento = curdate();",con.Conectar()))
            {
                try
                {
                    if (cmd.ExecuteScalar() != null)
                    {
                        retorno = false;
                        mensagem = "Só é possivel abrir o caixa uma vez ao dia";
                        return (DadosGlobais.caixaAberto = retorno, mensagem);
                    }
                }
                catch (MySqlException e)
                {
                    Debug.WriteLine(e.Message);
                    retorno = false;
                    mensagem = "Ocorreu um erro com o banco de dados";
                    return (DadosGlobais.caixaAberto = retorno, mensagem);
                }
            }
            cmd = new MySqlCommand();
            cmd.CommandText = @"
insert into fechamentocaixa
	(horaAbertura,idFuncionarioAbertura,saldoInicial)
values
	(time(now()),@idFuncionario,@saldoInicial)
";
            cmd.Parameters.AddWithValue("@idFuncionario",DadosGlobais.id);
            cmd.Parameters.AddWithValue("@saldoInicial", saldoInicial);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                retorno = true;
                mensagem = "Caixa aberto";
            }
            catch(MySqlException e)
            {
                Debug.WriteLine(e.Message);
                retorno = false;
                mensagem = "Ocorreu um erro com o banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return (DadosGlobais.caixaAberto = retorno,mensagem);
        }
        public bool fecharCaixa(int valorContado,string obs)
        {
            decimal saldoInicial;
            using (cmd = new MySqlCommand(@"
select
    saldoInicial
from
    fechamentocaixa
where
    dataFechamento = curdate()", con.Conectar()))
            {
                saldoInicial = (decimal)cmd.ExecuteScalar();
            };
            bool retorno;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
update fechamentocaixa
set
	horaFechamento = time(now()),
    idFuncionarioFechamento = @idFuncionarioFechamento,
    valorFechamento = 
(	
select
    (select sum(valor)
	from
		movimentodocaixa
	where
		dataMovimento = curdate() and
        idtipodemovimento in (1,3))
	+
	(@saldoI)
	-
    (select sum(valor)
	from
		movimentodocaixa
	where
		dataMovimento = curdate() and
        idtipodemovimento in (2,4))
),
    valorContado = @valorContado,
    observacao = @observacao
where dataFechamento = curdate();
";
            cmd.Parameters.AddWithValue("@idFuncionarioFechamento", DadosGlobais.id);
            cmd.Parameters.AddWithValue("@valorContado", valorContado);
            cmd.Parameters.AddWithValue("@observacao", obs);
            cmd.Parameters.AddWithValue("@saldoI",saldoInicial);
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
        public DataTable dtTotalDia()
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select
	t.tipoDeMovimento,
	sum(m.valor) as 'totalDia'
from
	movimentodocaixa as m
inner join
	tiposdemovimento as t
    on t.idTipoDeMovimento = m.idTipoDeMovimento
where
    m.dataMovimento = curdate()
group by
	m.idTipoDeMovimento
union
	select
		'Saldo Inicial',
        (select 
			saldoInicial
		from
			fechamentocaixa
		where 
			dataFechamento = curdate())
union
	select
		'Total Geral',
	(
    (select 
		Sum(valor)
	from
		movimentodocaixa
	where
		dataMovimento = curdate() and
        idtipodemovimento in (1,3))
	+
        (select 
			saldoInicial
		from
			fechamentocaixa
		where 
			dataFechamento = curdate())
	-
    ifnull(
    (select sum(valor)
	from
		movimentodocaixa
	where
		dataMovimento = curdate() and
        idtipodemovimento in (2,4)
	)
    ,0)
    ) as 'sum'
";
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
        public DataTable getTiposDeMovimento()
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select 
    tipodemovimento 
from 
    tiposdemovimento
where
    ativo = 1
";
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
        public DataTable getFormaDePagamento()
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select 
    formadepagamento 
from 
    formasdepagamento
where
    ativo = 1
";
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
        public (bool valido,string mensagem, decimal valor) validarMovCaixa(string idMovCaixa)
        {
            bool valido;
            string mensagem;
            decimal valor;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
select
	ifnull(0,valor)
from 
	movimentodocaixa
where
	idMovimento = @idMovimento;
            ";
            cmd.Parameters.AddWithValue("@idMovimento", idMovCaixa);
            try
            {
                cmd.Connection = con.Conectar();
                var v = cmd.ExecuteScalar();
                if (v != null)
                {
                    valido = true;
                    mensagem = "O ID informado é válido";
                    valor = Decimal.Parse(v.ToString());
                }
                else 
                { 
                    valido = false;
                    mensagem = "O ID informado não é válido";
                    valor = 0;
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
                    string idNota;
                    using (MySqlCommand cmd = new MySqlCommand(@"
insert into notas
	(idFormaDePagamento,idOrdem)
values
	((select 
		idFormaDePagamento 
    from 
		formasdepagamento 
    where 
		FormaDePagamento = @FormaDePagamento and
        ativo = 1),
	@idOrdem);

select ifnull((
    select 
	    idNota 
    from 
	    notas 
    where
	    ativo = 1
    order by idNota desc limit 1),
'');
                    ", con.Conectar()))
                    {
                        cmd.Parameters.AddWithValue("@FormaDePagamento", FormaDePagamento);
                        cmd.Parameters.AddWithValue("@idOrdem", idOrdem);
                        cmd.Connection = con.Conectar();
                        idNota = (string)cmd.ExecuteScalar();
                    }
                    Debug.WriteLine("idNota:"+idNota);
                    cmd = new MySqlCommand();
                    cmd.CommandText = @"
insert into 
    movimentoDoCaixa
	(idTipoDeMovimento,observacao,valor,idNota,idFuncionario)
value
	((select
        idTipoDeMovimento
      from
        tiposDeMovimento
      where
        tipodemovimento = @tipodemovimento and
        ativo = 1),
    @observacao,@valor,@idNota,@idFuncionario);
insert into 
    itensdasnotas (
    select 
        i.idEstoque, @idNota 
    from 
        itensdasordens as i 
    where i.idOrdem = @idOrdem);
                    ";
                    cmd.Parameters.AddWithValue("@tipoDeMovimento", tipoDeMovimento);
                    Debug.WriteLine("tipo de movimento: "+ tipoDeMovimento);
                    cmd.Parameters.AddWithValue("@observacao", observacao);
                    Debug.WriteLine("obs: " + observacao);
                    cmd.Parameters.AddWithValue("@valor", valor);
                    Debug.WriteLine("valor: " + valor);
                    cmd.Parameters.AddWithValue("@idFuncionario", DadosGlobais.id);
                    Debug.WriteLine("idFuncionario: " + DadosGlobais.id);
                    cmd.Parameters.AddWithValue("@idNota", idNota);
                    Debug.WriteLine("idNota: " + idNota);
                    cmd.Parameters.AddWithValue("@idOrdem", idOrdem);
                    Debug.WriteLine("idOrdem: " + idOrdem);
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    scope.Complete();
                    Debug.WriteLine("Debug concluido");
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
        public bool notaPagamento(string tipoDeMovimento,string obs,string valor)
        {
            cmd = new MySqlCommand();
            cmd.CommandText = @"
insert into 
	movimentodocaixa(idTipoDeMovimento,observacao,valor,idFuncionario)
values
    ((select
        idTipoDeMovimento
      from
        tiposDeMovimento
      where
        tipodemovimento = @tipodemovimento and
        ativo = 1)
    ,@obs,@valor,@idFuncionario);
            ";
            cmd.Parameters.AddWithValue("@tipoDeMovimento", tipoDeMovimento);
            cmd.Parameters.AddWithValue("@obs", obs);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@idFuncionario", DadosGlobais.id);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                return true;
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
        public bool notaEst(string tipoDeMovimento, string obs, string valor,string idMovimentoDoCaixa)
        {
            cmd = new MySqlCommand();
            cmd.CommandText = @"
insert into
	movimentodocaixa(idTipoDeMovimento,observacao,valor,idMovEst,idFuncionario)
value
	((select
        idTipoDeMovimento
      from
        tiposDeMovimento
      where
        tipoDeMovimento = @tipoDeMovimento and
        ativo = 1),
    @observacao,@valor,@idMovimentoDoCaixa,@idFuncionario);
";
            cmd.Parameters.AddWithValue("@tipoDeMovimento", tipoDeMovimento);
            cmd.Parameters.AddWithValue("@observacao", obs);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@idMovimentoDoCaixa", idMovimentoDoCaixa);
            cmd.Parameters.AddWithValue("@idFuncionario", DadosGlobais.id);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
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
        
        //Historicos
        public DataTable dtMovDoCaixa(string pesquisa)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select
	m.idMovimento as 'id',
    m.dataMovimento,
    m.horamovimento as 'hora',
    t.tipodemovimento as 'movimento',
    m.observacao as 'observação',
    m.valor as 'valor',
    m.idNota as 'id nota',
    m.idMovEst as 'id mov.est.'
from 
	movimentodocaixa as m
inner join
	tiposdemovimento as t
    on t.idTipoDeMovimento = m.idTipoDeMovimento
where 
	m.idFuncionario = @idFuncionario and
    m.observacao like concat('%',@pesquisa,'%') or
    m.idMovimento like concat('%',@pesquisa,'%') or
    m.dataMovimento like concat('%',@pesquisa,'%');
";
            cmd.Parameters.AddWithValue("@idFuncionario", DadosGlobais.id);
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
        public DataTable dtNotas(string pesquisa)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select 
	n.idNota as 'id',
    n.dataEmissao as 'data de emissao',
    n.horaEmissao as 'hora',
    f.FormaDePagamento as 'forma de pagamento',
    coalesce(c.preco,0) as 'valor'
from notas as n
inner join
	formasdepagamento as f 
		on f.idFormadepagamento = n.idFormadepagamento
left join
	(
    select
		n.idNota, sum(p.preco) as 'preco'
	from
		notas as n
	inner join
		itensdasnotas as i on i.idNota = n.idNota
	inner join
		estoque as e on e.idEstoque = i.idEstoque
	inner join
		produtos as p on p.idProduto = e.idProduto
	group by n.idNota
    order by idNota asc
	) c on c.idNota = n.idNota
where n.dataEmissao like concat('%',@pesquisa,'%') and
    n.ativo = 1;
            ";
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
        public DataTable dtFechamentos(string pesquisa)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select
	f.dataFechamento,
    f.horaAbertura,
    f1.nome,
    f.saldoInicial,
    f.horaFechamento,
    f2.nome,
    f.valorFechamento,
    f.valorContado,
    f.observacao
from
	fechamentoCaixa as f
inner join
	funcionarios as f1
    on f1.idFuncionario = f.idFuncionarioAbertura
inner join
	funcionarios as f2
    on f2.idFuncionario = f.idFuncionarioFechamento
where
	f.dataFechamento like concat('%',@pesquisa,'%') or
	f1.nome like concat('%',@pesquisa,'%') or
	f2.nome like concat('%',@pesquisa,'%') or
    f.observacao like concat('%',@pesquisa,'%'); 
";
            cmd.Parameters.AddWithValue("@pesquisa", pesquisa);
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
    }
}
