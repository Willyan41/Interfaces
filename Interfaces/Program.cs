using Interfaces.Entidades;
using System;
using System.Globalization;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel:");
            Console.Write("Modelo veiculo: ");
            string modelo = Console.ReadLine();

            Console.Write("Entrada (dd/MM/yyyy hh:mm): ");
            DateTime dataEntrada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm" , CultureInfo.InvariantCulture);

            Console.Write("Retorno (dd/MM/yyyy hh:mm): ");
            DateTime dataRetorno = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o valor da hora:");
            double valorHora = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o valor da diaria:");
            double valorDiaria = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AluguelCarro aluguelcarro = new AluguelCarro(dataEntrada, dataRetorno, new Veiculo(modelo));

            
        }
    }
}
