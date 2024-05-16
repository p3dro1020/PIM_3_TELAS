using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin.Infra
{
    internal class User
    {
        public int id_usuario { get; set; }
        public string usuario { get; set; }
        public string senha_usuario { get; set; }

        // Validação do nome de usuário e senha do User
        public bool scanUserPassword (string txtUser, string txtPassword)
        {
            try 
            {
                using var conn = new DBconnect();

                string query = "SELECT * FROM Usuário WHERE usuario = @txtUser AND senha_usuario = @txtPassword";
                NpgsqlCommand selectCommand = new NpgsqlCommand(query, conn.Connection);
                selectCommand.Parameters.AddWithValue("@txtUser", txtUser);
                selectCommand.Parameters.AddWithValue("@txtPassword", txtPassword);

                NpgsqlDataReader loginFeedback = selectCommand.ExecuteReader();
                if (loginFeedback.Read())
                {
                    MessageBox.Show("Logado!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
            } catch ( Exception e ) {
                MessageBox.Show("Erro ao analisar dados");
                return false;
            }
        }
    }
}