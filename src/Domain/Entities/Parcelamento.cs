using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Parcelamento : Entitybase
    {
        public double Valor { get; set; }
        public int QuantidadeParcelas { get; set; }
        public double Juros { get; set; }
        public double ValorParcela { get; set; }
        public DateTime DataVencimento { get; set; }
        public List<Pagamento> Pagamentos { get; set; }
        public pagamento Pagamento { get; set; }
        public int PagamentoId { get; set; }
    }
}