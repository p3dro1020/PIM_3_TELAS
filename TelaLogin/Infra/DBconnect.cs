using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using TelaLogin.Class;
using TelaLogin.ClassGlobal;
using static System.Net.Mime.MediaTypeNames;

namespace TelaLogin.Infra
{
    public class DBuser : IDBuser
    {
        private static string txt_conexao = "Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=PIM";
        private NpgsqlConnection Connection = new NpgsqlConnection(txt_conexao);

        public bool VerifyUser(string user, string password)
        {
            try
            {
                Connection.Open();

                NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM funcionario WHERE usuario = @usuario AND senha = @senha;", Connection);
                cmd.Parameters.AddWithValue("@usuario", user);
                cmd.Parameters.AddWithValue("@senha", password);

                NpgsqlDataReader dr = cmd.ExecuteReader();
                // se o usuario e senha estiverem corretos, o nome do usuario é armazenado na variavel nomeUsuario,
                // se a consulta dr.Read nao retornar nada, significa que nao existe usuario ou senha que foi digitado
                if (dr.Read())
                {
                    MessageBox.Show("Logado com sucesso!");
                    //Globais.nomeUsuario = dr["nome"].ToString();
                    return true;
                }
                else
                {
                    MessageBox.Show($"Usuário ou senha inválidos! Tentativa:"); //{Globais.clickUsuarioLogin}/3
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao verificar dados: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
    public class DBproduct : IDBproduct, IDisposable
    {
        private static string txt_conexao = "Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=PIM";
        private NpgsqlConnection Connection = new NpgsqlConnection(txt_conexao);
        //public NpgsqlConnection Connection { get; set; }

       /* public DBconnect()
        {
            Connection.Open();
        }*/
        public void Dispose()
        {
            Connection.Close();
        }
            
        public void OpenConnection()
        {
            Connection = new NpgsqlConnection(
                "Server = localhost;" +
                "Port = 5432;" +
                "Database = PIM;" +
                "Uid = postgres;" +
                "Psw = admin;");

        }

        public bool CreateProduct(Produto p)
        {
            try
            {
                Connection.Open();
                string query = "insert into cultivos(nome, quantidade, data_plantio, data_colheita)values(@nome,@quantidade,@plantio,@colheita);";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@nome", p.Nome);
                cmd.Parameters.AddWithValue("@quantidade", p.Quantidade);
                cmd.Parameters.AddWithValue("@plantio", p.Data_plantio);
                cmd.Parameters.AddWithValue("@colheita", p.Data_colheita);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao inserir novo produto: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public bool UpdateProduct(Produto p)
        {
            try
            {
                Connection.Open();
                string sql = "update cultivos set nome = @nome, quantidade = @quantidade, data_plantio = @plantio, data_colheita = @colheita where cultivo_id = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection);
                cmd.Parameters.AddWithValue("@nome", p.Nome);
                cmd.Parameters.AddWithValue("@quantidade", p.Quantidade);
                cmd.Parameters.AddWithValue("@plantio", p.Data_plantio);
                cmd.Parameters.AddWithValue("@colheita", p.Data_colheita);
                cmd.Parameters.AddWithValue("@id", p.Id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao atualizar produto: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public List<Produto> ListAllProducts()
        {
            List<Produto> produtos = new List<Produto>();
            Connection.Open();

            string query = "SELECT * FROM cultivos_view ORDER BY cultivo_id;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Produto p = new Produto();
                p.Id = Convert.ToInt32(dr["cultivo_id"]);
                p.Nome = dr["nome"].ToString();
                p.Quantidade = Convert.ToInt32(dr["quantidade"]);
                // transformar em data
                p.Data_plantio = Convert.ToDateTime(dr["data_plantio"]);
                p.Data_colheita = Convert.ToDateTime(dr["data_colheita"]);
                p.Status = dr["status"].ToString();
                produtos.Add(p);
            }

            dr.Close();
            Connection.Close();
            return produtos;
        }

        public List<Produto> SearchProduct(string text)
        {
            List<Produto> produtos = new List<Produto>();
            Connection.Open();

            string query = "SELECT * FROM cultivos_view WHERE UPPER(nome) LIKE UPPER(@text) ORDER BY cultivo_id;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@text", $"%{text}%");

            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Produto p = new Produto();
                p.Id = Convert.ToInt32(dr["cultivo_id"]);
                p.Nome = dr["nome"].ToString();
                p.Quantidade = Convert.ToInt32(dr["quantidade"]);
                // transformar em data
                p.Data_plantio = Convert.ToDateTime(dr["data_plantio"]).Date;
                p.Data_colheita = Convert.ToDateTime(dr["data_colheita"]).Date;
                p.Status = dr["status"].ToString();
                produtos.Add(p);
            }

            dr.Close();
            Connection.Close();
            return produtos;
        }

        public void DeleteProduct(int id)
        {
            try
            {
                Connection.Open();
                string query = "DELETE FROM cultivos WHERE cultivo_id = " + id;
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception e)
            {
                Connection.Close();
                MessageBox.Show("Erro ao tentar deletar: " + e.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

    }

    public class DBsupplier : IDBsupplier
    {
        private static string txt_conexao = "Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=PIM";
        private NpgsqlConnection Connection = new NpgsqlConnection(txt_conexao);

        public List<Fornecedor> ListAllSuppliers()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            Connection.Open();

            string query = "SELECT * FROM fornecedor ORDER BY id_fornecedor;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Fornecedor f = new Fornecedor();
                f.Id = Convert.ToInt32(dr["id_fornecedor"]);
                f.Nome = dr["razao_social"].ToString();
                // transformar em data
                f.DataCadastro = Convert.ToDateTime(dr["data_cadastro"]);
                f.Cnpj = dr["cnpj"].ToString();
                f.Email = dr["email"].ToString();
                fornecedores.Add(f);
            }

            dr.Close();
            Connection.Close();
            return fornecedores;
        }

        public bool CreateSuppliers(Fornecedor fornecedor)
        {
            try
            {
                // pega a data atual do sistema
                DateTime data = DateTime.Today;
                
                Connection.Open();
                string query = "insert into fornecedor(razao_social, data_cadastro, cnpj, email, nome_fantasia, cep, endereco, complemento, bairro, uf, cidade, numero_casa)values(@nome, @data, @cnpj, @email, @nome_fantasia, @cep, @endereco, @complemento, @bairro, @uf, @cidade, @n);";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                cmd.Parameters.AddWithValue("@email", fornecedor.Email);
                cmd.Parameters.AddWithValue("@nome_fantasia", fornecedor.RazaoSocial);
                cmd.Parameters.AddWithValue("@cep", fornecedor.Cep);
                cmd.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
                cmd.Parameters.AddWithValue("@complemento", fornecedor.Complemento);
                cmd.Parameters.AddWithValue("@bairro", fornecedor.Bairro);
                cmd.Parameters.AddWithValue("@uf", fornecedor.Uf);
                cmd.Parameters.AddWithValue("@cidade", fornecedor.Cidade);
                cmd.Parameters.AddWithValue("@n", fornecedor.Numero);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao inserir novo fornecedor: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public Fornecedor SearchSupplier(int id)
        {
            Fornecedor f = new Fornecedor();
            Connection.Open();
            
            string query = "SELECT * FROM fornecedor WHERE id_fornecedor = @id;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@id", id);

            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                f.Id = Convert.ToInt32(dr["id_fornecedor"]);
                f.Nome = dr["razao_social"].ToString();
                // transformar em data
                f.DataCadastro = Convert.ToDateTime(dr["data_cadastro"]);
                f.Cnpj = dr["cnpj"].ToString();
                f.Email = dr["email"].ToString();
                f.Bairro = dr["bairro"].ToString();
                f.Cep = dr["cep"].ToString();
                f.Cidade = dr["cidade"].ToString();
                f.Complemento = dr["complemento"].ToString();
                f.Endereco = dr["endereco"].ToString();
                f.Numero = Convert.ToInt32(dr["numero_casa"]);
                f.RazaoSocial = dr["nome_fantasia"].ToString();
                f.Uf = dr["uf"].ToString();
            }

            dr.Close();
            
            Connection.Close();
            return f;
          
        }

        public List<Fornecedor> SearchSupplierPhone(int id)
        {
            List<Fornecedor> num = new List<Fornecedor>();
            Connection.Open();

            try
            {
                string query = "SELECT num FROM telefone_fornecedor WHERE id_fornecedor = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@id", id);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Fornecedor f = new Fornecedor();
                    f.Telefone = (dr["num"].ToString());
                    num.Add(f);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao buscar telefones: " + e.Message);
            }
            finally
            {
                Connection.Close();
            }
            return num;
        }

        public bool AddNumSupplier(Fornecedor fornecedor)
        {
            try
            {
                Connection.Open();
                string query = "insert into telefone_fornecedor(id_fornecedor,num)values(@id,@num);";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@id", fornecedor.Id);
                cmd.Parameters.AddWithValue("@num", fornecedor.Telefone);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao inserir novo fornecedor: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }
        
        public bool UpdateNumSupplier(Fornecedor fornecedor,string newNum)
        {
            try
            {
                Connection.Open();
                string query = "update telefone_fornecedor set num = @numOld where id_fornecedor = @id and num = @numNew;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@id", fornecedor.Id);
                cmd.Parameters.AddWithValue("@numOld", fornecedor.Telefone);
                cmd.Parameters.AddWithValue("@numNew", newNum);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao atualizar telefone: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public bool DeleteNumSupplier(Fornecedor fornecedor)
        {
            try
            {
                Connection.Open();
                string query = "DELETE FROM telefone_fornecedor WHERE id_fornecedor = @id and num = @num;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@id", fornecedor.Id);
                cmd.Parameters.AddWithValue("@num", fornecedor.Telefone);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao deletar telefone: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public List<Fornecedor> SearchSupplierName(string name)
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            Connection.Open();

            string query = "SELECT * FROM fornecedor WHERE UPPER(razao_social) LIKE UPPER(@name) ORDER BY id_fornecedor;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@name", $"%{name}%");

            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Fornecedor f = new Fornecedor();
                f.Id = Convert.ToInt32(dr["id_fornecedor"]);
                f.Nome = dr["razao_social"].ToString();
                // transformar em data
                f.DataCadastro = Convert.ToDateTime(dr["data_cadastro"]);
                f.Cnpj = dr["cnpj"].ToString();
                f.Email = dr["email"].ToString();
                fornecedores.Add(f);
            }

            dr.Close();
            Connection.Close();
            return fornecedores;
        }

        public bool UpdateSuppliers(Fornecedor fornecedor)
        {
            try
            {
                Connection.Open();
                string query = "update fornecedor set razao_social = @nome, cnpj = @cnpj, email = @email, nome_fantasia = @nome_fantasia, cep = @cep, endereco = @endereco, complemento = @complemento, bairro = @bairro, uf = @uf, cidade = @cidade, numero_casa = @n where id_fornecedor = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
                cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                cmd.Parameters.AddWithValue("@email", fornecedor.Email);
                cmd.Parameters.AddWithValue("@nome_fantasia", fornecedor.RazaoSocial);
                cmd.Parameters.AddWithValue("@cep", fornecedor.Cep);
                cmd.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
                cmd.Parameters.AddWithValue("@complemento", fornecedor.Complemento);
                cmd.Parameters.AddWithValue("@bairro", fornecedor.Bairro);
                cmd.Parameters.AddWithValue("@uf", fornecedor.Uf);
                cmd.Parameters.AddWithValue("@cidade", fornecedor.Cidade);
                cmd.Parameters.AddWithValue("@n", fornecedor.Numero);
                cmd.Parameters.AddWithValue("@id", fornecedor.Id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao atualizar fornecedor: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public bool DeleteSuppliers(int id)
        {
            try
            {
                Connection.Open();
                string query = "DELETE FROM fornecedor WHERE id_fornecedor = " + id;
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.ExecuteNonQuery();
                Connection.Close();
                return true;
            }
            catch (Exception e)
            {
                Connection.Close();
                MessageBox.Show("Erro ao tentar deletar: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }

        }

        public List<Item> SearchSupplierItem(int id)
        {
            List<Item> itens = new List<Item>();
            Connection.Open();

            try
            {
                string query = "SELECT id_item,nome, un, preco FROM itens_fornecidos WHERE id_fornecedor = @id ORDER BY id_item;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@id", id);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Item i = new Item();
                    VarGlobal.idItem = Convert.ToInt32(dr["id_item"]);
                    i.NomeItem = (dr["nome"].ToString());
                    i.Un = (dr["un"].ToString());
                    i.Preco = Convert.ToDouble(dr["preco"]);
                    itens.Add(i);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao buscar itens fornecidos: " + e.Message);
            }
            finally
            {
                Connection.Close();
            }

            return itens;
        }

        public bool AddNewItem(Item item)
        {
            try
            {
                Connection.Open();
                string query = "insert into itens_fornecidos(id_fornecedor,nome,un,preco)values(@id,@nome,@un,@preco);";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@id", item.Id_fornecedor);
                cmd.Parameters.AddWithValue("@nome", item.NomeItem);
                cmd.Parameters.AddWithValue("@un", item.Un);
                cmd.Parameters.AddWithValue("@preco", item.Preco);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao inserir novo item: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public bool UpdateItem(Item item)
        {
            try
            {
                Connection.Open();
                string query = "UPDATE itens_fornecidos SET nome = @nome, un = @un, preco = @preco WHERE id_item = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@id", VarGlobal.idItem);
                cmd.Parameters.AddWithValue("@nome", item.NomeItem);
                cmd.Parameters.AddWithValue("@un", item.Un);
                cmd.Parameters.AddWithValue("@preco", item.Preco);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao atualizar telefone: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
