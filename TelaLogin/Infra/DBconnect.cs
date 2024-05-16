using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TelaLogin.Infra
{
    internal class DBconnect : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }

        public DBconnect()
        {
            Connection = new NpgsqlConnection(
                "Server = localhost;" +
                "Port = 5432;" +
                "Database = PIM;" +
                "Uid = postgres;" +
                "Psw = admin;");

            Connection.Open();
        }
        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
