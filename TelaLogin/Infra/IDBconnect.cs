using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelaLogin.Class;
using Npgsql;
using System.Data;

namespace TelaLogin.Infra
{
    internal interface IDBconnect 
    {
        public void OpenConnection();
        public void CloseConnection();
        public bool VerifyUser(string user, string password);
        public bool CreateProduct(Produto produto);
        public void UpdateProduct(DataTable dt);
        List<Produto> ListAllProducts();
        /*void ExcludeProduto(int id);
        void CreateFuncionario(Funcionario funcionario);
        void UpdateFuncionario(Funcionario funcionario);
        void ExcludeFuncionario(int id);
        Produto ObterPorId(int id);
        List<Produto> ObterTodos();*/

    }
}
