using Npgsql;
using TelaLogin.Class;
using TelaLogin.ClassGlobal;
using TelaLogin.FormsMenu;
using TelaPIM;

namespace TelaLogin.Infra
{

    public class DBuser : IDBuser
    {
        private static string txt_conexao = "Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=PIM";
        private NpgsqlConnection Connection = new NpgsqlConnection(txt_conexao);

        public bool VerifyUser(string user, string password)
        {
            MainMenu menu = new MainMenu();
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
                    VarGlobal.NomeUsuario = dr["nome"].ToString();
                    //VarGlobal.NivelAcesso = dr["nivel_acesso"].ToString();
                    VarGlobal.IdUsuario = Convert.ToInt32(dr["id"]);
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
    public class DBproduct : IDBproduction, IDisposable
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

        public bool CreateProduct(Plantio p)
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

        public bool UpdateProduct(Plantio p)
        {
            try
            {
                Connection.Open();
                string sql = "update cultivos set nome = @nome, quantidade = @quantidade, data_plantio = @plantio, data_colheita = @colheita, status = @status where cultivo_id = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection);
                cmd.Parameters.AddWithValue("@nome", p.Nome);
                cmd.Parameters.AddWithValue("@quantidade", p.Quantidade);
                cmd.Parameters.AddWithValue("@plantio", p.Data_plantio);
                cmd.Parameters.AddWithValue("@colheita", p.Data_colheita);
                cmd.Parameters.AddWithValue("@status", p.Status);
                cmd.Parameters.AddWithValue("@id", p.Id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao atualizar plantio: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public List<Plantio> ListAllProducts()
        {
            List<Plantio> produtos = new List<Plantio>();
            Connection.Open();

            string query = "SELECT * FROM cultivos_view ORDER BY cultivo_id;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Plantio p = new Plantio();
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

        public List<Plantio> SearchProduct(string text)
        {
            List<Plantio> produtos = new List<Plantio>();
            Connection.Open();

            string query = "SELECT * FROM cultivos_view WHERE UPPER(nome) LIKE UPPER(@text) ORDER BY cultivo_id;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@text", $"%{text}%");

            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Plantio p = new Plantio();
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

        public List<Plantio> SearchProductStatus(string text)
        {
            List<Plantio> produtos = new List<Plantio>();
            Connection.Open();

            string query = "SELECT * FROM cultivos_view WHERE UPPER(status) LIKE UPPER(@text) ORDER BY cultivo_id;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@text", $"%{text}%");

            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Plantio p = new Plantio();
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
                MessageBox.Show("Erro ao tentar deletar plantio: " + e.Message);
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

        public bool UpdateNumSupplier(Fornecedor fornecedor, string newNum)
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

        public Item SearchItem(int id)
        {
            Connection.Open();
            Item i = new Item();
            try
            {
                string query = "SELECT id_fornecedor,id_item,codigo_barra,nome,categoria,unidade,valor_custo,valor_venda,porcentagem,lucro,qtd_estoque_min,fornecedor FROM itens_fornecidos WHERE id_item = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@id", id);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    i.IdFornecedor = Convert.ToInt32(dr["id_fornecedor"]);
                    i.IdItem = Convert.ToInt32(dr["id_item"]);
                    i.CodigoBarras = dr["codigo_barra"].ToString();
                    i.NomeItem = dr["nome"].ToString();
                    i.Categoria = dr["categoria"].ToString();
                    i.Un = dr["unidade"].ToString();
                    i.PrecoCusto = Convert.ToDouble(dr["valor_custo"]);
                    i.PrecoVenda = Convert.ToDouble(dr["valor_venda"]);
                    i.Porcentagem = Convert.ToDouble(dr["porcentagem"]);
                    i.Lucro = Convert.ToDouble(dr["lucro"]);
                    i.EstoqueMinimo = Convert.ToInt32(dr["qtd_estoque_min"]);
                    i.NomeFornecedor = dr["fornecedor"].ToString();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao buscar item: " + e.Message);
            }
            finally
            {
                Connection.Close();
            }
            return i;

        }


        public List<Item> SearchSupplierItem(int id)
        {
            List<Item> itens = new List<Item>();
            Connection.Open();

            try
            {
                string query = "SELECT id_fornecedor,id_item,codigo_barra,nome,categoria,unidade,valor_custo,valor_venda,porcentagem,lucro,qtd_estoque_min,fornecedor FROM itens_fornecidos WHERE id_fornecedor = @id ORDER BY id_item;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@id", id);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Item i = new Item();
                    i.IdFornecedor = Convert.ToInt32(dr["id_fornecedor"]);
                    i.IdItem = Convert.ToInt32(dr["id_item"]);
                    i.CodigoBarras = dr["codigo_barra"].ToString();
                    i.NomeItem = dr["nome"].ToString();
                    i.Categoria = dr["categoria"].ToString();
                    i.Un = dr["unidade"].ToString();
                    i.PrecoCusto = Convert.ToDouble(dr["valor_custo"]);
                    i.PrecoVenda = Convert.ToDouble(dr["valor_venda"]);
                    i.Porcentagem = Convert.ToDouble(dr["porcentagem"]);
                    i.Lucro = Convert.ToDouble(dr["lucro"]);
                    i.EstoqueMinimo = Convert.ToInt32(dr["qtd_estoque_min"]);
                    i.NomeFornecedor = dr["fornecedor"].ToString();
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
                string query = "insert into itens_fornecidos(id_fornecedor,codigo_barra,nome,categoria,unidade,valor_custo,valor_venda,porcentagem,lucro,qtd_estoque_min,fornecedor)values(@id,@codigo_barra,@nome,@categoria,@unidade,@valor_custo,@valor_venda,@porcentagem,@lucro,@qtd_estoque_min,@fornecedor);";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@id", item.IdFornecedor);
                cmd.Parameters.AddWithValue("@codigo_barra", item.CodigoBarras);
                cmd.Parameters.AddWithValue("@nome", item.NomeItem);
                cmd.Parameters.AddWithValue("@categoria", item.Categoria);
                cmd.Parameters.AddWithValue("@unidade", item.Un);
                cmd.Parameters.AddWithValue("@valor_custo", item.PrecoCusto);
                cmd.Parameters.AddWithValue("@valor_venda", item.PrecoVenda);
                cmd.Parameters.AddWithValue("@porcentagem", item.Porcentagem);
                cmd.Parameters.AddWithValue("@lucro", item.Lucro);
                cmd.Parameters.AddWithValue("@qtd_estoque_min", item.EstoqueMinimo);
                cmd.Parameters.AddWithValue("@fornecedor", item.NomeFornecedor);
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
                string query = "UPDATE itens_fornecidos SET codigo_barra = @codigo_barra, nome = @nome, categoria = @categoria, unidade = @unidade, valor_custo = @valor_custo, valor_venda = @valor_venda, porcentagem = @porcentagem, lucro = @lucro, qtd_estoque_min = @qtd_estoque_min, fornecedor = @fornecedor WHERE id_item = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@id", item.IdItem);
                cmd.Parameters.AddWithValue("@codigo_barra", item.CodigoBarras);
                cmd.Parameters.AddWithValue("@nome", item.NomeItem);
                cmd.Parameters.AddWithValue("@categoria", item.Categoria);
                cmd.Parameters.AddWithValue("@unidade", item.Un);
                cmd.Parameters.AddWithValue("@valor_custo", item.PrecoCusto);
                cmd.Parameters.AddWithValue("@valor_venda", item.PrecoVenda);
                cmd.Parameters.AddWithValue("@porcentagem", item.Porcentagem);
                cmd.Parameters.AddWithValue("@lucro", item.Lucro);
                cmd.Parameters.AddWithValue("@qtd_estoque_min", item.EstoqueMinimo);
                cmd.Parameters.AddWithValue("@fornecedor", item.NomeFornecedor);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao atualizar item: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public bool DeleteItem(int id)
        {
            try
            {
                Connection.Open();
                string query = "UPDATE itens_fornecidos SET fornecedor = null,id_fornecedor = null WHERE id_item = " + id;
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.ExecuteNonQuery();
                Connection.Close();
                return true;
            }
            catch (Exception e)
            {
                Connection.Close();
                MessageBox.Show("Erro ao tentar deletar item: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

    }
    public class DBstock : IDBstock
    {
        private static string txt_conexao = "Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=PIM";
        private NpgsqlConnection Connection = new NpgsqlConnection(txt_conexao);

        public bool CreateStock(ItemEstoque estoque)
        {
            try
            {
                Connection.Open();
                string query = "insert into estoque(id_item,qtd)values(@id,@qtd);";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@id", estoque.IdItem);
                cmd.Parameters.AddWithValue("@qtd", estoque.Quantidade);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao inserir novo estoque: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }


        public bool UpdateStock(ItemEstoque estoque)
        {
            try
            {
                Connection.Open();
                string query = "UPDATE estoque SET qtd = @qtd WHERE id_item = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@id", estoque.IdItem);
                cmd.Parameters.AddWithValue("@qtd", estoque.Quantidade);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao atualizar estoque: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public void DeleteStock(int id)
        {
            try
            {
                Connection.Open();
                string query = "DELETE FROM estoque WHERE id_item = " + id;
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception e)
            {
                Connection.Close();
                MessageBox.Show("Erro ao tentar deletar no estoque: " + e.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        public ItemEstoque SearchStock(string cdgBarra)
        {
            Connection.Open();
            ItemEstoque ie = new ItemEstoque();
            try
            {
                string query = "SELECT * FROM itens_fornecidos WHERE codigo_barra = @cdg;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@cdg", cdgBarra);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ie.Nome = dr["nome"].ToString();
                    ie.Categoria = dr["categoria"].ToString();
                    ie.Unidade = dr["unidade"].ToString();
                    ie.Preco = Convert.ToDouble(dr["valor_venda"]);
                    ie.Fornecedor = dr["fornecedor"].ToString();
                    ie.IdItem = Convert.ToInt32(dr["id_item"]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao buscar item: " + e.Message);
            }
            finally
            {
                Connection.Close();
            }

            if(ie.Nome == null) return null;
            else return ie;

        }

        public List<ItemEstoque> SearchStockName(string name)
        {
            List<ItemEstoque> estoques = new List<ItemEstoque>();
            Connection.Open();

            string query = "SELECT * FROM estoque_itens WHERE UPPER(nome) LIKE UPPER(@name) ORDER BY id_item;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@name", $"%{name}%");

            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ItemEstoque e = new ItemEstoque();
                e.IdItem = Convert.ToInt32(dr["id_item"]);
                e.Quantidade = Convert.ToInt32(dr["qtd"]);
                e.CodigoBarras = dr["codigo_barra"].ToString();
                e.Nome = dr["nome"].ToString();
                e.Categoria = dr["categoria"].ToString();
                e.Unidade = dr["unidade"].ToString();
                e.Preco = Convert.ToDouble(dr["valor_venda"]);
                e.Fornecedor = dr["fornecedor"].ToString();
                estoques.Add(e);
            }

            dr.Close();
            Connection.Close();
            

            // verifica se encontrou o produto no estoque, se nao encontrou retorna null
            if (estoques == null)
            {
                return null;
            }
            else
            {
                return estoques;
            }


        }

        public List<ItemEstoque> SearchStockCategory(string category)
        {
            List<ItemEstoque> estoques = new List<ItemEstoque>();
            Connection.Open();

            string query = "SELECT * FROM estoque_itens WHERE UPPER(categoria) LIKE UPPER(@category) ORDER BY id_item;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@category", $"%{category}%");

            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ItemEstoque e = new ItemEstoque();
                e.IdItem = Convert.ToInt32(dr["id_item"]);
                e.Quantidade = Convert.ToInt32(dr["qtd"]);
                e.CodigoBarras = dr["codigo_barra"].ToString();
                e.Nome = dr["nome"].ToString();
                e.Categoria = dr["categoria"].ToString();
                e.Unidade = dr["unidade"].ToString();
                e.Preco = Convert.ToDouble(dr["valor_venda"]);
                e.Fornecedor = dr["fornecedor"].ToString();
                estoques.Add(e);
            }

            dr.Close();
            Connection.Close();
            return estoques;
        }

        public List<ItemEstoque> GetAllStock()
        {
            List<ItemEstoque> estoques = new List<ItemEstoque>();
            Connection.Open();

            string query = "select * from estoque_itens order by id_item;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ItemEstoque e = new ItemEstoque();
                e.IdItem = Convert.ToInt32(dr["id_item"]);
                e.Quantidade = Convert.ToInt32(dr["qtd"]);
                e.CodigoBarras = dr["codigo_barra"].ToString();
                e.Nome = dr["nome"].ToString();
                e.Categoria = dr["categoria"].ToString();
                e.Unidade = dr["unidade"].ToString();
                e.Preco = Convert.ToDouble(dr["valor_venda"]);
                e.Fornecedor = dr["fornecedor"].ToString();
                estoques.Add(e);
            }

            dr.Close();
            Connection.Close();
            return estoques;
        }

    }
    public class DBsale : IDBsales
    {
        private static string txt_conexao = "Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=PIM";
        private NpgsqlConnection Connection = new NpgsqlConnection(txt_conexao);
        public Venda SearchProductByBarCode(string cod)
        {
            Connection.Open();
            Venda v = new Venda();
            try
            {
                string query = "select nome,unidade,valor_venda,id_item from itens_fornecidos where codigo_barra = @cdg;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@cdg", cod);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                // verifica se o codigo de barras existe no banco de dados
                while (dr.Read())
                {
                    v.Produto = dr["nome"].ToString();
                    v.Unidade = dr["unidade"].ToString();
                    v.ValorUnitario = Convert.ToDouble(dr["valor_venda"]);
                    v.CodigoProduto = Convert.ToInt32(dr["id_item"]);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao buscar código de barras: " + e.Message);
            }
            finally
            {
                Connection.Close();
            }
            // verifica se encontrou o produto, se nao encontrou retorna null
            if (v.Produto == null)
            {
                return null;
            }else
            {
                v.QtdEstoque = SearchQtd(cod);
                return v;
            }


        }

        public int SearchQtd(string codBarra)
        {
            Connection.Open();
            int qtd = 0;
            try
            {
                string query = "SELECT e.qtd FROM estoque e INNER JOIN itens_fornecidos i ON e.id_item = i.id_item WHERE codigo_barra = @cod";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@cod", codBarra);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    qtd = Convert.ToInt32(dr["qtd"]);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao buscar quantidade de estoque: " + e.Message);
            }
            finally
            {
                Connection.Close();
            }
            return qtd;
        }

        public List<Pedido> SearchSales()
        {
            Connection.Open();
            
            List<Pedido> lp = new List<Pedido>();
            try
            {
                string query = "SELECT id_pedido,qtd_itens,valor_total,desconto,data_pedido FROM pedido;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                // busca todos os pedidos
                while (dr.Read())
                {
                    Pedido p = new Pedido();
                    p.IdPedido = Convert.ToInt32(dr["id_pedido"]);
                    p.Quantidade = Convert.ToInt32(dr["qtd_itens"]);
                    p.Total = Convert.ToDouble(dr["valor_total"]);
                    p.Desconto = Convert.ToDouble(dr["desconto"]);
                    p.DataVenda = Convert.ToDateTime(dr["data_pedido"]);
                    lp.Add(p);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao buscar pedidos: " + e.Message);
            }
            finally
            {
                Connection.Close();
            }
            
            return lp;

        }
        
        public List<Venda> SearchItensSale(int id)
        {
            Connection.Open();
            List<Venda> lv = new List<Venda>();
            try
            {
                string query = @"
                                SELECT 
                                    p.id_pedido,
                                    itf.id_item,
                                    itf.unidade,
                                    itf.nome,
                                    itf.lucro * ip.qtd AS lucro,
                                    ip.qtd,
                                    ip.valor_un
                                FROM 
                                    item_pedido ip
                                INNER JOIN 
                                    itens_fornecidos itf ON ip.id_item = itf.id_item
                                INNER JOIN 
                                    pedido p ON p.id_pedido = ip.id_pedido
                                WHERE 
                                    p.id_pedido = @id;";

                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@id", id);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                // busca todos os itens do pedido
                while (dr.Read())
                {
                    Venda v = new Venda();
                    v.CodigoProduto = Convert.ToInt32(dr["id_item"]);
                    v.Unidade = dr["unidade"].ToString();
                    v.Produto = dr["nome"].ToString();
                    v.Ganhos = Convert.ToDouble(dr["lucro"]);
                    v.Quantidade = Convert.ToInt32(dr["qtd"]);
                    v.ValorUnitario = Convert.ToDouble(dr["valor_un"]);
                    lv.Add(v);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao buscar itens do pedido: " + e.Message);
            }
            finally
            {
                Connection.Close();
            }
            return lv;
        }

        public List<Venda> SearchLastSales()
        {
            Connection.Open();
            List<Venda> lv = new List<Venda>();
            try
            {
                string query = @"
                                SELECT 
	                                p.data_pedido,
                                    itf.nome,
	                                ip.valor_un,
                                    ip.qtd,
	                                itf.lucro * ip.qtd AS lucro
                                FROM 
                                    item_pedido ip
                                INNER JOIN 
                                    itens_fornecidos itf ON ip.id_item = itf.id_item
                                INNER JOIN 
                                    pedido p ON p.id_pedido = ip.id_pedido
                                 ORDER BY p.id_pedido DESC LIMIT 5;";

                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                // busca todos os itens do pedido
                while (dr.Read())
                {
                    Venda v = new Venda();
                    v.DataVenda = Convert.ToDateTime(dr["data_pedido"]);
                    v.Produto = dr["nome"].ToString();
                    v.Ganhos = Convert.ToDouble(dr["lucro"]);
                    v.ValorUnitario = Convert.ToDouble(dr["valor_un"]);
                    v.Quantidade = Convert.ToInt32(dr["qtd"]);
                    v.ValorTotal = v.ValorUnitario * v.Quantidade;
                    lv.Add(v);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao buscar itens do pedido: " + e.Message);
            }
            finally
            {
                Connection.Close();
            }
            return lv;
        }

    }
    public class DBpedido : IDBpedido
    {
        private static string txt_conexao = "Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=PIM";
        private NpgsqlConnection Connection = new NpgsqlConnection(txt_conexao);

        public Pedido GetProxPedido()
        {
            Connection.Open();
            Pedido pedido = new Pedido();
            try
            {
                string query = "SELECT id_pedido FROM pedido ORDER BY id_pedido DESC LIMIT 1;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                // verifica se o codigo de barras existe no banco de dados
                while (dr.Read())
                {
                    pedido.IdPedido = Convert.ToInt32(dr["id_pedido"]);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao buscar pedido: " + e.Message);
            }
            finally
            {
                Connection.Close();
            }
            return pedido;
        }

        public bool AddNewPedido(Pedido p)
        {
            try
            {
                Connection.Open();
                string query = "insert into pedido(qtd_itens,valor_total,desconto) values (@qtd,@valor,@desconto);";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@qtd", p.Quantidade);
                cmd.Parameters.AddWithValue("@valor", p.Total);
                cmd.Parameters.AddWithValue("@desconto", p.Desconto);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao inserir pedido: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public void AddItemPedido(Item i)
        {
            try
            {
                Connection.Open();
                string query = "insert into item_pedido(id_pedido,id_item,qtd,valor_un) values (@id_pedido,@id_item,@qtd,@valor_un);";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@id_pedido", i.IdPedido);
                cmd.Parameters.AddWithValue("@id_item", i.IdItem);
                cmd.Parameters.AddWithValue("@qtd", i.Quantidade);
                cmd.Parameters.AddWithValue("@valor_un", i.PrecoVenda);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao inserir itens: " + e.Message);
            }
            finally
            {
                Connection.Close();
            }
        }
    }
    public class DBemployee 
    {
        private static string txt_conexao = "Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=PIM";
        private NpgsqlConnection Connection = new NpgsqlConnection(txt_conexao);

        public bool CreateEmployee(Funcionario funcionario)
        {
            try
            {
                Connection.Open();
                string query = "insert into funcionario(nome,cargo,email,salario,usuario,senha)values(@nome, @cargo, @email, @salario, @usuario, @senha);";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                cmd.Parameters.AddWithValue("@email", funcionario.Email);
                cmd.Parameters.AddWithValue("@salario", funcionario.Salario);
                cmd.Parameters.AddWithValue("@usuario", funcionario.Usuario);
                cmd.Parameters.AddWithValue("@senha", funcionario.Senha);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao inserir novo funcionário: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public List<Funcionario> ListAllEmployees()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Connection.Open();

            string query = "SELECT * FROM funcionario ORDER BY id;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Funcionario f = new Funcionario();
                f.Id = Convert.ToInt32(dr["id"]);
                f.Nome = dr["nome"].ToString();
                f.Cargo = dr["cargo"].ToString();
                f.Email = dr["email"].ToString();
                f.Salario = Convert.ToDouble(dr["salario"]);
                f.Usuario = dr["usuario"].ToString();
                f.Senha = dr["senha"].ToString();
                funcionarios.Add(f);
            }

            dr.Close();
            Connection.Close();
            return funcionarios;
        }

        public Funcionario SearchEmployee(int id)
        {
            Funcionario f = new Funcionario();
            Connection.Open();

            string query = "SELECT * FROM funcionario WHERE id = @id;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@id", id);

            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                f.Id = Convert.ToInt32(dr["id"]);
                f.Nome = dr["nome"].ToString();
                f.Cargo = dr["cargo"].ToString();
                f.Email = dr["email"].ToString();
                f.Salario = Convert.ToDouble(dr["salario"]);
                f.Usuario = dr["usuario"].ToString();
                f.Senha = dr["senha"].ToString();
                // f.Acesso = Convert.ToInt32(dr["acesso"]);

            }

            dr.Close();

            Connection.Close();
            return f;
        }

        public List<Funcionario> SearchEmployeeName(string name)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Connection.Open();

            string query = "SELECT * FROM funcionario WHERE UPPER(nome) LIKE UPPER(@name) ORDER BY id;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@name", $"%{name}%");

            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Funcionario f = new Funcionario();
                f.Id = Convert.ToInt32(dr["id"]);
                f.Nome = dr["nome"].ToString();
                f.Cargo = dr["cargo"].ToString();
                f.Email = dr["email"].ToString();
                f.Salario = Convert.ToDouble(dr["salario"]);
                f.Usuario = dr["usuario"].ToString();
                f.Senha = dr["senha"].ToString();
                funcionarios.Add(f);
            }

            dr.Close();
            Connection.Close();
            return funcionarios;
        }

        public bool UpdateEmployee(Funcionario funcionario)
        {
            try
            {
                Connection.Open();
                string query = "update funcionario set nome = @nome, cargo = @cargo, email = @email, salario = @salario, usuario = @usuario, senha = @senha where id = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                cmd.Parameters.AddWithValue("@email", funcionario.Email);
                cmd.Parameters.AddWithValue("@salario", funcionario.Salario);
                cmd.Parameters.AddWithValue("@usuario", funcionario.Usuario);
                cmd.Parameters.AddWithValue("@senha", funcionario.Senha);
                cmd.Parameters.AddWithValue("@id", funcionario.Id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao atualizar funcionário: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public bool DeleteEmployee(int id)
        {
            try
            {
                Connection.Open();
                string query = "delete from funcionario where id = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao deletar funcionário: " + e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

    }

}
