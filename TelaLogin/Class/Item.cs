using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin.Class
{
    public class Item
    {
        public int IdFornecedor { get; set; }
        public int IdItem { get; set; }
        public string CodigoBarras { get; set; }
        public string Categoria { get; set; }
        public string NomeFornecedor { get; set; }
        public string NomeItem { get; set; }
        public string Un { get; set; }
        public double PrecoCusto { get; set; }
        public double PrecoVenda { get; set; }
        public double Porcentagem { get; set; }
        public double Lucro { get; set; }
        public int EstoqueMinimo { get; set; }

    }
}
