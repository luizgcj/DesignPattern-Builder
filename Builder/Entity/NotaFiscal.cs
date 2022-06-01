using System;
using System.Collections.Generic;

namespace Builder.Entity
{
    public class NotaFiscal
    {
        public int Numero { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataHoraEmissao { get; set; }        
        public IList<Item> Itens { get; set; }
        public double ValorTotal { get; set; }
        public double Impostos { get; set; }

        public NotaFiscal(int Numero, string RazaoSocial, string Cnpj, DateTime DataHoraEmissao, IList<Item> Itens, double ValorTotal, double Impostos)
        {
            this.Numero = Numero;
            this.RazaoSocial = RazaoSocial;
            this.Cnpj = Cnpj;
            this.DataHoraEmissao = DataHoraEmissao;
            this.Itens = Itens;
            this.ValorTotal = ValorTotal;
            this.Impostos = Impostos;
        }

        public string ToString()
        {
            var retorno = $"Número: {this.Numero} - Razão Social: {this.RazaoSocial} - CNPJ: {this.Cnpj} - Valor Total: {this.ValorTotal} - Total Impostos: {this.Impostos}";
            foreach (var item in this.Itens)
                retorno += $"Item: {item.Codigo} - Descrição: {item.Descricao} - Valor Unitário: {item.ValorUnitario}\n";
            return retorno;
        }
    }
}
