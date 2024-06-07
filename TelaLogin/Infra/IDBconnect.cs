using TelaLogin.Class;

namespace TelaLogin.Infra
{
    internal interface IDBuser
    {
        public bool VerifyUser(string user, string password);
    }
    internal interface IDBproduction 
    {
        public void OpenConnection();
        // metodos Product
        public bool CreateProduct(Plantio produto);
        public bool UpdateProduct(Plantio produto);
        List<Plantio> ListAllProducts();
        List<Plantio> SearchProduct(string text);
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
        bool DeleteItem(int id);

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

    internal interface IDBstock
    {
        // metodos stock
        bool CreateStock(ItemEstoque estoque);
        bool UpdateStock(ItemEstoque estoque);
        //bool DeleteStock(int id);
        ItemEstoque SearchStock(string cdgBarra);
        List<ItemEstoque> GetAllStock();
    }

    internal interface IDBsales
    {
        // metodos sales
        Venda SearchProductByBarCode(string cod);
        //bool AddSale(Venda venda);

    }
    internal interface IDBpedido
    {
        // metodos pedido
        Pedido GetProxPedido();
        bool AddNewPedido(Pedido pedido);
        void AddItemPedido(Item item);
        /*
        bool CreatePedido(Pedido pedido);
        bool UpdatePedido(Pedido pedido);
        bool DeletePedido(int id);
        List<Pedido> SearchPedido(string text);
        List<Pedido> ListAllPedidos();
        */
    }
}
