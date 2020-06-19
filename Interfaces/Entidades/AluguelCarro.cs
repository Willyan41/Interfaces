using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entidades
{
    class AluguelCarro
    {

        public DateTime InicioAluguel { get; set; }
        public DateTime FinalAluguel { get; set; }
        public Veiculo Veiculo { get; set; }
        public Pagamento Pagamento { get; set; }

        public AluguelCarro() { }

        public AluguelCarro(DateTime inicioAluguel, DateTime finalAluguel, Veiculo veiculo)
        {
            InicioAluguel = inicioAluguel;
            FinalAluguel = finalAluguel;
            Veiculo = veiculo;
            
        }
    }
}
