using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelaLogin.Class;
using System.Data;

namespace TelaLogin.Infra
{
    internal interface IDBconnect 
    {
        public void OpenConnection();
        public bool VerifyUser(string user, string password);
        public bool CreateProduct(Produto produto);
        public bool UpdateProduct(Produto produto);
        List<Produto> ListAllProducts();
        List<Produto> SearchProduct(string text);
        void ExcludeProduct(int id);
        /*
        void CreateFuncionario(Funcionario funcionario);
        void UpdateFuncionario(Funcionario funcionario);
        void ExcludeFuncionario(int id);
        Produto ObterPorId(int id);
        List<Produto> ObterTodos();*/

    }
}
