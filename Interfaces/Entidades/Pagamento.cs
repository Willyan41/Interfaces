using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Interfaces.Entidades
{
    class Pagamento
    {
        private double PagamentoBase { get; set; }
        private double Taxa { get; set; }

        public Pagamento() { }

        public Pagamento(double pagamentoBase, double taxa)
        {
            PagamentoBase = pagamentoBase;
            Taxa = taxa;

        }

        public double TotalPagamento
        {
            get { return PagamentoBase + Taxa; }
        }


        public override string ToString()
        {
            return "Pagamento Base: " +
                PagamentoBase.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: " +
                Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal Pagamento: " +
                TotalPagamento.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
