using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entidades
{
    public class Veiculo
    {
        private string Modelo { get; set; }

        public Veiculo() { }

        public Veiculo (string modelo)
        {
            this.Modelo = modelo;
        }

    }
}
