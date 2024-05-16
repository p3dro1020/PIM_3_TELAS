using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using TelaLogin.Class;

namespace TelaLogin.Infra
{
    public class DBconnect : IDBconnect, IDisposable
    {
        
        public NpgsqlConnection Connection { get; set; }

        public DBconnect()
        {
            OpenConnection();
        }
        public void Dispose()
        {
            Connection.Dispose();
        }

        public void OpenConnection()
        {
            Connection = new NpgsqlConnection(
                "Server = localhost;" +
                "Port = 5432;" +
                "Database = PIM;" +
                "Uid = postgres;" +
                "Psw = admin;");

            Connection.Open();
        }
        public void CloseConnection()
        {
            Connection.Dispose();
        }

        public bool VerifyUser(string user, string password)
        {
            try
            {
                OpenConnection();

                NpgsqlCommand cmd = new NpgsqlCommand($"SELECT nome  FROM funcionario WHERE usuario = @usuario AND senha = @senha;", Connection);
                cmd.Parameters.AddWithValue("@usuario", user);
                cmd.Parameters.AddWithValue("@senha", password);

                NpgsqlDataReader dr = cmd.ExecuteReader();
                // se o usuario e senha estiverem corretos, o nome do usuario é armazenado na variavel nomeUsuario,
                // se a consulta dr.Read nao retornar nada, significa que nao existe usuario ou senha que foi digitado
                if (dr.Read())
                {
                    MessageBox.Show("Logado com sucesso!");
                    //Globais.nomeUsuario = dr["nome"].ToString();
                    Connection.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show($"Usuário ou senha inválidos! Tentativa:"); //{Globais.clickUsuarioLogin}/3
                    Connection.Close();
                    return false;
                }
            }
            catch (Exception e)
            {
                Connection.Close();
                MessageBox.Show("Erro ao verificar dados: " + e.Message);
                return false;
            }
        }

        public bool CreateProduct(Produto p)
        {
            try
            {
                Connection.Open();
                string query = "insert into cultivos(nome, quantidade, data_plantio, data_colheita)values(@nome,@quantidade,@plantio,@colheita);"; //   
                NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@nome", p.Nome);
                cmd.Parameters.AddWithValue("@quantidade", p.Quantidade);
                cmd.Parameters.AddWithValue("@plantio", p.Data_plantio);
                cmd.Parameters.AddWithValue("@colheita", p.Data_colheita);
                cmd.ExecuteNonQuery();
                Connection.Close();
                return true;
            }
            catch (Exception e)
            {
                Connection.Close();
                MessageBox.Show("Erro ao inserir novo produto: " + e.Message);
                return false;
            }
        }

        public void UpdateProduct(DataTable dt)
        {
            try
            {
                Connection.Open();
                string sql = "update cultivos set nome = @nome, quantidade = @quantidade, data_plantio = @plantio, data_colheita = @colheita where id = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection);
                cmd.Parameters.AddWithValue("@nome", dt.Rows[0]["nome"]);
                cmd.Parameters.AddWithValue("@quantidade", dt.Rows[0]["quantidade"]);
                cmd.Parameters.AddWithValue("@plantio", dt.Rows[0]["data_plantio"]);
                cmd.Parameters.AddWithValue("@colheita", dt.Rows[0]["data_colheita"]);
                cmd.Parameters.AddWithValue("@id", dt.Rows[0]["id"]);
                cmd.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception e)
            {
                Connection.Close();
                MessageBox.Show("Erro ao atualizar produto: " + e.Message);
            }
        }

        public List<Produto> ListAllProducts()
        {
            List<Produto> produtos = new List<Produto>();
            OpenConnection();

            string query = "SELECT * FROM cultivos order by cultivo_id;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Produto p = new Produto();
                p.Id = Convert.ToInt32(dr["cultivo_id"]);
                p.Nome = dr["nome"].ToString();
                p.Quantidade = Convert.ToInt32(dr["quantidade"]);
                // transformar em data
                p.Data_plantio = Convert.ToDateTime(dr["data_plantio"]).Date;
                p.Data_colheita = Convert.ToDateTime(dr["data_colheita"]).Date;
                produtos.Add(p);
            }

            return produtos;
        }

    }
}
