using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin.Class
{
    public class ItemEstoque
    {
        public int Id { get; set; }
        public string CodigoBarras { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Unidade { get; set; }
        public int IdItem { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public string Fornecedor { get; set; }
    }
}
