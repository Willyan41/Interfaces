using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entidades
{
    public class AluguelCarro
    {

        private DateTime InicioAluguel { get; set; }
        private DateTime FinalAluguel { get; set; }
        private Veiculo Veiculo { get; set; }
        private Pagamento Pagamento { get; set; }

        public AluguelCarro() { }

        public AluguelCarro(DateTime inicioAluguel, DateTime finalAluguel, Veiculo veiculo)
        {
            InicioAluguel = inicioAluguel;
            FinalAluguel = finalAluguel;
            Veiculo = veiculo;
        }
    }
}
