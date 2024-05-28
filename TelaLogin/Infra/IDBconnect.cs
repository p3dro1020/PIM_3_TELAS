using TelaLogin.Class;

namespace TelaLogin.Infra
{
    internal interface IDBuser
    {
        public bool VerifyUser(string user, string password);
    }
    internal interface IDBproduct 
    {
        public void OpenConnection();
        // metodos Product
        public bool CreateProduct(Produto produto);
        public bool UpdateProduct(Produto produto);
        List<Produto> ListAllProducts();
        List<Produto> SearchProduct(string text);
        public void DeleteProduct(int id);
    }
    internal interface IDBsupplier
    {
        /*
        // metodos suppliers
         
        public bool CreateSuppliers(Fornecedor fornecedor);
        void UpdateSuppliers(Fornecedor fornecedor);
        void DeleteSuppliers(int id);
        void SearchSuppliers(int id);
        List<Fornecedor> ObterTodos();
         */
    }

    internal interface IDBemployee
    {
        // metodos employee
        void CreateEmployee(Funcionario funcionario);
        void UpdateEmployee(Funcionario funcionario);
        void DeleteEmployee(int id);
        void SearchEmployee(int id);
        List<Funcionario> ObterTodos();
    }
}
