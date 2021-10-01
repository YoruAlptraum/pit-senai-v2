using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Transactions;

namespace PIT_SENAI_V2.Classes
{
    class Gerencia
    {
        Conexao con = new Conexao();
        MySqlDataAdapter da;
        MySqlCommand cmd;
        DataTable dt;

        //Funcionarios
        public DataTable getFuncionarios(bool historico, string pesquisa)
        {            
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            if (!historico)
            {
                cmd.CommandText = @"
select 
    f.idFuncionario as 'id',
	f.nome,
    f.documento,
    f.endereco,
    f.cep,
    f.telefone,
    f.contato,
    f.email,
    a.acesso
from funcionarios as f 
inner join acessos as a
	on a.idAcesso = f.idAcesso
where ativo = 1 and
f.nome like concat('%',@pesquisa,'%')
";
            }
            else
            {
                cmd.CommandText = @"
select 
    f.idFuncionario as 'id',
	f.nome,
    f.documento,
    f.endereco,
    f.cep,
    f.telefone,
    f.contato,
    f.email,
    a.acesso,
    f.ativo
from funcionarios as f 
inner join acessos as a
	on a.idAcesso = f.idAcesso
where
f.nome like concat('%',@pesquisa,'%')
";
            }
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
        public string removerFuncionario(string idFuncionario)
        {
            string mensagem;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
update
	funcionarios
set
	ativo = 0
where
	idFuncionario = @idFuncionario;
";
            cmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
            try
            {
                cmd.Connection = con.Conectar();
                int col = cmd.ExecuteNonQuery();
                Debug.WriteLine(col);
                if (col > 0)
                {
                    mensagem = "Estatus do funcionário foi atualizado";
                }
                else mensagem = "Não foi possivel atualizar";
            }
            catch (MySqlException e)
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
        public DataTable getFuncionario(string idFuncionario)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select 
	f.nome,
    f.documento,
    f.endereco,
    f.cep,
    f.telefone,
    f.contato,
    f.email,
    a.acesso,
    f.ativo
from
	funcionarios as f
inner join
	acessos as a
    on a.idAcesso = f.idAcesso
where 
	idFuncionario = @idFuncionario
";
            cmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
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
        public (string mensagem,bool ok)adicionarFuncinario(string nome, string senha, string documento, string endereco,
            string cep, string telefone, string contato, string email, string idAcesso)
        {
            string mensagem;
            bool ok;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
insert into 
	funcionarios(nome,senha,documento,endereco,cep,telefone,contato,email,idAcesso)
values
	(@nome,md5(@senha),@documento,@endereco,@cep,@telefone,@contato,@email,@idAcesso);
";
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@documento", documento);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@contato", contato);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@idAcesso", idAcesso);
            try
            {
                cmd.Connection = con.Conectar();
                int col = cmd.ExecuteNonQuery();
                Debug.WriteLine(col);
                if (col > 0)
                {
                    ok = true;
                    mensagem = "Funcionário adicionado";
                }
                else
                {
                    ok = false;
                    mensagem = "Não foi possivel cadastrar";
                }
            }
            catch(MySqlException e)
            {
                Debug.WriteLine(e.Message);
                ok = false;
                mensagem = "Erro com o banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return (mensagem,ok);
        }
        public (string mensagem, bool ok) atualizarFuncinario(string nome, string senha, string documento, string endereco,
            string cep, string telefone, string contato, string email, string idAcesso,int ativo,string idFuncionario)
        {
            string mensagem;
            bool ok;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
update
	funcionarios
set 
	nome = @nome,
    senha = md5(@senha),
    documento = @documento,
    endereco = @endereco,
    cep = @cep,
    telefone = @telefone,
    contato = @contato,
    email = @email,
    idAcesso = @idAcesso,
    ativo = @ativo
where
	idFuncionario = @idFuncionario";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@documento", documento);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@contato", contato);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@idAcesso", idAcesso);
            cmd.Parameters.AddWithValue("@ativo", ativo);
            cmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
            try
            {
                cmd.Connection = con.Conectar();
                int col = cmd.ExecuteNonQuery();
                Debug.WriteLine(col);
                if (col > 0)
                {
                    ok = true;
                    mensagem = "Dados atualizados";
                }
                else
                {
                    ok = false; 
                    mensagem = "Não foi possivel atualizar o funcionario";
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
                ok = false;
                mensagem = "Erro com o banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return (mensagem,ok);
        }
        public DataTable getAcessos()
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select 
	acesso
from
	acessos
order by idAcesso asc";
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

        //Fornecedores
        public DataTable getFornecedores(bool historico,string pesquisa)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            if (historico)
            {
                cmd.CommandText = @"
select
	idFornecedor as 'id',
    fornecedor,
    responsavel,
    descricao,
    telefone,
    contato,
    email,
    ativo
from
	fornecedores
where
	fornecedor like concat('%',@pesquisa,'%') or
    descricao like concat('%',@pesquisa,'%')
";
            }
            else
            {
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
	fornecedores
where
    ativo = 1 and (
	fornecedor like concat('%',@pesquisa,'%') or
    descricao like concat('%',@pesquisa,'%'))
";
            }
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
        public string removerFornecedor(string idFornecedor)
        {
            string mensagem;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
update
	fornecedores
set
	ativo = 0
where
	idFornecedor = @idFornecedor;
";
            cmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);
            try
            {
                cmd.Connection = con.Conectar();
                int col = cmd.ExecuteNonQuery();
                Debug.WriteLine(col);
                if (col > 0)
                {
                    mensagem = "Estatus do fornecedor foi atualizado";
                }
                else mensagem = "Não foi possivel atualizar";
            }
            catch (MySqlException e)
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
        public DataTable getFornecedor(string id)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select 
	fornecedor,
    responsavel,
    descricao,
    telefone,
    contato,
    email,
    ativo
from
	fornecedores
where
	idFornecedor = @id;
";
            cmd.Parameters.AddWithValue("@id", id);
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
        public (string mensagem,bool ok)adicionarFornecedor(string fornecedor, string responsavel, string descricao,
            string telefone, string contato, string email)
        {
            string mensagem;
            bool ok;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
insert into
	fornecedores (fornecedor,responsavel,descricao,telefone,contato,email)
values
	(@fornecedor,@responsavel,@descricao,@telefone,@contato,@email);
";
            cmd.Parameters.AddWithValue("@fornecedor", fornecedor);
            cmd.Parameters.AddWithValue("@responsavel", responsavel);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@contato", contato);
            cmd.Parameters.AddWithValue("@email", email);
            try
            {
                cmd.Connection = con.Conectar();
                int col = cmd.ExecuteNonQuery();
                Debug.WriteLine(col);
                if (col > 0)
                {
                    ok = true;
                    mensagem = "Fornecedor adicionado";
                }
                else
                {
                    ok = false;
                    mensagem = "Não foi possivel cadastrar";
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
                ok = false;
                mensagem = "Erro com o banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return (mensagem, ok);
        }
        public (string mensagem, bool ok) atualizarFornecedor(string fornecedor, string responsavel, string descricao,
            string telefone, string contato, string email, int ativo, string id)
        {
            string mensagem;
            bool ok;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
update
	fornecedores
set
	fornecedor = @fornecedor,
    responsavel = @responsavel,
    descricao = @descricao,
    telefone = @telefone,
    contato = @contato,
    email = @email,
    ativo = @ativo
where
	idFornecedor = @id
";
            cmd.Parameters.AddWithValue("@fornecedor", fornecedor);
            cmd.Parameters.AddWithValue("@responsavel", responsavel);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@contato", contato);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@ativo", ativo);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                cmd.Connection = con.Conectar();
                int col = cmd.ExecuteNonQuery();
                Debug.WriteLine(col);
                if (col > 0)
                {
                    ok = true;
                    mensagem = "Dados atualizados";
                }
                else
                {
                    ok = false;
                    mensagem = "Não foi possivel atualizar o fornecedor";
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
                ok = false;
                mensagem = "Erro com o banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return (mensagem, ok);
        }

        //Clientes
        public DataTable getClientes(bool historico, string pesquisa)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            if (historico)
            {
                cmd.CommandText = @"
select
	c.idCliente as 'id',
    c.nome,
    c.documento,
    c.endereco,
    c.cep,
    f.nome as 'vendedor',
    c.banco,
    c.ativo
from 
	clientes as c
left join
	funcionarios as f
		on f.idFuncionario = c.idVendedor
where
    c.nome like concat('%',@pesquisa,'%')
";
            }
            else
            {
                cmd.CommandText = @"
select
	c.idCliente as 'id',
    c.nome,
    c.documento,
    c.endereco,
    c.cep,
    f.nome as 'vendedor',
    c.banco
from 
	clientes as c
left join
	funcionarios as f
		on f.idFuncionario = c.idVendedor
where
	c.ativo = 1
    and c.nome like concat('%',@pesquisa,'%')
";
            }
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
        public string removerCliente(string idCliente)
        {
            string mensagem;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
update
	clientes
set
	ativo = 0
where
	idCliente = @idCliente;
";
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            try
            {
                cmd.Connection = con.Conectar();
                int col = cmd.ExecuteNonQuery();
                Debug.WriteLine(col);
                if (col > 0)
                {
                    mensagem = "Estatus do cliente foi atualizado";
                }
                else mensagem = "Não foi possivel atualizar";
            }
            catch (MySqlException e)
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
        public DataTable getCliente(string id)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select
	c.nome,
    c.documento,
    c.endereco,
    c.cep,
    f.nome as 'vendedor',
    c.banco,
    c.ativo
from
	clientes as c
inner join
	funcionarios as f
    on f.idFuncionario = c.idVendedor
where
	c.idCliente = @id;
";
            cmd.Parameters.AddWithValue("@id", id);
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
        public (string mensagem, bool ok) adicionarCliente(string nome,string documento,
            string endereco,string cep,string vendedor,string banco,DataTable contatos)
        {
            string mensagem,hr = null;
            bool ok;
            try
            {
                using (cmd = new MySqlCommand())
                {
                    cmd.CommandText = @"
select ativo from clientes where documento = @doc
";
                    cmd.Parameters.AddWithValue("@doc", documento);
                    cmd.Connection = con.Conectar();
                    if (cmd.ExecuteScalar() != null)
                    {
                        hr = cmd.ExecuteScalar().ToString();
                        Debug.WriteLine("ativo: " + hr);
                    }
                }
                if(hr == "1")
                {
                    mensagem = "O documento ja está cadastrado";
                    ok = false;
                }
                else if(hr == "0")
                {
                    mensagem = "O cadastro relacionado ao codumento encontra-se desativado";
                    ok = false;
                }
                else
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        cmd = new MySqlCommand();
                        cmd.CommandText = @"
insert into
	clientes(nome,documento,endereco,cep,idVendedor,banco)
values
	(@nome,@documento,@endereco,@cep,(select idFuncionario from funcionarios where nome = @vendedor),@banco);

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
                        cmd.Parameters.AddWithValue("@vendedor", vendedor);
                        cmd.Parameters.AddWithValue("@banco", banco);

                        cmd.Connection = con.Conectar();
                        string id = cmd.ExecuteScalar().ToString();
                        //inserir contatos do cliente
                        int col = 0;
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
                            cmd.Parameters.AddWithValue("@idCliente", id);
                            cmd.Parameters.AddWithValue("@tipoContato", contatos.Rows[i][0]);
                            cmd.Parameters.AddWithValue("@Contato", contatos.Rows[i][1]);
                            cmd.Connection = con.Conectar();
                            col = cmd.ExecuteNonQuery();
                            Debug.WriteLine("col: " + col);
                        }
                        if (col > 0)
                        {
                            ok = true;
                            mensagem = "Cliente adicionado";
                        }
                        else
                        {
                            ok = false;
                            mensagem = "Não foi possivel cadastrar";
                        }
                        scope.Complete();
                    }
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
                ok = false;
                mensagem = "Erro com o banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return (mensagem, ok);
        }
        public (string mensagem, bool ok) atualizarCliente(string nome, string documento,
            string endereco, string cep, string vendedor, string banco, int ativo, string id,
            DataTable contatos)
        {

            string mensagem;
            bool ok;
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cmd = new MySqlCommand();
                    cmd.CommandText = @"
update
	clientes
set
	nome = @nome,
    documento = @documento,
    endereco = @endereco,
    cep = @cep,
    idVendedor = (select idFuncionario from funcionarios where nome = @vendedor),
    banco = @banco,
    ativo = @ativo
where
	idCliente = @id;

delete
from
	contatosdosclientes
where idCliente = @id;
";
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@documento", documento);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@cep", cep);
                    cmd.Parameters.AddWithValue("@vendedor", vendedor);
                    cmd.Parameters.AddWithValue("@banco", banco);
                    cmd.Parameters.AddWithValue("@ativo", ativo);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    //inserir contatos
                    int col = 0;
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
                        cmd.Parameters.AddWithValue("@idCliente", id);
                        cmd.Parameters.AddWithValue("@tipoContato", contatos.Rows[i][0]);
                        cmd.Parameters.AddWithValue("@Contato", contatos.Rows[i][1]);
                        cmd.Connection = con.Conectar();
                        col = cmd.ExecuteNonQuery();
                        Debug.WriteLine("col: " + col);
                    }
                    Debug.WriteLine(col);
                    if (col > 0)
                    {
                        ok = true;
                        mensagem = "Dados atualizados";
                    }
                    else
                    {
                        ok = false;
                        mensagem = "Não foi possivel atualizar o cliente";
                    }
                    scope.Complete();
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
                ok = false;
                mensagem = "Erro com o banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return (mensagem, ok);
        }
        public DataTable getVendedores()
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select
	nome
from
	funcionarios
where
	idAcesso = 5
order by nome asc
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
        public DataTable getContatos(string id)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select 
	tipoContato,
    contato
from
	contatosdosclientes
where 
	idCliente = @id
order by tipoContato asc
";
            cmd.Parameters.AddWithValue("@id", id);
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

        //Produtos
        public DataTable getProdutos(bool historico, string pesquisa)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            if (historico)
            {
                cmd.CommandText = @"
select
	p.idProduto as 'id',
    p.nomeProduto,
    p.preco,
    p.estoqueMinimo,
    c.categoria,
    f.fornecedor,
    p.ativo
from
	produtos as p
inner join
	categorias as c 
		on c.idCategoria = p.idCategoria
inner join
	fornecedores as f
		on f.idFornecedor = p.idFornecedor
where
    nomeProduto like concat('%',@pesquisa,'%')
";
            }
            else
            {
                cmd.CommandText = @"
select
	p.idProduto as 'id',
    p.nomeProduto,
    p.preco,
    p.estoqueMinimo,
    c.categoria,
    f.fornecedor
from
	produtos as p
inner join
	categorias as c 
		on c.idCategoria = p.idCategoria
inner join
	fornecedores as f
		on f.idFornecedor = p.idFornecedor
where
	p.ativo = 1 and
    nomeProduto like concat('%',@pesquisa,'%')
";
            }
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
        public string removerProduto(string idProduto)
        {
            string mensagem;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
update
	produtos
set
	ativo = 0
where
	idProduto = @idProduto;
";
            cmd.Parameters.AddWithValue("@idProduto", idProduto);
            try
            {
                cmd.Connection = con.Conectar();
                int col = cmd.ExecuteNonQuery();
                Debug.WriteLine(col);
                if (col > 0)
                {
                    mensagem = "Estatus do produto foi atualizado";
                }
                else mensagem = "Não foi possivel atualizar";
            }
            catch (MySqlException e)
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
        public DataTable getProduto(string id)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select
	p.nomeProduto,
    p.preco,
    p.estoqueMinimo,
    c.categoria,
    f.fornecedor,
    p.ativo
from
	produtos as p
inner join
	categorias as c 
    on c.idCategoria = p.idCategoria
inner join
	fornecedores as f
    on f.idFornecedor = p.idFornecedor
where idProduto = @id;
";
            cmd.Parameters.AddWithValue("@id", id);
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
        public (string mensagem, bool ok) adicionarProduto(string produto, decimal preco, int estoqueMinimo,
            string categoria, string fornecedor)
        {
            string mensagem;
            bool ok;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
insert into
	produtos (nomeProduto, preco, estoqueMinimo, idCategoria, idFornecedor)
values
	(@nomeProduto,@preco,@estoqueMinimo,
		(select idCategoria from categorias where categoria = @categoria and ativo = 1 limit 1 ),
        (select idFornecedor from fornecedores where fornecedor = @fornecedor and ativo = 1 limit 1)
	);
";
            cmd.Parameters.AddWithValue("@nomeProduto", produto);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@estoqueMinimo", estoqueMinimo);
            cmd.Parameters.AddWithValue("@categoria", categoria);
            cmd.Parameters.AddWithValue("@fornecedor", fornecedor);
            try
            {
                cmd.Connection = con.Conectar();
                int col = cmd.ExecuteNonQuery();
                Debug.WriteLine(col);
                if (col > 0)
                {
                    ok = true;
                    mensagem = "Produto adicionado";
                }
                else
                {
                    ok = false;
                    mensagem = "Não foi possivel cadastrar";
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
                ok = false;
                mensagem = "Erro com o banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return (mensagem, ok);
        }
        public (string mensagem, bool ok) atualizarProduto(string produto, decimal preco, int estoqueMinimo,
            string categoria, string fornecedor, int ativo, string id)
        {
            string mensagem;
            bool ok;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
update
	produtos
set
	nomeProduto = @produto,
    preco = @preco,
    estoqueMinimo = @estoqueMinimo,
    idCategoria = (select idCategoria from categorias where categoria = @categoria and ativo = 1 limit 1),
    idFornecedor = (select idFornecedor from fornecedores where fornecedor = @fornecedor and ativo = 1 limit 1),
    ativo = @ativo
where
	idProduto = @id;
";
            cmd.Parameters.AddWithValue("@produto", produto);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@estoqueMinimo", estoqueMinimo);
            cmd.Parameters.AddWithValue("@categoria", categoria);
            cmd.Parameters.AddWithValue("@fornecedor", fornecedor);
            cmd.Parameters.AddWithValue("@ativo", ativo);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                cmd.Connection = con.Conectar();
                int col = cmd.ExecuteNonQuery();
                Debug.WriteLine(col);
                if (col > 0)
                {
                    ok = true;
                    mensagem = "Dados atualizados";
                }
                else
                {
                    ok = false;
                    mensagem = "Não foi possivel atualizar o produto";
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
                ok = false;
                mensagem = "Erro com o banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return (mensagem, ok);
        }
        public DataTable getCategorias()
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select 
	categoria
from
	categorias
order by idCategoria asc
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
        public DataTable getFornecedores()
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select 
	fornecedor
from
	fornecedores
order by idFornecedor asc
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

        //              --- Devoluçções ---
        public DataTable getNotas(bool historico, string pesquisa)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            if (historico)
            {
                cmd.CommandText = @"
select
	n.idNota as 'id',
    n.dataEmissao,
    n.horaEmissao,
    n.idOrdem as 'idOrdem',
    f.FormaDePagamento,
    n.ativo
from 
	notas as n
inner join
	formasdepagamento as f
    on f.idFormaDePagamento = n.idFormaDePagamento
where
    dataEmissao like concat('%',@pesquisa,'%');
";
            }
            else
            {
                cmd.CommandText = @"
select
	n.idNota as 'id',
    n.dataEmissao,
    n.horaEmissao,
    n.idOrdem as 'idOrdem',
    f.FormaDePagamento
from 
	notas as n
inner join
	formasdepagamento as f
		on f.idFormaDePagamento = n.idFormaDePagamento
where
	n.ativo = 1
    and n.dataEmissao like concat('%',@pesquisa,'%');
";
            }
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
        public string removerNota(string id)
        {
            string mensagem;
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cmd = new MySqlCommand();
                    cmd.CommandText = @"
update
	notas
set
	ativo = 0
where
	idNota = @id;
    
update
	estoque
set
	vendido = 0
where idEstoque in
	(select idEstoque from itensdasnotas where idNota = @id)
";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Connection = con.Conectar();
                    int col = cmd.ExecuteNonQuery();
                    Debug.WriteLine(col);
                    if (col > 0)
                    {
                        mensagem = "Estatus da nota foi atualizado";
                    }
                    else mensagem = "Não foi possivel atualizar";
                    scope.Complete();
                }
            }
            catch (MySqlException e)
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

        //Categorias
        public DataTable getCategorias(bool historico, string pesquisa)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            if (historico)
            {
                cmd.CommandText = @"
select
	idCategoria as 'id',
    categoria,
    ativo
from
	categorias
where 
    categoria like concat('%',@pesquisa,'%')
";
            }
            else
            {
                cmd.CommandText = @"
select
	idCategoria as 'id',
    categoria
from
	categorias
where ativo = 1 and
    categoria like concat('%',@pesquisa,'%')
";
            }
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
        public string removerCategoria(string idCategoria)
        {
            string mensagem;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
update
	categorias
set
	ativo = 0
where
	idCategoria = @idCategoria;
";
            cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
            try
            {
                cmd.Connection = con.Conectar();
                int col = cmd.ExecuteNonQuery();
                Debug.WriteLine(col);
                if (col > 0)
                {
                    mensagem = "Estatus da categoria foi atualizado";
                }
                else mensagem = "Não foi possivel atualizar";
            }
            catch (MySqlException e)
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
        public DataTable getCategoria(string id)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select
	categoria,
    ativo
from
	categorias
where idCategoria = @id;
";
            cmd.Parameters.AddWithValue("@id", id);
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
        public (string mensagem, bool ok) adicionarCategoria(string categoria)
        {
            string mensagem;
            bool ok;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
insert into
	categorias(categoria)
values
	(@categoria);
";
            cmd.Parameters.AddWithValue("@categoria", categoria);
            try
            {
                cmd.Connection = con.Conectar();
                int col = cmd.ExecuteNonQuery();
                Debug.WriteLine(col);
                if (col > 0)
                {
                    ok = true;
                    mensagem = "Categoria adicionada";
                }
                else
                {
                    ok = false;
                    mensagem = "Não foi possivel cadastrar";
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
                ok = false;
                mensagem = "Erro com o banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return (mensagem, ok);
        }
        public (string mensagem, bool ok) atualizarCategoria(string categoria,int ativo, string id)
        {
            string mensagem;
            bool ok;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
update
	categorias
set
	categoria = @categoria,
    ativo = @ativo
where
	idCategoria = @id;
";
            cmd.Parameters.AddWithValue("@categoria", categoria);
            cmd.Parameters.AddWithValue("@ativo", ativo);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                cmd.Connection = con.Conectar();
                int col = cmd.ExecuteNonQuery();
                Debug.WriteLine(col);
                if (col > 0)
                {
                    ok = true;
                    mensagem = "Dados atualizados";
                }
                else
                {
                    ok = false;
                    mensagem = "Não foi possivel atualizar a categoria";
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
                ok = false;
                mensagem = "Erro com o banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return (mensagem, ok);
        }

        //Formas de Pagamento
        public DataTable getFormasDePagamento(bool historico, string pesquisa)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            if (historico)
            {
                cmd.CommandText = @"
select
	idFormaDePagamento as 'id',
    FormaDePagamento,
    ativo
from
	formasdepagamento
where 
    formadepagamento like concat('%',@pesquisa,'%')
";
            }
            else
            {
                cmd.CommandText = @"
select
	idFormaDePagamento as 'id',
    FormaDePagamento
from
	formasdepagamento
where 
    formadepagamento like concat('%',@pesquisa,'%') and
    ativo = 1
";
            }
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
        public string removerFormaDePagamento(string idFormaDePagamento)
        {
            string mensagem;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
update
	formasdepagamento
set
	ativo = 0
where
	idFormaDePagamento = @idFormaDePagamento;
";
            cmd.Parameters.AddWithValue("@idFormaDePagamento", idFormaDePagamento);
            try
            {
                cmd.Connection = con.Conectar();
                int col = cmd.ExecuteNonQuery();
                Debug.WriteLine(col);
                if (col > 0)
                {
                    mensagem = "Estatus da forma de pagamento foi atualizado";
                }
                else mensagem = "Não foi possivel atualizar";
            }
            catch (MySqlException e)
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
        public DataTable getFormaDePagamento(string id)
        {
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            cmd.CommandText = @"
select
	formadepagamento,
    ativo
from
	formasdepagamento
where
	idFormaDePagamento = @id;
";
            cmd.Parameters.AddWithValue("@id", id);
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
        public (string mensagem, bool ok) adicionarFormaDePagamento(string formaDePagamento)
        {
            string mensagem;
            bool ok;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
insert into
	formasDePagamento(FormaDePagamento)
values
	(@formaDePagamento);
";
            cmd.Parameters.AddWithValue("@formaDePagamento", formaDePagamento);
            try
            {
                cmd.Connection = con.Conectar();
                int col = cmd.ExecuteNonQuery();
                Debug.WriteLine(col);
                if (col > 0)
                {
                    ok = true;
                    mensagem = "Forma de pagamento adicionada";
                }
                else
                {
                    ok = false;
                    mensagem = "Não foi possivel cadastrar";
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
                ok = false;
                mensagem = "Erro com o banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return (mensagem, ok);
        }
        public (string mensagem, bool ok) atualizarFormaDePagamento(string formaDePagamento, int ativo,
            string id)
        {
            string mensagem;
            bool ok;
            cmd = new MySqlCommand();
            cmd.CommandText = @"
update
	formasDePagamento
set
	formaDePagamento = @formaDePagamento,
    ativo = @ativo
where
	idFormaDePagamento = @id;
";
            cmd.Parameters.AddWithValue("@formaDePagamento", formaDePagamento);
            cmd.Parameters.AddWithValue("@ativo", ativo);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                cmd.Connection = con.Conectar();
                int col = cmd.ExecuteNonQuery();
                Debug.WriteLine(col);
                if (col > 0)
                {
                    ok = true;
                    mensagem = "Dados atualizados";
                }
                else
                {
                    ok = false;
                    mensagem = "Não foi possivel atualizar a forma de pagamento";
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
                ok = false;
                mensagem = "Erro com o banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return (mensagem, ok);
        }
    }
}
