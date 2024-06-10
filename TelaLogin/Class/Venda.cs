using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin.Class
{
    public class Venda
    {
        public DateTime DataVenda { get; set; }
        public string CodigoBarra { get; set; }
        public int QtdEstoque { get; set;}
        public int Quantidade { get; set; }
        public string Produto { get; set; }
        public string Unidade { get; set; }
        public double Ganhos { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }
        public int CodigoProduto { get; set; }

    }
}
