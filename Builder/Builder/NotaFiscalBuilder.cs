using Builder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public class NotaFiscalBuilder
    {
        public int Numero { get; private set; }
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime DataHoraEmissao { get; private set; }
        public IList<Item> todosItens = new List<Item>();
        private double valorTotal;
        private double impostos;

        public NotaFiscalBuilder SetNumero(int Numero)
        {
            this.Numero = Numero;
            return this;
        }

        public NotaFiscalBuilder SetRazaoSocial(string RazaoSocial)
        {
            this.RazaoSocial = RazaoSocial;
            return this;
        }

        public NotaFiscalBuilder SetCnpj(string Cnpj)
        {
            this.Cnpj = Cnpj;
            return this;
        }

        public NotaFiscalBuilder SetDataHoraEmissao()
        {
            this.DataHoraEmissao = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder SetItem(Item item)
        {
            this.todosItens.Add(item);
            valorTotal += item.ValorUnitario;
            impostos += item.ValorUnitario * 0.05;
            return this;
        }

        public NotaFiscal CriarNota()
        {
            return new NotaFiscal(this.Numero, this.RazaoSocial, this.Cnpj, this.DataHoraEmissao, this.todosItens, this.valorTotal, this.impostos);
        }
    }
}
