using Interfaces.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Serviços
{
    class ServicoAluguel
    {
        public double ValorHora { get; private set; }
        public double ValorDia { get; private set; }

        private IServicoImposto _impostoServico; 

        public ServicoAluguel() { }

        public ServicoAluguel(double valorHora, double valorDia, IServicoImposto servicoImposto)
        {
            this.ValorHora = valorHora;
            this.ValorDia = valorDia;
            _impostoServico = servicoImposto;
        }

        public void ProcessoPagamento(AluguelCarro aluguelCarro)
        {
            TimeSpan duracao = aluguelCarro.FinalAluguel.Subtract(aluguelCarro.InicioAluguel);

            double pagamentoBasico = 0.0;

            if(duracao.TotalHours <= 12.0)
            {
                pagamentoBasico = ValorHora * Math.Ceiling(duracao.TotalHours);

            }
            else
            {
                pagamentoBasico = ValorDia * Math.Ceiling(duracao.TotalDays);
            }

            double imposto = _impostoServico.Taxa(pagamentoBasico);

            aluguelCarro.Pagamento = new Pagamento(pagamentoBasico, imposto);

        }

    }
}
