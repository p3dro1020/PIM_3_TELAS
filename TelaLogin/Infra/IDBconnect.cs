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

        // metodos suppliers

        List<Fornecedor> ListAllSuppliers();
        bool CreateSuppliers(Fornecedor fornecedor);
        Fornecedor SearchSupplier(int id);
        List<Fornecedor> SearchSupplierName(string name);
        public List<Fornecedor> SearchSupplierPhone(int id);
        bool AddNumSupplier(Fornecedor fornecedor);
        bool UpdateNumSupplier(Fornecedor fornecedor,string numOld);
        bool DeleteNumSupplier(Fornecedor fornecedor);
        bool UpdateSuppliers(Fornecedor fornecedor);
        bool DeleteSuppliers(int id);
        List<Item> SearchSupplierItem(int id);
        bool AddNewItem(Item item);
        bool UpdateItem(Item item);

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
