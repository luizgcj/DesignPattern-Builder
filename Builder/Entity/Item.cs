using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Entity
{
    public class Item
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }

        public Item(int Codigo, string Descricao, double ValorUnitario)
        {
            this.Codigo = Codigo;
            this.Descricao = Descricao;
            this.ValorUnitario = ValorUnitario;
        }
    }
}
