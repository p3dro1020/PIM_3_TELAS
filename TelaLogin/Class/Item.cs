using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin.Class
{
    public class Item
    {
        public int Id_fornecedor { get; set; }
        public int Id_item { get; set; }
        public string NomeFornecedor { get; set; }
        public string NomeItem { get; set; }
        public string Un { get; set; }
        public double Preco { get; set; }
    }
}
