using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Serviços
{
    public class ImpostoServico : IServicoImposto
    {

        public double Taxa(double quantia)
        {
            if (quantia <= 100)
            {
                return quantia * 0.2;
            }
            else
            {
                return quantia * 0.15;
            }

        }

    }
}
