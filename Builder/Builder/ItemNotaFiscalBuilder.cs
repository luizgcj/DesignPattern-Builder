using Builder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public class ItemNotaFiscalBuilder
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }

        public ItemNotaFiscalBuilder SetCodigo(int Codigo)
        {
            this.Codigo = Codigo;
            return this;
        }

        public ItemNotaFiscalBuilder SetDescricao(string Descricao)
        {
            this.Descricao = Descricao;
            return this;
        }

        public ItemNotaFiscalBuilder SetValorUnitario(double ValorUnitario)
        {
            this.ValorUnitario = ValorUnitario;
            return this;
        }

        public Item CriarItemNotaFiscal()
        {
            return new Item(this.Codigo, this.Descricao, this.ValorUnitario);
        }
    }
}
