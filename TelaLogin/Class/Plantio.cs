using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin.Class
{
    public class Plantio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Status { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data_colheita { get; set; }
        //public DateBoldEventArgs Data_colheita_ideal { get; set; }
        public DateTime Data_plantio { get; set; }
        public string DataPlantioFormatada => Data_plantio.ToString("dd/MM/yyyy"); 
        public string DataColheitaFormatada => Data_colheita.ToString("dd/MM/yyyy");
        public DateBoldEventArgs Data_validade { get; set; }

    }
}
