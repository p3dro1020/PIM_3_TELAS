using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelaLogin.Class;

namespace TelaLogin.ClassGlobal
{
    internal class VarGlobal
    {
        // armazena o id do fornecedor
        public static int id { get; set; }
        public static string nome { get; set; }
        public static int id_item { get; set; }
        public static int Qtd { get; set; }
        public static List<Item> Itens { get; set; }
    }
}
