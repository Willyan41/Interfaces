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

        public ServicoAluguel() { }

        public ServicoAluguel(double valorHora, double valorDia)
        {
            this.ValorHora = valorHora;
            this.ValorDia = valorDia;
        }

        public void pagamento(AluguelCarro aluguelCarro)
        {

        }

    }
}
