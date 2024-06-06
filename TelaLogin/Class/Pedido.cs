using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin.Class
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int Quantidade { get; set; }
        public double Total { get; set; }
        public string DataEhora { get; set; }
        public string Status { get; set; }
    }
}
